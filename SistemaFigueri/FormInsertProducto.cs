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
using CapaDatos;


namespace SistemaFigueri
{

    public partial class FormInsertProducto : MaterialSkin.Controls.MaterialForm
    {
        CNProductos pro = new CNProductos();
        FormProductos formPro = new FormProductos();
        CDProductos cdpro = new CDProductos();

        public FormInsertProducto()
        {
            InitializeComponent();
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormInsertProducto_Load(object sender, EventArgs e)
        {
            listarCategoria();
            listarMedida();
        }

        //LLENAR COMBOBOX CATEGORIA
        private void listarCategoria()
        {
            CDProductos cdpor = new CDProductos();
            cbocategoria.DataSource = cdpor.ListarCategoria();
            cbocategoria.DisplayMember = "Descripcion";
            cbocategoria.ValueMember = "IdCategoria";

        }

        //LLENAR COMBOBOX MEDIDA
        private void listarMedida()
        {
            CDProductos cdpor = new CDProductos();
            cbomedida.DataSource = cdpor.ListarMedida();
            cbomedida.DisplayMember = "Descripcion";
            cbomedida.ValueMember = "IdMedida";

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
            else if(V.KeyChar.ToString().Equals("."))
            {
                V.Handled = true;
            }
        }

        private void bmnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void bmdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void bmtiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bminimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmvalorunitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDecimales(e);
        }

        private void bmprecio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDecimales(e);
        }

        private void bmprecio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDecimales(e);
        }

        private void bmoferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloDecimales(e);
        }

        private void bmnota_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void bmfactor_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bminicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmvigente_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmcta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {

        }

        private void bmcta_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bminicial_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {

        }

        private void btnguardarPro_Click_1(object sender, EventArgs e)
        {
            string fecha1 = dpduracion.Value.ToString("yyyy-MM-dd");
            try
            {

                pro.InsertProduct(bmnombre.Text,cbocategoria.SelectedValue.ToString(),cbomedida.SelectedValue.ToString(),bmdescripcion.Text,
                    fecha1,bmstock.Text,bmaximo.Text,bminimo.Text,bmvalorunitario.Text,bmprecio1.Text,bmprecio2.Text,bmoferta.Text,bmnota.Text,
                    bminicial.Text);
                MessageBox.Show("Se inserto correctamente");
                this.DialogResult = DialogResult.OK;
                this.Close();      
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
            }
        }

        private void limpiarForm()
        {
            bmnombre.Text = "";
            cbocategoria.Text = "";
            cbomedida.Text = "";
            bmdescripcion.Text = "";
            bmstock.Text = "";
            bmaximo.Text = "";
            bminimo.Text = "";
            bmvalorunitario.Text = "";
            bmprecio1.Text = "";
            bmprecio2.Text = "";
            bmoferta.Text = "";
            bmnota.Text = "";
            bminicial.Text = "";

        }
    }
}
