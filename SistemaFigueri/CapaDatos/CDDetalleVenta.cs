using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    class CDDetalleVenta
    {
        private string _IdDetalleVenta;
        private string _IdTienda;
        private string _IdProducto;
        private string _Descripcion;
        private int _Cantidad;
        private decimal _Devolucion;
        private decimal _Malogrados;
        private decimal _Total;
        private decimal _Costo;
        private int _IdVenta;
        private decimal _Descuento;

        public decimal Costo { get => _Costo; set => _Costo = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public decimal Malogrados { get => _Malogrados; set => _Malogrados = value; }
        public decimal Devolucion { get => _Devolucion; set => _Devolucion = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string IdTienda { get => _IdTienda; set => _IdTienda = value; }
        public string IdDetalleVenta { get => _IdDetalleVenta; set => _IdDetalleVenta = value; }
        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }
        public decimal Descuento { get => _Descuento; set => _Descuento = value; }

        public CDDetalleVenta()
        {

        }


        public CDDetalleVenta(string idtienda, string idproducto,
            string descripcion, int cantidad, decimal devolucion, decimal malogrado, decimal total, decimal costo, string iddetalleventa, int idventa, decimal descuento)
        {
            this.IdTienda = idtienda;
            this.IdProducto = idproducto;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Devolucion = devolucion;
            this.Malogrados = malogrado;
            this.Total = total;
            this.Costo = costo;
            this.IdDetalleVenta = iddetalleventa;
            this.IdVenta = idventa;
            this.Descuento = descuento;
        }
        public string InsertarDetalleVenta(CDDetalleVenta DetalleVenta,
            ref SqlConnection sqlCo, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCo;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "SP_InsertaDetalle_Venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIdDetalleVenta = new SqlParameter();
                ParIdDetalleVenta.ParameterName = "@IdDetalleVenta";
                ParIdDetalleVenta.SqlDbType = SqlDbType.NVarChar;
                ParIdDetalleVenta.Value = DetalleVenta.IdDetalleVenta;
                SqlCmd.Parameters.Add(ParIdDetalleVenta);

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@IdVenta";
                ParIdVenta.SqlDbType = SqlDbType.NVarChar;
                ParIdVenta.Value = DetalleVenta.IdVenta;
                SqlCmd.Parameters.Add(ParIdVenta);

                SqlParameter ParIdTienda = new SqlParameter();
                ParIdTienda.ParameterName = "@IdTienda";
                ParIdTienda.SqlDbType = SqlDbType.NVarChar;
                ParIdTienda.Value = DetalleVenta.IdTienda;
                SqlCmd.Parameters.Add(ParIdTienda);

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@IdProducto";
                ParIdProducto.SqlDbType = SqlDbType.NVarChar;
                ParIdProducto.Value = DetalleVenta.IdProducto;
                SqlCmd.Parameters.Add(ParIdProducto);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                ParDescripcion.Value = DetalleVenta.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Float;
                ParCantidad.Value = DetalleVenta.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParDevolucion = new SqlParameter();
                ParDevolucion.ParameterName = "@Devolucion";
                ParDevolucion.SqlDbType = SqlDbType.Float;
                ParDevolucion.Value = DetalleVenta.Devolucion;
                SqlCmd.Parameters.Add(ParDevolucion);

                SqlParameter ParMalogrados = new SqlParameter();
                ParMalogrados.ParameterName = "@Malogrados";
                ParMalogrados.SqlDbType = SqlDbType.Float;
                ParMalogrados.Value = DetalleVenta.Malogrados;
                SqlCmd.Parameters.Add(ParMalogrados);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@Total";
                ParTotal.SqlDbType = SqlDbType.Float;
                ParTotal.Value = DetalleVenta.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@Costo";
                ParCosto.SqlDbType = SqlDbType.Float;
                ParCosto.Value = DetalleVenta.Costo;
                SqlCmd.Parameters.Add(ParCosto);


                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@Descuento";
                ParDescuento.SqlDbType = SqlDbType.Float;
                ParDescuento.Value = DetalleVenta.Costo;
                SqlCmd.Parameters.Add(ParDescuento);

                // comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingresa";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

    }


}
