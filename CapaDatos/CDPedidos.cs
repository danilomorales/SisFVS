using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    
    public class CDPedidos
    {
        private SqlDataAdapter adapter;
        private CDConexion Conexion = new CDConexion();
        public SqlDataAdapter buscarPedido(String fecha1,String fecha2)
        {
            String sql = "Caja.SP_FE_TraerPedido";
               
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                adapter = new SqlDataAdapter(sql, Conexion.AbrirConexion());

                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@FechaPedido1", fecha1);
                adapter.SelectCommand.Parameters.AddWithValue("@FechaPedido2", fecha2);
                adapter.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar pedido: "+ex);
            }
            return adapter;
        }

        public SqlDataAdapter buscarDetallePedido(String idPedido)  
        {
                String sql = "[Caja].[SP_FE_TraerDetallePedido]";
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    adapter = new SqlDataAdapter(sql, Conexion.AbrirConexion());
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@vIdPedidoProducto", idPedido);
                adapter.SelectCommand.ExecuteNonQuery();

            }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al buscar detalle: " + ex);
                }
                return adapter;
        }
    }
}
