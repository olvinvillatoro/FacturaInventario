using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Facturacion
{

   
    public partial class Login : Form
    {
        MySqlConnection cn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Password =; Database = bd_flara; Port = 3306");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        Factura factura = new Factura();
       
        public int tipoUsuario;

        public Login()
        {
            
            InitializeComponent();
            txt_Usuario.Focus();
           

        }
//PROCEDIMIENTO PARA COMPROBAR SI EL USUARIO EXISTE EN LA DB
        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            if (txt_Usuario.Text != "" && txt_Pass.Text != "")
            {
                try
                {


                    cn.Open();
                    cmd.Connection = cn;
                    try
                    {
                        cmd.CommandText = "select count(*) from bd_flara.tbl_usuario where usuario = '" + txt_Usuario.Text.ToString() + "' and contraseña = '" + txt_Pass.Text.ToString() + "'";
                        int valor = int.Parse(cmd.ExecuteScalar().ToString());
                        if (valor > 0)
                        {




                            cmd.CommandText = "select * from bd_flara.tbl_usuario where usuario = '" + txt_Usuario.Text + "' and contraseña ='" + txt_Pass.Text + "'";

                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                if (dr.GetInt32("tipo_usuario") == 1)
                                {
                                    tipoUsuario = 1;
                                    Principal principal = new Principal();
                                    principal.ShowDialog();
                                    lbl_Usuario.Text = "";


                                }

                                else {
                                    factura.ShowDialog();
                                    tipoUsuario = 2;
                                    lbl_Usuario.Text = "";



                                }




                            }




                        }
                        else {
                            lbl_Usuario.BackColor = Color.Red;
                            lbl_Usuario.Text = "Usuario o Contraseña invalida";
                        }


                    }
                    catch (Exception ex)
                    {

                        txt_Usuario.Focus();
                    }
                    cn.Close();

                    txt_Usuario.Clear();
                    txt_Pass.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Debe Ingresar Un Usuario y Una Contraseña");
        }

        public void Cargar() {
          
            InitializeComponent();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n')

            {

                cn.Open();
                cmd.Connection = cn;
                try
                {
                    cmd.CommandText = "select count(*) from tbl_usuario where user = '" + txt_Usuario.Text.ToString() + "' and pass = '" + txt_Pass.Text.ToString() + "'";
                    int valor = int.Parse(cmd.ExecuteScalar().ToString());
                    if (valor > 0)
                    {
                        factura.Show();


                    }
                    else {
                        lbl_Usuario.BackColor = Color.Red;
                        lbl_Usuario.Text = "Usuario o Contraseña invalida";
                    }


                }
                catch (Exception ex)
                {

                    txt_Usuario.Focus();
                }
                cn.Close();
               

            }

        }

        private void txt_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btn_Entrar_Click(sender, e);
                
            }
        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_usuario2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
