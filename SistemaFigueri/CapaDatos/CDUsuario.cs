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
            string sql = "select * from Usuario where Login='"+usuario+"' and Pass='"+contrasena+"'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
    
            return leer;
        }
    }
}
