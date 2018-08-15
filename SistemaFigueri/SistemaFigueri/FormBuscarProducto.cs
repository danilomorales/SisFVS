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
        public List<DataRow> list { get; set; }
        CNProductos cp = new CNProductos();
        CDProductos cdpro = new CDProductos();
        DataTable tProducto = new DataTable();
        public String producto { get; set; }
        public int idproducto { get; set; }

        public FormBuscarProducto()
        {
            InitializeComponent();
        }
        public void mostarProductos(DataGridView dgvProducto)
        {
            try
            {
                CNProductos objProducto = new CNProductos();
                SqlDataAdapter adapter = objProducto.CargaProductoFiltro();
                foreach (DataRow row in tProducto.Rows)
                {
                    list.Add((DataRow)row);
                }
                adapter.Fill(tProducto);
                dgvProducto.DataSource = tProducto;
                adapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Carga fallida:" + ex.ToString());

            }
        }
        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {

            dgvlListaProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvlListaProducto.AllowUserToResizeRows = false;
            mostarProductos(dgvlListaProducto);
            //dgvlListaProducto.Columns[0].Visible = false;
            dgvlListaProducto.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Alias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Descripción"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["TiempoDuracion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["PrecioOferta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Vigente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Ctaegoría"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Medida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn column in dgvlListaProducto.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void tbFiltra_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = tProducto.DefaultView;
            dv.RowFilter = string.Format("Código like '%{0}%' or Alias like '%{0}%' or Descripción like '%{0}%'", tbFiltra.Text);

        }

        private void dtaListaPro_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnCerrarFiltroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvlListaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormVenta fv = new FormVenta();
            //fv.tbAlias.Text
            //String alias = dgvlListaProducto.Rows[e.RowIndex].Cells["Alias"].Value.ToString(); 
            //String producto = dgvlListaProducto.Rows[e.RowIndex].Cells["Descripción"].Value.ToString(); 
            //String stock = dgvlListaProducto.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
            //String id = dgvlListaProducto.Rows[e.RowIndex].Cells[0].Value.ToString();
            //producto = " " + alias + " " + producto + " " + stock;
            //idproducto = Int32.Parse(id);
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
