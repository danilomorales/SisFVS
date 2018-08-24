using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNDetalleVenta
    {
        CDConexion C = new CDConexion();
        public string IdProducto { get; set; }
        public Int32 IdVenta { get; set; }
        public Int32 Cantidad { get; set; }
        public string Descuento { get; set; }
        public Decimal PrecioUnitario { get; set; }
        public Decimal Igv { get; set; }
        public Decimal SubTotal { get; set; }

    }
}
