using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

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




    }
}