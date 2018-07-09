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
    public partial class FormMantProducto : Form
    {
        public FormMantProducto()
        {
            InitializeComponent();
        }

        private void btnMPCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
