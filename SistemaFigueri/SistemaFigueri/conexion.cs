using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaFigueri
{
    class conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;

        public void conectar()
        {
            try
            {
                Conexion.Open();
                MessageBox.Show("Conectado");
            }
            catch
            {
                MessageBox.Show("Error al conectar");
            }
            finally
            {
                Conexion.Close();
            }
        }
        public void listar(String sql, String tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, Conexion);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        public bool insert(String sql)
        {
            Conexion.Open();
            comando = new SqlCommand(sql, Conexion);
            int i = comando.ExecuteNonQuery();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
