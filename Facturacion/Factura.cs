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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Facturacion
{
    public partial class Factura : Form
    {
        double total=0;
        public double subTotal;
        double ganancia=0;
        public int descuento;
      public  string cliente = "Cliente Particular";
      public  string clienteId = "0000000000000";
        Validacion v = new Validacion();
        
        public Factura()
        {
            InitializeComponent();
            llenarListBox();
            txt_codigo.Focus();
           

        }
        public void setDescuento(int descuento) {
            this.descuento = descuento;
        }
        void llenarListBox(){
         
            nud_cantidad.Minimum = 0;
            nud_cantidad.Value = 1;
            txt_codigo.Focus();


            lbl_date.Text = DateTime.Now.ToShortDateString();
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            try { 
            cn.Open();
            cmd.Connection = cn;

            try
            {

                cmd.CommandText = "select * from bd_flara.tbl_categoria";

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string categoria = dr.GetString("categoria");
                    



                }

                    cn.Close();


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


        //agregar producto a la factura
        private void button1_Click(object sender, EventArgs e)
        {
            
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
           cn.Open();
          cmd.Connection = cn;
            if (txt_codigo.Text.ToString()=="") {

                MessageBox.Show("Debe Ingresar Un Codigo De Producto\nSeleccione El Boton 'BUSCAR PRODUCTO' Si No Recuerda El Codigo");
                btn_buscar.Focus();
            }
            else
            {
                try
                {

                    cmd.CommandText = "select * from bd_flara.tbl_producto where id_producto = '" + int.Parse(txt_codigo.Text) + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if (nud_cantidad.Value == 0)
                        {
                            DialogResult respuesta =
                                     MessageBox.Show("Especifique la Cantidad \n CANTIDAD DISPONIBLE: " + dr.GetInt32("existencia").ToString(), "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nud_cantidad.Focus();

                        }

                        else {

                            if (nud_cantidad.Value <= dr.GetInt32("existencia"))
                            {


                                agregarProductoFactura(int.Parse(dr.GetString("id_producto")), dr.GetString("nombre"), int.Parse(nud_cantidad.Value.ToString()), double.Parse(dr.GetString("precio_venta")));


                            }

                            else {
                                DialogResult respuesta =
                                MessageBox.Show("No Disponible Esa Cantidad \n \n "
                                + dr.GetString("nombre").ToString() + "  Disponibles: " + dr.GetInt32("existencia").ToString(), "ATENCION",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                                nud_cantidad.Focus();
                            }

                        }




                    }

                    else {

                        MessageBox.Show("Producto No Encontrado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_codigo.Focus();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cn.Close();

            calcularGanancia();
        }




        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarProducto buscar = new BuscarProducto();
            buscar.setDescuento(descuento);
            buscar.descuentos();
            buscar.ShowDialog(this);
            // buscar.checkBoxDescuento.Visible=true;


        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //al precionar enenter comiensa a buscar
            if (e.Equals(Keys.Enter))
            {
                button1_Click(this, new EventArgs());
            }
        }




        //generar factura, restar de la db e imprimir la factura
        private void btn_facturar_Click(object sender, EventArgs e)
        {

            Login log = new Login();
            int idFactura =-1;
            MySqlCommand cmd = new MySqlCommand();
            int a=0;


            if (dgv_factura.Rows.Count==0) {

                MessageBox.Show("Debe agregar al menos un producto a la factura");
            }


            else
            {
                try
                {

                    MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");

                    MySqlDataReader dr;
                    cn.Open();
                    cmd.Connection = cn;

                    //cambiar el 1 por  log.tipoUsuario y eliminar usuario
                    int usuario = log.tipoUsuario;
                    int nuevaCantidad;


                    for (int i = 0; i <= (dgv_factura.RowCount - 1); i++)
                    {

                        //selecciona la cantidad disponible
                        cmd.CommandText = "select existencia from bd_flara.tbl_producto where id_producto = '" + int.Parse(dgv_factura.Rows[i].Cells[0].Value.ToString()) + "'";
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {

                            try
                            {  //modifica la cantidad en la base de datos
                                nuevaCantidad = (int.Parse(dr["existencia"].ToString()) - int.Parse(dgv_factura.Rows[i].Cells[2].Value.ToString()));
                                cmd.CommandText = "update bd_flara.tbl_producto set existencia = '" + nuevaCantidad + "' where id_producto = '" + int.Parse(dgv_factura.Rows[i].Cells[0].Value.ToString()) + "'";
                                dr.Close();

                                a = cmd.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + " porducto: " + i);
                            }


                        }
                    }

                    calcularGanancia();
                    ganancia = 0;
                    total = 0;
                    //si modifico la cantidad actualiza total y lo guarda para usarlo al generarla
                    if (a > 0)
                    {


                        for (int k = 0; k < (dgv_factura.Rows.Count); k++)
                        {
                            total = total + ((float.Parse(dgv_factura.Rows[k].Cells[3].Value.ToString())) * (int.Parse(dgv_factura.Rows[k].Cells[2].Value.ToString())));

                        }
                        total = Math.Round(total, 2);
                    }
                    ganancia = total - subTotal;
                    //  MessageBox.Show("modificados");

                    DateTime fecha = DateTime.Now;
                    string x = fecha.ToString("yyyy-MM-dd HH:mm:ss");

                    if (clienteId == "0000000000000")
                    {
                        cmd.CommandText = "INSERT INTO `tbl_factura` (`total`,`ganancia`, `fecha`, `factura`, `id_cliente`, `id_usuarios`) VALUES (?total, ?ganancia, ?fecha, ?factura, ?id_cliente, ?id_usuarios) ";


                        cmd.Parameters.Add("?total", MySqlDbType.Double).Value = total;
                        cmd.Parameters.Add("?ganancia", MySqlDbType.Double).Value = ganancia;
                        cmd.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = fecha;
                        cmd.Parameters.Add("?factura", MySqlDbType.Blob).Value = null;
                        cmd.Parameters.Add("?id_cliente", MySqlDbType.VarChar).Value = "0000000000000";
                        cmd.Parameters.Add("?id_usuarios", MySqlDbType.Int16).Value = 1;

                        cmd.ExecuteNonQuery();
                        idFactura = int.Parse(cmd.LastInsertedId.ToString());
                    }

                    else {

                        cmd.CommandText = "INSERT INTO `tbl_factura` (`total`,`ganancia`, `fecha`, `factura`, `id_cliente`, `id_usuarios`) VALUES (?total, ?ganancia, ?fecha, ?factura, ?id_cliente, ?id_usuarios) ";


                        cmd.Parameters.Add("?total", MySqlDbType.Double).Value = total;
                        cmd.Parameters.Add("?ganancia", MySqlDbType.Double).Value = ganancia;
                        cmd.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = fecha;
                        cmd.Parameters.Add("?factura", MySqlDbType.Blob).Value = null;
                        cmd.Parameters.Add("?id_cliente", MySqlDbType.VarChar).Value = clienteId;
                        cmd.Parameters.Add("?id_usuarios", MySqlDbType.Int16).Value = 1;

                        cmd.ExecuteNonQuery();
                        idFactura = int.Parse(cmd.LastInsertedId.ToString());


                    }
                    //MessageBox.Show("" + idFactura);
                    cmd.Parameters.Clear();

                    if (idFactura > 0)
                    {
                        for (int j = 0; j < (dgv_factura.Rows.Count); j++)
                        {

                            //     MessageBox.Show(dgv_factura.Rows[j].Cells[0].Value.ToString() + "  " + idFactura.ToString());

                            int codigoProducto = int.Parse(dgv_factura.Rows[j].Cells[0].Value.ToString());
                            cmd.CommandText = string.Format("INSERT INTO bd_flara.fact_prod (id_factura, id_producto) values('{0}','{1}' ) ", idFactura, codigoProducto);
                            cmd.ExecuteNonQuery();
                            string queso = cmd.LastInsertedId.ToString();
                            /*   cmd.CommandText = "INSERT INTO `fact_prod` (`id_factura`, `id_producto`) VALUES (?id_factura, ?id_producto)";
                              cmd.Parameters.Add("?id_factura", MySqlDbType.Int16).Value = idFactura;
                              cmd.Parameters.Add("?id_producto", MySqlDbType.Int16).Value = codigoProducto;
                        cmd.Parameters.Clear();      
                        */
                            //  cmd.Parameters.Add("?id_factura", MySqlDbType.Int16).Value = idFactura;
                            //cmd.Parameters.Add("?id_producto", MySqlDbType.Int16).Value = int.Parse(dgv_factura.Rows[j].Cells[0].Value.ToString());

                            //  cmd.CommandText = string.Format("Insert into prueba.producto (idfactura, idproducto, total, fecha, idcliente) values ('{0}','{1}','{2}','{3}','{4}')",
                            //        idFactura, int.Parse(dgv_factura.Rows[i].Cells[1].Value.ToString()), total, DateTime.Now.Date, 1);




                        }


                    }

                    else {
                        MessageBox.Show("no agregado");
                    }

                    imprimirFactura(idFactura);
                    dgv_factura.Rows.Clear();
                    dgv_factura.Refresh();
                    MessageBox.Show("FACTURA GENERADA");


                    cn.Close();

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

                


        }


        private void dgv_factura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_factura.Columns[e.ColumnIndex].Name == "Cantidad")
             {

                
                total = 0;
                for (int i = 0; i <= (dgv_factura.Rows.Count - 1); ++i)
                {
                    total = total + ((float.Parse(dgv_factura.Rows[i].Cells[3].Value.ToString())) * (int.Parse(dgv_factura.Rows[i].Cells[2].Value.ToString())));

                }

                lbl_total.Text = "L" + total.ToString();

                /*total = total -(oldQty*int.Parse(dgv_factura.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value.ToString())  );
                total = total + (int.Parse(dgv_factura.Rows[e.RowIndex].Cells[e.ColumnIndex].ToString()) * int.Parse(dgv_factura.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].ToString()));
                lbl_total.Text = total.ToString();*/
            }
        }

        private void dgv_factura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        //QUITAR PRODUCTO DE UNA FACTURA
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            /*   Document doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
               Random ran = new Random();



               string ruta = "E:\\back up usb\\ProyectoFactoriacion CSharp\\Facturacion\\Facturacion\\Facturas\\factura"+1001+".pdf";

               PdfWriter pdfw = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
               //abre el documento a escribir
               doc.Open();

               var title = FontFactory.GetFont("Arial", 25);
               var subtitle= FontFactory.GetFont("Arial", 12);
               var phrase = new Phrase("Ferreteria Lara", title);
               Paragraph parrafo = new Paragraph("Ferreteria Lara",title);
               parrafo.IndentationLeft = 210f;       
               doc.Add(parrafo);
               parrafo.Clear();
               string texto = "Parmas, Sonaguera, Colon";
               Paragraph subtitulo= new Paragraph(texto, subtitle);

               subtitulo.IndentationLeft = 211f;
               doc.Add(subtitulo);
               texto = "Celular: +504-9539-6956 \n";
               subtitulo = new Paragraph(texto, subtitle);
               doc.Add(subtitulo);



               texto =  DateTime.Now.ToLongDateString()+ "\n .";

               subtitulo = new Paragraph(texto, subtitle);
               subtitulo.IndentationLeft = 380f;
               doc.Add(subtitulo);


               List lista = new List(List.UNORDERED);
               PdfPTable tabla = new PdfPTable(3);

               tabla.AddCell("Producto");
               tabla.AddCell("Cantidad");
               tabla.AddCell("Precio");
               for (int i = 0; i <= (dgv_factura.Rows.Count - 1); ++i)
               {
                   lista.Add(dgv_factura.Rows[i].Cells[0].Value.ToString());
                   tabla.AddCell(dgv_factura.Rows[i].Cells[1].Value.ToString());
                   tabla.AddCell(dgv_factura.Rows[i].Cells[2].Value.ToString());
                   tabla.AddCell(dgv_factura.Rows[i].Cells[3].Value.ToString());

               }

               doc.Add(lista);
               doc.Add(tabla);
               Paragraph total=new Paragraph("El Total de la factura es: " + lbl_total.Text.ToString());
               total.IndentationLeft =380;
               doc.Add(total);

               doc.Close();

               System.Diagnostics.Process.Start(ruta);*/

            try
            {

                foreach (DataGridViewRow item in this.dgv_factura.SelectedRows)
                {
                    dgv_factura.Rows.RemoveAt(item.Index);
                }
                total = 0;
                for (int i = 0; i <= (dgv_factura.Rows.Count - 1); ++i)
                {
                    total = total + ((float.Parse(dgv_factura.Rows[i].Cells[3].Value.ToString())) * (int.Parse(dgv_factura.Rows[i].Cells[2].Value.ToString())));

                }

                lbl_total.Text = "L" + total.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        





        //metodo para agregar a la factura
        public void agregarProductoFactura(int codigo, string nombre, int cantidad, double precio) {

            int yaExisteEnLaFactura=0;
            int row=0;

            for (int i = 0; i < (dgv_factura.Rows.Count); ++i)
            {
                if (int.Parse(dgv_factura.Rows[i].Cells[0].Value.ToString()) == codigo)
                {
                    yaExisteEnLaFactura++;
                    row = i;
                }
            }

            //comprueba si el producto ya se agrego una vez en la factura
            if (yaExisteEnLaFactura == 0)
            {



                dgv_factura.Rows.Add(codigo, nombre, cantidad, precio);
                total = 0;
                for (int i = 0; i <= (dgv_factura.Rows.Count-1); ++i)
                {
                    total = total + ((float.Parse(dgv_factura.Rows[i].Cells[3].Value.ToString())) * (int.Parse(dgv_factura.Rows[i].Cells[2].Value.ToString())));

                }
                total = Math.Round(total, 2);
                //          total = total + ((float.Parse(dr.GetString("precio"))) * (int.Parse(nud_cantidad.Value.ToString())));
                lbl_total.Text = "L" + total.ToString();


                int nuevaCantidad = cantidad - int.Parse(nud_cantidad.Value.ToString());
                // Hace el update de cantidad en el producto y restarle a existencia la cantidad agregada a factura
                //cmd.CommandText = "update flara.producto set existencia = '" + nuevaCantidad + "' where idproducto = '" + int.Parse(txt_codigo.Text) + "'";

                txt_codigo.Clear();
                nud_cantidad.Value = 1;
                txt_codigo.Focus();
            }

            //ya existe en la factura
            else {
                DialogResult respuesta = MessageBox.Show("Ese Producto Ya Existe En La Factura \n \n Desea Modificar La Cantidad? ", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    /*  total = (total -( int.Parse(dgv_factura.Rows[row].Cells[2].Value.ToString())* float.Parse(dgv_factura.Rows[row].Cells[3].Value.ToString()))   );
                      oldQty = int.Parse(dgv_factura.Rows[row].Cells[2].Value.ToString()); */
                    dgv_factura.Rows[row].Cells[2].Selected = true;



                }
                else {

                    txt_codigo.Clear();
                    nud_cantidad.Value = 1;
                    txt_codigo.Focus();

                }


            }






        }

        public void imprimirFactura(int idFactura) {


            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);


            string ruta = "C:\\factura\\factura" + idFactura+".pdf";

            PdfWriter pdfw = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            //abre el documento a escribir
            doc.Open();
            var title = FontFactory.GetFont("Arial", 25);
            var subtitle = FontFactory.GetFont("Arial", 12);
            var phrase = new Phrase("Ferreteria Lara", title);
            Paragraph parrafo = new Paragraph("Ferreteria Lara", title);
            parrafo.IndentationLeft = 210f;
            doc.Add(parrafo);

            parrafo.Clear();
            string texto = "Parmas, Sonaguera, Colon";
            Paragraph subtitulo = new Paragraph(texto, subtitle);
            subtitulo.IndentationLeft = 213f;
            doc.Add(subtitulo);

            texto = DateTime.Now.ToLongDateString() + "\n .";
            subtitulo = new Paragraph(texto, subtitle);
            subtitulo.IndentationLeft = 380f;
           // doc.Add(subtitulo);

            texto = "Celular: +504-9539-6956                                                                          "+DateTime.Now.ToLongDateString();
            subtitulo = new Paragraph(texto, subtitle);
            subtitulo.IndentationLeft = 213f;
            doc.Add(subtitulo);

            subtitulo.Clear();
            subtitulo = new Paragraph(cliente, subtitle);
            doc.Add(subtitulo);

            subtitulo.Clear();
            subtitulo = new Paragraph(clienteId, subtitle);
            doc.Add(subtitulo);

            subtitulo.Clear();
            subtitulo = new Paragraph(" ", subtitle);
            doc.Add(subtitulo);
            doc.Add(subtitulo);

            PdfPTable tabla = new PdfPTable(3);

            tabla.AddCell("Producto");
            tabla.AddCell("Cantidad");
            tabla.AddCell("Precio");
            for (int i = 0; i <= (dgv_factura.Rows.Count-1); ++i)
            {
                int precio = int.Parse(dgv_factura.Rows[i].Cells[2].Value.ToString());
                double cantidad = double.Parse(dgv_factura.Rows[i].Cells[3].Value.ToString());
                cantidad = Math.Round(cantidad, 2);
                double precioCantidad = precio * cantidad;
                precioCantidad = Math.Round(precioCantidad, 2);

                tabla.AddCell(dgv_factura.Rows[i].Cells[1].Value.ToString());
                tabla.AddCell(dgv_factura.Rows[i].Cells[2].Value.ToString());
                tabla.AddCell(precioCantidad.ToString());

            }

            
            doc.Add(tabla);
            Paragraph total = new Paragraph("El Total de la factura es: " + lbl_total.Text.ToString());
            total.IndentationLeft = 380;
            doc.Add(total);

            doc.Close();

            System.Diagnostics.Process.Start(ruta);

        }

        public void calcularGanancia() {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            try
            {
              
               
                MySqlDataReader dr;
                cn.Open();
                cmd.Connection = cn;
                subTotal = 0;
                for (int i = 0; i < dgv_factura.RowCount; i++)
                {
                    cmd.CommandText = "SELECT * FROM `tbl_producto` WHERE `id_producto`= '" + int.Parse(dgv_factura.Rows[i].Cells[0].Value.ToString()) + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        subTotal = subTotal + (double.Parse(dr["precio_compra"].ToString())* int.Parse(dgv_factura.Rows[i].Cells[2].Value.ToString()));

                    }
                    subTotal = Math.Round(subTotal, 2);
                    dr.Close();
                }
                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            cn.Close();
           
        }

        private void dgv_factura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i <= (dgv_factura.Rows.Count-1); ++i)
            {
                total = total + ((float.Parse(dgv_factura.Rows[i].Cells[3].Value.ToString())) * (int.Parse(dgv_factura.Rows[i].Cells[2].Value.ToString())));

            }

            //          total = total + ((float.Parse(dr.GetString("precio"))) * (int.Parse(nud_cantidad.Value.ToString())));
            lbl_total.Text = "L" + total.ToString();
        }

        private void vtn_agregarCliente_Click(object sender, EventArgs e)
        {
            BuscarProducto buscar = new BuscarProducto();
            buscar.setModificar(1);
            buscar.modificarCliente();
            buscar.setDescuento(descuento);
            buscar.descuentos();
            buscar.Show(this);
        }


        private void dgv_factura_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_factura.CurrentCell.ColumnIndex == 2)
            {
                e.Control.KeyPress += new KeyPressEventHandler(dgv_factura_KeyPress);
            }
        }

        private void dgv_factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
