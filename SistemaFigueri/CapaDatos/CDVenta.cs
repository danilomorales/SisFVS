using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDVenta
    {

        private CDConexion conexion = new CDConexion();

        private int _IdVenta;
        private int _IdCliente;
        private int _IdUsuario;  
        private int _IdPersona;
        private int _IdResponsable;
        private int _IdTipoDoc;
        private int _IdTipoPago;
        private DateTime _FechaVenta;
        private string _Nota;
        private string _Serie;
        private float _IGV;

        public float IGV { get => _IGV; set => _IGV = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Nota { get => _Nota; set => _Nota = value; }
        public DateTime FechaVenta { get => _FechaVenta; set => _FechaVenta = value; }
        public int IdTipoPago { get => _IdTipoPago; set => _IdTipoPago = value; }
        public int IdTipoDoc { get => _IdTipoDoc; set => _IdTipoDoc = value; }
        public int IdResponsable { get => _IdResponsable; set => _IdResponsable = value; }
        public int IdPersona { get => _IdPersona; set => _IdPersona = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }

        public CDVenta() { }

        //cons
        public CDVenta(int idventa, int idcliente, int idusuario, int idpersona, int idresponsable, int tipodoc, int idtipopago, DateTime fechaventa, string notita, string serie, float igv)
        {
            this.IdVenta = idventa;
            this.IdCliente = idcliente;
            this.IdUsuario = idusuario;
            this.IdPersona = idpersona;
            this.IdResponsable = idresponsable;
            this.IdTipoDoc = tipodoc;
            this.IdTipoPago = idtipopago;
            this.FechaVenta = fechaventa;
            this.Nota = notita;
            this.Serie = serie;
            this.IGV = igv;

        }
        //
        public string DisminuyeStock(int idproducto,int cantidad)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = conexion.AbrirConexion();
                SqlCmd.Connection = sqlCon;
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
