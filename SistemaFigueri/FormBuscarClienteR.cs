using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaNegocio;
using CapaDatos;
using CapaEntidades;
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
        public String empresa { get; set; }
        public String tipodoc { get; set; }
        public String idcliente { get; set; }
  

        public FormBuscarClienteR()
        {
            InitializeComponent();
        }
        private void CrearTabla()
        {


            //dgvCliente.Columns.Add("ColumnIdCliente", "IdCliente");
            dgvCliente.Columns.Add("ColumnDocumento", "Documento");
            dgvCliente.Columns.Add("ColumnDNI", "DNI");
            dgvCliente.Columns.Add("ColumnRUC", "RUC");
            dgvCliente.Columns.Add("ColumnNombres", "Nombres");
            dgvCliente.Columns.Add("ColumnApellidos", "Apellidos");
            dgvCliente.Columns.Add("ColumnRazón_Social", "Razón_Social");
           dgvCliente.Columns.Add("ColumnSector", "Sector");

            //dgvCliente.Columns["ColumnIdCliente"].Width = 40;
            dgvCliente.Columns["ColumnDocumento"].Width = 40;
            dgvCliente.Columns["ColumnDNI"].Width = 50;
            dgvCliente.Columns["ColumnRUC"].Width = 20;
            dgvCliente.Columns["ColumnNombres"].Width = 20;
            dgvCliente.Columns["ColumnApellidos"].Width = 20;
            dgvCliente.Columns["ColumnRazón_Social"].Width = 40;
            dgvCliente.Columns["ColumnSector"].Width = 40;
            DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();
            cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCliente.ColumnHeadersDefaultCellStyle = cssabecera;

            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.MultiSelect = false;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void LlenarGrid()
        {
            try
            {
                int num = 0;
                dgvCliente.Rows.Clear();
                List<CECliente> Lista = CNClientes.Intancia.ListaClienteVenta();
                for (int i = 0; i < Lista.Count; i++)
                {
                    num++;
                    String[] fila = new String[]
                    {
                        //Lista[i].IdCliente.ToString(),num.ToString(),
                        Lista[i].Documento,
                        Lista[i].DNI,
                        Lista[i].RUC,
                        Lista[i].Nombre_Empresa,
                        Lista[i].Nombres,
                        Lista[i].Apellidos,
                        Lista[i].Sector};
                    dgvCliente.Rows.Add(fila);
                }
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception)
            {

                throw;
            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                CrearTabla();
                LlenarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
            //Program.IdClienteReceptor = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value.ToString());
            Program.NroDocIdentidad = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            Program.NumeroRuc = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            Program.RazonSocial = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            Program.NombreComercial = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            Program.Nombres = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            Program.ApellidoPaterno = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            Program.ApellidoMaterno = dgvCliente.CurrentRow.Cells[7].Value.ToString();
          
            this.Close();
        }
        int tip_busqueda = 1;
        private void tbFiltraCliente_KeyUp(object sender, KeyEventArgs e)
        {
            //DataView dc = tbCliente.DefaultView;
            //dc.RowFilter = string.Format("Documento like '%{0}%' or DNI like '%{0}%' or RUC like '%{0}%' or Apellidos like '%{0}%' or Razón_Social like '%{0}%' ", tbFiltraCliente.Text);

            try
            {
                if (e.KeyCode != Keys.Back)
                {
                    String val_entrada = tbFiltraCliente.Text;
                    int num = 0;
                    List<CECliente> Lista = CNClientes.Instancia.BuscarprodAvanzada(tip_busqueda, val_entrada);
                    dgvCliente.Rows.Clear();
                    for (int i = 0; i < Lista.Count(); i++)
                    {
                        num++;
                        String[] fila = new String[] {
                        Lista[i]._Codigo,
                        Lista[i]._Alias,
                        Lista[i]._DescripcionProducto,
                        Lista[i]._Stock,
                        Lista[i]._TiempoDuracion,
                        Lista[i]._precio.ToString(),num.ToString() };
                        dgvCliente.Rows.Add(fila);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvCliente_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String Dni = dgvCliente.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
            String Nombres = dgvCliente.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
            String Apellidos = dgvCliente.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            String Ruc = dgvCliente.Rows[e.RowIndex].Cells["RUC"].Value.ToString();
            String IdCliente = dgvCliente.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString();
            String Empresa = dgvCliente.Rows[e.RowIndex].Cells["NombreEmpresa"].Value.ToString();
            String TipoDoc = dgvCliente.Rows[e.RowIndex].Cells["Documento"].Value.ToString();

            dni = Dni;
            cliente = "" +""+Nombres+" "+Apellidos;
            ruc = Ruc;
            idcliente = IdCliente;
            empresa = Empresa;
            tipodoc = TipoDoc;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }


}
