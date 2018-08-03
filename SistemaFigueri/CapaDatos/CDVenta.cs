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

        //
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
        public string DisminuyeStock(int idproducto, int cantidad)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                
                sqlCon = conexion.AbrirConexion();
                sqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "SP_DisminuyeStock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@IdProducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = idproducto;
                SqlCmd.Parameters.Add(ParIdProducto);

                SqlParameter Parcantidad = new SqlParameter();
                Parcantidad.ParameterName = "@Cantidad";
                Parcantidad.SqlDbType = SqlDbType.Int;
                Parcantidad.Value = cantidad;
                SqlCmd.Parameters.Add(Parcantidad);



                // comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No Se actualizó estock";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string Insertar(CDVenta Venta, List<CDDetalleVenta> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon = conexion.AbrirConexion();
                SqlCon.Open();
                //trns 
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "SP_InsertaVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Par
                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@IdVenta";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdventa);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@IdCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Venta.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdPersona = new SqlParameter();
                ParIdPersona.ParameterName = "@IdPersona";
                ParIdPersona.SqlDbType = SqlDbType.Int;
                ParIdPersona.Value = Venta.IdPersona;
                SqlCmd.Parameters.Add(ParIdPersona);

                SqlParameter ParIdResponsable = new SqlParameter();
                ParIdResponsable.ParameterName = "@IdResponsable";
                ParIdResponsable.SqlDbType = SqlDbType.Int;
                ParIdResponsable.Value = Venta.IdResponsable;
                SqlCmd.Parameters.Add(ParIdResponsable);

                SqlParameter ParFechaVenta = new SqlParameter();
                ParFechaVenta.ParameterName = "@FechaVenta";
                ParFechaVenta.SqlDbType = SqlDbType.Date;
                ParFechaVenta.Value = Venta.FechaVenta;
                SqlCmd.Parameters.Add(ParFechaVenta);

                SqlParameter ParIdTipoDoc = new SqlParameter();
                ParIdTipoDoc.ParameterName = "@IdTipoDoc";
                ParIdTipoDoc.SqlDbType = SqlDbType.Int;
                ParIdTipoDoc.Size = 20;
                ParIdTipoDoc.Value = Venta.IdTipoDoc;
                SqlCmd.Parameters.Add(ParIdTipoDoc);

                SqlParameter ParIdTipoPago = new SqlParameter();
                ParIdTipoPago.ParameterName = "@IdTipoPago";
                ParIdTipoPago.SqlDbType = SqlDbType.Int;
                ParIdTipoPago.Size = 20;
                ParIdTipoPago.Value = Venta.IdTipoPago;
                SqlCmd.Parameters.Add(ParIdTipoPago);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@Serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 20;
                ParSerie.Value = Venta.Serie;
                SqlCmd.Parameters.Add(ParSerie);

                SqlParameter ParNota = new SqlParameter();
                ParNota.ParameterName = "@Nota";
                ParNota.SqlDbType = SqlDbType.VarChar;
                ParNota.Size = 1000;
                ParNota.Value = Venta.Nota;
                SqlCmd.Parameters.Add(ParNota);

                SqlParameter ParIgv = new SqlParameter();
                ParIgv.ParameterName = "@IGV";
                ParIgv.SqlDbType = SqlDbType.Decimal;
                ParIgv.Precision = 4;
                ParIgv.Scale = 2;
                ParIgv.Value = Venta.IGV;
                SqlCmd.Parameters.Add(ParIgv);


                //comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    //cod ingreso

                    this.IdVenta = Convert.ToInt32(SqlCmd.Parameters["@IdVenta"].Value);
                    foreach (CDDetalleVenta det in Detalle)
                    {
                        //codigo del ingreso que se autogenero
                        det.IdVenta = this.IdVenta;

                        rpta = det.InsertarDetalleVenta(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            //sale de for si hay error
                            break;
                        }
                        else
                        {
                            //Actualiza stock 

                            //rpta = DisminuyeStock(det.Cantidad);
                            //if (!rpta.Equals("OK"))
                            //{
                            //    break;
                            //}
                        }
                    }
                }
                if (rpta.Equals("OK"))
                {
                    //inserta detalles 
                    SqlTra.Commit();
                }
                else
                {
                    //algo paso con detalles 
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        public string Eliminar(CDVenta Venta)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon = conexion.AbrirConexion();
                SqlCon.Open();

                //Esaa
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPEliminarVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@IdVenta";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = Venta.IdVenta;
                SqlCmd.Parameters.Add(ParIdventa);
                //execute

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        //Disminuir Stock
        public string DisminuirStock(int iddetalle_ingreso, int cantidad)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon = conexion.AbrirConexion();
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_DisminuyeStock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@IdProducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = iddetalle_ingreso;
                SqlCmd.Parameters.Add(ParIdProducto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Se actualizó el Stock";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.AbrirConexion();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarVentas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método Busca por fecha 
        public DataTable BuscarFechas(String TextoBuscar, String TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.AbrirConexion();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarVenta_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@txtbusca";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@txtbusca2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Método Busca por fechas DetVenta 
        public DataTable MostrarDetalle(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.AbrirConexion();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MuestraDetalleVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@txtbusca";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable BuscarProductoporNombre(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("dtProducto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.AbrirConexion();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscaProducto_Nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@txtbusca";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable BuscaProductoPorcodigo(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("dtProducto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.AbrirConexion();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscaProducto_Codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@txtbusca";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

    }
}
