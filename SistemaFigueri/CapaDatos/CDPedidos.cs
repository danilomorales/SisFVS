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
            String sql = "select cli.IdCliente,cli.NombreEmpresa, ti.NombreTienda,concat(res.Nombres,' ',res.Apellidos) as Responsable,pedido.FechaPedido,pedido.Valor,pedido.IGV,pedido.MontoTotal," +
                "pedido.Descuento,pedido.IdTipoDoc,pedido.TotalEnviado " +
                "from PEDIDO_PRODUCTO pedido " +
                "LEFT JOIN  Caja.CLIENTE cli ON pedido.IdCliente = cli.IdCliente " +
                "LEFT JOIN dbo.TIENDA ti ON pedido.IdTienda = ti.IdTienda " +
                "LEFT JOIN dbo.RESPONSABLE res ON pedido.IdResponsable = res.IdResponsable " +
                "WHERE pedido.FechaPedido >= TRY_PARSE(@FechaPedido1 as datetime using 'es-ES') " +
                "and pedido.FechaPedido <= TRY_PARSE(@FechaPedido2 as datetime using 'es-ES') ; ";
               
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
