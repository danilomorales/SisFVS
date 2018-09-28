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
        public CE_Cliente EnCliente;
        public String dni { get; set; }
        public String clienteN { get; set; }
        public String clienteA { get; set; }
        public String ruc { get; set; }
        public String empresa { get; set; }
        public String tipodoc { get; set; }
        public String idcliente { get; set; }
  

        public FormBuscarClienteR()
        {
            InitializeComponent();
        }
        private void CrearTabla()
        {dgvCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgvCliente.AllowUserToResizeRows = false;
                MostrarCliente(dgvCliente);
                //lbtotal.Text = CStr(dgvCliente.RowCount);

                dgvCliente.Columns["IdCliente"].Visible = false;
                dgvCliente.Columns["IdCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["Documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["RUC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["Apellidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["Razón_Social"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["Sector"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCliente.Columns["Documento"].Width = 10;
                dgvCliente.Columns["DNI"].Width = 10;
                dgvCliente.Columns["RUC"].Width = 10;
                dgvCliente.Columns["Nombres"].Width = 15;
                dgvCliente.Columns["Apellidos"].Width = 15;
                dgvCliente.Columns["Razón_Social"].Width = 30;
                dgvCliente.Columns["Sector"].Width = 70;
                this.dgvCliente.Columns["IdCliente"].Visible = false;
                foreach (DataGridViewColumn column in dgvCliente.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }


        }

        private void MostrarCliente(DataGridView dgvCliente)
        {
            try
            {
                //int num = 0;
                //dgvCliente.Rows.Clear();
                //List<CECliente> Lista = CNClientes.Intancia.ListaClienteVenta();
                //for (int i = 0; i < Lista.Count; i++)
                //{
                //    num++;
                //    String[] fila = new String[]
                //    {
                //        //Lista[i].Id_Cliente.ToString(),num.ToString(),
                //        Lista[i].Documento,
                //        Lista[i].DNI,
                //        Lista[i].RUC,
                //        Lista[i].Nombres,
                //        Lista[i].Apellidos,
                //        Lista[i].Nombre_Empresa,
                //        Lista[i].Sector};
                //    dgvCliente.Rows.Add(fila);
                //}
                CNClientes objProducto = new CNClientes();
                SqlDataAdapter adapter = objProducto.CargaCliente();
                foreach (DataRow row in tbCliente.Rows)
                {
                    lista.Add((DataRow)row);
                }
                adapter.Fill(tbCliente);
                dgvCliente.DataSource = tbCliente;
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
            //try
            //{
                CrearTabla();
               
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }
    

        private void btnCerrarFiltro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionaCliente()
        {
           

        }

        private void dgvCliente_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int intento = LocalBD.Instancia.ReturnIntento(1, 1);
                int invocador = LocalBD.Instancia.Invocar(0, 0);
                if (invocador == 1)
                {
                    int Id_Cliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                    //LocalBD.Instancia.ReturnDetVenta(1, id_prod, 1);
                }
                else if (invocador == 2)
                {
                    int Id_Cliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
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

            String Dni = dgvCliente.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
            String Nombres = dgvCliente.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
            String Apellidos = dgvCliente.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            String Ruc = dgvCliente.Rows[e.RowIndex].Cells["RUC"].Value.ToString();
            //String IdCliente = dgvCliente.Rows[e.RowIndex].Cells["ColumnIdCliente"].Value.ToString();
            String Empresa = dgvCliente.Rows[e.RowIndex].Cells["Razón_Social"].Value.ToString();
            String TipoDoc = dgvCliente.Rows[e.RowIndex].Cells["Documento"].Value.ToString();

            dni = Dni;
            clienteN = Nombres;
            clienteA = Apellidos;
            ruc = Ruc;
            //idcliente = IdCliente;
            empresa = Empresa;
            tipodoc = TipoDoc;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Selecciona()
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                String IdCliente;
                CNClientes dObj_ModeloCaj = new CNClientes();
                IdCliente = dgvCliente.SelectedRows[0].Cells["IdCliente"].ToString();
                EnCliente = dObj_ModeloCaj.LlenaEntidad_Cliente(IdCliente);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes sombrear un registro para seleccionarlo", "Validar busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvCliente_DoubleClick_1(object sender, EventArgs e)
        {
            Selecciona();
        }

        private void dgvCliente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void tbFiltraCliente_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dc = tbCliente.DefaultView;
            dc.RowFilter = string.Format("Nombres like '%{0}%' or Apellidos like '%{0}%' or DNI like '%{0}%' or like '%{0}%' or like '%{0}%'", tbFiltraCliente.Text);

        }
    }


}
