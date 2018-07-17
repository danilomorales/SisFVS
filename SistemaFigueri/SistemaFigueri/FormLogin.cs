using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using System.Data.SqlClient;
using System.Data;

namespace SistemaFigueri
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hend, int wsmg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAceder_Click(object sender, EventArgs e)
        {

        }

        //private void tbUsuario_Enter(object sender, EventArgs e)
        //{
        //    if(ss.Text == "USUARIO")
        //    {
        //        ss.Text = "";
        //        ss.ForeColor = Color.WhiteSmoke;
        //    }
        //}

        //private void tbUsuario_Leave(object sender, EventArgs e)
        //{
        //    if (ss.Text =="")
        //    {
        //        ss.Text = "USUARIO";
        //        ss.ForeColor = Color.DimGray;
        //    }
        //}

        //private void tbContrasenna_Enter(object sender, EventArgs e)
        //{
        //    if (x.Text == "CONTRASEÑA")
        //    {
        //        x.Text = "";
        //        x.ForeColor = Color.WhiteSmoke;
        //        x.UseSystemPasswordChar = true;
        //    }
        //}

        //private void tbContrasenna_Leave(object sender, EventArgs e)
        //{
        //    if (x.Text == "")
        //    {
        //        x.Text = "CONTRASEÑA";
        //        x.ForeColor = Color.DimGray;
        //        x.UseSystemPasswordChar = false;
        //    }
        //}

        //private void Login_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(Handle, 0x112, 0xf012, 0);
        //}

        //private void btnAceder_Click(object sender, EventArgs e)
        //{
        //    CNUsuario objUsuario = new CNUsuario();
        //    SqlDataReader Loguear;
        //    objUsuario.Usuario = ss.Text;
        //    objUsuario.Pass = x.Text;
        //    if (objUsuario.Usuario == ss.Text)
        //    {
        //        Loguear = objUsuario.IniciarSesion();
        //        if (Loguear.Read() == true)
        //        {
        //            Hide();
        //            FormPrincipal objPPrincipal = new FormPrincipal();
        //            objPPrincipal.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Usuario o contraseña Invalidos");
        //        }
        //    }


        //}

        //private void tbUsuario_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void tbContrasenna_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
