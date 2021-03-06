﻿using System;
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

        public SqlDataReader controlPriRol(int idrol, int idprivilegio)
        {
            String sql = "insert into dbo.ROL_PRIVILEGIO (IdRol,IdPrivilegio) values(@idrol,@idprivilegio)";
            SqlCommand comandon = new SqlCommand(sql, Conexion.AbrirConexion());
            comandon.CommandType = CommandType.StoredProcedure;
            comandon.Parameters.AddWithValue("@idrol", idrol);
            comandon.Parameters.AddWithValue("@idprivilegio", idprivilegio);
            lector = comandon.ExecuteReader();
            return lector;
        }

        public SqlDataAdapter listarRoles()
        {
            String sql = "select * from dbo.ROL";
            adapter = new SqlDataAdapter(sql, Conexion.AbrirConexion());
            return adapter;
        }

        public SqlDataAdapter cargarPerfiles()
        {
            String sql = "SELECT usu.IdUsuario,per.IdPersona,usu.Login,per.Nombres,per.ApellidoPaterno,per.ApellidoMaterno,per.DNI,per.Direccion,usu.foto " +
                " FROM Caja.Usuario usu LEFT JOIN Caja.Persona per ON usu.IdPersona =per.IdPersona ;";
            adapter = new SqlDataAdapter(sql, Conexion.AbrirConexion());
            return adapter;
        }

        public SqlDataReader buscarPerfil(int id)
        {
            String sql = "SELECT usu.IdUsuario,per.IdPersona,usu.Login,usu.Pass,per.Nombres,per.ApellidoPaterno,per.ApellidoMaterno,per.DNI,per.Direccion,usu.foto " +
                " FROM Caja.Usuario usu LEFT JOIN Caja.Persona per ON usu.IdPersona =per.IdPersona where usu.IdUsuario=@id ;";
            SqlCommand comandon = new SqlCommand(sql, Conexion.AbrirConexion());
            comandon.Parameters.AddWithValue("@id", id);
            lector = comandon.ExecuteReader();
            return lector;
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
                if (url == ""||url==null)
                {
                    SqlParameter imageParameter = new SqlParameter("@vImagen", SqlDbType.Image);
                    imageParameter.Value = DBNull.Value;
                    comando.Parameters.Add(imageParameter);
                    comando.ExecuteNonQuery();
                   
                }
                else
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    comando.Parameters.AddWithValue("@vImagen", img);
                    comando.ExecuteNonQuery();
                    
                }
                count = 1;
            }
            catch(SqlException exp)
            {
                Console.WriteLine("Error insertando usuario" + exp.ToString());
            }
            return count;
        }

        public int EditarUsuario(int idusuario,int idpersona,String nombres, String paterno, String materno, String dni, String direccion, String user, String pass, String url)
        {
            int count = 0;
            try
            {
                String sql = "UPDATE Caja.Persona SET Nombres=@vNombres,ApellidoPaterno=@vApellidoPaterno,ApellidoMaterno=@vApellidoMaterno, " +
                    "DNI=@vDNI,Direccion=@vDireccion where IdPersona=@vIdPersona ";
                String sql2 ="UPDATE Caja.Usuario SET Login=@vUser,Pass=@vPass,foto=@vImagen WHERE IdUsuario=@vIdUsuario";
                SqlCommand comando = new SqlCommand(sql, Conexion.AbrirConexion());
                SqlCommand comandon = new SqlCommand(sql2, Conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@vIdPersona ", idpersona);
                comando.Parameters.AddWithValue("@vNombres ", nombres);
                comando.Parameters.AddWithValue("@vApellidoPaterno", paterno);
                comando.Parameters.AddWithValue("@vApellidoMaterno", materno);
                comando.Parameters.AddWithValue("@vDNI", dni);
                comando.Parameters.AddWithValue("@vDireccion", direccion);
                comando.ExecuteNonQuery();
                comandon.Parameters.AddWithValue("@vIdUsuario ", idusuario);
                comandon.Parameters.AddWithValue("@vUser", user);
                comandon.Parameters.AddWithValue("@vPass", pass);
                if (url == "" || url == null)
                {
                    SqlParameter imageParameter = new SqlParameter("@vImagen", SqlDbType.Image);
                    imageParameter.Value = DBNull.Value;
                    comandon.Parameters.Add(imageParameter);
                    comandon.ExecuteNonQuery();

                }
                else
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    comandon.Parameters.AddWithValue("@vImagen", img);
                    comandon.ExecuteNonQuery();

                }
                count = 1;
            }
            catch (SqlException exp)
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

        public SqlDataReader existeUsuario(String login)
        {
            String sql = "select Login from Caja.Usuario where Login=@login ";
            SqlCommand comando = new SqlCommand(sql, Conexion.AbrirConexion());
            comando.Parameters.AddWithValue("@login", login);
            lector = comando.ExecuteReader();
            return lector;
        }

        public SqlDataReader privSegunIdRol(int id)
        {
            String sql = "SELECT*FROM dbo.PRIVILEGIO WHERE IdPrivilegio NOT IN (select pri.IdPrivilegio from dbo.PRIVILEGIO pri " +
                "LEFT JOIN dbo.ROL_PRIVILEGIO rolpri ON pri.IdPrivilegio = rolpri.IdPrivilegio " +
                "LEFT JOIN dbo.ROL rol ON rolpri.IdRol = rol.IdRol " +
                "WHERE rolpri.IdRol = @id);";
            SqlCommand comando = new SqlCommand(sql, Conexion.AbrirConexion());
            comando.Parameters.AddWithValue("@id", id);
            lector = comando.ExecuteReader();
            return lector;
        }

        public SqlDataReader privSegunIdRol2(int id)
        {
            String sql = "select pri.IdPrivilegio,pri.nombre from dbo.PRIVILEGIO pri " +
                "LEFT JOIN dbo.ROL_PRIVILEGIO rolpri ON pri.IdPrivilegio = rolpri.IdPrivilegio " +
                "LEFT JOIN dbo.ROL rol ON rolpri.IdRol = rol.IdRol " +
                "WHERE rolpri.IdRol = @id";
            SqlCommand comando = new SqlCommand(sql, Conexion.AbrirConexion());
            comando.Parameters.AddWithValue("@id", id);
            lector = comando.ExecuteReader();
            return lector;
        }

        public void eliminarUsuario(int idusuario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "delete from Caja.Usuario WHERE IdUsuario=" + idusuario + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }

        public void eliminarUsuarioRol(int idusuario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "delete from dbo.USUARIO_ROL WHERE IdUsuario=" + idusuario + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }

        public void eliminarRolPrivilegio(int idrol)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "delete from dbo.ROL_PRIVILEGIO WHERE IdRol=" + idrol + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
    }
}
