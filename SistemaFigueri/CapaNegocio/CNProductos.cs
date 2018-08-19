using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProductos
    {
        private CDProductos pro = new CDProductos();
        

        //READALL PRODUCT
        public SqlDataAdapter MostarProductos()
        {
            return  pro.listarProductos();
        }

        //CREATE PRODUCT
        public void InsertProduct(String alias, String id_categoria, String id_medida, String descripcion, String stock,
            String stockMax, String stockMin, String valor_uni, String precio1, String precio2, String precioOferta, String nota, String factor,
           String item, String stockIni, String cta_vnt)
        {
            Console.WriteLine( "Sera pues ..."+alias+" "+  id_categoria+" "+  id_medida + " " + descripcion + " " + stock + " " +
             stockMax + " " + stockMin + " " + valor_uni + " " + precio1 + " " + precio2 + " " + precioOferta + " " + nota + " " + factor + " " +
            item + " " + stockIni + " " + cta_vnt );
            pro.InsertarProductos(alias,
                id_categoria, id_medida,
                descripcion, 
                Convert.ToDouble(stock), Convert.ToDouble(stockMax), 
                Convert.ToInt32(stockMin), Convert.ToDouble(valor_uni), 
                Convert.ToDouble(precio1), Convert.ToDouble(precio2), 
                Convert.ToDouble(precioOferta), nota, Convert.ToDouble(factor),
                Convert.ToInt32(item), Convert.ToDouble(stockIni), cta_vnt);

        }

        //UPDATE PRODUCT
        public void UpdateProduct(String idProducto,String alias, String id_categoria, String id_medida, String descripcion, String tiempo, String stock,
            String stockMax, String stockMin, String valor_uni, String precio1, String precio2, String precioOferta, String nota, String factor,
            String estado, String item, String stockIni, String cta_vnt)
        {
            Console.WriteLine("Sera pues ..." + alias + " " + id_categoria + " " + id_medida + " " + descripcion + " " + tiempo + " " + stock + " " +
             stockMax + " " + stockMin + " " + valor_uni + " " + precio1 + " " + precio2 + " " + precioOferta + " " + nota + " " + factor + " " +
             estado + " " + item + " " + stockIni + " " + cta_vnt + " " +idProducto);
            pro.EditarProducto(idProducto,alias,
              id_categoria, id_medida,
                descripcion, tiempo,
                Convert.ToDouble(stock), Convert.ToDouble(stockMax),
                Convert.ToInt32(stockMin), Convert.ToDouble(valor_uni),
                Convert.ToDouble(precio1), Convert.ToDouble(precio2),
                Convert.ToDouble(precioOferta), nota, Convert.ToDouble(factor), estado,
                Convert.ToInt32(item), Convert.ToDouble(stockIni), cta_vnt);
        }

        //DELETE PRODUCT
        public void DeleteProduct(String idProducto)
        {
            pro.EliminarProducto(idProducto);
        }

        //Carga Productos Filtro Venta 
        public SqlDataAdapter CargaProductoFiltro()
        {
            SqlDataAdapter producto;
            producto = pro.Cargaproductos();
            return producto;
        }

    }
}
