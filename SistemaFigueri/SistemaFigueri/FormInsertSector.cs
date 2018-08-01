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
        private void bmCancelarSec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardarSec_Click(object sender, EventArgs e)
        {
            try
            {

                cnsec.InsertSector(bmdescripcion.Text,bmnota.Text);
                MessageBox.Show("Se inserto correctamente");
                this.Close();
                // cdpro.listarProductos();
                forsec.mostarSector();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
            }
        }

        //LIMPIAR FORMULARIO
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
    }
}
