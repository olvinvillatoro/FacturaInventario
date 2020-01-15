using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Facturacion
{
    public class bdComun
    {
        MySqlDataReader dr;
        DataTable dt;
        MySqlDataAdapter da;
        MySqlConnection conectar;
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("Server=127.0.0.1; Database=db_proyectoFacturacion; Uid=root; pwd=;");
            conectar.Open();
            return conectar;

        }

        // llena la datagridview de la base de datos


        public void cargarCliente(DataGridView dgv){
    try{
        da = new MySqlDataAdapter("Select *from tblCliente", conectar);
        dt = new DataTable();
        da.Fill(dt);
        dgv.DataSource = dt;
        }
    catch( Exception ex)
    {
        MessageBox.Show("No Se pudieron Mostrar los datos"+ex.ToString());
    }

        }


       

    }
}