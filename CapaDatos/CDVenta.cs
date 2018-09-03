using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class CDVenta
    {
        private static readonly CDVenta _intancia = new CDVenta();
        public static CDVenta Instancia
        {
            get { return CDVenta._intancia; }
        }

        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;

        public DataTable CargaFormaPago()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Caja.TIPO_PAGO";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }
        public DataTable CargaMoneda()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Caja.Moneda";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;

        }

        public void InsertaNuevaVenta(CEVenta venta_entidad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Caja.SP_NuevaVenta", conexion.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ide_cliente", SqlDbType.Int).Value = venta_entidad._ide_cliente;
                cmd.Parameters.Add("@ide_comp_pago", SqlDbType.Int).Value = venta_entidad._cant_dias_pago;
                //cmd.Parameters.Add("@ide_comp_pago", SqlDbType.DateTime).Value = venta_entidad._fecha_vmto;
                cmd.Parameters.Add("@lastide_motivo_notcred", SqlDbType.Int).Value = venta_entidad._motivo_nc;
                cmd.Parameters.Add("@ref_num_serie_venta", SqlDbType.NVarChar, 5).Value = venta_entidad.Ref_nserie_nc;
                cmd.Parameters.Add("@ref_num_doc_venta", SqlDbType.Decimal).Value = venta_entidad.Ref_ndoc_nc;
                cmd.Parameters.Add("@ide_moneda", SqlDbType.Int).Value = venta_entidad.Idmoneda;
                cmd.Parameters.Add("@imp_valor_venta", SqlDbType.Decimal).Value = venta_entidad.Valor_venta;
                cmd.Parameters.Add("@imp_depo_venta", SqlDbType.Decimal).Value = venta_entidad.Deposito_venta;
                cmd.Parameters.Add("@imp_valor_venta", SqlDbType.Decimal).Value = venta_entidad.Importe_venta;
                cmd.Parameters.Add("@por_impto_venta", SqlDbType.Decimal).Value = venta_entidad.Porc_igv;
                cmd.Parameters.Add("@imp_precio_total_venta", SqlDbType.Decimal).Value = venta_entidad.Igv_tota;

                //pago de cliente
                cmd.Parameters.Add("@imp_paga_venta", SqlDbType.Decimal).Value = venta_entidad.Impuesto_pago;
                //saldo que queda
                cmd.Parameters.Add("@imp_saldo_venta", SqlDbType.Decimal).Value = venta_entidad.Importe_saldo;
                cmd.Parameters.Add("@ide_punto_venta", SqlDbType.Int).Value = venta_entidad.Id_punto_venta;
                cmd.Parameters.Add("@ide_area", SqlDbType.Int).Value = venta_entidad.Idarea;
                //estado comprobate 
                cmd.Parameters.Add("@ide_estado_venta", SqlDbType.Int).Value = venta_entidad.Id_est_venta;
                cmd.Parameters.Add("@ide_usuario", SqlDbType.Int).Value = venta_entidad.Idusuario;
                cmd.Parameters.Add("@des_obs_motivo_anula", SqlDbType.DateTime).Value = venta_entidad.Motivo_anulacion;
                cmd.Parameters.Add("@ide_sucursal", SqlDbType.DateTime).Value = venta_entidad.Idsucursal;
            }
            catch(Exception ex)
            {
                string error = "Esto Paso" + ex;
            }
        }

        public List<CEVenta> ListarVenta(String fechadesde, String fechahasta, int idSucursal)
        {
            SqlCommand cmd = null;
            List<CEVenta> Lista = null;
            SqlDataReader dr = null;
            try
            {
                
            //    cmd = new SqlCommand("spListaVenta", conexion.Conexion);
            //    cmd.Parameters.AddWithValue("@prmfinicio", fechadesde);
            //    cmd.Parameters.AddWithValue("@prmfin", fechahasta);
            //    cmd.Parameters.AddWithValue("@prmidsucursal", idSucursal);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cn.Open();
            //    dr = cmd.ExecuteReader();
            //    Lista = new List<entVenta>();
            //    while (dr.Read())
            //    {
            //        entVenta v = new entVenta();
            //        v.Id_Venta = Convert.ToInt32(dr["Id_Venta"]);
            //        v.Codigo_Venta = dr["Codigo_Venta"].ToString();
            //        v.Estado_Venta = dr["Estado_Venta"].ToString();
            //        v.Correlativo_Venta = dr["Correlativo_Venta"].ToString();
            //        v.FechaVenta = Convert.ToDateTime(dr["FechaVenta"]);
            //        v.Igv_Venta = Convert.ToInt32(dr["Igv_Venta"]);
            //        v.Total = Convert.ToDouble(dr["Total"].ToString());
                    

            //        entTipComprobante tc = new entTipComprobante();
            //        tc.Id_TipCom = Convert.ToInt32(dr["Id_TipCom"]);
            //        tc.Nombre_TipCom = dr["Nombre_TipCom"].ToString();
            //        v.tipocomprobante = tc;

            //        entTipoPago tp = new entTipoPago();
            //        tp.Id_TipPago = Convert.ToInt32(dr["Id_TipPago"]);
            //        v.tipopago = tp;
            //        Lista.Add(v);
            //    }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }


    }
}
