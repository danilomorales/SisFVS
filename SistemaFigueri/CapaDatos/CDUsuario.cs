using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.IO;

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

        public SqlDataReader controlUsuarioRol(int idusuario,int idrol)
        {
            String sql = "SPControlUsuarioRol";
            SqlCommand comandon = new SqlCommand(sql, Conexion.AbrirConexion());
            comandon.CommandType = CommandType.StoredProcedure;
            comandon.Parameters.AddWithValue("@id", idusuario);
            comandon.Parameters.AddWithValue("@idrol", idrol);
            lector = comandon.ExecuteReader();
            return lector;
        }

        public SqlDataReader comboRol()
        {
            String sql = "select * from dbo.CajaRol";
            SqlCommand comando = new SqlCommand(sql, Conexion.AbrirConexion());
            lector = comando.ExecuteReader();
            return lector;
        }

        public SqlDataAdapter cargarPerfiles()
        {
            String sql = "SELECT usu.IdUsuario,per.IdPersona,usu.Login,per.Nombres,per.ApellidoPaterno,per.ApellidoMaterno,per.DNI,per.Direccion,usu.foto " +
                " FROM Caja.Usuario usu LEFT JOIN Caja.Persona per ON usu.IdPersona =per.IdPersona ;";
            adapter = new SqlDataAdapter(sql, Conexion.AbrirConexion());
            return adapter;
        }

        public int InsertarUsuario(String nombres, String paterno, String materno, String dni, String direccion, String user, String pass,String url)
        {
            int count = 0;
            try
            {
                String sql = "SPInsertarUsuario";
                SqlCommand comando = new SqlCommand(sql, Conexion.AbrirConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@vNombres ", nombres);
                comando.Parameters.AddWithValue("@vApellidoPaterno", paterno);
                comando.Parameters.AddWithValue("@vApellidoMaterno", materno);
                comando.Parameters.AddWithValue("@vDNI", dni);
                comando.Parameters.AddWithValue("@vDireccion", direccion);
                comando.Parameters.AddWithValue("@vUser", user);
                comando.Parameters.AddWithValue("@vPass", pass);
                byte[] img = null;
                FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                comando.Parameters.AddWithValue("@vImagen",img);
                comando.ExecuteNonQuery();
                count = 1;
            }
            catch(SqlException exp)
            {
                Console.WriteLine("Error insertando usuario" + exp.ToString());
            }
            return count;
        }

        public SqlDataReader rolSegunIdUsuario(int id )
        {
            String sql = "SELECT*FROM dbo.ROL WHERE IdRol NOT IN(select rol.IdRol from dbo.ROL rol " +
                "LEFT JOIN dbo.USUARIO_ROL usurol ON rol.IdRol = usurol.IdRol " +
                "LEFT JOIN caja.Usuario usu ON usurol.IdUsuario = usu.IdUsuario " +
                "WHERE usurol.IdUsuario = @id); ";
            SqlCommand comando = new SqlCommand(sql, Conexion.AbrirConexion());
            comando.Parameters.AddWithValue("@id", id);
            lector = comando.ExecuteReader();
            return lector;
        }

        public SqlDataReader rolSegunIdUsuario2(int id)
        {
            String sql = "select rol.IdRol,rol.nomRol from dbo.ROL rol " +
                "LEFT JOIN dbo.USUARIO_ROL usurol ON rol.IdRol = usurol.IdRol " +
                "LEFT JOIN caja.Usuario usu ON usurol.IdUsuario = usu.IdUsuario " +
                "WHERE usurol.IdUsuario = @id; ";
            SqlCommand comando = new SqlCommand(sql, Conexion.AbrirConexion());
            comando.Parameters.AddWithValue("@id", id);
            lector = comando.ExecuteReader();
            return lector;
        }

    }
}
