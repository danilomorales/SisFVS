using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaFigueri
{
    public partial class FormMantCliente : Form
    {
        public FormMantCliente()
        {
            InitializeComponent();
        }

        private void btnCancelarMant_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
