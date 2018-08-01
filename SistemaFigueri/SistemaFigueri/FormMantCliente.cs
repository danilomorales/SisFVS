using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;
using CapaDatos;


namespace SistemaFigueri
{
    public partial class FormMantCliente : MaterialSkin.Controls.MaterialForm
    {
        public FormMantCliente()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manejoSki = MaterialSkin.MaterialSkinManager.Instance;
            manejoSki.AddFormToManage(this);
            manejoSki.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            manejoSki.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue800,
                MaterialSkin.Primary.Indigo500, 
                MaterialSkin.Primary.Blue100,
                MaterialSkin.Accent.LightBlue200,
                MaterialSkin.TextShade.WHITE);
        }
        CNClientes cli = new CNClientes();
        FormCliente formCliente = new FormCliente();
        private void btnCancelarMant_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantCliente_Load(object sender, EventArgs e)
        {
            listarTienda();
            listarSector();
            listarDocumento();
        }

        //ACTIVAR TEXTBOX
        private void cbocliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbocliente.SelectedItem.Equals("Cliente Juridica"))
            {
                bfruc.Visible = true;
                bmruc.Visible = true;
            }
            else
            {
                bfruc.Visible = false;
                bmruc.Visible = false;
            }
        }       

        //GUARDAR NUEVO CLIENTE
        private void bmGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cli.InsertClient(cbotienda.SelectedValue.ToString(),cbosector.SelectedValue.ToString(),bmempresa.Text,bmdireccion.Text,
                    bmnombreCliente.Text,bmtelefono.Text,bmfax.Text,bmruc.Text,bmcorreo.Text,cbodocumento.SelectedValue.ToString(),
                    bmnumerodoc.Text,bmobservacion.Text,dateInscripcion.Text,cboestado.SelectedValue.ToString(),bmctacte.Text,bmnivel.Text,dateNacimiento.Text,
                    bmtipocompra.Text,bmcredito.Text,bmqueja.Text,bmsaldo.Text,bmordencliente.Text,cbocliente.SelectedValue.ToString(),bmpromedioventas.Text,bmctacte.Text);
                MessageBox.Show("Se inserto cliente correctamente");
                this.Close();
                formCliente.MostrarClientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se creo nuevo cliente" + ex);
            }
        }

        //LISTAR TIENDA
        private void listarTienda()
        {
            CDCliente cdcli = new CDCliente();
            cbotienda.DataSource = cdcli.ListarTienda();
            cbotienda.DisplayMember = "NombreTienda";
            cbotienda.ValueMember = "IdTienda";
        }

        //LISTAR SECTOR
        private void listarSector()
        {
            CDCliente cdcli = new CDCliente();
            cbosector.DataSource = cdcli.ListarSector();
            cbosector.DisplayMember = "DescripcionSector";
            cbosector.ValueMember = "IdSector";
        }

        //LISTAR DOCUMENTO
        private void listarDocumento()
        {
            CDCliente cdcli = new CDCliente();
            cbodocumento.DataSource = cdcli.ListarDocumento();
            cbodocumento.DisplayMember = "Descripcion";
            cbodocumento.ValueMember = "IdTipoDocIdent";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void cancelaMant_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
