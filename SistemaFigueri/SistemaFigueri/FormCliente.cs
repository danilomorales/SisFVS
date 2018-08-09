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
        DataTable tabla = new DataTable();
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

                    formUP.listarPersona();
                    formUP.listarSector();
                    formUP.listarDocumento();
                    //formUP.ListarDepartamento();
                    //formUP.ListarProvincia("depa");
                    //formUP.ListarDistrito("provi");   
                    formUP.idRecpCliente = dgvCliente.CurrentRow.Cells["IdClienteReceptor"].Value.ToString();
                    formUP.cboedidocumento.Text = dgvCliente.CurrentRow.Cells["Tipo de Documento"].Value.ToString();
                    formUP.cboediPersona.Text = dgvCliente.CurrentRow.Cells["Tipo de Persona"].Value.ToString();
                    formUP.bmedinumerodoc.Text = dgvCliente.CurrentRow.Cells["Nro de Documento"].Value.ToString();
                    formUP.bmediruc.Text = dgvCliente.CurrentRow.Cells["Nro de RUC"].Value.ToString();
                    formUP.bmedirazonSocial.Text = dgvCliente.CurrentRow.Cells["Razón Social"].Value.ToString();
                    formUP.bmedinombreComercial.Text = dgvCliente.CurrentRow.Cells["Nombre Comercial"].Value.ToString();
                    formUP.bmedinombreCliente.Text = dgvCliente.CurrentRow.Cells["Nombres"].Value.ToString();
                    formUP.bmediapellidoP.Text = dgvCliente.CurrentRow.Cells["Apellido Paterno"].Value.ToString();
                    formUP.bmediapellidoM.Text = dgvCliente.CurrentRow.Cells["Apellido Materno"].Value.ToString();                                                                                                       
                    formUP.bmedicorreo.Text = dgvCliente.CurrentRow.Cells["Correo"].Value.ToString();
                    formUP.bmedidireccion.Text = dgvCliente.CurrentRow.Cells["Dirección"].Value.ToString();
                    formUP.bmedifax.Text = dgvCliente.CurrentRow.Cells["Fax"].Value.ToString();
                    formUP.bmedifijo.Text = dgvCliente.CurrentRow.Cells["Fijo"].Value.ToString();
                    formUP.bmeditelefono.Text = dgvCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                    formUP.dateediNacimiento.Text = dgvCliente.CurrentRow.Cells["Fecha de Nacimiento"].Value.ToString();
                    formUP.cboedidepartamento.Text = dgvCliente.CurrentRow.Cells["Departamento"].Value.ToString();
                    formUP.cboediprovincia.Text = dgvCliente.CurrentRow.Cells["Provincia"].Value.ToString();
                    formUP.cboedidistrito.Text = dgvCliente.CurrentRow.Cells["Distrito"].Value.ToString();
                    formUP.bmediUsuRegistra.Text = dgvCliente.CurrentRow.Cells["Usuario Registra"].Value.ToString();
                    formUP.dateediInscripcion.Text = dgvCliente.CurrentRow.Cells["Fecha de Registro"].Value.ToString();
                    formUP.bmediUserModifica.Text = dgvCliente.CurrentRow.Cells["Usuario Modifica"].Value.ToString();
                    formUP.dtedifechaModifica.Text = dgvCliente.CurrentRow.Cells["Fecha Modifica"].Value.ToString();
                    formUP.cboedisector.Text = dgvCliente.CurrentRow.Cells["Sector"].Value.ToString();
                    formUP.bmediobservacion.Text = dgvCliente.CurrentRow.Cells["Observación"].Value.ToString();
                    formUP.ShowDialog();
                    MostrarClientes();

                }
                else
                    MessageBox.Show("Selecciones una fila por favor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no mostro nada" + ex.ToString());
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
                //this.Close();
                Refresh();
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
            cmd.CommandText = " select * from Caja.ClienteReceptor where Nombres like('" + bmBuscar.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCliente.DataSource = dt;
            Conexion.Close();
          
        }

        public void actualizar()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataset = new DataTable();
            dataset.Clear();
            dataAdapter.Fill(dataset);
            
        }

        private void bmBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataView dv = tabla.DefaultView;
            //dv.RowFilter = string.Format("'Nombres' like '%{0}%' or ' Correo' like '%{0}%' or 'Telefono' like '%{0}%'", bmBuscar.Text);
        }
    }
}
