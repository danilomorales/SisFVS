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
    public partial class FormUpdateSector : Form
    {
        public FormUpdateSector()
        {
            InitializeComponent();
        }

        CNSector cnsec = new CNSector();
        public string idSector;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void bmedidescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void bmedinota_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
        

        private void btnguardarPro_Click(object sender, EventArgs e)
        {
            try
            {
                cnsec.UpdateSector(idSector, bmedidescripcion.Text.ToString(), bmedinota.Text.ToString(), bmediporcentaje.Text.ToString());
                MessageBox.Show("Se edito correctamente el Sector");
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Actualizar los datos por :" + ex.ToString());
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
