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
    public partial class FormPerfiles : Form
    {
        int pageNumber = 1;
        public List<DataRow> list { get; set; }
        DataTable tabla = new DataTable();
        public FormPerfiles()
        {
            InitializeComponent();

        }


        public void cargarPerfiles(DataGridView dgv)
        {
            try
            {
                CNUsuario objUsuario = new CNUsuario();
                SqlDataAdapter adapter = objUsuario.cargarPerfiles();
                foreach (DataRow row in tabla.Rows)
                {
                    list.Add((DataRow)row);
                }
             
                //plist = new PagedList<DataRow>(list);
                adapter.Fill(tabla);
                dgv.DataSource = tabla;
                dgvPerfiles.Columns["foto"].Width = 60;
                dgvPerfiles.RowTemplate.Height = 120;
                DataGridViewImageColumn imagen = new DataGridViewImageColumn();
                imagen = (DataGridViewImageColumn)dgvPerfiles.Columns["foto"];
                imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;
                adapter.Dispose();
            } catch (Exception ex) {
                MessageBox.Show("No se pudo llenar la tabla usuario perfil: " + ex.ToString());
            }

        }

        

        private void FormPerfiles_Load(object sender, EventArgs e)
        {
            /*dgvPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;*/
            cargarPerfiles(dgvPerfiles);
            dgvPerfiles.Columns[0].Visible = false;
            dgvPerfiles.Columns[1].Visible = false;
            dgvPerfiles.Columns[2].Visible = false;
                        dgvPerfiles.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["ApellidoPaterno"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["ApellidoMaterno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["Login"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //((DataGridViewImageColumn)dgvPerfiles.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            int cellnum = 0;
            int rownum = 0;
            foreach(DataGridViewRow row in dgvPerfiles.Rows)
            {
                cellnum = cellnum +1;

                dgvPerfiles.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
            }

            foreach (DataGridViewColumn column in dgvPerfiles.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dgvPerfiles.Columns.Add("Nº", "Nº");
            this.dgvPerfiles.Columns["Nº"].Width = 20;
            this.dgvPerfiles.Columns["Nº"].DisplayIndex = 0;
            dgvPerfiles.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            


        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                DataView dv = tabla.DefaultView;
                dv.RowFilter = string.Format("Login like '%{0}%' or Nombres like '%{0}%' or ApellidoPaterno like '%{0}%'", txtSearch.Text);
         
        }

        private void dgvPerfiles_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            this.dgvPerfiles.Rows[e.RowIndex].Cells["Nº"].Value = (e.RowIndex + 1).ToString();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgUsuarios);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgRoles);
        }

        private void btnPrivilegios_Click(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgPrivilegios);
        }
        

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgUsuarios);
        }

        private void btnRoles_Click_1(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgRoles);
        }

        private void btnPrivilegios_Click_1(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgPrivilegios);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormNuevoPerfil formMC = new FormNuevoPerfil();
            formMC.ShowDialog();
        }
    }
}
