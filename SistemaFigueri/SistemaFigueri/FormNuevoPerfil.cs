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

namespace SistemaFigueri
{
    public partial class FormNuevoPerfil : MaterialSkin.Controls.MaterialForm
    {
        CNUsuario objUsuario = new CNUsuario();
        String imgUrl = "";
        public FormNuevoPerfil()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter="JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                openFileDialog1.Title = "Seleccione la foto de perfil";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imgUrl = openFileDialog1.FileName.ToString();
                    pbfoto.ImageLocation = imgUrl;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormNuevoPerfil_Load(object sender, EventArgs e)
        {

            /*DataTable tb = new DataTable();
            SqlDataReader adapter = objUsuario.cargarCombo();
            tb.Load(adapter);
            cboroles.DisplayMember = "nomRol";
            cboroles.ValueMember = "IdRol";
            cboroles.DataSource = tb;*/
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtnombres.Text!="" &&
                    txtpaterno.Text != "" &&
                    txtmaterno.Text != "" &&
                    txtdni.Text != "" &&
                    txtdireccion.Text != "" &&
                    txtusuario.Text != "" &&
                    txtclave.Text != "")
            {
                SqlDataReader reader = objUsuario.existeUsuario(txtusuario.Text);
                if (reader.Read())
                {
                    MessageBox.Show("El usuario ya existe, elija otro por favor");
                }
                else
                {
                    if (txtclave.Text == txtclave2.Text)
                    {
                        if (objUsuario.insertarUsuario(txtnombres.Text,
                        txtpaterno.Text,
                        txtmaterno.Text,
                        txtdni.Text,
                        txtdireccion.Text,
                        txtusuario.Text,
                        txtclave.Text,
                        imgUrl) == 1)
                        {
                            MessageBox.Show("Se insertó correctamente");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La clave no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else{              
                MessageBox.Show("Complete el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
