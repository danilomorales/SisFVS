﻿using System;
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
            
            
            SqlDataAdapter adapter = cli.MostarClientes();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }

            adapter.Fill(tabla);
            dgvCliente.DataSource = tabla;           
            adapter.Dispose();
        }

        private void bmBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select c.IdCliente,c.Nombres,c.ApellidoPaterno,c.ApellidoMaterno,t.NombreTienda as 'Nombre de la Tienda'," +
                "s.DescripcionSector as 'Nombre del sector',c.NombreEmpresa as 'Nombre de la Empresa',c.Direccion,c.Contacto as 'Nombre del Contacto'," +
                "c.Telefono,c.Fax,c.RUC,c.Email as 'Correo',d.Descripcion 'Documento',c.NroDocumento as 'Nr° del Documento',c.Observacion as 'Observación'," +
                "c.Departamento,c.Provincia,c.Distrito,c.UsuarioRegistra as'Usuario que Registra',c.Inscripcion as 'Inscripción',c.Estado," +
                "c.SaldoCtaCte as 'Cuenta Corriente',c.Nivel,c.FechaNac as 'Fecha de Nacimiento',c.TipoCompra as 'Tipo de Compra',c.Credito," +
                "c.Queja,c.EstSaldoIni as 'Estado Inicial',c.OrdenCliente as 'Orden del Cliente',c.PromedioDeVentas as 'Promedio de ventas',c.cta_cli," +
                "c.UsuarioModifica,c.FechaModifica from caja.CLIENTE c, dbo.TIENDA t, dbo.SECTOR s, dbo.TIPO_DOC_IDENT d where c.IdTienda = t.IdTienda AND" +
                " c.IdSector = s.IdSector and c.IdTipoDocIdent = d.IdTipoDocIdent" +
                " AND CONCAT (NroDocumento,'',RUC,'',Nombres,'',ApellidoPaterno,'',ApellidoMaterno,'',Descripcion,'') LIKE ('%"+bmBuscar.Text+"%')";
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
    }
}
