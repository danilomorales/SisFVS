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
            String sql = "select pedido.IdPedidoProducto,cli.IdCliente,cli.NombreEmpresa,concat(cli.Nombres,' ',cli.ApellidoPaterno,' ',cli.ApellidoMaterno) as cliente, " +
                "cli.RUC, tidoc.Descripcion,cli.NroDocumento, ti.NombreTienda,concat(res.Nombres,' ',res.Apellidos) as Responsable,pedido.FechaPedido,pedido.Valor,pedido.IGV,pedido.MontoTotal," +
                "pedido.Descuento,pedido.TotalEnviado " +
                "from PEDIDO_PRODUCTO pedido " +
                "INNER JOIN  Caja.CLIENTE cli ON pedido.IdCliente = cli.IdCliente " +
                "INNER JOIN dbo.TIPO_DOC_IDENT tidoc ON cli.IdTipoDocIdent=tidoc.IdTipoDocIdent " +
                "INNER JOIN dbo.TIENDA ti ON pedido.IdTienda = ti.IdTienda " +
                "INNER JOIN dbo.RESPONSABLE res ON pedido.IdResponsable = res.IdResponsable " +
                "WHERE pedido.FechaPedido >= TRY_PARSE(@FechaPedido1 as datetime using 'es-ES') " +
                "and pedido.FechaPedido <= TRY_PARSE(@FechaPedido2 as datetime using 'es-ES') " +
                "and pedido.IdPedidoProducto NOT IN(select DISTINCT IdPedidoProducto from dbo.DETALLE_PEDIDO_PRODUCTO where Devolucion='0') " +
                "ORDER BY pedido.FechaPedido DESC ; ";
               
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

        public SqlDataAdapter buscarDetallePedido(String idPedido)  
        {
                String sql = "SELECT det.IdProducto,pro.DescripcionProducto,det.Precio,pro.Stock,det.Cantidad FROM dbo.DETALLE_PEDIDO_PRODUCTO det " +
                        ", dbo.PEDIDO_PRODUCTO ped, dbo.PRODUCTO pro " +
                        "WHERE ped.IdPedidoProducto = det.IdPedidoProducto " +
                        "AND det.IdProducto = pro.IdProducto " +
                        "AND ped.IdPedidoProducto = @IdPedido; ";
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    adapter = new SqlDataAdapter(sql, Conexion.AbrirConexion());
                    adapter.SelectCommand.Parameters.AddWithValue("@IdPedido", idPedido);
 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al buscar detalle: " + ex);
                }
                return adapter;
        }
    }
}
