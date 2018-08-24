using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;
using System.IO;

namespace SistemaFigueri
{
    public partial class FormEditarUsuario : MaterialSkin.Controls.MaterialForm
    {
        CNUsuario objUsuario = new CNUsuario();
        public int idusu { get; set; }
        public int idpersona { get; set; }
        String imgUrl = "";
        public FormEditarUsuario()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {

            SqlDataReader reader = objUsuario.buscarPerfil(idusu);
            while (reader.Read())
            {
                //MessageBox.Show(reader["nomRol"].ToString());
                idpersona = Int32.Parse(reader["IdPersona"].ToString());
                String login = reader["Login"].ToString();
                //MessageBox.Show(login);
                txtnombres.Text= reader["Nombres"].ToString();
                txtpaterno.Text = reader["ApellidoPaterno"].ToString();
                txtmaterno.Text = reader["ApellidoMaterno"].ToString();
                txtdni.Text = reader["DNI"].ToString();
                txtdireccion.Text = reader["Direccion"].ToString();
                txtusuario.Text = reader["Login"].ToString();
                txtclave.Text = reader["Pass"].ToString();
                txtclave2.Text = reader["Pass"].ToString();
                byte[] image = new byte[0];
                if (reader["foto"] != DBNull.Value) 
                {
                    image = (byte[])reader["foto"];
                    MemoryStream ms = new MemoryStream(image);
                    pbfoto.Image = Image.FromStream(ms);
                }
                
            }
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                openFileDialog1.Title = "Seleccione la foto de perfil";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imgUrl = openFileDialog1.FileName.ToString();
                    pbfoto.ImageLocation = imgUrl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtclave.Text == txtclave2.Text)
            {
                if (MessageBox.Show("¿Está seguro(a) de actualizar los datos del usuario?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (objUsuario.EditarUsuario(idusu, idpersona, txtnombres.Text, txtpaterno.Text, txtmaterno.Text,
                        txtdni.Text, txtdireccion.Text, txtusuario.Text, txtclave.Text, imgUrl) == 1)
                    {
                        MessageBox.Show("Se ha actualizado los datos del usuario");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Los campos de clave no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                
        }
    }
}
