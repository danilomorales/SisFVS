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
using CapaEntidades;
using CapaDatos;


namespace SistemaFigueri
{
    public partial class FormBuscarProducto : Form
    {
        public List<DataRow> lista { get; set; }
        CNProductos ccnp = new CNProductos();
        CDProductos cdpro = new CDProductos();
        DataTable tProducto = new DataTable();

        public String idcliente { get; set; }
        public String alias { get; set; }
        public String descripcion { get; set; }
        public String stock { get; set; }
        public String fechavencimiento { get; set; }
        public String precio{ get; set; }
        public String idproducto { get; set; }

        public FormBuscarProducto()
        {
            InitializeComponent();
        }
        public void LIstaProductoFiltro(DataGridView dgvProducto)
        {
  
        }
        private void CrearTabla()
        {
            dgvlListaProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvlListaProducto.AllowUserToResizeRows = false;
            CargaTablaProducto(dgvlListaProducto);
            //lbtotal.Text = CStr(dgvCliente.RowCount);

            //dgvCliente.Columns["IdCliente"].Visible = false;
            dgvlListaProducto.Columns["IdProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Alias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["DescripcionProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlListaProducto.Columns["Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvlListaProducto.Columns["Alias"].Width = 10;
            dgvlListaProducto.Columns["DescripcionProducto"].Width = 30;
            dgvlListaProducto.Columns["Stock"].Width = 10;
            dgvlListaProducto.Columns["Precio"].Width = 5;
            dgvlListaProducto.Columns["Nota"].Width = 80;
            this.dgvlListaProducto.Columns["IdProducto"].Visible = false;
            foreach (DataGridViewColumn column in dgvlListaProducto.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


        }


        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CrearTabla();
                tbFiltra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
 


        private void tbFiltra_KeyUp(object sender, KeyEventArgs e)
        {
           

        }
        private void dtaListaPro_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnCerrarFiltroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargaTablaProducto(DataGridView dgvlListaProducto)
        {
            try
            {
                CNProductos objProducto = new CNProductos();
                SqlDataAdapter adapter = objProducto.CargaProdcuto();
                foreach (DataRow row in tProducto.Rows)
                {
                    lista.Add((DataRow)row);
                }
                adapter.Fill(tProducto);
                dgvlListaProducto.DataSource = tProducto;
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Carga fallida:" + ex.ToString());

            }
        }
       
        private void dgvlListaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int intento = LocalBD.Instancia.ReturnIntento(1, 1);
                int invocador = LocalBD.Instancia.Invocar(0, 0);
                if (invocador == 1)
                {
                    int id_prod = Convert.ToInt32(dgvlListaProducto.CurrentRow.Cells[0].Value);
                    //LocalBD.Instancia.ReturnDetVenta(1, id_prod, 1);
                }
                else if (invocador == 2)
                {
                    int id_prod = Convert.ToInt32(dgvlListaProducto.CurrentRow.Cells[0].Value);
                    //LocalBD.Instancia.ReturnDetNotaVenta(1, id_prod, 1);
                }
                else
                {
                    LocalBD.Instancia.Invocar(1, 0);
                }
                this.Close();
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CNVentas cn = new CNVentas();
            String IdProducto = dgvlListaProducto.Rows[e.RowIndex].Cells["IdProducto"].Value.ToString();
            String Producto = dgvlListaProducto.Rows[e.RowIndex].Cells["DescripcionProducto"].Value.ToString();
            String Alias = dgvlListaProducto.Rows[e.RowIndex].Cells["Alias"].Value.ToString(); 
            Decimal nuevoPrecio = cn.traerPrecio(idcliente, IdProducto);
            String Stock = dgvlListaProducto.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
            //String Id = dgvlListaProducto.Rows[e.RowIndex].Cells[0].Value.ToString();
            alias = Alias;
            descripcion = Producto;
            stock = Stock;
            precio = nuevoPrecio.ToString();
            idproducto = IdProducto;
            this.DialogResult = DialogResult.OK;
            this.Close();
            //fv.Close();   
        }

        private void tbFiltra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataView dv = tProducto.DefaultView;
                dv.RowFilter = string.Format("DescripcionProducto like '%{0}%' or Nota like '%{0}%' or Alias like '%{0}%'", tbFiltra.Text);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvlListaProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
    }
}
