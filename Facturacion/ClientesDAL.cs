using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Facturacion
{
    public class ClientesDAL
    {
        public static int AgregarCliente(Cliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tblCliente (nombreCliente, direccionCliente, telefonoCliente) values ('{0}','{1}','{2}')",
                pCliente.Nombre, pCliente.Direccion, pCliente.Telefono), bdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<Cliente> BuscarCliente(string pNombre, string pApellido)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT idCliente, nombreCliente, direccionCliente FROM clientes  where Nombre ='{0}' or Apellido='{1}'", pNombre, pApellido), bdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Apellido = _reader.GetString(2);
                
                pCliente.Direccion = _reader.GetString(4);


                _lista.Add(pCliente);
            }

            return _lista;
        }

    }
}
