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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormMantProducto formMP = new FormMantProducto();
            formMP.ShowDialog();
        }

        private void btnCerrarListProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }

   
}
