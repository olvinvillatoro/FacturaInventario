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
    public partial class BuscarProducto : Form
    {

        Validacion v = new Validacion();
        Login log = new Login();
        int descuento;

        public BuscarProducto()
        {
            InitializeComponent();

        }
        public void descuentos() {
            if (descuento!=1)
            {
                checkBoxDescuento.Visible = false;
            }

        }

         public int modificar=0;
        public void setModificar(int modificar){ this.modificar = modificar; }
        public void setDescuento(int descuento) { this.descuento = descuento; }

        public void modificarCliente()
        {
            
            
                lbl_codigo.Text = "Identidad";
                lbl_nombre.Text = "Nombre del Cliente";
                btn_buscar.Text = "Buscar Cliente";
            if(modificar==2) btn_modificarProducto.Show();

           


        }
    private void btn_buscar_Click(object sender, EventArgs e)
        {
            //BUSCAR CLIENTES
            if (modificar == 2 || modificar ==1) {
                try
                {
                    MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlDataReader dr;
                    //obtiene codigo y nombre del text box
                    string codigo = txt_codigoBuscar.Text.ToString(), nombre = textBox1.Text.Trim().ToString();

                    //determina cual esta vacio
                    if (codigo != "" && nombre == "")
                    {


                        cn.Open();
                        cmd.Connection = cn;
                        try
                        {
                            cmd.CommandText = "select * from bd_flara.tbl_cliente where id_cliente ='" + txt_codigoBuscar.Text.Trim().ToString() + "'";
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                //cierra el data reader para que puedea usar el sda
                                dr.Close();
                                try
                                {
                                    MySqlDataAdapter sda = new MySqlDataAdapter();
                                    sda.SelectCommand = cmd;
                                    DataTable dbdataset = new DataTable();
                                    sda.Fill(dbdataset);
                                    BindingSource bsource = new BindingSource();

                                    bsource.DataSource = dbdataset;

                                    dgv_buscar.DataSource = bsource;
                                    sda.Update(dbdataset);
                                }

                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                                MessageBox.Show("No se encontro ningun Cliente con esa identidad \n Revise su ortografia");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                        cn.Close();
                    }
                    //si el codigo esta vacio pero el nombre no
                    else if (codigo == "" && nombre != "")
                    {


                        cn.Open();
                        cmd.Connection = cn;
                        try
                        {
                            cmd.CommandText = "select * from bd_flara.tbl_cliente where nombre like '" + textBox1.Text.ToString() + "%'";
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

                                    dgv_buscar.DataSource = bsource;
                                    sda.Update(dbdataset);
                                }

                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                                MessageBox.Show("No se encontro ningun cliente con ese nombre \n Revise su ortografia");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                        cn.Close();
                    }


                    else if (codigo != "" && nombre != "")
                    {


                        cn.Open();
                        cmd.Connection = cn;
                        try
                        {
                            cmd.CommandText = "select * from bd_flara.tbl_cliente where nombre like'" + textBox1.Text.ToString() + "%' and id_cliente='" + txt_codigoBuscar.Text.Trim().ToString() + "'";
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

                                    dgv_buscar.DataSource = bsource;
                                    sda.Update(dbdataset);
                                }

                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                                MessageBox.Show("No se encontro ningun cliente con esos datos \n Revise su ortografia");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                        cn.Close();
                    }
                    textBox1.Clear();
                    txt_codigoBuscar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }





            //Modificar Porducto en form1

            else if (modificar==3) {
                try
                {
                    MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlDataReader dr;
                    //obtiene codigo y nombre del text box
                    string codigo = txt_codigoBuscar.Text.ToString(), nombre = textBox1.Text.Trim().ToString();

                    //determina cual esta vacio
                    if (codigo != "" && nombre == "")
                    {


                        cn.Open();
                        cmd.Connection = cn;
                        try
                        {
                            cmd.CommandText = "select * from bd_flara.tbl_producto where id_producto ='" + txt_codigoBuscar.Text.Trim().ToString() + "'";
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                //cierra el data reader para que puedea usar el sda
                                dr.Close();
                                try
                                {
                                    MySqlDataAdapter sda = new MySqlDataAdapter();
                                    sda.SelectCommand = cmd;
                                    DataTable dbdataset = new DataTable();
                                    sda.Fill(dbdataset);
                                    BindingSource bsource = new BindingSource();

                                    bsource.DataSource = dbdataset;

                                    dgv_buscar.DataSource = bsource;
                                    sda.Update(dbdataset);
                                }

                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                                MessageBox.Show("No se encontro ningun Producto con esa identidad \n Revise su ortografia");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                        cn.Close();
                    }
                    //si el codigo esta vacio pero el nombre no
                    else if (codigo == "" && nombre != "")
                    {


                        cn.Open();
                        cmd.Connection = cn;
                        try
                        {
                            cmd.CommandText = "select * from bd_flara.tbl_producto where nombre like '" + textBox1.Text.ToString() + "%'";
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

                                    dgv_buscar.DataSource = bsource;
                                    sda.Update(dbdataset);
                                }

                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                                MessageBox.Show("No se encontro ningun Producto con ese nombre \n Revise su ortografia");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                        cn.Close();
                    }


                    else if (codigo != "" && nombre != "")
                    {


                        cn.Open();
                        cmd.Connection = cn;
                        try
                        {
                            cmd.CommandText = "select * from bd_flara.tbl_producto where nombre like'" + textBox1.Text.ToString() + "%' and id_producto='" + txt_codigoBuscar.Text.Trim().ToString() + "'";
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

                                    dgv_buscar.DataSource = bsource;
                                    sda.Update(dbdataset);
                                }

                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                                MessageBox.Show("No se encontro ningun Producto con esos datos \n Revise su ortografia");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                        cn.Close();
                    }
                    textBox1.Clear();
                    txt_codigoBuscar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //buscar PRODUCTOS
            else
            {
                try
                {
                    MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlDataReader dr;
                    //obtiene codigo y nombre del text box
                    string codigo = txt_codigoBuscar.Text.ToString(), nombre = textBox1.Text.ToString();

                    //determina cual esta vacio
                    if (codigo != "" && nombre == "")
                    {


                        cn.Open();
                        cmd.Connection = cn;
                        try
                        {
                            cmd.CommandText = "select * from bd_flara.tbl_producto where id_producto ='" + txt_codigoBuscar.Text + "%'";
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                //cierra el data reader para que puedea usar el sda
                                dr.Close();
                                try
                                {
                                    MySqlDataAdapter sda = new MySqlDataAdapter();
                                    sda.SelectCommand = cmd;
                                    DataTable dbdataset = new DataTable();
                                    sda.Fill(dbdataset);
                                    BindingSource bsource = new BindingSource();

                                    bsource.DataSource = dbdataset;

                                    dgv_buscar.DataSource = bsource;
                                    sda.Update(dbdataset);
                                }

                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                                MessageBox.Show("No se encontro ningun producto \n Revise su ortogragia");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                        cn.Close();
                    }
                    //si el codigo esta vacio pero el nombre no
                    else if (codigo == "" && nombre != "")
                    {


                        cn.Open();
                        cmd.Connection = cn;
                        try
                        {
                            cmd.CommandText = "select * from bd_flara.tbl_producto where nombre like'" + textBox1.Text + "%'";
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

                                    dgv_buscar.DataSource = bsource;
                                    sda.Update(dbdataset);
                                }

                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                                MessageBox.Show("No se encontro ningun producto \n Revise su ortogragia");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                        cn.Close();
                    }


                    else if (codigo != "" && nombre != "")
                    {


                        cn.Open();
                        cmd.Connection = cn;
                        try
                        {
                            cmd.CommandText = "select * from bd_flara.tbl_producto where nombre like'" + textBox1.Text + "%' and id_producto='" + txt_codigoBuscar.Text + "'";
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

                                    dgv_buscar.DataSource = bsource;
                                    sda.Update(dbdataset);
                                }

                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                                MessageBox.Show("No se encontro ningun producto \n Revise su ortogragia");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                        cn.Close();
                    }
                    textBox1.Clear();
                    txt_codigoBuscar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void list_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_codigoBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);

            //al precionar ENTER busca automaticamente el producto sin presionar el boton buscar

            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btn_buscar_Click(sender, e);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //al precionar ENTER busca automaticamente el producto sin presionar el boton buscar
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btn_buscar_Click(sender, e);
            }
        }

        private void dgv_buscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar==1) {

                Factura factura = (Factura)this.Owner;

                try
                {

                    if (factura != null)
                    {
                       // factura.agregarProductoFactura(int.Parse(dgv_buscar.Rows[0].Cells[0].Value.ToString()), dgv_buscar.Rows[0].Cells[1].Value.ToString(), 1, double.Parse(dgv_buscar.Rows[0].Cells[3].Value.ToString()));
                        factura.lbl_nombreCliente.Text = dgv_buscar.Rows[dgv_buscar.CurrentCell.RowIndex].Cells[1].Value.ToString();
                        factura.clienteId = dgv_buscar.Rows[dgv_buscar.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        factura.cliente = dgv_buscar.Rows[dgv_buscar.CurrentCell.RowIndex].Cells[1].Value.ToString();
                        modificar = 0;
                        this.Close();
                        /* for (int i = 0; i <= (factura.dgv_factura.Rows.Count - 1); ++i)
                         {
                             factura.subTotal = factura.subTotal + ((float.Parse(factura.dgv_factura.Rows[i].Cells[3].Value.ToString())) * (int.Parse(factura.dgv_factura.Rows[i].Cells[2].Value.ToString())));

                         }
                         factura.lbl_total.Text = factura.subTotal.ToString();*/
                    }
                    /**/

                    else
                        MessageBox.Show("No Disponible");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }

            else if(modificar==0)
            {
                // se declara  (Factura)this.Owner; para que pueda enviar de regreso a Factura como padre y no como nueva form en Factura se delcara BuscarProducto.ShowDialog(this);
                Factura factura = (Factura)this.Owner;
                Login log = new Login();


                try
                {

                    if (factura != null)
                    {
                       
                            if (checkBoxDescuento.Checked)
                            {
                                factura.agregarProductoFactura(int.Parse(dgv_buscar.Rows[0].Cells[0].Value.ToString()), dgv_buscar.Rows[0].Cells[1].Value.ToString(), 1, double.Parse(dgv_buscar.Rows[0].Cells[4].Value.ToString()));
                                this.Close();
                            }
                            else
                            {

                                factura.agregarProductoFactura(int.Parse(dgv_buscar.Rows[0].Cells[0].Value.ToString()), dgv_buscar.Rows[0].Cells[1].Value.ToString(), 1, double.Parse(dgv_buscar.Rows[0].Cells[3].Value.ToString()));
                                this.Close();
                                /* for (int i = 0; i <= (factura.dgv_factura.Rows.Count - 1); ++i)
                                 {
                                     factura.subTotal = factura.subTotal + ((float.Parse(factura.dgv_factura.Rows[i].Cells[3].Value.ToString())) * (int.Parse(factura.dgv_factura.Rows[i].Cells[2].Value.ToString())));

                                 }
                                 factura.lbl_total.Text = factura.subTotal.ToString();*/
                            } 
                        }
                    
                    

                    else
                        MessageBox.Show("No Disponible");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("No Disponible");
        }

        private void btn_modificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Principal inventario = (Principal)this.Owner;
                if (modificar == 3)
                {
                    inventario.setModif(3);
                    int codigo = int.Parse(dgv_buscar.Rows[dgv_buscar.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    inventario.setCoidgo(codigo);
                    inventario.llenarDgvInventario(codigo);
                    inventario.modificar();

                    this.Close();

                }
                else if (modificar == 2)
                {
                    inventario.setModif(2);
                    string codigo = dgv_buscar.Rows[dgv_buscar.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    inventario.Identidad.Hide();
                    inventario.mtxt_identidadCliente.Hide();
                    inventario.setIdCliente(codigo);
                    inventario.llenarGgvCliente(codigo);
                    inventario.lbl_tituloCliente.Text = "Modificar Cliente";
                    inventario.cb_estadoCliente.Visible = true;
                    this.Close();
                }
                else {

                    MessageBox.Show("No Disponible"); }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
