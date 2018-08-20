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
        CDCliente Dcliente = new CDCliente();

        public String alias { get; set; }
        public String descripcion { get; set; }
        public String stock { get; set; }
        public String fechavencimiento { get; set; }
        public String precio{ get; set; }
        public String oferta { get; set; }
        public String idproducto { get; set; }

        public FormBuscarProducto()
        {
            InitializeComponent();
        }
        public void LIstaProductoFiltro(DataGridView dgvProducto)
        {
            try
            {
                CNProductos objProducto = new CNProductos();
                SqlDataAdapter adapter = objProducto.ListaProductosFiltro();
                foreach (DataRow row in tProducto.Rows)
                {
                    list.Add((DataRow)row);
                }
                adapter.Fill(tProducto);
                dgvProducto.DataSource = tProducto;
                adapter.Dispose();

                //CNProductos objProducto = new CNProductos();
                
                //foreach (DataRow row in tProducto.Rows)
                //{
                //    list.Add((DataRow)row);
                //}
                //dgvProducto.DataSource = tProducto;

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
            LIstaProductoFiltro(dgvlListaProducto);
           // dgvlListaProducto.Columns[0].Visible = false;
            dgvlListaProducto.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["DescripcionProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Alias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["TiempoDuracion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
 
            foreach (DataGridViewColumn column in dgvlListaProducto.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            lbIdCliente.Text = precio;


        }
        private void tbFiltra_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = tProducto.DefaultView;
            dv.RowFilter = string.Format("Código like '%{0}%' or Alias like '%{0}%' or DescripcionProducto like '%{0}%'", tbFiltra.Text);

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
            //FormVenta fv = new FormVenta();
            //fv.tbAlias.Text = this.dgvlListaProducto.CurrentRow.Cells["Alias"].Value.ToString();
            String IdProducto = dgvlListaProducto.Rows[e.RowIndex].Cells["Código"].Value.ToString();
            String Producto = dgvlListaProducto.Rows[e.RowIndex].Cells["DescripcionProducto"].Value.ToString();
            String Alias = dgvlListaProducto.Rows[e.RowIndex].Cells["Alias"].Value.ToString();
            String Fechav = dgvlListaProducto.Rows[e.RowIndex].Cells["TiempoDuracion"].Value.ToString();
            String Precio = dgvlListaProducto.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            String Stock = dgvlListaProducto.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
            String Id = dgvlListaProducto.Rows[e.RowIndex].Cells[0].Value.ToString();
            alias = Alias;
            descripcion = Producto;
            stock = Stock;
            fechavencimiento = Fechav;
            precio = Precio;
            idproducto = IdProducto;
            this.DialogResult = DialogResult.OK;
            this.Close();
            //fv.Close();
        }
    }
}
