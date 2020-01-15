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
using System.Windows.Forms.DataVisualization.Charting;

namespace Facturacion
{
    


    public partial class Principal : Form
    {
        public int modifi = 0;
        Validacion v = new Validacion();
        BuscarProducto buscarProd = new BuscarProducto();
        int codigo = 0;
        string idCliente;

        public Principal()
        {
           
            InitializeComponent();
            llenarCombobox();
            llenarChart();
            notificacionProveedor();



        }
      public void setModif(int modifica)
        {

            this.modifi = modifica;
        }
        public void setCoidgo(int cod) {
            this.codigo = cod;
        }

        public void setIdCliente(string cliente) {
            this.idCliente = cliente;
        }
        
        void llenarCombobox()
        {

            dtpInicio.MaxDate = DateTime.Today;
            dtpFinal.MaxDate = DateTime.Today;

            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpFinal.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            dtpFinal.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            //lbl_date.Text = DateTime.Now.ToShortDateString();
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            try
            {
                cn.Open();
                cmd.Connection = cn;

                try
                {

                    cmd.CommandText = "select * from tbl_categoria";

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string categoria = dr.GetString("categoria");
                        cb_CategoriaInventario.Items.Add(categoria);




                    }
                    dr.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {

                    cmd.CommandText = "select * from tbl_proveedor where id_estado= '1' ";

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string proveedor = dr.GetString("nombre");
                        cb_proveedorInventario.Items.Add(proveedor);




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

            if (buscarProd.modificar > 0) {
                lbl_modificar.Show();
                btn_BuscarInventario.Hide();
                lbl_asegurese.Hide();
                


            }

        }


        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta =
           MessageBox.Show("Esta Seguro?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
               this.Close();
            }

            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_EliminarCliente_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
          MessageBox.Show("Seguro?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
        // COMPROBACION DE USUARIO

                Login login = new Login();
                login.Cargar();
                login.Show();
               


            }

        }

        private void btn_RestarSaldo_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
          MessageBox.Show("Seguro?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
              
            }

        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
          MessageBox.Show("Seguro?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                dgv_agregar.Rows.Clear();
                this.Refresh();
            }

        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void textBox_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txt_NombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txt_IdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txt_Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txt_NumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_AgregarProductoFactura_Click(object sender, EventArgs e)
        {
            bdComun.ObtenerConexion();
            MessageBox.Show("Conectado");
           
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            int idEstado=1;
            
           
            if (modifi==2) {
                try
                {

                    MySqlCommand cmd = new MySqlCommand();

                    MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");

                    MySqlDataReader dr;
                    cn.Open();
                    cmd.Connection = cn;


                    string nombreCliente = txt_NombreCliente.Text.ToString();
                    string telefonoCliente = mtxt_telefonoCliente.Text.Trim().ToString();

                    // double precioCompra = double.Parse(txt_precioCompra.Text.Trim());
                    //  double precioVenta = double.Parse(txt_precioDeVenta.Text.Trim());

                    idCliente = dgv_Cliente.Rows[0].Cells[0].Value.ToString();
                    string direccionCliente = txt_Direccion.Text.ToString();
                    string comentariosCliente = txt_Comentarios.Text.ToString();


                    if (txt_NombreCliente.Text == "" || mtxt_telefonoCliente.Text.ToString() == "" || txt_Direccion.Text.ToString() == "" || cb_estadoCliente.SelectedItem.ToString() == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                        if (txt_NombreCliente.Text == "")
                        {
                            txt_NombreCliente.Focus();
                        }
                        else if (mtxt_telefonoCliente.Text.ToString() == "")
                        {
                            mtxt_telefonoCliente.Focus();
                        }
                       



                    }


                    else {
                        idEstado = cb_estadoCliente.SelectedIndex + 1;



                        cmd.CommandText = "UPDATE bd_flara.tbl_cliente SET nombre='" + nombreCliente + "', telefono='" + telefonoCliente + "', direccion='" + direccionCliente + "', descripcion='" + comentariosCliente + "', id_estado='" + idEstado + "' WHERE id_cliente= '" +idCliente+"'";


                        int a = cmd.ExecuteNonQuery();


                        if (a > 0)
                        {
                               llenarGgvCliente(idCliente);
                            modifi = 0;
                            lbl_tituloCliente.Text = "Agregar Cliente";
                          
                            dgv_Cliente.Refresh();


                        }
                        else
                            MessageBox.Show("No se pudo modificar el cliente");
                        cn.Close();

                    }

                    
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }
            }

            else
            {
                MySqlCommand cmd = new MySqlCommand();

                MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");

                MySqlDataReader dr;
                cn.Open();
                cmd.Connection = cn;


                string nombreCliente = txt_NombreCliente.Text.ToString();
                string telefonoCliente = mtxt_telefonoCliente.Text.Trim().ToString();
                // double precioCompra = double.Parse(txt_precioCompra.Text.Trim());
                //  double precioVenta = double.Parse(txt_precioDeVenta.Text.Trim());
                idCliente = mtxt_identidadCliente.Text.Trim().ToString();
                string direccionCliente = txt_Direccion.Text.ToString();
                string comentariosCliente = txt_Comentarios.Text.ToString();


                                    if (txt_NombreCliente.Text == "" || mtxt_telefonoCliente.Text.ToString() == "" || mtxt_identidadCliente.Text.ToString() == "" || txt_Direccion.Text.ToString() == "")
                                    {
                                                    MessageBox.Show("Debe llenar todos los campos");
                                                    if (txt_NombreCliente.Text == "")
                                                    {
                                                        txt_NombreCliente.Focus();
                                                    }
                                                    else if (mtxt_telefonoCliente.Text.ToString() == "")
                                                    {
                                                        mtxt_telefonoCliente.Focus();
                                                    }
                                                    else if (mtxt_identidadCliente.Text.ToString() == "")
                                                    {
                                                        mtxt_identidadCliente.Focus();
                                                    }



                                    }


                                    else {



                                                cmd.CommandText = string.Format("INSERT INTO bd_flara.tbl_cliente ( id_cliente, nombre, saldo_pendiente, telefono, direccion, descripcion) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                                                 idCliente, nombreCliente, 0, telefonoCliente, direccionCliente, comentariosCliente);



                                                int a = cmd.ExecuteNonQuery();


                                        if (a > 0)
                                        {


                            
                                                    llenarGgvCliente(idCliente);

                                        }
                                        else
                                                     MessageBox.Show("No se pudo agregar");
                    cn.Close();

                }
                try
                {



                    
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }
            }
            


/*
            if (ProcessCmdKey.ExecuteNonReader())
        
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            conexion.cargarCliente(dgv_agregar);*/
        }

        private void dataGrid_Facturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AgregarProductoInventario_Click(object sender, EventArgs e)
        { 
            if (modifi<=0)
            {
                try
                {

                    //  int Codigo = int.Parse(txt_codigoProducto.Text.Trim());

                    MySqlCommand cmd = new MySqlCommand();

                    MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");

                    MySqlDataReader dr;
                    cn.Open();
                    cmd.Connection = cn;






                    if (txt_nombreProducto.Text == "" || txt_cantidadProducto.Text == "" || txt_precioCompra.Text == "" || txt_precioDeVenta.Text == "" || txt_precioDescuento.Text == "" || cb_proveedorInventario.SelectedIndex < 0 || cb_CategoriaInventario.SelectedIndex < 0)
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                        if (txt_cantidadProducto.Text == "")
                        {
                            txt_cantidadProducto.Focus();
                        }
                        else if (txt_nombreProducto.Text == "")
                        {
                            txt_nombreProducto.Focus();
                        }
                        else if (txt_precioCompra.Text == "")
                        {
                            txt_precioCompra.Focus();
                        }
                        else if (txt_precioDescuento.Text == "")
                        {
                            txt_precioDescuento.Focus();
                        }

                    }




                    else if (double.Parse(txt_precioCompra.Text.ToString()) > double.Parse(txt_precioDeVenta.Text.ToString()))
                    {
                        MessageBox.Show("El PRECIO DE VENTA no puede ser MENOR que el PRECIO DE COMPRA");
                    }


                    else {
                        string nombreProducto = txt_nombreProducto.Text.ToString();
                        int cantidad = int.Parse(txt_cantidadProducto.Text.Trim());
                        double precioCompra = double.Parse(txt_precioCompra.Text.Trim());
                        precioCompra = Math.Round(precioCompra, 2);
                        double precioVenta = double.Parse(txt_precioDeVenta.Text.Trim());
                        precioVenta = Math.Round(precioVenta, 2);
                        double precioDescuento = double.Parse(txt_precioDescuento.Text.Trim());
                        precioDescuento = Math.Round(precioDescuento, 2);

                        string descripcion = txt_descripcionProducto.Text.ToString();
                        string ubicacion = txt_ubicacionProducto.Text.ToString();

                        int indexCategoria = cb_CategoriaInventario.SelectedIndex + 1;
                        int indexProveedor = cb_proveedorInventario.SelectedIndex + 1;


                        cmd.CommandText = string.Format("INSERT INTO bd_flara.tbl_producto ( nombre, precio_compra, precio_venta, precio_ventadescuento, existencia, ubicacion, descripcion, id_categoria, id_estado, id_proveedor) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                         nombreProducto, precioCompra, precioVenta,precioDescuento, cantidad, txt_ubicacionProducto.Text, txt_descripcionProducto.Text, indexCategoria, 1, indexProveedor);



                        int a = cmd.ExecuteNonQuery();


                        if (a > 0)
                        {


                            int codigo = int.Parse(cmd.LastInsertedId.ToString());

                            llenarDgvInventario(codigo);
                        }
                        else
                            MessageBox.Show("No se pudo agregar");
                        cn.Close();
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                } 
            }
            else if(modifi==1)
            {

                try
                {

                    //  int Codigo = int.Parse(txt_codigoProducto.Text.Trim());

                    MySqlCommand cmd = new MySqlCommand();

                    MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");

                    MySqlDataReader dr;
                    cn.Open();
                    cmd.Connection = cn;


                    string nombreProducto = txt_nombreProducto.Text.ToString();
                    int cantidad = int.Parse(txt_cantidadProducto.Text.Trim());
                    double precioCompra = double.Parse(txt_precioCompra.Text.Trim());
                    precioCompra = Math.Round(precioCompra, 2);
                    double precioVenta = double.Parse(txt_precioDeVenta.Text.Trim());
                    precioCompra = Math.Round(precioCompra, 2);
                    double precioDescuento = double.Parse(txt_precioDescuento.Text.Trim());
                    precioDescuento = Math.Round(precioDescuento, 2);
                    string descripcion = txt_descripcionProducto.Text.ToString();
                    string ubicacion = txt_ubicacionProducto.Text.ToString();

                    int indexCategoria = cb_CategoriaInventario.SelectedIndex + 1;
                    int indexProveedor = cb_proveedorInventario.SelectedIndex + 1;



                    if (txt_nombreProducto.Text == "" || txt_cantidadProducto.Text == "" || txt_precioCompra.Text == "" || txt_precioDeVenta.Text == "" || txt_precioDescuento.Text == "" || cb_proveedorInventario.SelectedIndex < 0 || cb_CategoriaInventario.SelectedIndex < 0||cb_estado.SelectedIndex < 0)
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                        if (txt_cantidadProducto.Text == "")
                        {
                            txt_cantidadProducto.Focus();
                        }
                        else if (txt_nombreProducto.Text == "")
                        {
                            txt_nombreProducto.Focus();
                        }
                        else if (txt_precioCompra.Text == "")
                        {
                            txt_precioCompra.Focus();
                        }



                    }




                    else if (precioCompra > precioVenta)
                    {
                        MessageBox.Show("El PRECIO DE VENTA no puede ser MENOR que el PRECIO DE COMPRA");
                    }


                    else {



                        cmd.CommandText ="UPDATE bd_flara.tbl_producto SET  nombre ='" + nombreProducto + "', precio_compra='" + precioCompra + "', precio_venta='" + precioVenta + "', precio_ventadescuento='" + precioDescuento + "', existencia='" + cantidad + "', ubicacion='" + txt_ubicacionProducto.Text + "', descripcion='" + txt_descripcionProducto.Text + "', id_categoria='" + indexCategoria + "', id_estado='" + int.Parse(cb_estado.SelectedIndex.ToString()) + 1 + "', id_proveedor='" + indexProveedor + "'  WHERE id_producto='" + int.Parse(dgv_agregar.Rows[0].Cells[0].Value.ToString()) + "'";
                         



                        int a = cmd.ExecuteNonQuery();


                        if (a > 0)
                        {
                            
                            llenarDgvInventario(codigo);

                        }
                        else
                            MessageBox.Show("No se pudo agregar");
                        cn.Close();
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                } 

            }
            modifi = 0;

            //fin del boton
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            chrt_ganancia.Palette = ChartColorPalette.Pastel;
            
            
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            DateTime fechaInicio, fechaFinal;
           
            
            cn.Open();
            cmd.Connection = cn;
            if (cb_fecha.SelectedIndex == 0) {
                try {
                   
                    cmd.CommandText = "SELECT * FROM `tbl_factura` WHERE `fecha` LIKE '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd")+ "%'";
                    //cmd.Parameters.AddWithValue("?fecha", MySqlDbType.DateTime).Value = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            //        "SELECT * FROM  WHERE LIKE '" + Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd") + "%'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();

                        try {


                            MySqlDataAdapter sda = new MySqlDataAdapter();
                            sda.SelectCommand = cmd;
                            DataTable dbdataset = new DataTable();
                            sda.Fill(dbdataset);
                            BindingSource bsource = new BindingSource();

                            bsource.DataSource = dbdataset;

                            dgv_reporte.DataSource = bsource;
                            sda.Update(dbdataset);
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                        MessageBox.Show("Aun no hay facturas creadas el dia de hoy");


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            else if (cb_fecha.SelectedIndex == 1)
            {
                TimeSpan timespan = new TimeSpan(7, 0, 0, 0);
                try
                {
                    fechaInicio = DateTime.Now;
                    fechaFinal = DateTime.Now;
                    fechaInicio = fechaInicio.Subtract(timespan);



                    // MessageBox.Show(Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd")+"\n" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd"));
                    cmd.CommandText = " SELECT * FROM `tbl_factura` WHERE `fecha` BETWEEN '" + Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd 23:59:59") + "'";


                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();



                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = cmd;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();

                        bsource.DataSource = dbdataset;

                        dgv_reporte.DataSource = bsource;
                        sda.Update(dbdataset);

                    }
                    else
                        MessageBox.Show("No hay facturas creadas");


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }

            else if (cb_fecha.SelectedIndex==2) {

                TimeSpan timespan = new TimeSpan(30, 0, 0, 0);
                try
                {
                    fechaInicio = DateTime.Now;
                    fechaFinal = DateTime.Now;
                    fechaInicio = fechaInicio.Subtract(timespan);



                    // MessageBox.Show(Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd")+"\n" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd"));
                    cmd.CommandText = " SELECT * FROM `tbl_factura` WHERE `fecha` BETWEEN '" + Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd 23:59:59") + "'";


                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();



                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = cmd;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();

                        bsource.DataSource = dbdataset;

                        dgv_reporte.DataSource = bsource;
                        sda.Update(dbdataset);

                    }
                    else
                        MessageBox.Show("No hay facturas creadas en los ultimos 30 dias");


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }

            cn.Close();

          
        }

        private void txt_cantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            v.SoloNumeros(e);
        }

        private void txt_precioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarProducto buscar = new BuscarProducto();
            buscar.setModificar(3);
            buscar.btn_modificarProducto.Show();
            buscar.setDescuento(0);
            buscar.descuentos();
            buscar.ShowDialog(this);
        }

        private void btn_generar1_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            string fechaInicio, fechaFinal;
            TimeSpan timespan = new TimeSpan(7, 0, 0, 0);

            cn.Open();
            cmd.Connection = cn;
            
            
                try
                {
                string fecha = dtp_inicio.Value.Year.ToString() + "-" + dtp_inicio.Value.Month.ToString() + "-" + dtp_inicio.Value.Day.ToString() + " 20:00:00";
               
                fechaInicio= fecha;
               
                fechaFinal = String.Format("{0:u}", dtp_final.Value);

               // MessageBox.Show(dtp_inicio.Value.ToString() + "\n" + dtp_final.Value.ToString());
                    //cmd.CommandText = "SELECT * FROM tbl_factura WHERE fecha BETWEEN '" + dtp_inicio.Value + "' AND '" + dtp_final.Value + "'";
                    cmd.CommandText ="SELECT * FROM `tbl_factura` WHERE `fecha` BETWEEN '"+ Convert.ToDateTime(dtp_inicio.Value).ToString("yyyy-MM-dd")+ "' AND '"+ Convert.ToDateTime(dtp_final.Value).ToString("yyyy-MM-dd 23:59:59")+ "'";
                    dr = cmd.ExecuteReader();
                   if (dr.Read())
                    {
                        dr.Close();



                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = cmd;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();

                        bsource.DataSource = dbdataset;

                        dgv_reporte.DataSource = bsource;
                        sda.Update(dbdataset);

                    }
                    else
                        MessageBox.Show("No hay facturas creadas entre esas fechas \nElija otro rango");


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            

            cn.Close();

        }

        private void dgv_reporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_reporte_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void dgv_reporte_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int codigoFactura = int.Parse(dgv_reporte.Rows[int.Parse(dgv_reporte.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString());



            ReporteFactura rFactura = new ReporteFactura();

            rFactura.cargarFactura(codigoFactura);
            rFactura.ShowDialog(this);
            

        }
        public void llenarDgvInventario(int codigo) {
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cn.Open();
            cmd.Connection = cn;
           

            try
            {
                cmd.CommandText = "select * from bd_flara.tbl_producto where id_producto = '" + codigo + "'";


                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;

                dgv_agregar.DataSource = bsource;
                sda.Update(dbdataset);

                MessageBox.Show("Producto agregado correctamente");
                txt_cantidadProducto.Clear();
                txt_nombreProducto.Clear();
                txt_precioCompra.Clear();
                txt_precioDeVenta.Clear();
                txt_ubicacionProducto.Clear();
               


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }
        public void llenarGgvCliente(string idCliente) {

            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;


            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "select * from bd_flara.tbl_cliente where id_cliente = '" + idCliente + "'";


                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;

                dgv_Cliente.DataSource = bsource;
                sda.Update(dbdataset);

                MessageBox.Show("Cliente agregado correctamente");
                txt_NombreCliente.Clear();
                txt_Direccion.Clear();
                mtxt_identidadCliente.Clear();
                mtxt_telefonoCliente.Clear();
                txt_Comentarios.Clear();



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }

        public void modificar() {

            btn_BuscarInventario.Visible = false;
            lbl_asegurese.Visible = false;
            lbl_modificar.Visible = true;
            cb_estado.Visible = true;
            cb_estado.Show();
            lbl_modificar.Show();
            btn_BuscarInventario.Hide();
            lbl_asegurese.Hide();


            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
           
                cn.Open();
                cmd.Connection = cn;

                try
                {

                    cmd.CommandText = "select * from tbl_estado";

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string estado = dr.GetString("estado");
                        cb_estado.Items.Add(estado);




                    }
                    dr.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            cn.Close();

            }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            BuscarProducto buscar = new BuscarProducto();

            buscar.setModificar(2);
            buscar.modificarCliente();
            buscar.setDescuento(0);
            buscar.descuentos();
            buscar.ShowDialog(this);
           
        }

        private void mtxt_identidadCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }


        public void llenarChart() {

            try
            {
                MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader dr;
                cn.Open();
                cmd.Connection = cn;
                DateTime fechachar1 = DateTime.Now;
                TimeSpan dias = new TimeSpan(6, 0, 0, 0);
                DateTime dia = DateTime.Today;
                dia.Subtract(dias);

                double[] ganan = new double[6];

                string[] titulo = new string[6];


                TimeSpan[] timespan = new TimeSpan[6];


                Series serie = new Series();




                try
                {
                    chrt_ganancia.Titles.Add("Ganancias de la Ultima Semana");
                    chrt_ganancia.ChartAreas[0].AxisX.Title = "Dia de la semana";
                    chrt_ganancia.ChartAreas[0].AxisY.Title = "Lempiras";

                    for (int i = 0; i < timespan.Length; i++)
                    {
                        timespan[i] = new TimeSpan(i, 0, 0, 0);
                    }


                    for (int i = 0; i < titulo.Length; i++)
                    {
                        titulo[i] = dia.Add(timespan[i]).ToString("dd-MMMM");
                    }

                    for (int i = 0; i < ganan.Length; i++)
                    {
                        List<double> ganancias1 = new List<double>();

                        cmd.CommandText = "SELECT * FROM `tbl_factura` WHERE `fecha` LIKE '" + Convert.ToDateTime(fechachar1.Subtract(timespan[i])).ToString("yyyy-MM-dd") + "%'";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            ganancias1.Add(dr.GetDouble("ganancia"));
                        }

                        /*    chrt_ganancia.Series["Ganancias semanal"].Points.AddXY(fechachar1.Subtract(timespan[i]).ToString("dd-MMMM"),(ganancias1.Sum(x => x)));
                          chrt_ganancia.Series["Ganancias semanal"].Label= ganancias1.Sum(x => x).ToString();


                        serie = chrt_ganancia.Series.Add(titulo[i].ToString());
                            ganan[i] = ganancias1.Sum(x => x);
                            serie.Label = ganancias1.Sum(x => x).ToString();
                            serie.Points.Add(ganan[i]);*/

                        chrt_ganancia.Series.Add(fechachar1.Subtract(timespan[i]).ToString("dd-MMMM"));
                        chrt_ganancia.Series[fechachar1.Subtract(timespan[i]).ToString("dd-MMMM")].Label = "L" + ganancias1.Sum(x => x).ToString();
                        chrt_ganancia.Series[fechachar1.Subtract(timespan[i]).ToString("dd-MMMM")].Points.Add(ganancias1.Sum(x => x));
                        dr.Close();
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }


                try
                {
                    chrt_masVendido.Titles.Add("Ventas de la Ultima Semana");
                    chrt_masVendido.ChartAreas[0].AxisX.Title = "Fecha";
                    chrt_masVendido.ChartAreas[0].AxisY.Title = "Cantidad de Facturas Creadas";
                    int[] ventas = new int[6];


                    for (int i = 0; i < timespan.Length; i++)
                    {
                        timespan[i] = new TimeSpan(i, 0, 0, 0);
                    }


                    for (int i = 0; i < titulo.Length; i++)
                    {
                        titulo[i] = dia.Subtract(timespan[i]).ToString("dd-MMMM");
                    }

                    for (int i = 0; i < ganan.Length; i++)
                    {


                        cmd.CommandText = "SELECT Count(*) FROM `tbl_factura` WHERE `fecha` LIKE '" + Convert.ToDateTime(fechachar1.Subtract(timespan[i])).ToString("yyyy-MM-dd") + "%'";

                        ventas[i] = (int.Parse(cmd.ExecuteScalar().ToString()));


                        chrt_masVendido.Series["Dia Con Mas Ventas"].Points.AddXY(fechachar1.Subtract(timespan[i]).ToString("dd-MMMM"), ventas[i]);

                        /* 
                        chrt_masVendido.Series["Dia Con Mas Ventas"].Label = ventas[i].ToString();


                        serie = chrt_ganancia.Series.Add(titulo[i].ToString());
                          ganan[i] = ganancias1.Sum(x => x);
                          serie.Label = ganancias1.Sum(x => x).ToString();
                          serie.Points.Add(ganan[i]);*/

                    }


                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }




        }

        private void btn_facturaPrin_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.setDescuento(1);
            factura.ShowDialog(this);
            
        }

        private void btn_abonos_Click(object sender, EventArgs e)
        {
            Abonos abonos = new Abonos();
            abonos.ShowDialog();
        }


        public void notificacionProveedor()
        {
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            DateTime dosDias = DateTime.Today,
                unDia = DateTime.Today, hoy = DateTime.Today;


        

            try
            {




                dosDias.AddDays(2.0);
                unDia.AddDays(1);
                cn.Open();
                cmd.Connection = cn;

                cmd.CommandText = "SELECT count(*) FROM tbl_proveedor WHERE fecha_visita  BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND '" + DateTime.Now.AddDays(2).ToString("yyyy-MM-dd") + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                if (valor > 0)
                {
                    this.notifyProveedores.BalloonTipTitle = "Visitas de proveedores";
                    this.notifyProveedores.BalloonTipText = "Recuerde que tiene " + valor + " visitas de proveedores en los proximos dos dias";
                    this.notifyProveedores.BalloonTipIcon = ToolTipIcon.Info;
                    this.notifyProveedores.Visible = true;
                    this.notifyProveedores.ShowBalloonTip(5000);
                }




            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        
        }

        private void timerProveedores_Tick(object sender, EventArgs e)
        {

            DateTime hora = DateTime.Now;
            TimeSpan ochoAm = new TimeSpan(8, 0, 0);
            TimeSpan diez = new TimeSpan(10, 0, 0);
            TimeSpan doce = new TimeSpan(12, 0, 0);
            TimeSpan cuatroPm = new TimeSpan(16, 0, 0);
            TimeSpan prueba = new TimeSpan(23, 25, 0);



            if (hora.Hour.Equals(08) && hora.Minute.Equals(00))
            {
                notificacionProveedor();
                this.timerProveedores.Stop();


            }

            if (hora.Hour.Equals(10) && hora.Minute.Equals(00))
            {
                notificacionProveedor();
                this.timerProveedores.Stop();

            }

            if (hora.Hour.Equals(12) && hora.Minute.Equals(00))
            {
                notificacionProveedor();
                this.timerProveedores.Stop();

            }

            if (hora.Hour.Equals(14) && hora.Minute.Equals(00))
            {
                notificacionProveedor();

            }

            if (hora.Hour.Equals(16) && hora.Minute.Equals(00))
            {
                notificacionProveedor();
                this.timerProveedores.Stop();

            }



        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            DateTime fechaInicio, fechaFinal;


            cn.Open();
            cmd.Connection = cn;
            if (cbFecha.SelectedIndex == 0)
            {
                try
                {

                    cmd.CommandText = "SELECT * FROM `tbl_factura` WHERE `fecha` LIKE '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd") + "%'";
                    //cmd.Parameters.AddWithValue("?fecha", MySqlDbType.DateTime).Value = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                    //        "SELECT * FROM  WHERE LIKE '" + Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd") + "%'";
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

                            dgv_reporte.DataSource = bsource;
                            sda.Update(dbdataset);

                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        double ganancia = 0;
                        for (int i = 0; i < dgv_reporte.RowCount - 1; i++)
                        {
                            ganancia = double.Parse(dgv_reporte.Rows[i].Cells[2].Value.ToString()) + ganancia;
                        }
                        ganancia = Math.Round(ganancia, 2);
                        lbl_gananciasReportes.Text = "Las Ganancias Generadas El Dia De Hoy Fueron L" + ganancia.ToString();
                    }
                    else
                        MessageBox.Show("Aun no hay facturas creadas el dia de hoy");


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            else if (cbFecha.SelectedIndex == 1)
            {
                TimeSpan timespan = new TimeSpan(7, 0, 0, 0);
                try
                {
                    fechaInicio = DateTime.Now;
                    fechaFinal = DateTime.Now;
                    fechaInicio = fechaInicio.Subtract(timespan);



                    // MessageBox.Show(Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd")+"\n" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd"));
                    cmd.CommandText = " SELECT * FROM `tbl_factura` WHERE `fecha` BETWEEN '" + Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd 23:59:59") + "'";


                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();



                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = cmd;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();

                        bsource.DataSource = dbdataset;

                        dgv_reporte.DataSource = bsource;
                        sda.Update(dbdataset);

                        double ganancia = 0;
                        for (int i = 0; i < dgv_reporte.RowCount - 1; i++)
                        {
                            ganancia = double.Parse(dgv_reporte.Rows[i].Cells[2].Value.ToString()) + ganancia;
                        }
                        ganancia = Math.Round(ganancia, 2);
                        lbl_gananciasReportes.Text = "Las Ganancias Generadas Desde El "+ fechaInicio.ToShortDateString() + " Hasta El "+fechaFinal.ToShortDateString() + " Fueron L" + ganancia.ToString();
                    }
                    else
                        MessageBox.Show("No hay facturas creadas");


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }

            else if (cbFecha.SelectedIndex == 2)
            {

                TimeSpan timespan = new TimeSpan(30, 0, 0, 0);
                try
                {
                    fechaInicio = DateTime.Now;
                    fechaFinal = DateTime.Now;
                    fechaInicio = fechaInicio.Subtract(timespan);



                    // MessageBox.Show(Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd")+"\n" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd"));
                    cmd.CommandText = " SELECT * FROM `tbl_factura` WHERE `fecha` BETWEEN '" + Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd 23:59:59") + "'";


                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();



                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = cmd;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();

                        bsource.DataSource = dbdataset;

                        dgv_reporte.DataSource = bsource;
                        sda.Update(dbdataset);

                        double ganancia = 0;
                        for (int i = 0; i < dgv_reporte.RowCount - 1; i++)
                        {
                            ganancia = double.Parse(dgv_reporte.Rows[i].Cells[2].Value.ToString()) + ganancia;
                        }
                        ganancia = Math.Round(ganancia, 2);

                        lbl_gananciasReportes.Text = "Las Ganancias Generadas Desde El " + fechaInicio.ToShortDateString() + " Hasta El " + fechaFinal.ToShortDateString() + "  Fueron L" + ganancia.ToString();

                    }
                    else
                        MessageBox.Show("No hay facturas creadas en los ultimos 30 dias");


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }
         
            cn.Close();

        }

        private void Cbfecha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar1_Click(object sender, EventArgs e)
        {

            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            string fechaInicio, fechaFinal;
            TimeSpan timespan = new TimeSpan(7, 0, 0, 0);

            cn.Open();
            cmd.Connection = cn;


            try
            {
                string fecha = dtpInicio.Value.Year.ToString() + "-" + dtpInicio.Value.Month.ToString() + "-" + dtpInicio.Value.Day.ToString() + " 20:00:00";

                fechaInicio = fecha;

                fechaFinal = String.Format("{0:u}", dtpFinal.Value);

                // MessageBox.Show(dtp_inicio.Value.ToString() + "\n" + dtp_final.Value.ToString());
                //cmd.CommandText = "SELECT * FROM tbl_factura WHERE fecha BETWEEN '" + dtp_inicio.Value + "' AND '" + dtp_final.Value + "'";
                cmd.CommandText = "SELECT * FROM `tbl_factura` WHERE `fecha` BETWEEN '" + Convert.ToDateTime(dtpInicio.Value).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(dtpFinal.Value).ToString("yyyy-MM-dd 23:59:59") + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();



                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;

                    dgv_reporte.DataSource = bsource;
                    sda.Update(dbdataset);


                    double ganancia = 0;
                    for (int i = 0; i < dgv_reporte.RowCount - 1; i++)
                    {
                        ganancia = double.Parse(dgv_reporte.Rows[i].Cells[2].Value.ToString()) + ganancia;
                    }
                    ganancia = Math.Round(ganancia, 2);
                    lbl_gananciasReportes.Text = "Las Ganancias Generadas Desde El " + dtpInicio.Value.ToShortDateString() + " Hasta El " + dtpFinal.Value.ToShortDateString() + "  Fueron L" + ganancia.ToString();
                }
                else
                    MessageBox.Show("No hay facturas creadas entre esas fechas \nElija otro rango");


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





            cn.Close();


        }

        private void notifyProveedores_BalloonTipClicked(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.ShowDialog();

        }

        private void notifyProveedores_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
         
        }



        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vistas_Click(object sender, EventArgs e)
        {
            
                Proveedores proveedores = new Proveedores();
                proveedores.ShowDialog();


            }

        private void proveedores_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.setDescuento(1);
            factura.ShowDialog(this);
        }

        private void abonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abonos abonos = new Abonos();
            abonos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            prov.ShowDialog(this);
        }
    }
}
