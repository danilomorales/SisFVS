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
        public static string nomUsu;
        public static string patUsu;
        public static string matUsu;
        public static string rol;
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void validar()
        {
            CNUsuario objUsuario = new CNUsuario();
            SqlDataReader Loguear;
            SqlDataReader Perfil;
            objUsuario.Usuario = tbUsuario.Text;
            objUsuario.Pass = tbContrasenna.Text;
            if (objUsuario.Usuario == tbUsuario.Text)
            {
                Loguear = objUsuario.IniciarSesion();
                
                if (Loguear.Read() == true)
                {
                    Perfil = objUsuario.UsuarioPerfil();
                    FormMenuPrincipal objPPrincipal = new FormMenuPrincipal();
                    try
                    {
                        while (Perfil.Read())
                        {
                            nomUsu = Perfil["Nombres"].ToString();
                            matUsu = Perfil["ApellidoPaterno"].ToString();
                            patUsu = Perfil["ApellidoMaterno"].ToString();
                            rol = Perfil["nomRol"].ToString();
                            objPPrincipal.label1.Text = nomUsu;
                            objPPrincipal.label2.Text = patUsu + " " + matUsu;
                            objPPrincipal.label3.Text = rol;
                        }
                        Hide();
                        Loguear.Close();
                        /*Label label = new Label();
                        label.Font= new Font("Arial", label.Font.Size, FontStyle.Bold);
                        label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                        label.BackColor = Color.FromArgb(39, 57, 80);
                        label.Location = new Point(22, 13);
                        label.Text="Nombre del usuario";
                        objPPrincipal.Controls.Add(label);*/

                        objPPrincipal.Show();
                    }
                    catch(Exception e){
                        MessageBox.Show("Error en el login"+e);
                    }




                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña Invalidos");
                }
            }
        }



        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void tbContrasenna_Enter(object sender, EventArgs e)
        {
            if (tbContrasenna.Text == "CONTRASEÑA")
            {
                tbContrasenna.Text = "";
                tbContrasenna.ForeColor = Color.WhiteSmoke;
                tbContrasenna.isPassword = true;
            }


        }

        private void tbContrasenna_Leave(object sender, EventArgs e)
        {
            if (tbContrasenna.Text == "")
            {
                tbContrasenna.Text = "CONTRASEÑA";
                tbContrasenna.ForeColor = Color.DimGray;
                tbContrasenna.isPassword = false;
            }
        }

        private void tbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                validar();
            }
        }

        private void tbContrasenna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validar();
            }
        }
    }



}
