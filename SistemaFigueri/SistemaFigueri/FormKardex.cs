using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace SistemaFigueri
{
    public partial class FormKardex : Form
    {
        public FormKardex()
        {
            InitializeComponent();

        }
        CNKardex car = new CNKardex();
        public string idProducto;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void FormKardex_Load(object sender, EventArgs e)
        {
            mostarProductos();
            //bmnombre.Text = dgvKardex.CurrentRow.Cells["Nombres"].Value.ToString();
            //bmcargo.Text = dgvKardex.CurrentRow.Cells["Apellidos"].Value.ToString();
        }

        public void mostarProductos()
        {
            dgvKardex.DataSource = car.MostarKardex(idProducto);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {

        }

        private void bmnombre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bmproducto_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
