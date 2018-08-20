using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDProductos
    {
         private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;

        //LISTAR PRODUCTOS
        public SqlDataAdapter listarProductos()
        {
            String sql = "select p.IdProducto,p.Alias as Nombre,c.Descripcion as Categoria,m.Descripcion as Medida," +
                "p.DescripcionProducto as 'Descripcion del producto',p.TiempoDuracion as Duración,p.Stock,p.StockMaximo as 'Stock Maximo'," +
                "p.StockMinimo as 'Stock Minimo',p.Valor_Unitario as 'Valor Unitario',p.PrecioVenta1 as 'P. Venta 1',p.PrecioVenta2 as 'P. Venta 2'," +
                "p.PrecioOferta as 'Precio Oferta',p.Nota,p.Factor,p.Estado,p.Item,p.StockInicial as 'Stock Inicial',p.cta_vnt as 'Cta vnt'," +
                "p.Vigente from caja.PRODUCTO p, dbo.CATEGORIA c, dbo.MEDIDA m where p.IdCategoria = c.IdCategoria AND p.IdMedida = m.IdMedida";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR PRODUCTO
        public void InsertarProductos(String alias, String id_categoria, String id_medida, String descripcion, double stock,
            double stockMax,int stockMin,double valor_uni, double precio1, double precio2, double precioOferta, String nota, double factor,
             int item, double stockIni, String cta_vnt)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into caja.PRODUCTO (Alias,IdCategoria,IdMedida,DescripcionProducto,Stock,StockMaximo,StockMinimo,Valor_Unitario,PrecioVenta1,PrecioVenta2,PrecioOferta,Nota,Factor,Estado,Item,StockInicial,cta_vnt,Vigente) " +
                "values('" + alias + "','" + id_categoria + "','" + id_medida + "','" + descripcion + "','" + stock + "','" + stockMax + "','" + stockMin + "'," +
                "'" + valor_uni + "','" + precio1 + "','" + precio2 + "','" + precioOferta + "','" + nota + "','" + factor + "','A','" + item + "','" + stockIni + "','" + cta_vnt + "',1)";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

      

        //EDITAR PRODUCTO
        public void EditarProducto(String idProducto,String alias, String id_categoria, String id_medida, String descripcion, String tiempo, double stock,
            double stockMax, int stockMin, double valor_uni, double precio1, double precio2, double precioOferta, String nota, double factor,
            String estado, int item, double stockIni, String cta_vnt)
        {
            Console.WriteLine("Tiempo" + tiempo);
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "update caja.PRODUCTO set Alias='" + alias + "',IdCategoria='" + id_categoria + "',IdMedida='" + id_medida + "',DescripcionProducto='" + descripcion + "',TiempoDuracion=" + tiempo + "," +
                    "Stock=" + stock + ",StockMaximo=" + stockMax + ",StockMinimo=" + stockMin + ",Valor_Unitario=" + valor_uni + ",PrecioVenta1=" + precio1 + ",PrecioVenta2=" + precio2 + ",PrecioOferta=" + precioOferta + "," +
                    "Nota='" + nota + "',Factor=" + factor + ",Estado='" + estado + "',Item=" + item + ",StockInicial=" + stockIni + "," +
                    "cta_vnt='" + cta_vnt + "' where IdProducto='" + idProducto + "'";
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch(SqlException ex)
            {

                Console.WriteLine("VIENE DEL CD" +  ex);
            }
            
        }

        //ELIMINAR PRODUCTO
        public void EliminarProducto(String idProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from caja.PRODUCTO where IdProducto='" + idProducto + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //Llenar ComboBox CATEGORIA
        public DataTable ListarCategoria()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from dbo.CATEGORIA";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        //Llenar ComboBox MEDIDA
        public DataTable ListarMedida()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from dbo.MEDIDA";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        //ListaProductos paraFiltrar Venta
        public SqlDataAdapter CargaProductosFiltro()
        {
            String sql = "SELECT top 100 Producto.IdProducto as Código, Producto.DescripcionProducto,Producto.Alias,Producto.Nota,Producto.TiempoDuracion,Producto.Stock, ROUND(Precio.ValorProducto, 2) AS Precio FROM Caja.PRODUCTO AS Producto INNER JOIN PRECIO AS Precio ON Producto.IdProducto = Precio.IdProducto INNER JOIN CLIENTE AS CLIENTE  ON Precio.IdSector = CLIENTE.IdSector INNER JOIN CATEGORIA AS CATEGORIA ON Producto.IdCategoria = CATEGORIA.IdCategoria WHERE(Producto.Estado = 'A')  AND(CATEGORIA.Tipo = 'P') order by Producto.IdProducto desc;";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;

        }

        public SqlDataAdapter CargaProductoCliente(String cliente, String producto)
        {

            String sql = "SELECT Producto.IdProducto, Producto.DescripcionProducto, ROUND(Precio.ValorProducto, 2) AS Precio FROM PRODUCTO AS Producto INNER JOIN PRECIO AS Precio ON Producto.IdProducto = Precio.IdProducto INNER JOIN CLIENTE AS CLIENTE ON Precio.IdSector = CLIENTE.IdSector INNER JOIN CATEGORIA AS CATEGORIA ON Producto.IdCategoria = CATEGORIA.IdCategoria WHERE(Producto.Estado = 'A') AND(Precio.IdPrecio = '01') AND(CATEGORIA.Tipo = 'P') AND(CATEGORIA.IdCategoria <> '0045') AND(CATEGORIA.IdCategoria <> '0036') AND(CATEGORIA.IdCategoria <> '0047') AND  (CLIENTE.IdCliente = '@IdCliente') AND(Producto.IdProducto = '@IdProducto')";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
                adapter.SelectCommand.Parameters.AddWithValue("@IdCliente", cliente);
                adapter.SelectCommand.Parameters.AddWithValue("@IdProducto", producto);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Listar"+ex);
            }
            return adapter;



            //adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            //return adapter;
            ////SqlCommand comando = new SqlCommand("", conexion.AbrirConexion());
            ////comando.CommandType = CommandType.StoredProcedure;
            ////leer = comando.ExecuteReader();
            //return leer();
        }
    }
}
