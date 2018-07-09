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
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        private void btnVenCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void TbBuscarcliente_Enter(object sender,EventArgs e)
        {
            if(tbBuscarcliente.Text == "Buscar Cliente")
            {
                tbBuscarcliente.Text = "";
                tbBuscarcliente.ForeColor = Color.WhiteSmoke;
            }

        }
        private void TbBuscarcliente_Leave(object sender, EventArgs e)
        {
            if (tbBuscarcliente.Text == "")
            {
                tbBuscarcliente.Text = "Buscar Cliente";
                tbBuscarcliente.ForeColor = Color.DimGray;
            }
        }

        private void tbBuscarcliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
