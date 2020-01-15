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
    public partial class ReporteFactura : Form
    {
        public ReporteFactura()
        {
            InitializeComponent();
            
           

        }

        public void cargarFactura(int idFactura) {
            string idcliente="";
            int idUsuario=0;
            int idproducto;
            List<int> codigoProd;
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cn.Open();
            cmd.Connection = cn;
            try {
                cmd.CommandText = "SELECT * FROM tbl_factura WHERE id_factura='"+idFactura+"'";
               dr= cmd.ExecuteReader();

                if (dr.Read()) {

                    lbl_fechaFactura.Text= dr.GetString("fecha");
                    lbl_totalNumero.Text = Convert.ToString(dr.GetDouble("total"));
                     idcliente = dr.GetString("id_cliente");
                     idUsuario = dr.GetInt16("id_usuarios");
                    lbl_ganancia.Text = dr["ganancia"].ToString();
                    dr.Close();
                   

                   
                   

                }


            }

          
            catch(Exception ex) {
                MessageBox.Show(ex.Message);

            }

            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM `tbl_cliente` where id_cliente= '" + idcliente + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl_nombreCliente.Text = dr["nombre"].ToString();
                   
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT `usuario` FROM `tbl_usuario` where id_usuarios= '" + idUsuario + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    lbl_usuarioFactura.Text = Convert.ToString(dr.GetString("usuario"));
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            axAcroPDF1.Show();

            axAcroPDF1.LoadFile("C:\\factura\\factura" + idFactura + ".pdf");
           


            /*     try
                 {
                     cmd.Parameters.Clear();
                     cmd.CommandText = "SELECT `id_producto` FROM `fact_prod` WHERE `id_factura`='" + idFactura + "'";
                     dr = cmd.ExecuteReader();
                     while (dr.Read())
                     {  
                        // codigoProd.Add(int.Parse(dr[1].ToString()));
                         dr.Close();


                     }



                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);

                 }

                 try
                 {
                     cmd.Parameters.Clear();
                     cmd.CommandText = "SELECT * FROM `tbl_producto` WHERE `id_producto`='" + 1 + "`";
                     dr = cmd.ExecuteReader();
                     if (dr.Read())
                     {
                         dr.Close();
                         try
                         {
                             MySqlDataAdapter sda = new MySqlDataAdapter();
                             sda.SelectCommand = cmd;
                             DataTable dbdataset = new DataTable();
                             sda.Fill(dbdataset);
                             BindingSource bsource = new BindingSource();

                             bsource.DataSource = dbdataset;

                             dgv_reporteFactura.DataSource = bsource;
                             sda.Update(dbdataset);
                         }

                         catch (Exception ex)
                         {
                             MessageBox.Show(ex.Message+"   --->" );
                         }
                     }
                 }
                 catch (Exception ex)
                 { MessageBox.Show(ex.Message); }*/


            cn.Close();
        }





    }
}
