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

        public String RegistrarDetalleVenta()
        {
            List<clParametro> lst = new List<clParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clParametro("@IdProducto", IdProducto));
                lst.Add(new clParametro("@IdVenta", IdVenta));
                lst.Add(new clParametro("@Cantidad", Cantidad));
                lst.Add(new clParametro("@Descuento", Cantidad));
                lst.Add(new clParametro("@PrecioUnitario", PrecioUnitario));
                lst.Add(new clParametro("@Igv", Igv));
                lst.Add(new clParametro("@SubTotal", SubTotal));
                lst.Add(new clParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                C.EjecutarSP("Caja.SP_RegistrarDetalleVenta", ref lst);
                Mensaje = lst[6].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }




    }
}
