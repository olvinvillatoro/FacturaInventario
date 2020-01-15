using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
    class Producto
    {
        public string nombreProducto { set; get; }
        public int Codigo { set; get; }
        public int Cantidad { set; get; }
        public double PrecioCompra { set; get; }
        public double PrecioVenta { set; get; }
        public string Ubicacion { set; get; }
        public string Descripcion { set; get; }




        public Producto() { }

        public Producto(string nombreProducto, int Codigo, int Cantidad, double PrecioCompra, double PrecioVenta, string Ubicacion, string Descripcion) {
            this.nombreProducto = nombreProducto;
            this.Codigo = Codigo;
            this.Cantidad = Cantidad;
            this.PrecioCompra = PrecioCompra;
            this.PrecioVenta = PrecioVenta;
            this.Ubicacion = Ubicacion;
            this.Descripcion = Descripcion;
        
        }

    }
}