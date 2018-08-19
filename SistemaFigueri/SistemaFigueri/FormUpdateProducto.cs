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
    public partial class FormUpdateProducto : Form
    {
        public FormUpdateProducto()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
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
        public string idProducto;
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                cnProd.UpdateProduct(idProducto.ToString(), bmedinombre.Text, cboedicategoria.SelectedValue.ToString(), cboedimedida.SelectedValue.ToString(), bmedidescripcion.Text, bmeditiempo.Text, bmedistock.Text,
             bmedistockmax.Text, bmedistockmini.Text, bmedivalos_unitario.Text, bmediprecio1.Text, bmediprecio2.Text, bmediprecioOferta.Text, bmedinota.Text,
             bmedifactor.Text, cboediestado.Text, bmediItem.Text, bmedinicial.Text, bmedicta.Text);
                MessageBox.Show("Se edito correctamente");
                this.DialogResult = DialogResult.OK;
                this.Close();
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Actualizar los datos por :" + ex.ToString());
            }

        }

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

        private void bmedifactor_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmediItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmedinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void bmedicta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
    }
}
