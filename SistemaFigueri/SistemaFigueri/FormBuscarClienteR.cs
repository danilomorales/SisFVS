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
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String stock { get; set; }
        int Listado = 0;

        public FormBuscarClienteR()
        {
            InitializeComponent();
        }


        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
        
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
    }


}
