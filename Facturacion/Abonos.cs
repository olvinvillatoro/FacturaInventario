using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Abonos : Form
    {
        Validacion v = new Validacion();
        double saldo, abonou, nuevoSaldo=0;
        string idempresa;
        string nombreEmpresa;
      
        int idproveedor;
        public Abonos()
        {
            InitializeComponent();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            txt_abono.Focus();
            lbl_date.Text = DateTime.Now.ToShortDateString();
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            try
            {
                cn.Open();
                cmd.Connection = cn;

                try
                {

                    cmd.CommandText = "select * from bd_flara.tbl_empresa";

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string empresa = dr.GetString("empresa");
                        cb_empresa.Items.Add(empresa);



                    }
                    dr.Close();
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void cb_empresa_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_empresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            try
            {
                cn.Open();
                cmd.Connection = cn;

                try
                {

                    cmd.CommandText = "select * from bd_flara.tbl_empresa where empresa ='" + cb_empresa.SelectedItem.ToString() + "'";

                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                         idempresa = dr.GetString("id_empresa");
                         saldo = dr.GetDouble("saldo_pendiente");
                        
                        dr.Close();
                        try
                        {
                            cb_proveedor.Items.Clear();
                            buscarBd(idempresa);
                            
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }




                    }
                    dr.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void buscarBd(string empresa) {
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            
            try
            {
                cb_proveedor.Items.Clear();
                cn.Open();
                cmd.Connection = cn;
              

                cmd.Parameters.Clear();
                cb_proveedor.Items.Clear();

                cmd.CommandText = "select nombre from bd_flara.tbl_proveedor where id_empresa='" + empresa + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string proveedor = dr["nombre"].ToString();
                    cb_proveedor.Items.Add(proveedor);
                }

                cn.Close();
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 




       

        }

        private void txt_abono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }

        private void cb_proveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        //agregar un abono a la tabla abonos
        private void btn_modificar_Click(object sender, EventArgs e)
        {
           
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;

            cn.Open();
            cmd.Connection = cn;



            if (txt_abono.Text.ToString() == "" || int.Parse(cb_empresa.SelectedIndex.ToString()) < 0 || int.Parse(cb_proveedor.SelectedIndex.ToString()) < 0)
            {
                MessageBox.Show("Debe llenar todos los campos\nSeleccione una empresa para ver su lista de proveedores");

            }


            else if (double.Parse(txt_abono.Text.ToString()) > saldo) {

                MessageBox.Show("El Valor Del Abono\nNo Puede Ser Mayor Que El Saldo\nSaldo: L"+saldo+"");
            }
            else {
                abonou = double.Parse(txt_abono.Text.ToString());
                nombreEmpresa = cb_empresa.SelectedItem.ToString();
                nuevoSaldo = saldo - double.Parse(txt_abono.Text.ToString());

                try
                {
                    cmd.CommandText = "SELECT id_proveedor FROM tbl_proveedor WHERE nombre='" + cb_proveedor.SelectedItem.ToString() + "' AND id_empresa='" + idempresa + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        idproveedor = int.Parse(dr["id_proveedor"].ToString());
                    }
                    else {
                        MessageBox.Show("no encotrado");
                    }



                    dr.Close();

                }
                catch (Exception)
                {

                    throw;
                }



                try
                {




                    try
                    {
                        double abono = double.Parse(txt_abono.Text.ToString());
                        cmd.CommandText =string.Format("INSERT INTO `tbl_abonos` (`abono`, `fecha`, `id_empresa`, `id_proveedor`) VALUES ( '{0}', '{1}', '{2}', '{3}')", abono, DateTime.Now.ToString("yyyy-MM-dd"), idempresa, idproveedor);
                       /* cmd.Parameters.Add("?abono", MySqlDbType.Double).Value = abono;
                        cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                        cmd.Parameters.Add("?id_empresa", MySqlDbType.String).Value = idempresa;
                        cmd.Parameters.Add("?id_proveedor", MySqlDbType.Int16).Value = idproveedor;*/

                        int a = cmd.ExecuteNonQuery();
                        if (a>0)
                        {
                            cmd.CommandText = "update bd_flara.tbl_empresa set saldo_pendiente = '" + nuevoSaldo + "' where id_empresa = '" + idempresa+ "'";
                            int b = cmd.ExecuteNonQuery();


                            if (b > 0)
                            {
                                dgv_abono.Rows[0].Cells[0].Value = idempresa;
                                dgv_abono.Rows[0].Cells[1].Value = nombreEmpresa;
                                dgv_abono.Rows[0].Cells[2].Value = nuevoSaldo;
                                dgv_abono.Rows[0].Cells[3].Value = abonou;

                                            MessageBox.Show("Abono Agregado\nSaldo Restante: L"+nuevoSaldo);
                                txt_abono.Text = "";
                            }
                        }
                        dr.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                   
                          }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


                cn.Close();

            }
            
        }
    }
}
