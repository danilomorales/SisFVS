using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;
using BunifuAnimatorNS;
using Bunifu.Framework.Lib;
using Bunifu.Framework.UI;


namespace SistemaFigueri
{
    public partial class FormMantCliente : MaterialSkin.Controls.MaterialForm
    {
        public FormMantCliente()
        {
            InitializeComponent();
        }

        private void btnCancelarMant_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox11_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantCliente_Load(object sender, EventArgs e)
        {
            LlenarItems li = new LlenarItems();
            li.llenarTienda(cbotienda);
            li.llenarSector(cbosector);
            li.llenarTipoDoc(cbodocumento); 
        }       


        private void cbotienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
