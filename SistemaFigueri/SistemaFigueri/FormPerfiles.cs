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
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dgv.DataSource = tabla;
            } catch (Exception ex) {
                MessageBox.Show("No se pudo llenar la tabla usuario perfil: " + ex.ToString());
            }

        }

        private void FormPerfiles_Load(object sender, EventArgs e)
        {
            cargarPerfiles(dgvPerfiles);
            dgvPerfiles.Columns[0].Visible = false;
            dgvPerfiles.Columns[1].Visible = false;
            dgvPerfiles.Columns[2].Visible = false;
         
   

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormNuevoPerfil formMC = new FormNuevoPerfil();
            formMC.ShowDialog();
        }
    }
}
