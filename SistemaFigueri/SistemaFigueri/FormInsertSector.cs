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
    public partial class FormInsertSector : Form
    {
        public FormInsertSector()
        {
            InitializeComponent();
        }
        CNSector cnsec = new CNSector();
        FormSector forsec = new FormSector();       

       // LIMPIAR FORMULARIO
        private void limpiarForm()
        {
            bmdescripcion.Text = "";
            bmnota.Text = "";
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

        private void bmdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void bmnota_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
      

        private void bmCancelarSec_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardarPro_Click(object sender, EventArgs e)
        {
            try
            {

                cnsec.InsertSector(bmdescripcion.Text, bmnota.Text, bmporcentaje.Text);
                MessageBox.Show("Se inserto correctamente el Sector");
                this.Close();
                // cdpro.listarProductos();
                this.DialogResult = DialogResult.OK;
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
