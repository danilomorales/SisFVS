using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime;

namespace CapaDatos
{
    public class Conexion
    {
        public static string Cn = Properties.Settings.Default.cn;


        #region singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get
            {
                return Conexion._instancia;
            }
        }
        #endregion singelton

        #region metodos
        public SqlConnection Conectar()
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                //cn.ConnectionString = "Data Source=DESKTOP-L6011JV;Initial Catalog=BDAYDTest;User ID=sa; Password=123";
                ////cn.ConnectionString = "Data Source=DESKTOP-L6011JV;Initial Catalog=BDAYDTest;User ID=sa";

                //string servidor = ConfigurationManager.Instancia.getServer;
                //string database = ConfigurationManager.Instancia.getDatabase;
                //string user = ConfigurationManager.Instancia.getUser;
                //string clave = ConfigurationManager.Instancia.getClave;


                //cn.ConnectionString = "Data Source=" + servidor + "; Initial Catalog = " +
                //    database + "; User ID =" + user + " ; Password =" + clave;
                return cn;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion metodos
    }
}

