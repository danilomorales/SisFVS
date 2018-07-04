using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class CDUsuario
    {
        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;

        public SqlDataReader iniciarSesion(string usuario, string contrasena)
        {
            
            SqlCommand comando = new SqlCommand();
       
    
            return leer;
        }
    }
}
