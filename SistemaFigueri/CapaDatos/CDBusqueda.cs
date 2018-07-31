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
        DataTable tab = new DataTable();
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        private SqlDataAdapter sqladapter;


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

        //public DataTable Filtrar()
        //{

        //    SqlCommand comando = new SqlCommand("SPFiltro_Busqueda", Conexion.AbrirConexion());
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Parameters.Add("@filtro", SqlDbType.VarChar, 50).Value = MostrarResultado();
        //    comando.ExecuteNonQuery();
        //    SqlDataAdapter adapter = new SqlDataAdapter(comando);
        //    adapter.Fill(tab);
        //    return tab;


        //}
        public DataTable autocompletar()
        {
            cmd = new SqlCommand("select NombreEmpresa from CLIENTE;", cnn);
            dr = cmd.ExecuteReader();
            tab.Load(leer);
            Conexion.CerrarConexion();
            return tab;
        }

        public SqlDataAdapter BusquedaProductos()
        {
            string comandosql = "select Alias, DescripcionProducto,Valor_Unitario from Caja.PRODUCTO";
            sqladapter = new SqlDataAdapter(comandosql, Conexion.AbrirConexion());
            return sqladapter;
        }
        
    


        

    }
}
