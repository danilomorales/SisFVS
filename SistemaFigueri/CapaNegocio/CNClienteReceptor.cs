﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNClienteReceptor
    {
        private CDConexion C = new CDConexion();

        private String _NroDocIdentidad;
        private String _NumeroRuc;
        private String _RazonSocial;
        private String _NombreComercial;
        private String _Nombres;
        private String _ApellidoPaterno;
        private String _ApellidoMaterno;


        public String NroDocIdentidad
        {
            get { return _NroDocIdentidad;}
            set { _NroDocIdentidad = value; }
        }
    
         public String NumeroRuc
        {
            get { return _NumeroRuc; }
            set { _NumeroRuc = value; }
         }

      
        public String RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }

        public String NombreComercial
        {
            get { return _NombreComercial; }
            set { _NombreComercial = value; }
        }

        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public String ApellidoPaterno
        {
            get { return _ApellidoPaterno; }
            set { _ApellidoPaterno = value; }
        }

         public String ApellidoMaterno
         {
            get { return _ApellidoMaterno; }
            set { _ApellidoMaterno = value; }
         }

       



    }
}
