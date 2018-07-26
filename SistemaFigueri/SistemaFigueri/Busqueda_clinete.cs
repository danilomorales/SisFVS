using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaDatos;



namespace SistemaFigueri
{
    class Busqueda_clinete :FormVenta
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Busqueda_clinete()
        {
            cnn = new SqlConnection("Data Source=.;Initial Catalog=DBFIGUE2;Integrated Security=True");
            cnn.Open();
        }

        public void autoCompletar(TextBox cajaTexto)
        {
            cmd = new SqlCommand("select NombreEmpresa from CLIENTE;", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cajaTexto.AutoCompleteCustomSource.Add(dr["NombreEmpresa"].ToString());
                
            }
            dr.Close();

        }
        public void autocompletaPro(TextBox ctPro)
        {
            cmd = new SqlCommand("select Alias from PRODUCTO;", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ctPro.AutoCompleteCustomSource.Add(dr["Alias"].ToString());
            }
            dr.Close();
        }
    }
}
