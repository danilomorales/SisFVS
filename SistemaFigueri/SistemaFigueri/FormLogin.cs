﻿using System;
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if(tbUsuario.Text == "USUARIO")
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.WhiteSmoke;
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
                tbContrasenna.ForeColor = Color.WhiteSmoke;
                tbContrasenna.UseSystemPasswordChar = true;
            }
        }

        private void tbContrasenna_Leave(object sender, EventArgs e)
        {
            if (tbContrasenna.Text == "")
            {
                tbContrasenna.Text = "CONTRASEÑA";
                tbContrasenna.ForeColor = Color.DimGray;
                tbContrasenna.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAceder_Click(object sender, EventArgs e)
        {
            CNUsuario objUsuario = new CNUsuario();
            SqlDataReader Loguear;
            objUsuario.Usuario = tbUsuario.Text;
            objUsuario.Pass = tbContrasenna.Text;
            if (objUsuario.Usuario == tbUsuario.Text)
            {
                Loguear = objUsuario.IniciarSesion();
                if (Loguear.Read() == true)
                {
                    this.Hide();
                    FormPrincipal objPPrincipal = new FormPrincipal();
                    objPPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña Invalidos");
                }
            }


        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContrasenna_TextChanged(object sender, EventArgs e)
        {

        }
    }
}