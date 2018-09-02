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
using CapaDatos;

namespace SistemaFigueri
{
    public partial class FormEditarCliente : MaterialSkin.Controls.MaterialForm
    {
        CNClientes CNclient = new CNClientes();
        private CNProductos product = new CNProductos();
        public FormEditarCliente()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manejoSki = MaterialSkin.MaterialSkinManager.Instance;
            manejoSki.AddFormToManage(this);
            manejoSki.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manejoSki.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Orange100,
                MaterialSkin.Primary.Orange300,
                MaterialSkin.Primary.Orange100,
                MaterialSkin.Accent.Orange100,
                MaterialSkin.TextShade.BLACK);
        }
        
        public string idCliente;

        private void buniActualizar_Click(object sender, EventArgs e)
        {
            string fecha1 = dateedinscripcion.Value.ToString("yyyy-MM-dd");
            string fecha2 = datediNacimiento.Value.ToString("yyyy-MM-dd");
            string fecha3 = datedimodificacion.Value.ToString("yyyy-MM-dd");
            MessageBox.Show("ENTRADO CON ID" + idCliente);
            try
            {
                product.UpdateClient(cboediTienda.SelectedValue.ToString(), cboedisector.SelectedValue.ToString(), bmedinombreCliente.Text, bmediapellidoP.Text,
                    bmediapellidoM.Text, bmedinombreEmpresa.Text, bmedireccion.Text, bmedicontacto.Text, bmeditelefono.Text, bmedifax.Text, bmediruc.Text,
                    bmedicorreo.Text, cboeditipoPersona.SelectedValue.ToString(), cboedidocumento.SelectedValue.ToString(), bmedinumerodoc.Text,
                    bmediobservacion.Text, fecha1, fecha2, bmedicredito.Text, cboeditipoCliente.SelectedValue.ToString(), cboedidepartamento.SelectedValue.ToString(),
                    cboediprovincia.SelectedValue.ToString(), cboedidistrito.SelectedValue.ToString(), bmediuserModi.Text, bmediuserModi.Text,
                    fecha3, idCliente);
                MessageBox.Show("IDDD" + idCliente);
                MessageBox.Show("Se edito correctamente el CLIENTE");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ACTUALIZAR:" + ex);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //LISTAR DOCUMENTO
        public void listarDocumento()
        {
            CDCliente cdcli = new CDCliente();
            cboedidocumento.DataSource = cdcli.ListarDocumento();
            cboedidocumento.DisplayMember = "Descripcion";
            cboedidocumento.ValueMember = "IdTipoDocIdent";

        }

        //LISTAR TIENDA
        public void listarTienda()
        {
            CDCliente cdcli = new CDCliente();
            cboediTienda.DataSource = cdcli.ListarTienda();
            cboediTienda.DisplayMember = "NombreTienda";
            cboediTienda.ValueMember = "IdTienda";
        }

        //LISTAR SECTOR
        public void listarSector()
        {
            CDCliente cdcli = new CDCliente();
            cboedisector.DataSource = cdcli.ListarSector();
            cboedisector.DisplayMember = "DescripcionSector";
            cboedisector.ValueMember = "IdSector";
        }

        //LISTAR PERSONA
        public void listarPersona()
        {
            CDCliente cdcli = new CDCliente();
            cboeditipoPersona.DataSource = cdcli.ListarPersona();
            cboeditipoPersona.DisplayMember = "Descripcion";
            cboeditipoPersona.ValueMember = "IdTipoPersona";
        }
    }
}
