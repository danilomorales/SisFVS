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
    public partial class FormPrincipalPage : Form
    {
        public FormPrincipalPage()
        {
            InitializeComponent();
        }

        private void FormPrincipalPage_Load(object sender, EventArgs e)
        {

        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            //lbFecha.Text = DateTime.Now.ToLongDateString();
            //lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
