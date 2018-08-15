using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaNegocio;
using CapaDatos;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaFigueri
{
    public partial class FormBuscarClienteR : Form
    {
        public List<DataRow> lista { get; set; }
        CNClientes nc = new CNClientes();
        CDCliente dc = new CDCliente();
        DataTable tbCliente = new DataTable();

        public String dni { get; set; }
        public String cliente { get; set; }
        public String ruc { get; set; }
  

        public FormBuscarClienteR()
        {
            InitializeComponent();
        }
        public void MostrarCliente(DataGridView dgvProducto)
        {
            try
            {
                CNClientes objProducto = new CNClientes();
                SqlDataAdapter adapter = objProducto.CargaProductoFiltro();
                foreach (DataRow row in tbCliente.Rows)
                {
                    lista.Add((DataRow)row);
                }
                adapter.Fill(tbCliente);
                dgvProducto.DataSource = tbCliente;
                adapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Carga fallida:" + ex.ToString());

            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvCliente.AllowUserToResizeRows = false;
            MostrarCliente(dgvCliente);
            //dgvlListaProducto.Columns[0].Visible = false;
            dgvCliente.Columns["Documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["RUC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["Apellidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["NombreEmpresa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["TipoCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.Columns["Sector"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           foreach (DataGridViewColumn column in dgvCliente.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void ListarClientes()
        {
         
        }

        private void btnCerrarFiltro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFiltraCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
  
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

   

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            Program.IdClienteReceptor = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value.ToString());
            Program.NroDocIdentidad = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            Program.NumeroRuc = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            Program.RazonSocial = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            Program.NombreComercial = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            Program.Nombres = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            Program.ApellidoPaterno = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            Program.ApellidoMaterno = dgvCliente.CurrentRow.Cells[7].Value.ToString();
          
            this.Close();
        }

        private void tbFiltraCliente_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dc = tbCliente.DefaultView;
            dc.RowFilter = string.Format("Documento like '%{0}%' or DNI like '%{0}%' or DNI like '%{0}%' or Nombres like '%{0}%' or Apellidos like '%{0}%' ", tbFiltraCliente.Text);


        }

        private void dgvCliente_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String Dni = dgvCliente.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
            String Nombres = dgvCliente.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
            String Apellidos = dgvCliente.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            String Ruc = dgvCliente.Rows[e.RowIndex].Cells["RUC"].Value.ToString();
            dni = Dni;
            cliente = "" +""+Nombres+""+Apellidos;
            ruc = Ruc;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }


}
