﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CNUsuario
    {

        //Escapsula las variables
        private CDUsuario objDato = new CDUsuario(); // Instancia a la capa datos de usuario
        //Variables
        private String _Login;
        private String _Pass;

        //Get y Set
           
        public String Usuario
        {
            set
            {
                if (value == "Usuario") { _Login = "No ingresó nombre de Usuario"; }
                else { _Login = value; }
            }
            get { return _Login; }
        }
        public String Pass
        {
            set { _Pass = value; }
            get { return _Pass; }
        }
        //constructor
        public CNUsuario() { }

        //funciones metodos
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.iniciarSesion(Usuario, Pass);
            return Loguear;
        }

        public SqlDataReader UsuarioPerfil()
        {
            SqlDataReader perfil;
            perfil = objDato.usuarioPerfil(Usuario);
            return perfil;
        }

        public SqlDataAdapter cargarPerfiles()
        {
            SqlDataAdapter perfil;
            perfil = objDato.cargarPerfiles();
            return perfil;
        }

        public SqlDataAdapter listarRoles()
        {
            SqlDataAdapter perfil;
            perfil = objDato.listarRoles();
            return perfil;
        }

        public SqlDataReader controlUsuarioRol(int idusuario,int idrol)
        {
            SqlDataReader perfil;
            perfil = objDato.controlUsuarioRol(idusuario,idrol);
            return perfil;
        }

        public SqlDataReader buscarPerfil(int id)
        {
            SqlDataReader perfil;
            perfil = objDato.buscarPerfil(id);
            return perfil;
        }

        public SqlDataReader controlRolPrivilegio(int idrol, int idprivilegio)
        {
            SqlDataReader perfil;
            perfil = objDato.controlPriRol(idrol, idprivilegio);
            return perfil;
        }

        public SqlDataReader rolSegunIdUsuario(int id)
        {
            SqlDataReader perfil;
            perfil = objDato.rolSegunIdUsuario(id);
            return perfil;
        }

        public SqlDataReader rolSegunIdUsuario2(int id)
        {
            SqlDataReader perfil;
            perfil = objDato.rolSegunIdUsuario2(id);
            return perfil;
        }
    
        public SqlDataReader privSegunIdRol(int id)
        {
            SqlDataReader perfil;
            perfil = objDato.privSegunIdRol(id);
            return perfil;
        }

        public SqlDataReader privSegunIdRol2(int id)
        {
            SqlDataReader perfil;
            perfil = objDato.privSegunIdRol2(id);
            return perfil;
        }

        public SqlDataReader existeUsuario(String login)
        {
            SqlDataReader perfil;
            perfil = objDato.existeUsuario(login);
            return perfil;
        }

        public int insertarUsuario(String nombres, String paterno, String materno, String dni, String direccion, String user, String pass, String url)
        {
            Console.WriteLine("Llegando al DAO .."+nombres+" "+ paterno + " " +  materno + " " + dni + " " + direccion +" " + user + " " + pass + " "  + " " + url);
            return objDato.InsertarUsuario(nombres, paterno, materno, dni, direccion, user, pass, url);
        }

        public int EditarUsuario(int idusuario,int idpersona,String nombres, String paterno, String materno, String dni, String direccion, String user, String pass, String url)
        {
            Console.WriteLine("Llegando al DAO.." + idusuario+" "+idpersona+" "+nombres + " " + paterno + " " + materno + " " + dni + " " + direccion + " " + user + " " + pass + " " + " " + url);
            return objDato.EditarUsuario(idusuario,idpersona,nombres, paterno, materno, dni, direccion, user, pass, url);
        }

        public void eliminarUsuario(int idusuario)
        {
            objDato.eliminarUsuario(idusuario);
        }

        public void eliminarUsuarioRol(int idusuario)
        {
            objDato.eliminarUsuarioRol(idusuario);
        }

        public void eliminarRolPrivilegio(int idusuario)
        {
            objDato.eliminarRolPrivilegio(idusuario);
        }


    }
}