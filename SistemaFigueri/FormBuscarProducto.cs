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
        public List<DataRow> list { get; set; }
        CNProductos cp = new CNProductos();
        CDProductos cdpro = new CDProductos();
        DataTable tProducto = new DataTable();
        CDCliente Dcliente = new CDCliente();
        FormBuscarClienteR clie = new FormBuscarClienteR();
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
            
            
            dgvlListaProducto.Columns.Add("ColumnCodigo", "IdProducto");
            dgvlListaProducto.Columns.Add("ColumnAlias", "Alias");
            dgvlListaProducto.Columns.Add("ColumnDescripcion", "DescripcionProducto");
            dgvlListaProducto.Columns.Add("ColumnStock", "Stock");
            dgvlListaProducto.Columns.Add("ColumnPecio", "Precio");

            dgvlListaProducto.Columns["ColumnCodigo"].Width = 20;
            dgvlListaProducto.Columns["ColumnAlias"].Width = 40;
            dgvlListaProducto.Columns["ColumnDescripcion"].Width = 50;
            dgvlListaProducto.Columns["ColumnStock"].Width = 20;
            dgvlListaProducto.Columns["ColumnPecio"].Width = 40;


        }


        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CrearTabla();
                ContarItems();
                CargarGridProductoVenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        int tip_busqueda=1;


        private void tbFiltra_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Back)
                {
                    String val_entrada = tbFiltra.Text;
                    int num = 0;
                    List<CEProducto> Lista = CNProductos.Instancia.BuscarprodAvanzada(tip_busqueda, val_entrada);
                    dgvlListaProducto.Rows.Clear();
                    for (int i = 0; i < Lista.Count(); i++)
                    {

                        num++;
                        String[] fila = new String[] {
                        Lista[i]._IdProdcuto,
                        Lista[i]._Alias,
                        Lista[i]._DescripcionProducto,
                        Lista[i]._Stock.ToString(),
                        Lista[i]._TiempoDuracion,
                        Lista[i]._precio.ToString(),num.ToString() };
                        dgvlListaProducto.Rows.Add(fila);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void rbNombreProd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tip_busqueda = 1;
                dgvlListaProducto.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tip_busqueda = 2;
                dgvlListaProducto.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void dtaListaPro_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnCerrarFiltroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGridProductoVenta()
        {
            try
            {
                dgvlListaProducto.Rows.Clear();
                List<CEProducto> Lista = CNProductos.Instancia.ListarProductoVenta();
                int num = 0;
                for (int i = 0; i < Lista.Count(); i++)
                {
                    num++;
                    String[] fila = new String[] {
                        Lista[i]._IdProdcuto,
                        Lista[i]._Alias,
                        Lista[i]._DescripcionProducto,
                        Lista[i]._Stock.ToString(),
                        Lista[i]._TiempoDuracion, 
                        Lista[i]._precio.ToString(),num.ToString() };
                    dgvlListaProducto.Rows.Add(fila);


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ContarItems()
        {
            try
            {
                int num = 0;
                foreach (DataGridViewRow row in dgvlListaProducto.Rows)
                {
                    num++;
                }
                lbresultados.Text = "Resultados Obtenidos: " + num;
            }
            catch (Exception)
            {

                throw;
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
            String IdProducto = dgvlListaProducto.Rows[e.RowIndex].Cells["ColumnCodigo"].Value.ToString();
            String Producto = dgvlListaProducto.Rows[e.RowIndex].Cells["ColumnDescripcion"].Value.ToString();
            String Alias = dgvlListaProducto.Rows[e.RowIndex].Cells["ColumnAlias"].Value.ToString(); 
            Decimal nuevoPrecio = cn.traerPrecio(idcliente, IdProducto);
            String Stock = dgvlListaProducto.Rows[e.RowIndex].Cells["ColumnStock"].Value.ToString();
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

    }
}
