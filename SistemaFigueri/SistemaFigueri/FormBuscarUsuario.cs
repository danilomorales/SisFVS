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
    public partial class FormBuscarUsuario : MaterialSkin.Controls.MaterialForm
    {
  
        int cellnum = 0;
        int rownum = 0;
        public List<DataRow> list { get; set; }
        public String usuario { get; set; }
        DataTable tabla = new DataTable();
        
        public FormBuscarUsuario()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void dgvUsuarios_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvUsuarios.Rows[e.RowIndex].Cells["Nº"].Value = (e.RowIndex + 1).ToString();
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {
            cargarPerfiles(dgvUsuarios);
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[1].Visible = false;
            dgvUsuarios.Columns["foto"].Visible = false;
            dgvUsuarios.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["ApellidoPaterno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["ApellidoMaterno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Login"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dgvUsuarios.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dgvUsuarios.Columns.Add("Nº", "Nº");
            this.dgvUsuarios.Columns["Nº"].Width = 30;
            this.dgvUsuarios.Columns["Nº"].DisplayIndex = 0;
            dgvUsuarios.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /*foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                cellnum = cellnum + 1;

                dgvUsuarios.Rows[rownum].Cells["Nº"].Value = rownum.ToString();
                rownum = rownum + 1;
            }
            Console.WriteLine("Filas " + rownum);*/

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
                /*dgvUsuarios.Columns["foto"].Width = 60;
                dgvUsuarios.RowTemplate.Height = 120;
                DataGridViewImageColumn imagen = new DataGridViewImageColumn();
                ((DataGridViewImageColumn)this.dgvUsuarios.Columns["foto"]).DefaultCellStyle.NullValue = null;
                imagen = (DataGridViewImageColumn)dgvUsuarios.Columns["foto"];
                imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla usuario perfil: " + ex.ToString());
            }

        }

        private void tbrolUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = tabla.DefaultView;
            dv.RowFilter = string.Format("Login like '%{0}%' or Nombres like '%{0}%' or ApellidoPaterno like '%{0}%'", tbrolUsu.Text);
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPerfiles perfiles = new FormPerfiles();
            
            String nombres = dgvUsuarios.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
            String pat = dgvUsuarios.Rows[e.RowIndex].Cells["ApellidoPaterno"].Value.ToString();
            String mat = dgvUsuarios.Rows[e.RowIndex].Cells["ApellidoMaterno"].Value.ToString();
            String usu = dgvUsuarios.Rows[e.RowIndex].Cells["Login"].Value.ToString();
            String id = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            //usuario = String.Format("Whatever default text there is {0}", nombres);
            usuario = nombres + " " + pat + " " + mat + "  - usuario: " + usu;
            this.DialogResult = DialogResult.OK;
            this.Close();
            /*MessageBox.Show("Valor: " + pat);
            MessageBox.Show("Valor: " + mat);
            MessageBox.Show("Valor: " + usu);
            MessageBox.Show("Valor: " + id);*/

        }
    }
}
