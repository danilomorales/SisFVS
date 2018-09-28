using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;

namespace CapaNegocio
{
    public class CNProductos
    {
        private static readonly CNProductos _intancia = new CNProductos();
        public static CNProductos Instancia
        {
            get { return CNProductos._intancia; }
        }
        private CDProductos pro = new CDProductos();

        //READALL PRODUCT
        public SqlDataAdapter MostarProductos()
        {
            return  pro.listarProductos();
        }

        //CREATE PRODUCT
        public void InsertProduct(string alias, string id_categoria, string id_medida, string descripcion, string tiempo, string stock,
            string stockMax, string stockMin, string valor_uni, string precio1, string precio2, string precioOferta, string nota,
            string stockIni)
        {
            Console.WriteLine( "Sera pues ..."+alias+" "+  id_categoria+" "+  id_medida + " " + descripcion + " " + stock + " " +
             stockMax + " " + stockMin + " " + valor_uni + " " + precio1 + " " + precio2 + " " + precioOferta + " " + nota + " " +
             stockIni );
            pro.InsertarProductos(alias,
                id_categoria, id_medida,
                descripcion, tiempo,Convert.ToInt32(stock),Convert.ToDouble(stockMax),Convert.ToInt32(stockMin),Convert.ToDouble(valor_uni),
                Convert.ToDouble(precio1),Convert.ToDouble(precio2),Convert.ToDouble(precioOferta),nota,Convert.ToDouble(stockIni));

        }

        //UPDATE PRODUCT
        public void UpdateProduct(string alias, string id_categoria, string id_medida, string descripcion, string tiempo, string stock,
            string stockMax, string stockMin, string valor_uni, string precio1, string precio2, string precioOferta, string nota,
            string stockIni, string idProducto)
        {
            try
            {
                Console.WriteLine("Editando producto ..." + alias + " " + id_categoria + " " + id_medida + " " + descripcion + " " + tiempo + " " + stock + " " +
             stockMax + " " + stockMin + " " + valor_uni + " " + precio1 + " " + precio2 + " " + precioOferta + " " + nota + " " +
             idProducto);
                pro.EditarProducto(alias, id_categoria, id_medida, descripcion,
                    tiempo, Convert.ToInt32(stock), Convert.ToDouble(stockMax),
                    Convert.ToInt32(stockMin), Convert.ToDouble(valor_uni),
                    Convert.ToDouble(precio1), Convert.ToDouble(precio2), 
                    Convert.ToDouble(precioOferta),
                    nota, Convert.ToDouble(stockIni),idProducto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("VIENE DEL CN" + ex);
            }
            
        }

        //DELETE PRODUCT
        public void DeleteProduct(String idProducto)
        {
            pro.EliminarProducto(idProducto);
        }

        //LIsta Productos 
        public SqlDataAdapter ListaProductosFiltro()
        {
            SqlDataAdapter producto;
            producto = pro.CargaProductosFiltro();
            return producto;
        }

        //Carga Productos según Cliente

        private CDProductos objDato = new CDProductos();
        public SqlDataAdapter buscarclienteProducto(String cliente, String producto)
        {
            return objDato.CargaProductoCliente(cliente, producto);
        }

        //lista Productos según Rbtn 
        public List<CEProducto> BuscarprodAvanzada(int tip_busq, String val_busqueda)
        {
            try
            {
                List<CEProducto> Lista = null;
                Lista = CDProductos.Instancia.BuscarProductoAvanzada(tip_busq, val_busqueda);
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        // losta productos en tabla From Buscar Cliente 
        public SqlDataAdapter CargaProdcuto()
        {
            SqlDataAdapter prodcuto;
            prodcuto = pro.CargaProductoLista();
            return prodcuto;
        }

        //ListaPRoductos paraventa
        public List<CEProducto> ListarProductoVenta()
        {
            try
            {
                List<CEProducto> Lista = null;
                Lista = CDProductos.Instancia.ListarProducto();
                if (Lista.Count == 0) throw new ApplicationException("Lista de productos vacia");
                else if (Lista == null) throw new ApplicationException("Se produjo un error ");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //bbusca produtos con Codigo de barra venta 
        public CEProducto BuscaProductoBarra(int id_pro, String Cod_barra)
        {
            try
            {
                CEProducto c = null;
                c = CDProductos.Instancia.BuscaProductoCB(id_pro, Cod_barra);
                if (c == null) throw new ApplicationException("No se encontro registro");
                return c;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //busca Producto por Descripcion
        public CEProducto BuscaProductoDescripcion(int id_pro, String des_pro)
        {
            try
            {
                CEProducto c = null;
                c = CDProductos.Instancia.BuscaProductoPorDescripcion(id_pro, des_pro);
                if (c == null) throw new ApplicationException("No se encontro registro");
                return c;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<String> filtroProductoDescripcion()
        {
            List<String> Lista = pro.filtroProductoDesc();
            if (Lista.Count <= 0) throw new ApplicationException("Lista de productos vacia");
            else if (Lista == null) throw new ApplicationException("Error al cargar lista de productos");
            return Lista;

        }


    }
}
