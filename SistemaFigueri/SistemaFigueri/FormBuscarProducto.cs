using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;
using CapaDatos;


namespace SistemaFigueri
{
    public partial class FormBuscarProducto : Form
    {

        CNProductos cp = new CNProductos();
        CDProductos cdpro = new CDProductos();
        DataTable tabla = new DataTable();

        public FormBuscarProducto()
        {
            InitializeComponent();
        }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            mostarProductos();
        }

        public void mostarProductos()
        {
            dtaListaPro.DataSource = cp.MostarProductos();

        }

        private void tbFiltra_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from caja.PRODUCTO where Alias like('" + tbFiltra.Text + "%')  or DescripcionProducto like('" + tbFiltra.Text + "')or TiempoDuracion like('" + tbFiltra.Text + "')" +
                "or Stock like('" + tbFiltra.Text + "')or StockMaximo like('" + tbFiltra.Text + "') or StockMinimo like('" + tbFiltra.Text + "')or Valor_Unitario like('" + tbFiltra.Text + "')" +
                "or PrecioVenta1 like('" + tbFiltra.Text + "')or PrecioVenta2 like('" + tbFiltra.Text + "') or PrecioOferta like('" + tbFiltra.Text + "')or Nota like('" + tbFiltra.Text + "')" +
                "or Factor like('" + tbFiltra.Text + "')or Estado like('" + tbFiltra.Text + "')or Item like('" + tbFiltra.Text + "') or StockInicial like('" + tbFiltra.Text + "')" +
                "or cta_vnt like('" + tbFiltra.Text + "')or Vigente like('" + tbFiltra.Text + "')";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtaListaPro.DataSource = dt;
            Conexion.Close();
        }

        private void dtaListaPro_DoubleClick(object sender, EventArgs e)
        {
            //Program. = Convert.ToInt32(dtaListaPro.CurrentRow.Cells[0].Value.ToString());
            //Program. = dtaListaPro.CurrentRow.Cells[2].Value.ToString();
            //Program. = dtaListaPro.CurrentRow.Cells[3].Value.ToString();
            //Program. = Convert.ToDecimal(dtaListaPro.CurrentRow.Cells[5].Value.ToString());
            //Program. = Convert.ToInt32(dtaListaPro.CurrentRow.Cells[6].Value.ToString());
            this.Close();



            //FormVenta form = FormVenta.GetInstancia();
            //string par1, par2;
            //Decimal par3;
            //int par5;
            //DateTime par6;
            //par1 = Convert.ToString(this.dtaListaPro.CurrentRow.Cells["Alias"].Value);
            //par2 = Convert.ToString(this.dtaListaPro.CurrentRow.Cells["DescripcionProducto"].Value);
            //par3 = Convert.ToDecimal(this.dtaListaPro.CurrentRow.Cells["Valor_Unitario"].Value);
            //par5 = Convert.ToInt32(this.dtaListaPro.CurrentRow.Cells["Stock"].Value);
            //par6 = Convert.ToDateTime(this.dtaListaPro.CurrentRow.Cells["TiempoDuracion"].Value);
            //form.SetProducto(par1, par2, par3, par5, par6);
            //this.Hide();
        }
    }
}
