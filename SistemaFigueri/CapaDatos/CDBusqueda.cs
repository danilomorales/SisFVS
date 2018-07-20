using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDBusqueda
    {
        private CDConexion Conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private object sqlDbType;

        public DataTable MostrarResultado()
        {
            //comando.Connection = Conexion.AbrirConexion();
            //comando.CommandText = "SP_ClienteReceptorBusquedaCliente_SEL";
            SqlCommand comando = new SqlCommand("SPListarLCientes", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;

        }

        public DataTable Filtrar()
        {
            try
            {
                comando = new SqlCommand("select Nombres from Caja.ClienteReceptor")
            }
            catch
            {

            }

        }

        

    }
}
