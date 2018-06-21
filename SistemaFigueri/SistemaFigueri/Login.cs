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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if(tbUsuario.Text == "USUARIO")
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.LightGray;
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text =="")
            {
                tbUsuario.Text = "USUARIO";
                tbUsuario.ForeColor = Color.DimGray;
            }
        }

        private void tbContrasenna_Enter(object sender, EventArgs e)
        {
            if (tbContrasenna.Text == "CONTRASEÑA")
            {
                tbContrasenna.Text = "";
                tbContrasenna.ForeColor = Color.LightGray;
            }
        }

        private void tbContrasenna_Leave(object sender, EventArgs e)
        {
            if (tbContrasenna.Text == "")
            {
                tbContrasenna.Text = "CONTRASEÑA";
                tbContrasenna.ForeColor = Color.DimGray;
            }
        }
    }
}
