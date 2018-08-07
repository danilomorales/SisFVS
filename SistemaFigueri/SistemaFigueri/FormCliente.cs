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

namespace SistemaFigueri
{
    public partial class FormCliente : Form
    {
        CNClientes cli = new CNClientes();
        public FormCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormMantCliente formMC = new FormMantCliente();
            formMC.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.SelectedRows.Count > 0)
                {
                    FormUpdateCliente formUP = new FormUpdateCliente();
                    //formUP.listarTienda();
                    formUP.listarSector();
                    formUP.listarDocumento();
                    formUP.idCliente = dgvCliente.CurrentRow.Cells["IdCliente"].Value.ToString();
                    formUP.cboeditienda.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                    formUP.cboedisector.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                    formUP.bmediempresa.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                    formUP.bmedidireccion.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                    formUP.bmedinombreCliente.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
                    formUP.bmeditelefono.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
                    formUP.bmedifax.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
                    formUP.bmediruc.Text = dgvCliente.CurrentRow.Cells[8].Value.ToString();
                    formUP.bmedicorreo.Text = dgvCliente.CurrentRow.Cells[9].Value.ToString();
                    formUP.cboedidocumento.Text = dgvCliente.CurrentRow.Cells[10].Value.ToString();
                    formUP.bmedinumerodoc.Text = dgvCliente.CurrentRow.Cells[11].Value.ToString();
                    formUP.bmediobservacion.Text = dgvCliente.CurrentRow.Cells[12].Value.ToString();
                    formUP.datediInscripcion.Text = dgvCliente.CurrentRow.Cells[13].Value.ToString();
                    formUP.cboediestado.Text = dgvCliente.CurrentRow.Cells[14].Value.ToString();
                    formUP.bmedictacte.Text = dgvCliente.CurrentRow.Cells[15].Value.ToString();
                    formUP.bmedinivel.Text = dgvCliente.CurrentRow.Cells[16].Value.ToString();
                    formUP.datediNacimiento.Text = dgvCliente.CurrentRow.Cells[17].Value.ToString();
                    formUP.bmeditipocompra.Text = dgvCliente.CurrentRow.Cells[18].Value.ToString();
                    formUP.bmedicredito.Text = dgvCliente.CurrentRow.Cells[19].Value.ToString();
                    formUP.bmediqueja.Text = dgvCliente.CurrentRow.Cells[20].Value.ToString();
                    formUP.bmedisaldo.Text = dgvCliente.CurrentRow.Cells[21].Value.ToString();
                    formUP.bmediordencliente.Text = dgvCliente.CurrentRow.Cells[22].Value.ToString();
                    formUP.cboedicliente.Text = dgvCliente.CurrentRow.Cells[23].Value.ToString();
                    formUP.bmedipromedioventas.Text = dgvCliente.CurrentRow.Cells[24].Value.ToString();
                    formUP.bmedicta_cli.Text = dgvCliente.CurrentRow.Cells[25].Value.ToString();
                    formUP.ShowDialog();
                    MostrarClientes();

                }
                else
                    MessageBox.Show("Selecciones una fila por favor");
            }
            catch(Exception ex)
            {
                MessageBox.Show("no mostro nada" + ex);
            }
            //FormUpdateCliente forUC = new FormUpdateCliente();
            //forUC.ShowDialog();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                //FormUpdateProducto formUP = new FormUpdateProducto();
                // formUP.idProducto = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
                cli.DeleteClient(dgvCliente.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("¿Estas seguro de eliminar este Cliente?");
                MostrarClientes();

            }
            else
                MessageBox.Show("Selecciones una fila por favor");
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        public void MostrarClientes()
        {
            dgvCliente.DataSource = cli.MostarClientes();
        }

        private void bmBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from caja.CLIENTE where NombreEmpresa like('" + bmBuscar.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCliente.DataSource = dt;
            Conexion.Close();
        }
    }
}
