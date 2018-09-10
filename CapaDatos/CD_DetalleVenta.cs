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
    public class CD_DetalleVenta
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;


        public void InsertaDetalleVenta(CEDetalleVenta detalle_ent)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Caja.SP_NuevaVenta", conexion.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ide_venta", SqlDbType.Int).Value = detalle_ent.Ide_venta;
                cmd.Parameters.Add("@num_item_vta_det", SqlDbType.Int).Value = detalle_ent.Num_item_vta_det;
                cmd.Parameters.Add("@ide_producto", SqlDbType.NVarChar,50).Value = detalle_ent.Ide_producto;
                cmd.Parameters.Add("@des_concepto_vta_det", SqlDbType.NVarChar,100).Value = detalle_ent.Des_concepto_vta_det;
                cmd.Parameters.Add("@imp_unit_vta_det", SqlDbType.Decimal).Value = detalle_ent.Imp_unit_vta_det;
                cmd.Parameters.Add("@can_unit_vta_det", SqlDbType.Decimal).Value = detalle_ent.Can_unit_vta_det;
                cmd.Parameters.Add("@imp_costo_vta_det", SqlDbType.Decimal).Value = detalle_ent.Imp_costo_vta_det;
                cmd.Parameters.Add("@por_dscto_vta_det", SqlDbType.Decimal).Value = detalle_ent.Por_dscto_vta_det;
                cmd.Parameters.Add("@imp_dscto_vta_det", SqlDbType.Decimal).Value = detalle_ent.Imp_dscto_vta_det;
                cmd.Parameters.Add("@imp_valor_vta_det", SqlDbType.Decimal).Value = detalle_ent.Imp_valor_vta_det;
                cmd.Parameters.Add("@flg_inaf_vta_det", SqlDbType.Int).Value = detalle_ent.Flg_inaf_vta_det;
                cmd.Parameters.Add("@imp_impto_vta_det", SqlDbType.Decimal).Value = detalle_ent.Por_impto_vta_det;
                cmd.Parameters.Add("@imp_precio_vta_det", SqlDbType.Decimal).Value = detalle_ent.Imp_precio_vta_det;
                
            }
            catch (Exception ex)
            {
                string error = "Esto Paso" + ex;
            }
    }

    }

}
