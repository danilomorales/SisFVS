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
        CDConexion objSql = new CDConexion();
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;

        string strError = "";

        public string deverror()
        {
            return strError;
        }

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

        public void InsertaNuevaVenta(CEVenta venta_entidad, String idComPago)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Caja.SP_NuevaVenta", conexion.Conexion);
                cmd.Parameters.AddWithValue("@ide_comp_pago", idComPago);
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
        public int Inserta_FEComprobanteVenta(CE_FE_Comprobante_Venta dObj_Venta)
        {

            SqlConnection pCnx = new SqlConnection();

            int dRpta = 0;

            pCnx = objSql.AbrirConexion();
            SqlTransaction objTrans = objSql.begintrans(pCnx);

            try
            {

                SqlCommand Cmd = new SqlCommand("[Caja].[SP_FEComprobanteVentaInsertaVenta_INS]", pCnx);
                SqlParameter dPar = new SqlParameter();
                Cmd.Parameters.Clear();

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Transaction = objTrans;


                dPar = Cmd.Parameters.Add("@vIde_Cliente", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Cliente;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Comp_Pago", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Comp_Pago;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vNum_Serie_Venta", SqlDbType.NVarChar);
                dPar.Value = dObj_Venta.Num_Serie_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vNum_Doc_Venta", SqlDbType.NVarChar);
                dPar.Value = dObj_Venta.Num_Doc_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vFec_Emite_Venta", SqlDbType.Date);
                dPar.Value = dObj_Venta.Fec_Emite_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vNum_Ruc_Venta", SqlDbType.NVarChar);
                dPar.Value = dObj_Venta.Num_Ruc_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Empresa_Fact", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Empresa_Fact;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vDes_Nombre_Venta", SqlDbType.NVarChar);
                dPar.Value = dObj_Venta.Des_Nombre_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vDes_Direc_Venta", SqlDbType.NVarChar);
                dPar.Value = dObj_Venta.des_Direc_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Tipo_Venta", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Tipo_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vCan_Dias_Pago_Venta", SqlDbType.Int);
                dPar.Value = dObj_Venta.Can_Dias_Pago_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vFec_Vmto_Venta", SqlDbType.Date);
                dPar.Value = dObj_Venta.Fec_Vmto_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Motivo_NotCred", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Motivo_Notcred;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vRef_Num_Serie_Venta", SqlDbType.NVarChar);
                dPar.Value = dObj_Venta.Ref_Num_Serie_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vRef_Num_Doc_Venta", SqlDbType.NVarChar);
                dPar.Value = dObj_Venta.Ref_Num_Doc_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Tipo_Cambio_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Tipo_Cambio_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Moneda", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_moneda;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Valor_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Valor_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Depo_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Depo_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Total_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Total_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vPor_Impto_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Por_Impto_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Impto_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Impto_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Precio_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Precio_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Val_Inaf_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Val_Inaf_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Depo_Inaf_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Depo_Inaf_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Precio_Inaf_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Precio_Inaf_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Precio_Total_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Precio_Total_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Paga_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Paga_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Saldo_Venta", SqlDbType.Decimal);
                dPar.Value = dObj_Venta.Imp_Saldo_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Punto_Venta", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Punto_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Area", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Area;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Estado_Venta", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Estado_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Usuario", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Usuario;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vFec_Factu_Comp_Venta", SqlDbType.Date);
                dPar.Value = dObj_Venta.Fec_Factu_Comp_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Motivo_Anula_Venta", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Motivo_Anula_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vDes_Obs_Motivo_Anula", SqlDbType.NVarChar);
                dPar.Value = dObj_Venta.Des_Obs_Motivo_Anula;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Sucursal", SqlDbType.Int);
                dPar.Value = dObj_Venta.Ide_Sucursal;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@valor", SqlDbType.Int);
                dPar.Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                dRpta = int.Parse(Cmd.Parameters["@valor"].Value.ToString());

                if (dRpta > 0)
                {
                    objSql.committrans(objTrans);
                    Cmd.Dispose();
                }
                else
                {
                    objSql.rollbacktrans(objTrans);
                    strError = "Error";
                    Cmd.Dispose();
                }
            }
            catch (SqlException ExSql)
            {
                strError = ExSql.Message;
                objSql.rollbacktrans(objTrans);
            }

            catch (Exception Ex)
            {
                strError = Ex.Message;
                objSql.rollbacktrans(objTrans);
            }
            finally
            {

                pCnx.Close();
            }
            return dRpta;
        }
        public int Inserta_FEComprobanteVentaDetalle(CE_FE_Comprobante_Vta_Det dObj_VentaDet)
        {

            SqlConnection pCnx = new SqlConnection();

            int dRpta = 0;

            pCnx = objSql.AbrirConexion();
            SqlTransaction objTrans = objSql.begintrans(pCnx);

            try
            {

                SqlCommand Cmd = new SqlCommand("[Caja].[SP_FEComprobanteVtaDetInsertaVentaDet_INS]", pCnx);
                SqlParameter dPar = new SqlParameter();
                Cmd.Parameters.Clear();

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Transaction = objTrans;


                dPar = Cmd.Parameters.Add("@vIde_Venta", SqlDbType.Int);
                dPar.Value = dObj_VentaDet.Ide_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vNum_Item_Vta_Det", SqlDbType.Int);
                dPar.Value = dObj_VentaDet.Num_Item_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Producto", SqlDbType.NVarChar);
                dPar.Value = dObj_VentaDet.Ide_Producto;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vDes_Concepto_Vta_Det", SqlDbType.NVarChar);
                dPar.Value = dObj_VentaDet.Des_Concepto_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Unit_Vta_Det", SqlDbType.Decimal);
                dPar.Value = dObj_VentaDet.Imp_Unit_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vCan_Unit_Vta_Det", SqlDbType.Decimal);
                dPar.Value = dObj_VentaDet.Can_Unit_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Costo_Vta_Det", SqlDbType.Decimal);
                dPar.Value = dObj_VentaDet.Imp_Costo_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vPor_Dscto_Vta_Det", SqlDbType.Decimal);
                dPar.Value = dObj_VentaDet.Por_Dscto_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Dscto_Vta_Det", SqlDbType.Decimal);
                dPar.Value = dObj_VentaDet.Imp_Dscto_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Valor_Vta_Det", SqlDbType.Decimal);
                dPar.Value = dObj_VentaDet.Imp_Valor_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vFlg_Inaf_Vta_Det", SqlDbType.Int);
                dPar.Value = dObj_VentaDet.Flg_Inaf_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vPor_Impto_Vta_Det", SqlDbType.Decimal);
                dPar.Value = dObj_VentaDet.Por_Impto_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Impto_Vta_Det", SqlDbType.Decimal);
                dPar.Value = dObj_VentaDet.Imp_Impto_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Precio_Vta_Det", SqlDbType.Decimal);
                dPar.Value = dObj_VentaDet.Imp_Precio_Vta_Det;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@valorDet", SqlDbType.Int);
                dPar.Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                dRpta = int.Parse(Cmd.Parameters["@valorDet"].Value.ToString());

                if (dRpta > 0)
                {
                    objSql.committrans(objTrans);
                    Cmd.Dispose();
                }
                else
                {
                    objSql.rollbacktrans(objTrans);
                    strError = "Error";
                    Cmd.Dispose();
                }
            }
            catch (SqlException ExSql)
            {
                strError = ExSql.Message;
                objSql.rollbacktrans(objTrans);
            }

            catch (Exception Ex)
            {
                strError = Ex.Message;
                objSql.rollbacktrans(objTrans);
            }
            finally
            {

                pCnx.Close();
            }
            return dRpta;
        }
        public int Inserta_FEComprobanteVentaPago(CE_FE_Comprobante_VentaPago dObj_VentaPago)
        {

            SqlConnection pCnx = new SqlConnection();
            int dRpta = 0;
            pCnx = objSql.AbrirConexion();
            SqlTransaction objTrans = objSql.begintrans(pCnx);

            try
            {

                SqlCommand Cmd = new SqlCommand("[Caja].[SP_FEComprobanteVentaPagoInsertaVentaPago_INS]", pCnx);
                SqlParameter dPar = new SqlParameter();
                Cmd.Parameters.Clear();

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Transaction = objTrans;


                dPar = Cmd.Parameters.Add("@vIde_Venta", SqlDbType.Int);
                dPar.Value = dObj_VentaPago.Ide_Venta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vNum_Item_Venta_Pago", SqlDbType.Int);
                dPar.Value = dObj_VentaPago.Num_Item_Venta_Pago;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Forma_Pago", SqlDbType.Int);
                dPar.Value = dObj_VentaPago.Ide_Forma_Pago;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Tarjeta_Banco", SqlDbType.Int);
                dPar.Value = dObj_VentaPago.Ide_Tarjeta_Banco;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Banco", SqlDbType.Int);
                dPar.Value = dObj_VentaPago.Ide_Banco;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Banco_Cuenta", SqlDbType.Int);
                dPar.Value = dObj_VentaPago.Ide_Banco_Cuenta;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vFecha_Doc_Pago", SqlDbType.Date);
                dPar.Value = dObj_VentaPago.Fecha_Doc_Pago;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vNum_Doc_Pago", SqlDbType.NVarChar);
                dPar.Value = dObj_VentaPago.Num_Doc_Pago;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Moneda", SqlDbType.Int);
                dPar.Value = dObj_VentaPago.Ide_Moneda;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vImp_Pago", SqlDbType.Decimal);
                dPar.Value = dObj_VentaPago.Imp_Pago;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@vIde_Usuario", SqlDbType.Int);
                dPar.Value = dObj_VentaPago.Ide_Usuario;
                dPar.Direction = ParameterDirection.Input;

                dPar = Cmd.Parameters.Add("@valor", SqlDbType.Int);
                dPar.Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                dRpta = int.Parse(Cmd.Parameters["@valor"].Value.ToString());

                if (dRpta > 0)
                {
                    objSql.committrans(objTrans);
                    Cmd.Dispose();
                }
                else
                {
                    objSql.rollbacktrans(objTrans);
                    strError = "Error";
                    Cmd.Dispose();
                }
            }
            catch (SqlException ExSql)
            {
                strError = ExSql.Message;
                objSql.rollbacktrans(objTrans);
            }

            catch (Exception Ex)
            {
                strError = Ex.Message;
                objSql.rollbacktrans(objTrans);
            }
            finally
            {

                pCnx.Close();
            }
            return dRpta;
        }


    }
}
