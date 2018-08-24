using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CDConexion
    {
        private static readonly CDConexion _instancia = new CDConexion();
        public static CDConexion Instancia
        {
            get
            {
                return CDConexion._instancia;
            }
        }
        public SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
        
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;

        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;


        }

        public SqlConnection Conectar()
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true";
                 return cn;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
