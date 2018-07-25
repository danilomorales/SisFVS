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
    public partial class FormUpdateCliente : Form
    {
        public FormUpdateCliente()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpdateCliente_Load(object sender, EventArgs e)
        {
            LlenarItems li = new LlenarItems();
            li.llenarTienda(cbotienda);
            li.llenarSector(cbosector);
            li.llenarTipoDoc(cbodocumento);
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
