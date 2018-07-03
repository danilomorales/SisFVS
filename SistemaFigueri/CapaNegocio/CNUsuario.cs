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
        private String _IdPersona;
        private String _Login;
        private String _Pass;

        //Get an Set

        public String Usuario
        {
            set{ _Login = value; }
            get { return _Login; }

        }
        public String Contrasena
        {
            set { _Login = value; }
            get { return _Pass; }

        }
        //constructor

        public CNUsuario() { }
        //funcoines metodos
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.iniciarSesion(Usuario, Contrasena);
            return Loguear;
        }




    }
}
