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
        CNProductos cnProd = new CNProductos();

        //READALL PRODUCT
        public DataTable MostarProductos()
        {
            DataTable table = new DataTable();
            table = pro.listarProductos();
            return table;
        }

        //INSERT PRODUCT
        public void InsertProduct(String alias, String id_categoria, String id_medida, String descripcion, String tiempo, String stock,
            String stockMax, String stockMin, String valor_uni, String precio1, String precio2, String precioOferta, String nota, String factor,
            String estado, String item, String stockIni, String cta_vnt, String vigente)
        {
            Console.WriteLine( "Sera pues ..."+alias+" "+  id_categoria+" "+  id_medida + " " + descripcion + " " + tiempo + " " + stock + " " +
             stockMax + " " + stockMin + " " + valor_uni + " " + precio1 + " " + precio2 + " " + precioOferta + " " + nota + " " + factor + " " +
             estado + " " + item + " " + stockIni + " " + cta_vnt + " " + vigente);
            pro.InsertarProductos(alias,
                id_categoria, id_medida,
                descripcion, Convert.ToInt32(tiempo), 
                Convert.ToDouble(stock), Convert.ToDouble(stockMax), 
                Convert.ToInt32(stockMin), Convert.ToDouble(valor_uni), 
                Convert.ToDouble(precio1), Convert.ToDouble(precio2), 
                Convert.ToDouble(precioOferta), nota, Convert.ToDouble(factor), estado,
                Convert.ToInt32(item), Convert.ToDouble(stockIni), cta_vnt, 
                Convert.ToInt32(vigente));

        }

        //UPDATE PRODUC
        public void UpdateProduct(String idProducto,String alias, String id_categoria, String id_medida, String descripcion, String tiempo, String stock,
            String stockMax, String stockMin, String valor_uni, String precio1, String precio2, String precioOferta, String nota, String factor,
            String estado, String item, String stockIni, String cta_vnt, String vigente)
        {
            Console.WriteLine("Sera pues ..." + alias + " " + id_categoria + " " + id_medida + " " + descripcion + " " + tiempo + " " + stock + " " +
             stockMax + " " + stockMin + " " + valor_uni + " " + precio1 + " " + precio2 + " " + precioOferta + " " + nota + " " + factor + " " +
             estado + " " + item + " " + stockIni + " " + cta_vnt + " " + vigente +"   "+idProducto);
            pro.EditarProducto(idProducto,alias,
              id_categoria, id_medida,
                descripcion,Convert.ToInt32(tiempo),
                Convert.ToDouble(stock), Convert.ToDouble(stockMax),
                Convert.ToInt32(stockMin), Convert.ToDouble(valor_uni),
                Convert.ToDouble(precio1), Convert.ToDouble(precio2),
                Convert.ToDouble(precioOferta), nota, Convert.ToDouble(factor), estado,
                Convert.ToInt32(item), Convert.ToDouble(stockIni), cta_vnt,
                Convert.ToInt32(vigente));
        }

        //DELETE PRODUCT
        public void DeleteProduct(String idProducto)
        {
            pro.EliminarProducto(idProducto);
        }

    }
}
