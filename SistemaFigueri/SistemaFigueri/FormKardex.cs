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
    public partial class FormKardex : MaterialSkin.Controls.MaterialForm
    {
        public FormKardex()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manejoSki = MaterialSkin.MaterialSkinManager.Instance;
            manejoSki.AddFormToManage(this);
            manejoSki.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            manejoSki.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue800,
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Blue100,
                MaterialSkin.Accent.Yellow200,
                MaterialSkin.TextShade.WHITE);
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
    }
}
