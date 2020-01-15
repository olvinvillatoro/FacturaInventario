using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
   public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public string Direccion { get; set; }

        public string Telefono { get; set; }
        public Cliente() { }

        public Cliente(int pId, string pNombre, string pApellido,  string pDireccion, string pTelefono)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            
            this.Direccion = pDireccion;
            this.Telefono = pTelefono;
        }

    }
}
