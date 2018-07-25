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
        private SqlDataReader lector;

        public SqlDataReader iniciarSesion(string usuario, string contrasena)
        {

            SqlCommand comando = new SqlCommand("SFIniciarSesion", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contrasena", contrasena);
            leer = comando.ExecuteReader();
            return leer;
        }

        public SqlDataReader usuarioPerfil(string usuario)
        {
            String sql = "SFPerfilUsuario";
            SqlCommand comandon = new SqlCommand(sql, Conexion.AbrirConexion());
            comandon.CommandType = CommandType.StoredProcedure;
            comandon.Parameters.AddWithValue("@Usuario", usuario);
            lector = comandon.ExecuteReader();
            return lector;
        }
    }
}
