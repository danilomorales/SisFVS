using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

        public void Lista (DataGridView datos)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Caja.PRODUCTO", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
            }
            catch
            {
                throw;
            }
        }

        public void busca(DataGridView datos, String BuscaAlias)
        {
            try
            {
                SqlCommand sql = new SqlCommand("SPAgrega_Producto", cnn);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.Add("@filtro", SqlDbType.VarChar, 200).Value = BuscaAlias;

                sql.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                datos.DataSource = dt;

            }
            catch
            {
                throw;
            }

        }
        
    }
}
