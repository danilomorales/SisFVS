using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaFigueri
{
    class Busqueda_Cliente
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public void Busqueda_clinete()
        {
            cnn = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123");
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
