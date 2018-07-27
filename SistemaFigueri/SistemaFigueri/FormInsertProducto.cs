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
using CapaDatos;


namespace SistemaFigueri
{

    public partial class FormInsertProducto : Form
    {
        CNProductos pro = new CNProductos();
        FormProductos formPro = new FormProductos();

        public FormInsertProducto()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardarPro_Click(object sender, EventArgs e)
        {
            try
            {

                pro.InsertProduct(bmnombre.Text, cbocategoria.SelectedValue.ToString(), cbomedida.SelectedValue.ToString(), bmdescripcion.Text, bmtiempo.Text, bmstock.Text,
              bmaximo.Text, bminimo.Text, bmvalorunitario.Text, bmprecio1.Text, bmprecio2.Text, bmoferta.Text, bmnota.Text,
              bmfactor.Text, cboestado.Text, bmitem.Text, bminicial.Text, bmcta.Text, bmvigente.Text);
                MessageBox.Show("Se inserto correctamente");
                this.Close();
                formPro.mostarProductos();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
            }
        }


        private void FormInsertProducto_Load(object sender, EventArgs e)
        {
            listarCategoria();
            listarMedida();
        }

        //LLENAR COMBOBOX CATEGORIA
        private void listarCategoria()
        {
            CDProductos cdpor = new CDProductos();
            cbocategoria.DataSource = cdpor.ListarCategoria();
            cbocategoria.DisplayMember = "Descripcion";
            cbocategoria.ValueMember = "IdCategoria";

        }

        //LLENAR COMBOBOX MEDIDA
        private void listarMedida()
        {
            CDProductos cdpor = new CDProductos();
            cbomedida.DataSource = cdpor.ListarMedida();
            cbomedida.DisplayMember = "Descripcion";
            cbomedida.ValueMember = "IdMedida";

        }

        private void limpiarForm()
        {
            bmnombre.Text = "";
            cbocategoria.Text = "";
            cbomedida.Text = "";
            bmdescripcion.Text = "";
            bmtiempo.Text = "";
            bmstock.Text = "";
            bmaximo.Text = "";
            bminimo.Text = "";
            bmvalorunitario.Text = "";
            bmprecio1.Text = "";
            bmprecio2.Text = "";
            bmoferta.Text = "";
            bmnota.Text = "";
            bmfactor.Text = "";
            cboestado.Text = "";
            bmitem.Text = "";
            bminicial.Text = "";
            bmcta.Text = "";
            bmvigente.Text="";
        }
    }
}
