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
      
        //LISTAR PRODUCTOS
        public DataTable listarProductos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select p.IdProducto,p.Alias as Nombre,c.Descripcion as Categoria,m.Descripcion as Medida,p.DescripcionProducto as 'Descripcion del producto'," +
                "p.TiempoDuracion as Duración,p.Stock,p.StockMaximo as 'Stock Maximo', p.StockMinimo as 'Stock Minimo',p.Valor_Unitario as 'Valor Unitario',p.PrecioVenta1 as 'P. Venta 1'," +
                "p.PrecioVenta2 as 'P. Venta 2',p.PrecioOferta as 'Precio Oferta',p.Nota,p.Factor,p.Estado,p.Item,p.StockInicial as 'Stock Inicial', p.cta_vnt as 'Cta vnt',p.Vigente " +
                "from caja.PRODUCTO p, dbo.CATEGORIA c, dbo.MEDIDA m " +
                "where p.IdCategoria = c.IdCategoria  AND p.IdMedida = m.IdMedida";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarProductos(String alias, String id_categoria, String id_medida, String descripcion, int tiempo, double stock,
            double stockMax,int stockMin,double valor_uni, double precio1, double precio2, double precioOferta, String nota, double factor,
            String estado, int item, double stockIni, String cta_vnt,int vigente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into caja.PRODUCTO (Alias,IdCategoria,IdMedida,DescripcionProducto,TiempoDuracion,Stock,StockMaximo,StockMinimo,Valor_Unitario,PrecioVenta1,PrecioVenta2,PrecioOferta,Nota,Factor,Estado,Item,StockInicial,cta_vnt,Vigente) values('" + alias + "','" + id_categoria + "','" + id_medida + "','" + descripcion + "','" + tiempo + "','" + stock + "','" + stockMax + "','" + stockMin + "'," +
                "'" + valor_uni + "','" + precio1 + "','" + precio2 + "','" + precioOferta + "','" + nota + "','" + factor + "','" + estado + "','" + item + "','" + stockIni + "','" + cta_vnt + "','" + vigente + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}
