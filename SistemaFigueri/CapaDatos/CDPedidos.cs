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
            String sql = "select IdCliente,IdTienda,FechaPedido,Valor,IGV,MontoTotal,Descuento,Estado,IdTipoDoc,TotalEnviado from PEDIDO_PRODUCTO WHERE FechaPedido >= TRY_PARSE (@FechaPedido1 as datetime using 'es-ES')and FechaPedido <=TRY_PARSE (@FechaPedido2 as datetime using 'es-ES');";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                adapter = new SqlDataAdapter(sql, Conexion.AbrirConexion());
                adapter.SelectCommand.Parameters.AddWithValue("@FechaPedido1", fecha1);
                adapter.SelectCommand.Parameters.AddWithValue("@FechaPedido2", fecha2);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar producto: "+ex);
            }
            return adapter;
        }
    }
}
