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

namespace SistemaFigueri
{
    public partial class FormProductos : Form
    {
        CNProductos cp = new CNProductos();

        public FormProductos()
        {
            InitializeComponent();
           
        }


        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormInsertProducto formMP = new FormInsertProducto();
            formMP.ShowDialog();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            mostarProductos();

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            FormUpdateProducto formUP = new FormUpdateProducto();
            formUP.ShowDialog();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estas seguro de eliminar este producto?");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void mostarProductos()
       {
            dgvProductos.DataSource = cp.MostarProductos();
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
