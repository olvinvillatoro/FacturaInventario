using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Facturacion
{
    class ProductoDAL
    {
       
        public static int AgregarProducto(Producto pProducto)
        {

            int retorno = 0;
// Asegurar el nombre de la tabla tblProducto en la DB
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tblProducto (nombreProducto, codigo, cantidad, precioCompra, precioVenta, ubicacion, descripcion) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                pProducto.nombreProducto, pProducto.Codigo,pProducto.Cantidad, pProducto.PrecioCompra, pProducto.PrecioVenta,pProducto.Ubicacion, pProducto.Descripcion), bdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    
    
    
    
    
    }
}
