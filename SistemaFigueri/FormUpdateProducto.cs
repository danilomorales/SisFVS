using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaDatos;
using CapaNegocio;


namespace SistemaFigueri
{
    public partial class FormUpdateProducto : MaterialSkin.Controls.MaterialForm
    {
        public FormUpdateProducto()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            MaterialSkin.MaterialSkinManager manejoSki = MaterialSkin.MaterialSkinManager.Instance;
            manejoSki.AddFormToManage(this);
            manejoSki.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manejoSki.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Orange100,
                MaterialSkin.Primary.Orange300,
                MaterialSkin.Primary.Orange100,
                MaterialSkin.Accent.Orange100,
                MaterialSkin.TextShade.BLACK);
        }

        CDProductos cdpro = new CDProductos();
        //arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hend, int wsmg, int wparam, int lparam);

        //CDProductos pro = new CDProductos();
        CNProductos cnProd = new CNProductos();
        FormProductos formPro = new FormProductos();
        public string idProducto = null;
        //public string idProducto { get; set; }
        public string fechita { get; set; }
              

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //LLENAR COMBOBOX DE CATEGORIA
        public void listarCategoria()
        {
            CDProductos cdpor = new CDProductos();
            cboedicategoria.DataSource = cdpor.ListarCategoria();
            cboedicategoria.DisplayMember = "Descripcion";
            cboedicategoria.ValueMember = "IdCategoria";

        }

        //LLENAR COMBOBOX DE MEDIDA
        public void listarMedida()
        {
            CDProductos cdpor = new CDProductos();
            cboedimedida.DataSource = cdpor.ListarMedida();
            cboedimedida.DisplayMember = "Descripcion";
            cboedimedida.ValueMember = "IdMedida";

        }

        //VALIDAR SOLO LETRAS
        public static void SoloLetras(KeyPressEventArgs V)
        {
            if (char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }
        }

        //VALIDAR SOLO NUMEROS
        public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }
        }

        //VALIDAR SOLO DECIMALES
        public static void SoloDecimales(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (V.KeyChar.ToString().Equals("."))
            {
                V.Handled = true;
            }
        }

        private void bmedinombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void bmedidescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void bmeditiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmedistock_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmedistockmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmedistockmini_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmedivalos_unitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDecimales(e);
        }

        private void bmediprecio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDecimales(e);
        }

        private void bmediprecio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDecimales(e);
        }

        private void bmediprecioOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDecimales(e);
        }

        private void bmedinota_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void bmedinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmedicta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void btnguardarPro_Click_1(object sender, EventArgs e)
        {
            string fecha1 = dpediduracion.Value.ToString("yyyy-MM-dd");
            MessageBox.Show("Formulario" + idProducto);
            try
            {
                cnProd.UpdateProduct(bmedinombre.Text, cboedicategoria.SelectedValue.ToString(), cboedimedida.SelectedValue.ToString(),
                    bmedidescripcion.Text, fecha1, bmedistock.Text, bmedistockmax.Text,
                    bmedistockmini.Text, bmedivalos_unitario.Text, bmediprecio1.Text,
                    bmediprecio2.Text, bmediprecioOferta.Text, bmedinota.Text,
                     bmedinicial.Text, idProducto);
                MessageBox.Show("IDDD" + idProducto);
                MessageBox.Show("Se edito correctamente");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo Actualizar los datos por :" + ex.ToString());
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
