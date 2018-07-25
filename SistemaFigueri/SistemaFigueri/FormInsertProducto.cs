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
                
                pro.InsertProduct(bmnombre.Text.ToString(),cbocategoria.Text.ToString(), cbomedida.Text.ToString(), bmdescripcion.Text.ToString(), bmtiempo.Text.ToString(), bmstock.Text.ToString(),
              bmaximo.Text.ToString(), bminimo.Text.ToString(), bmvalorunitario.Text.ToString(), bmprecio1.Text.ToString(), bmprecio2.Text.ToString(), bmoferta.Text.ToString(), bmnota.Text.ToString(),
              bmfactor.Text.ToString(), cboestado.Text.ToString(), bmitem.Text.ToString(), bminicial.Text.ToString(), bmcta.Text.ToString(), bmvigente.Text.ToString());
                MessageBox.Show("Se inserto correctamente");
                formPro.mostarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
            }
        }
     

        private void FormInsertProducto_Load(object sender, EventArgs e)
        {
            LlenarItems li = new LlenarItems();
            li.llenarCategoria(cbocategoria);
            li.llenarMedida(cbomedida);
        }
    }
}
