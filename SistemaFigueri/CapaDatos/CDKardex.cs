using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDKardex
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //LISTAR Kardex
        public DataTable listarKardex(String idProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select k.Concepto,r.Tipo_Cargo,k.FechaIngreso,k.FechaVencimiento,k.Hora,k.Tipo_Movimiento,k.Cantidad,k.Balance,k.Costo_Unitario," +
                "k.Precio_Venta,k.UnidadMedida from dbo.KARDEX_PRODUCTO k, caja.PRODUCTO p, dbo.CATEGORIA c, dbo.RESPONSABLE r " +
                "where k.IdProducto = p.IdProducto and c.IdCategoria = p.IdCategoria and k.IdResponsable = r.IdResponsable and p.IdProducto = '"+ idProducto +"'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //OBTENER DATOS
        public void ObtenerDatos(String idProducto, String nombre, String apellido, String alias, String descripcion)
        {           
        }


    }
}
