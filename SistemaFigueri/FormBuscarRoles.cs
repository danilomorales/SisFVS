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
    public partial class FormBuscarRoles : MaterialSkin.Controls.MaterialForm
    {
        public List<DataRow> list { get; set; }
        public String nomRol { get; set; }
        public int idrol { get; set; }
        DataTable tabla = new DataTable();
        public FormBuscarRoles()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void FormBuscarRoles_Load(object sender, EventArgs e)
        {
            cargarRoles(dgvRoles);
            dgvRoles.Columns["nomRol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void cargarRoles(DataGridView dgv)
        {
            try
            {
                CNUsuario objUsuario = new CNUsuario();
                SqlDataAdapter adapter = objUsuario.listarRoles();
                foreach (DataRow row in tabla.Rows)
                {
                    list.Add((DataRow)row);
                }
                adapter.Fill(tabla);
                dgv.DataSource = tabla;

                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla usuario perfil: " + ex.ToString());
            }

        }

        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String rol = dgvRoles.Rows[e.RowIndex].Cells["nomRol"].Value.ToString();
            String id = dgvRoles.Rows[e.RowIndex].Cells[0].Value.ToString();
            //usuario = String.Format("Whatever default text there is {0}", nombres);
            //MessageBox.Show(id);
            nomRol = "Rol:  " + rol ;
            idrol = Int32.Parse(id);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
