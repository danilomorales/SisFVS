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
                        formUP.idCliente = dgvCliente.CurrentRow.Cells["IdCliente"].Value.ToString();
                        formUP.bmedinombreCliente.Text = dgvCliente.CurrentRow.Cells["Nombres"].Value.ToString();
                        formUP.bmediapellidoP.Text = dgvCliente.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();
                        formUP.bmediapellidoM.Text = dgvCliente.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();
                        formUP.cboedidocumento.Text = dgvCliente.CurrentRow.Cells["Nombre de la Tienda"].Value.ToString();
                        formUP.cboedisector.Text = dgvCliente.CurrentRow.Cells["Nombre del sector"].Value.ToString();
                        formUP.bmedinombreEmpresa.Text = dgvCliente.CurrentRow.Cells["Nombre de la Empresa"].Value.ToString();
                        formUP.bmedireccion.Text = dgvCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                        formUP.bmedicontacto.Text = dgvCliente.CurrentRow.Cells["Nombre del Contacto"].Value.ToString();
                        formUP.bmeditelefono.Text = dgvCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                        formUP.bmedifax.Text = dgvCliente.CurrentRow.Cells["Fax"].Value.ToString();
                        formUP.bmediruc.Text = dgvCliente.CurrentRow.Cells["RUC"].Value.ToString();
                        formUP.bmedicorreo.Text = dgvCliente.CurrentRow.Cells["Correo"].Value.ToString();
                        formUP.cboedidocumento.Text = dgvCliente.CurrentRow.Cells["Documento"].Value.ToString();
                        formUP.bmedinumerodoc.Text = dgvCliente.CurrentRow.Cells["Nr° del Documento"].Value.ToString();
                        formUP.bmediobservacion.Text = dgvCliente.CurrentRow.Cells["Observación"].Value.ToString();
                        formUP.cboedidepartamento.Text = dgvCliente.CurrentRow.Cells["Departamento"].Value.ToString();
                        formUP.cboediprovincia.Text = dgvCliente.CurrentRow.Cells["Provincia"].Value.ToString();
                        formUP.cboedidistrito.Text = dgvCliente.CurrentRow.Cells["Distrito"].Value.ToString();
                        formUP.bmediuserRegistra.Text = dgvCliente.CurrentRow.Cells["Usuario que Registra"].Value.ToString();
                        formUP.datedinscripcion.Text = dgvCliente.CurrentRow.Cells["Inscripción"].Value.ToString();
                        formUP.bmedicorriente.Text = dgvCliente.CurrentRow.Cells["Cuenta Corriente"].Value.ToString();
                        formUP.datediNacimiento.Text = dgvCliente.CurrentRow.Cells["Fecha de Nacimiento"].Value.ToString();
                        formUP.bmeditipoCompra.Text = dgvCliente.CurrentRow.Cells["Tipo de Compra"].Value.ToString();
                        formUP.bmedicredito.Text = dgvCliente.CurrentRow.Cells["Credito"].Value.ToString();
                        formUP.bmediqueja.Text = dgvCliente.CurrentRow.Cells["Queja"].Value.ToString();
                        formUP.bmediordenCliente.Text = dgvCliente.CurrentRow.Cells["Orden del Cliente"].Value.ToString();
                        formUP.bmedipromedioVentas.Text = dgvCliente.CurrentRow.Cells["Promedio de ventas"].Value.ToString();
                        formUP.bmedicta_cli.Text = dgvCliente.CurrentRow.Cells["cta_cli"].Value.ToString();
                        formUP.bmediuserModi.Text = dgvCliente.CurrentRow.Cells["UsuarioModifica"].Value.ToString();
                        formUP.datediModificacion.Text = dgvCliente.CurrentRow.Cells["FechaModifica"].Value.ToString();
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
            
            
            SqlDataAdapter adapter = cli.MostarClientes();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }

            //plist = new PagedList<DataRow>(list);
            adapter.Fill(tabla);
            dgvCliente.DataSource = tabla;
            /*dgvPerfiles.Columns["foto"].Width = 60;
            dgvPerfiles.RowTemplate.Height = 120;
            DataGridViewImageColumn imagen = new DataGridViewImageColumn();
            ((DataGridViewImageColumn)this.dgvPerfiles.Columns["foto"]).DefaultCellStyle.NullValue = null;
            imagen = (DataGridViewImageColumn)dgvPerfiles.Columns["foto"];
            imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
            adapter.Dispose();
        }

        private void bmBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select c.IdClienteReceptor,c.Nombres,c.ApellidoPaterno as 'Apellido Paterno',c.ApellidoMaterno as 'Apellido Materno',p.Descripcion as 'Tipo de Persona'," +
                "t.Nombre as 'Tipo de Documento',c.NroDocIdentidad as 'Nro de Documento',c.NumeroRuc as 'Nro de RUC',c.RazonSocial as 'Razón Social',c.NombreComercial as 'Nombre Comercial'," +
                "c.Correo,c.Direccion as 'Dirección',c.Fax,c.Fijo,c.Telefono,c.FechaNacimiento as 'Fecha de Nacimiento',c.Departamento,c.Provincia,c.Distrito,c.Estado" +
                ",c.UsuarioRegistra as 'Usuario Registra',c.FechaRegistro as 'Fecha de Registro',c.UsuarioModifica as 'Usuario Modifica',c.FechaModifica as 'Fecha Modifica'," +
                "s.DescripcionSector as 'Sector',c.Observacion as 'Observación'from caja.ClienteReceptor c,caja.TipoPersona p, caja.SECTOR s, caja.DocIdentidad t " +
                "where c.IdTipoPersona = p.IdTipoPersona and c.IdSector = s.IdSector and c.IdDocIdentidad = t.IdDocIdentidad and NroDocIdentidad " +
                "like ('%" + bmBuscar.Text + "%')   ";
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
