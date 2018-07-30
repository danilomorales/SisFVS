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
        private SqlDataAdapter adapter;
        DataTable tabla;

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

        public SqlDataAdapter cargarPerfiles()
        {
            String sql = "SELECT usu.IdUsuario,per.IdPersona,rol.IdRol,usu.Login,per.Nombres,per.ApellidoPaterno,per.ApellidoMaterno,per.DNI,per.Direccion,rol.nomRol,usu.foto " +
                " FROM Caja.Usuario usu LEFT JOIN Caja.Persona per ON usu.IdPersona =per.IdPersona LEFT JOIN dbo.CajaRol rol on usu.idRol=rol.idRol;";
            adapter = new SqlDataAdapter(sql, Conexion.AbrirConexion());
            return adapter;
        }
    }
}
