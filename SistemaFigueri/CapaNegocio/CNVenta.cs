using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNVenta
    {
            //llama insertar de la CapaDatos
            public static string Insertar(int idventa, int idcliente, int idusuario, int idpersona, 
                int idresponsable, int tipodoc, int idtipopago, DateTime fechaventa, string notita, 
                string serie, float igv, DataTable dtDetalle)
            {
                CDVenta Obj = new CDVenta();
                Obj.IdVenta = idventa;
                Obj.IdCliente = idcliente;
                Obj.IdUsuario = idusuario;
                Obj.IdPersona = idpersona;
                Obj.IdResponsable = idresponsable;
                Obj.IdTipoDoc = tipodoc;
                Obj.IdTipoPago = idtipopago;
                Obj.FechaVenta = fechaventa;
                Obj.Nota = notita;
                Obj.Serie = serie;
                Obj.IGV = igv;
                List <CDDetalleVenta> detalles = new List<CDDetalleVenta>();
                foreach (DataRow row in dtDetalle.Rows)
                {
                    CDDetalleVenta detalle = new CDDetalleVenta();
                    //detalle.IdProducto = Convert.ToInt32(row["IdProducto"].ToString());
                    detalle.Cantidad = Convert.ToInt32(row["Cantidad"].ToString());
                    detalle.Costo = Convert.ToDecimal(row["PrecioVenta1"].ToString());
                    detalle.Descuento = Convert.ToDecimal(row["Descuento"].ToString());
                    detalles.Add(detalle);

                }

                return Obj.Insertar(Obj, detalles);
            }

            //elimina
            public static string Eliminar(int idventa)
            {
                CDVenta Obj = new CDVenta();
                Obj.IdVenta = idventa;
                return Obj.Eliminar(Obj);
            }

            //Método Mostrar 
            public static DataTable Mostrar()
            {
                return new CDVenta().Mostrar();
            }

            //Método BuscarFechas 
            public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
            {
                CDVenta Obj = new CDVenta();
                return Obj.BuscarFechas(textobuscar, textobuscar2);
            }
            public static DataTable MostrarDetalle(string textobuscar)
            {
                CDVenta Obj = new CDVenta();
                return Obj.MostrarDetalle(textobuscar);
            }
            public static DataTable MuestraProductoPorNombre(string textobuscar)
            {
                CDVenta Obj = new CDVenta();
                return Obj.BuscarProductoporNombre(textobuscar);
            }
            public static DataTable MuestrarProductoPorCodigo(string textobuscar)
            {
                CDVenta Obj = new CDVenta();
                return Obj.BuscaProductoPorcodigo(textobuscar);
            }

    }
    

}
