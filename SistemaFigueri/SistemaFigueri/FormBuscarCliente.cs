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
    public partial class FormBuscarCliente : Form
    {
        private CNClienteReceptor C = new CNClienteReceptor();

        int Listado = 0;

        public FormBuscarCliente()
        {
            InitializeComponent();
        }


        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 5000;
            ListarClientes();
            dgvCliente.ClearSelection();
        }
        private void ListarClientes()
        {
            DataTable dt = new DataTable();
            dt = C.Listado();
            try
            {
                dgvCliente.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvCliente.Rows.Add(dt.Rows[i][0]);
                    dgvCliente.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dgvCliente.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dgvCliente.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dgvCliente.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dgvCliente.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dgvCliente.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dgvCliente.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dgvCliente.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                }
                dgvCliente.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrarFiltro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFiltraCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvCliente.ClearSelection();
            if (e.KeyChar == 13)
            {
                DataTable dt = new DataTable();
                C.NroDocIdentidad = tbFiltraCliente.Text;
                dt = C.BuscaClienteReceptor(C.NroDocIdentidad);
                try
                {
                    if (dgvCliente.Columns.Count > 0)
                    {
                        dgvCliente.Columns[0].Visible = false;
                    }
                    dgvCliente.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgvCliente.Rows.Add(dt.Rows[i][0]);
                        dgvCliente.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        dgvCliente.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        dgvCliente.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                        dgvCliente.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                        dgvCliente.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                        dgvCliente.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                        dgvCliente.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                        dgvCliente.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    }
                    dgvCliente.ClearSelection();
                    timer1.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                ListarClientes();
                timer1.Start();
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.Rows.Count > 0)
            {
                dgvCliente.Rows[dgvCliente.CurrentRow.Index].Selected = true;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Listado)
            {
                case 0: ListarClientes(); break;
            }
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
