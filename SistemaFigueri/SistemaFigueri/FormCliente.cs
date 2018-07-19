using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFigueri
{
    public partial class FormCliente : Form
    {
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
            FormUpdateCliente forUC = new FormUpdateCliente();
            forUC.ShowDialog();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estas seguro de eliminar este Cliente?");
        }
    }
}
