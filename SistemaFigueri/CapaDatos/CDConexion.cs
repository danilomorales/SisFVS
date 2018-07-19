using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    class CDConexion
    {
        
        private SqlConnection Conexion = new SqlConnection("Server=192.168.21.5;DataBase=DBFIGUE2;Integrated Security = true;User ID=sa;Password=123");
        
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
    }
}
