using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFigueri
{
    public class Venta
    {
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
        public int IdUser { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoPago { get; set; }
        public string Serie { get; set; }
        public string NroNroComprobante { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public int stock { get; set; }
        public String alias { get; set; }
        //Serie
        public int Id_Serie { get; set; }
        public String Numero_Serie { get; set; }

        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Descuento { get; set; }
        public decimal Igv { get; set; }
        public decimal SubTotal { get; set; }

        //Pago
        //1 - EFECTIVO
        public string FormaPago { get; set; }
        public decimal Monto { get; set; }
        public decimal Cobrado { get; set; }
        public int IdMoneda { get; set; }
        public string Moneda { get; set; }
        //2 - TARJETA
        public int idtarjeta { get; set; }
        public String tarjeta { get; set; }
        public int idtipotarjeta { get; set; }
        public int idmoneda { get; set; }
        public String moneda { get; set; }
        public String monto { get; set; }
        public String noperacion { get; set; }
        public String nreferencia { get; set; }
        public String nlote { get; set; }
        public String nterminal { get; set; }
        public String ntarjeta { get; set; }

        public Venta()
        {
            Cantidad = 0;
            Descripcion = "";
            PrecioVenta = 0;
            IdVenta = 0;
            IdProducto = 0;
            Igv = 18;
            SubTotal = 0;
            Descuento = "";

        }
        public Venta(int objIdVenta, int objCantidad, string objDescripcion, decimal objPVenta,
           int objIdProducto, decimal objIgv, decimal objSubTotal, string objDescuento)
        {
            IdVenta = objIdVenta;
            Cantidad = objCantidad;
            Descripcion = objDescripcion;
            PrecioVenta = objPVenta;
            IdProducto = objIdProducto;
            Igv = objIgv;
            SubTotal = objSubTotal;
            Descuento = objDescuento;
        }

    }

}
