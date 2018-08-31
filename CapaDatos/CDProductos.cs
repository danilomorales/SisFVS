using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class CDProductos
    {
        private static readonly CDProductos _intancia = new CDProductos();
        public static CDProductos Instancia
        {
            get { return CDProductos._intancia; }
        }

        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;

        //LISTAR PRODUCTOS
        public SqlDataAdapter listarProductos()
        {
            String sql = "Caja.SP_FE_MostrarProducto";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR PRODUCTO
        public void InsertarProductos(string alias, string id_categoria, string id_medida, string descripcion, string tiempo,int stock,
            double stockMax,int stockMin,double valor_uni, double precio1, double precio2, double precioOferta, string nota,
            double stockIni)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_InsertarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@alias", alias);
            comando.Parameters.AddWithValue("@id_categoria", id_categoria);
            comando.Parameters.AddWithValue("@id_medida", id_medida);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@tiempo", tiempo);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@stockMax", stockMax);
            comando.Parameters.AddWithValue("@stockMin", stockMin);
            comando.Parameters.AddWithValue("@valor_uni", valor_uni);
            comando.Parameters.AddWithValue("@precio1", precio1);
            comando.Parameters.AddWithValue("@precio2", precio2);
            comando.Parameters.AddWithValue("@precioOferta", precioOferta);
            comando.Parameters.AddWithValue("@nota", nota);
            comando.Parameters.AddWithValue("@stockIni", stockIni);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }   

        //EDITAR PRODUCTO
        public void EditarProducto(string alias, string id_categoria, string id_medida, string descripcion, string tiempo, int stock,
            double stockMax, int stockMin, double valor_uni, double precio1, double precio2, double precioOferta, string nota,
            double stockIni,string idProducto)
        {
            Console.WriteLine("Tiempo" + tiempo);
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Caja.SP_FE_EditarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@alias", alias);
                comando.Parameters.AddWithValue("@id_categoria", id_categoria);
                comando.Parameters.AddWithValue("@id_medida", id_medida);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@tiempo", tiempo);
                comando.Parameters.AddWithValue("@stock", stock);
                comando.Parameters.AddWithValue("@stockMax", stockMax);
                comando.Parameters.AddWithValue("@stockMin", stockMin);
                comando.Parameters.AddWithValue("@valor_uni", valor_uni);
                comando.Parameters.AddWithValue("@precio1", precio1);
                comando.Parameters.AddWithValue("@precio2", precio2);
                comando.Parameters.AddWithValue("@precioOferta", precioOferta);
                comando.Parameters.AddWithValue("@nota", nota);
                comando.Parameters.AddWithValue("@stockIni", stockIni);
                comando.Parameters.AddWithValue("@idProducto", idProducto);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch(SqlException ex)
            {

                Console.WriteLine("VIENE DEL CD" +  ex);
            }
            
        }

        //ELIMINAR PRODUCTO
        public void EliminarProducto(string idProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
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

        }


        //Carga Productos según Rbtn 
        public List<CEProducto> BuscarProductoAvanzada(int tip_entrada, String valor_entrada)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<CEProducto> Lista = null;
            try
            {
                SqlConnection cn = CDConexion.Instancia.CerrarConexion();
                cmd = new SqlCommand("Caja.SP_BuscaProdAvanzado", cn);
                cmd.Parameters.AddWithValue("@prmTipEntrada", tip_entrada);
                cmd.Parameters.AddWithValue("@prmValorEntrada", valor_entrada);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<CEProducto>();
                while (dr.Read())
                {
                    CEProducto p = new CEProducto();
                    p._Codigo = dr["Código"].ToString();
                    p._Alias = dr["Alias"].ToString();
                    p._DescripcionProducto = dr["DescripcionProducto"].ToString();
                    p._TiempoDuracion = dr["TiempoDuracion"].ToString();
                    p._Stock = dr["Stock"].ToString();
                    p._precio = Convert.ToDouble(dr["Precio"].ToString());
                    Lista.Add(p);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public List<CEProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<CEProducto> Lista = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = CDConexion.Instancia.CerrarConexion();
                cmd = new SqlCommand("Caja.SP_ListaProductos_Venta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<CEProducto>();
                while (dr.Read())
                {
                    
                    CEProducto p = new CEProducto();
                    p._Codigo = dr["Código"].ToString();
                    p._Alias = dr["Alias"].ToString();
                    p._DescripcionProducto = dr["DescripcionProducto"].ToString();
                    p._TiempoDuracion =dr["TiempoDuracion"].ToString();
                    p._Stock = dr["Stock"].ToString();
                    p._precio = Convert.ToDouble(dr["Precio"].ToString());
                    Lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        //Busca Productos por código de barra
        public CEProducto BuscaProductoCB(int id_pro, String Cod_barra)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            CEProducto p = null;
            try
            {
                SqlConnection cn = CDConexion.Instancia.CerrarConexion();
                cmd = new SqlCommand("Caja.SP_FE_BuscaProductoCB", cn);
                cmd.Parameters.AddWithValue("@prmidProducto", id_pro);
                cmd.Parameters.AddWithValue("@prmCodBarra", Cod_barra);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p = new CEProducto();
                    p._Codigo = dr["Código"].ToString();
                    p._Alias = dr["Alias"].ToString();
                    p._DescripcionProducto = dr["DescripcionProducto"].ToString();
                    p._TiempoDuracion = dr["TiempoDuracion"].ToString();
                    p._Stock = dr["Stock"].ToString();
                    p._precio = Convert.ToDouble(dr["Precio"].ToString());

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return p;
        }
    }
}
