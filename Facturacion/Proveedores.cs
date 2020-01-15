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
    public partial class Proveedores : Form
    {
        TimeSpan semana = new TimeSpan(7, 0, 0, 0);
        Validacion v = new Validacion();
        int modificar = 0;
        public Proveedores()
        {
            InitializeComponent();
            visitasSemana(semana);
            comboEmpresas();
        }
        private void Proveedores_Load(object sender, EventArgs e)
        {
           
        }

        private void dgv_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgv_visitas.Rows[int.Parse(dgv_visitas.CurrentCell.RowIndex.ToString())].Cells[5].Value.ToString();
            cargarEmpresa(id);
            tabControl1.SelectedIndex = 1;
        }

        public void cargarEmpresa(string id) {


            try
            {
                MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader dr;

                cn.Open();
                cmd.Connection = cn;
                try
                {


                    // MessageBox.Show(Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd")+"\n" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd"));
                    cmd.CommandText = "SELECT * FROM `tbl_empresa` WHERE `id_empresa` ='" + id + "'";
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

                            dgv_empresa.DataSource = bsource;
                            sda.Update(dbdataset);

                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("No se encontró \n revise su ortografia");



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
        public void comboEmpresas() {
            try
            {
                dtpVisita.MinDate = DateTime.Today;

                //   dtpInicio.CustomFormat = "yyyy/MM/dd hh:mm:ss";
                //lbl_date.Text = DateTime.Now.ToShortDateString();
                MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader dr;
                try
                {
                    cn.Open();
                    cmd.Connection = cn;



                    cmd.CommandText = "select * from tbl_empresa";

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string categoria = dr.GetString("empresa");
                        cbEmpresa.Items.Add(categoria);




                    }
                    dr.Close();
                    cn.Close();

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


        }
        public void visitasSemana(TimeSpan rango) {

            try
            {
                MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader dr;
                DateTime fechaInicio, fechaFinal;

                cn.Open();
                cmd.Connection = cn;

                try
                {
                    fechaInicio = DateTime.Today;
                    fechaFinal = DateTime.Now;
                    fechaFinal = fechaFinal.Add(rango);



                    // MessageBox.Show(Convert.ToDateTime(fechaInicio).ToString("yyyy-MM-dd")+"\n" + Convert.ToDateTime(fechaFinal).ToString("yyyy-MM-dd"));
                    cmd.CommandText = " SELECT * FROM `tbl_proveedor` WHERE `fecha_visita` BETWEEN '" + fechaInicio.ToString("yyyy-MM-dd") + "' AND '" + fechaFinal.ToString("yyyy-MM-dd") + "'";


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

                            dgv_visitas.DataSource = bsource;
                            sda.Update(dbdataset);
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("No Hay Visitas Pendientes De Proveedores");

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

        private void Cargar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan dosSemanas = new TimeSpan(14, 0, 0, 0);
            TimeSpan unMes = new TimeSpan(30, 0, 0, 0);
            if (cb_visita.SelectedIndex == 0)
            {
                visitasSemana(dosSemanas);
            }
            else if (cb_visita.SelectedIndex == 1)
            {
                visitasSemana(unMes);
            }
            else
            {
                MessageBox.Show("Seleccione Un Rango De Visitas");
                cb_visita.Focus();

            }

        }

        private void dgv_visitas_MouseHover(object sender, EventArgs e)
        {
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void dgv_visitas_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnGurdar_Click(object sender, EventArgs e)
        {
            try
            {
                string empresa;
                string idEmpresaXprov;
                int idestado;
                MySqlCommand cmd = new MySqlCommand();

                MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");

                MySqlDataReader dr;
                cn.Open();
                cmd.Connection = cn;






                if (modificar == 0)
                {
                    if (txt_Nombre.Text == "" || txtTelefono.Text == "" || cbEmpresa.SelectedIndex < 0)
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                        if (txt_Nombre.Text == "")
                        {
                            txt_Nombre.Focus();
                        }
                        else if (txtTelefono.Text == "")
                        {
                            txtTelefono.Focus();
                        }




                    }



                    else {
                        try
                        {
                            empresa = cbEmpresa.SelectedItem.ToString();
                            cmd.CommandText = "SELECT id_empresa FROM tbl_empresa WHERE empresa ='" + empresa + "'";
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                idEmpresaXprov = dr.GetString("id_empresa");
                                dr.Close();

                                try
                                {
                                    string correo;
                                    if (txtCorreo.Text == "")
                                    {
                                        correo = "Sin Correo";
                                    }
                                    else correo = txtCorreo.Text.ToString();



                                    string nombre = txt_Nombre.Text.ToString();
                                    string telefono = txtTelefono.Text.ToString();

                                    DateTime fechaVisita = dtpVisita.Value;

                                    cmd.CommandText = string.Format("INSERT INTO bd_flara.tbl_proveedor ( nombre, telefono, correo, fecha_visita, id_empresa) values ('{0}','{1}','{2}','{3}','{4}')",
                                     nombre, telefono, correo, fechaVisita.ToString("yyyy-MM-dd"), idEmpresaXprov);



                                    int a = cmd.ExecuteNonQuery();


                                    if (a > 0)
                                    {

                                        MessageBox.Show("Guardado Correctamente");

                                        dgv_proveedores.Rows.Add(nombre, telefono, correo, fechaVisita.ToString("yyyy-MM-dd"), idEmpresaXprov);



                                    }
                                    else MessageBox.Show("No se pudo agregar");
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.ToString());

                                }

                            }
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }





                    }



                }



                //SI VA A MODIFICAR UN PROVEEDOR DESDE LA TAB BUSCAR

                else if (modificar == 2)
                {




                    if (txt_Nombre.Text == "" || txtTelefono.Text == "" || cbEmpresa.SelectedIndex < 0 || cb_estadoProveedores.SelectedItem.ToString()=="")
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                        if (txt_Nombre.Text == "")
                        {
                            txt_Nombre.Focus();
                        }
                        else if (txtTelefono.Text == "")
                        {
                            txtTelefono.Focus();
                        }




                    }



                    else {
                        try
                        {
                            int proveedor = int.Parse(dgv_modificar.Rows[dgv_modificar.CurrentCell.RowIndex].Cells[0].Value.ToString());
                            empresa = cbEmpresa.SelectedItem.ToString();
                            idestado = cb_estadoProveedores.SelectedIndex + 1;
                            cmd.CommandText = "SELECT id_empresa FROM tbl_empresa WHERE empresa ='" + empresa + "'";
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                idEmpresaXprov = dr.GetString("id_empresa");
                                dr.Close();

                                try
                                {
                                    string correo;
                                    if (txtCorreo.Text == "")
                                    {
                                        correo = "Sin Correo";
                                    }
                                    else correo = txtCorreo.Text.ToString();



                                    string nombre = txt_Nombre.Text.ToString();
                                    string telefono = txtTelefono.Text.ToString();

                                    DateTime fechaVisita = dtpVisita.Value;

                                    cmd.CommandText = "UPDATE `tbl_proveedor` SET `nombre` = '"+nombre+"', `telefono` = '"+telefono+"', `correo` = '"+correo+"', `fecha_visita` = '"+ fechaVisita.ToString("yyyy-MM-dd") + "', `id_empresa` = '"+ idEmpresaXprov + "', `id_estado` = '"+idestado+"' WHERE `tbl_proveedor`.`id_proveedor` = '"+proveedor+"'";



                                    int a = cmd.ExecuteNonQuery();


                                    if (a > 0)
                                    {

                                        MessageBox.Show("El Proveedor "+nombre +" Fue Modificado Correctamente");
                                        dgv_proveedores.Rows.Clear();
                                        dgv_proveedores.Rows.Add(nombre, telefono, correo, fechaVisita.ToString("yyyy-MM-dd"), idEmpresaXprov);
                                        cb_estadoProveedores.Visible = false;
                                        modificar = 0;


                                    }
                                    else MessageBox.Show("No se pudo modificar");
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.ToString());

                                }

                            }
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }





                    }




                }
                
              
                cn.Close();
                txt_rtn.Clear();
                txt_Nombre.Clear();
                txt_telefono.Clear();
                txt_saldoPendienteE.Clear();
                txt_descripcion.Clear();
                txt_Direccionn.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           

            

        }

        private void btn_guardarEmpresa_Click(object sender, EventArgs e)
        {

            try
            {
                string empresa;
                empresa = txt_nombreEmpresa.Text.ToString();
                string telefono = txtTelefono.Text.ToString();
                string rtn = txt_rtn.Text.ToString();
                double saldoPendiente = double.Parse(txt_saldoPendienteE.Text.Trim().ToString());
                string direccion = txt_Direccionn.Text.ToString();
                string descripcion = txt_descripcion.Text.ToString();
                MySqlCommand cmd = new MySqlCommand();

                MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
                MySqlDataReader dr;
                cn.Open();
                cmd.Connection = cn;

                if (modificar == 0)
                {
                   
                    





                    if (txt_nombreEmpresa.Text == "" || txt_telefono.Text == "" || txt_rtn.Text == "" || txt_saldoPendienteE.Text == "" || txt_Direccionn.Text == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                        if (txt_Nombre.Text == "")
                        {
                            txt_Nombre.Focus();
                        }
                        else if (txtTelefono.Text == "")
                        {
                            txtTelefono.Focus();
                        }
                        else if (txt_rtn.Text == "")
                        {
                            txt_rtn.Focus();
                        }
                        else if (txt_saldoPendienteE.Text == "")
                        {
                            txt_saldoPendienteE.Focus();
                        }


                    }



                    else {
                        try
                        {
                           


                            cmd.CommandText = string.Format("INSERT INTO bd_flara.tbl_empresa ( id_empresa,empresa,saldo_pendiente ,telefono, direccion, descripcion) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                             rtn, empresa, saldoPendiente, telefono, direccion, descripcion);
                           

                            int a = cmd.ExecuteNonQuery();


                            if (a > 0)
                            {

                                MessageBox.Show("Guardada Correctamente");
                                cargarEmpresa(rtn);


                            }
                            else MessageBox.Show("No se pudo agregar");






                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }





                    }

                }

                //SI VA A MODIFICAR A LA EMPRESA DESDE LA TAB MODIFICAR

                else {









                    if (txt_nombreEmpresa.Text == "" || txt_telefono.Text == "" || txt_saldoPendienteE.Text == "" || txt_Direccionn.Text == "" || cb_estadoEmpresa.SelectedItem.ToString()=="")
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                        if (txt_Nombre.Text == "")
                        {
                            txt_Nombre.Focus();
                        }
                        else if (txtTelefono.Text == "")
                        {
                            txtTelefono.Focus();
                        }
                        else if (txt_rtn.Text == "")
                        {
                            txt_rtn.Focus();
                        }
                        else if (txt_saldoPendienteE.Text == "")
                        {
                            txt_saldoPendienteE.Focus();
                        }


                    }



                    else {

                        try
                        {
                            int idEstado = cb_estadoEmpresa.SelectedIndex + 1;

                            cmd.CommandText = "UPDATE `tbl_empresa` SET `empresa` = '" + empresa + "', `saldo_pendiente` = '" + saldoPendiente + "', `telefono` = '" + telefono + "', `direccion` = '" + direccion + "', `descripcion` = '" + descripcion + "', `id_estado` = '" + idEstado + "' WHERE `tbl_empresa`.`id_empresa` = '" + dgv_modificar.Rows[dgv_modificar.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
                             int a = cmd.ExecuteNonQuery();
                            if (a > 0)
                            {
                                MessageBox.Show("La Empresa " + empresa + " Se Modifico Correctamente");
                                
                                modificar = 0;
                                txt_nombreEmpresa.Text = "";
                                txt_telefono.Text = "";
                                txt_saldoPendienteE.Text = "";
                                txt_Direccionn.Text = "";
                                txt_descripcion.Text = "";
                                txt_rtn.Visible = true;
                                lbl_rtnEmpresa.Visible = true;
                                cb_estadoEmpresa.Visible = false;

                            }
                            else MessageBox.Show("No se pudo agregar");

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                          }

                    }
                cn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           


        }

        private void btn_BuscarModificar_Click(object sender, EventArgs e)
        {
            string codigo = txt_idModificar.Text.ToString(), nombre = txt_nombreModificar.Text.Trim().ToString();
            string tabla,id,nm;
            if (cb_modificar.SelectedItem==null)
            {
                MessageBox.Show("Seleccione Una Opcion");
                cb_modificar.Focus();
            }
            else if (cb_modificar.SelectedItem.ToString() == "Empresa")
                            {
                                tabla = "tbl_empresa";
                                id = "id_empresa";
                                nm = "empresa";
                                llenarModificar(codigo, nombre,tabla, id, nm);

                            }



                                else if (cb_modificar.SelectedItem.ToString() == "Proveedor")
                                {
                                        id = "id_proveedor";
                                        nm = "nombre";
                                        tabla = "tbl_proveedor";
                                        llenarModificar(codigo, nombre, tabla, id, nm);

                                 }


            lbl_id.Text = "ID";

        }



        public void llenarModificar(string codigo, string nombre, string tabla, string identidad, string nm) {


            MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            //obtiene codigo y nombre del text box
           

            //determina cual esta vacio
            if (codigo != "" && nombre == "")
            {


                cn.Open();
                cmd.Connection = cn;
                try
                {
                    cmd.CommandText = "select * from "+tabla+" where "+identidad+"= '" + codigo + "'";
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

                            dgv_modificar.DataSource = bsource;
                            sda.Update(dbdataset);
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("No se encontró \nrevise su ortografia");
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
                    cmd.CommandText = "select * from "+tabla+ " where "+nm+" like '" + nombre + "%'";
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

                            dgv_modificar.DataSource = bsource;
                            sda.Update(dbdataset);
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("No se encontró \nrevise su ortografia");
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
                    cmd.CommandText = "select * from " + tabla + " where "+nm+" like'" + nombre+ "%' and "+identidad+"='" + codigo + "'";
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

                            dgv_modificar.DataSource = bsource;
                            sda.Update(dbdataset);
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("No se encontró \nrevise su ortografia");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                cn.Close();
            }

        }

        private void dgv_modificar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cb_modificar.Text.ToString() == "Empresa")
                {
                    string id = dgv_modificar.Rows[int.Parse(dgv_modificar.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString();
                    cargarEmpresa(id);
                    txt_rtn.Visible = false;
                    lbl_rtnEmpresa.Visible = false;
                    cb_estadoEmpresa.Visible = true;
                    modificar = 1;
                    tabControl1.SelectedIndex = 1;

                }
                else if (cb_modificar.Text.ToString() == "Proveedor")
                {

                    string id = dgv_modificar.Rows[int.Parse(dgv_modificar.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString();
                    string nombre= dgv_modificar.Rows[int.Parse(dgv_modificar.CurrentCell.RowIndex.ToString())].Cells[1].Value.ToString();
                    int telefono = int.Parse(dgv_modificar.Rows[int.Parse(dgv_modificar.CurrentCell.RowIndex.ToString())].Cells[2].Value.ToString());
                    string correo = dgv_modificar.Rows[int.Parse(dgv_modificar.CurrentCell.RowIndex.ToString())].Cells[3].Value.ToString();
                    string fecha = dgv_modificar.Rows[int.Parse(dgv_modificar.CurrentCell.RowIndex.ToString())].Cells[4].Value.ToString();
                    string empresa = seleccionarEmpresa(dgv_modificar.Rows[int.Parse(dgv_modificar.CurrentCell.RowIndex.ToString())].Cells[5].Value.ToString());
                    modificar = 2;


                    dgv_proveedores.Rows.Add(nombre,telefono,correo, fecha,empresa);
                    cb_estadoProveedores.Visible = true;


                    tabControl1.SelectedIndex = 2;

                   



                }
                else if (cb_modificar.Text.ToString() == null)
                {
                    MessageBox.Show("Seleccione Empresa o Proveedor");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_modificar_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void txt_telefono_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txt_nombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
          

        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txt_saldoPendienteE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_rtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        public string seleccionarEmpresa(string rtn) {
            string empresa= rtn;
            try
            {
                MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader dr;
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText="SELECT empresa FROM tbl_empresa WHERE id_empresa='"+rtn+"'";
                dr=cmd.ExecuteReader();

                if (dr.Read())
                {
                    empresa = dr.GetString("empresa");
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

            return empresa;
        }

        private void cb_modificar_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }
    }
}
