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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                cnsec.UpdateSector(idSector.ToString(), bmedidescripcion.Text, bmedinota.Text);
                MessageBox.Show("Se edito correctamente el Sector");
                //formPro.mostarProductos();
                this.Close();
               // cdpro.listarProductos();
               // formPro.dgvProductos.Update();
               // formPro.dgvProductos.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Actualizar los datos por :" + ex.ToString());
            }
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
    }
}
