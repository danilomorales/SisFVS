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
        public List<DataRow> list { get; set; }
        DataTable tabla;
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


            using (FormMantCliente formMC = new FormMantCliente())
            {

                if (formMC.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MostrarClientes();
                }
            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.SelectedRows.Count > 0)
                {
                    using (FormUpdateCliente formUP = new FormUpdateCliente())
                    {
                        formUP.listarTienda();
                        formUP.listarSector();
                        formUP.listarDocumento();
                        formUP.listarPersona();
                        formUP.idCliente = dgvCliente.CurrentRow.Cells["IdCliente"].Value.ToString();
                        formUP.bmedinombreCliente.Text = dgvCliente.CurrentRow.Cells["Nombres"].Value.ToString();
                        formUP.bmediapellidoP.Text = dgvCliente.CurrentRow.Cells["Apellido Paterno"].Value.ToString();
                        formUP.bmediapellidoM.Text = dgvCliente.CurrentRow.Cells["Apellido Materno"].Value.ToString();
                        formUP.cboedidocumento.Text = dgvCliente.CurrentRow.Cells["Nombre de la Tienda"].Value.ToString();
                        formUP.cboedisector.Text = dgvCliente.CurrentRow.Cells["Nombre del sector"].Value.ToString();
                        formUP.bmedinombreEmpresa.Text = dgvCliente.CurrentRow.Cells["Nombre de la Empresa"].Value.ToString();
                        formUP.bmedireccion.Text = dgvCliente.CurrentRow.Cells["Dirección"].Value.ToString();
                        formUP.bmedicontacto.Text = dgvCliente.CurrentRow.Cells["Contacto"].Value.ToString();
                        formUP.bmeditelefono.Text = dgvCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                        formUP.bmedifax.Text = dgvCliente.CurrentRow.Cells["Fax"].Value.ToString();
                        formUP.bmediruc.Text = dgvCliente.CurrentRow.Cells["RUC"].Value.ToString();
                        formUP.bmedicorreo.Text = dgvCliente.CurrentRow.Cells["Email"].Value.ToString();
                        formUP.cboeditipoPersona.Text = dgvCliente.CurrentRow.Cells["Tipo de persona"].Value.ToString();
                        formUP.cboedidocumento.Text = dgvCliente.CurrentRow.Cells["Tipo de Documento"].Value.ToString();
                        formUP.bmedinumerodoc.Text = dgvCliente.CurrentRow.Cells["N° de Documento"].Value.ToString();
                        formUP.bmediobservacion.Text = dgvCliente.CurrentRow.Cells["Observación"].Value.ToString();
                        formUP.dateedinscripcion.Value = DateTime.Parse(dgvCliente.CurrentRow.Cells["Inscripción"].Value.ToString());
                        formUP.datediNacimiento.Value = DateTime.Parse(dgvCliente.CurrentRow.Cells["Fecha de Nacimiento"].Value.ToString());
                        formUP.bmedicredito.Text = dgvCliente.CurrentRow.Cells["Credito"].Value.ToString();
                        formUP.cboeditipoCliente.Text = dgvCliente.CurrentRow.Cells["Tipo de Cliente"].Value.ToString();
                        formUP.cboedidepartamento.Text = dgvCliente.CurrentRow.Cells["Departamento"].Value.ToString();
                        formUP.cboediprovincia.Text = dgvCliente.CurrentRow.Cells["Provincia"].Value.ToString();
                        formUP.cboedidistrito.Text = dgvCliente.CurrentRow.Cells["Distrito"].Value.ToString();
                        formUP.bmediuserRegistra.Text = dgvCliente.CurrentRow.Cells["Usuario que registra"].Value.ToString();
                        //formUP.datedimodificacion.Value = DateTime.Parse(dgvCliente.CurrentRow.Cells["Fecha que Modifica"].Value.ToString());
                        if (formUP.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            MostrarClientes();
                        }
                    }                  
                }
                else
                    MessageBox.Show("Selecciones una fila por favor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no mostro nada" + ex.ToString());
            }
            
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
            
            
            SqlDataAdapter adapter = cli.MostarClientes();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }
          
            adapter.Fill(tabla);
            dgvCliente.DataSource = tabla;
            adapter.Dispose();
            dgvCliente.Columns[0].Visible = false;
            dgvCliente.Columns[10].Visible = false;
            dgvCliente.Columns[13].Visible = false;
            dgvCliente.Columns[17].Visible = false;
            dgvCliente.Columns[18].Visible = false;
            dgvCliente.Columns[19].Visible = false;
            dgvCliente.Columns[20].Visible = false;
            dgvCliente.Columns[21].Visible = false;
            dgvCliente.Columns[22].Visible = false;
            dgvCliente.Columns[23].Visible = false;
            dgvCliente.Columns[24].Visible = false;
            dgvCliente.Columns[25].Visible = false;
            dgvCliente.Columns[26].Visible = false;
            dgvCliente.Columns[27].Visible = false;
            //dgvCliente.Columns[28].Visible = false;
            //plist = new PagedList<DataRow>(list);
        }

        private void bmBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.05;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select c.IdCliente,c.Nombres,c.ApellidoPaterno as 'Apellido Paterno'," +
                "c.ApellidoMaterno as 'Apellido Materno',t.NombreTienda as 'Nombre de la Tienda'," +
                "s.DescripcionSector as 'Nombre del Sector',c.NombreEmpresa as 'Nombre de la Empresa'," +
                "c.Direccion as 'Dirección',c.Contacto,c.Telefono,c.Fax,c.RUC,c.Email," +
                "p.Descripcion as 'Tipo de persona',d.Descripcion as 'Tipo de Documento'," +
                "c.NroDocumento as 'N° de Documento',c.Observacion as 'Observación'," +
                "c.Inscripcion as 'Inscripción',c.Estado,c.FechaNac as 'Fecha de Nacimiento'," +
                "c.Credito,c.TipoCliente as 'Tipo de Cliente',c.Departamento,c.Provincia," +
                "c.Distrito,c.UsuarioRegistra as 'Usuario que registra',c.UsuarioModifica as 'Usuario que modifica'," +
                "c.FechaModifica as 'Fecha que Modifica'from caja.CLIENTE c, caja.TIENDA t, caja.SECTOR s," +
                " caja.TIPO_DOC_IDENT d, caja.TipoPersona p where (c.NroDocumento like ('%" + bmBuscar.Text + "%')" +
                "or c.Nombres like ('%" + bmBuscar.Text + "%')or c.ApellidoPaterno like ('%" + bmBuscar.Text + "%')" +
                "or c.ApellidoMaterno like ('%" + bmBuscar.Text + "%')or d.Descripcion like ('%" + bmBuscar.Text + "%')) " +
                "and c.IdTienda = t.IdTienda and c.IdSector = s.IdSector " +
                "and c.IdTipoDocIdent = d.IdTipoDocIdent and c.IdTipoPersona = p.IdTipoPersona ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCliente.DataSource = dt;
            Conexion.Close();
        }
       
    }
}
