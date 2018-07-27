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
using CapaDatos;
using CapaNegocio;


namespace SistemaFigueri
{
    public partial class FormUpdateProducto : Form
    {
        public FormUpdateProducto()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
               
    
        //arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hend, int wsmg, int wparam, int lparam);

        //CDProductos pro = new CDProductos();
        CNProductos cnProd = new CNProductos();
        FormProductos formPro = new FormProductos();
        public string idProducto;
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                cnProd.UpdateProduct(idProducto.ToString(), bmedinombre.Text, cboedicategoria.SelectedValue.ToString(), cboedimedida.SelectedValue.ToString(), bmedidescripcion.Text, bmeditiempo.Text, bmedistock.Text,
             bmedistockmax.Text, bmedistockmini.Text, bmedivalos_unitario.Text, bmediprecio1.Text, bmediprecio2.Text, bmediprecioOferta.Text, bmedinota.Text,
             bmedifactor.Text, cboediestado.Text, bmediItem.Text, bmedinicial.Text, bmedicta.Text, bmedivigente.Text);
                MessageBox.Show("Se edito correctamente");
                formPro.mostarProductos();
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Actualizar los datos por :" + ex.ToString());
            }

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpdateProducto_Load(object sender, EventArgs e)
        {
            //listarCategoria();
            //listarMedida();
        }

        public void listarCategoria()
        {
            CDProductos cdpor = new CDProductos();
            cboedicategoria.DataSource = cdpor.ListarCategoria();
            cboedicategoria.DisplayMember = "Descripcion";
            cboedicategoria.ValueMember = "IdCategoria";

        }

        public void listarMedida()
        {
            CDProductos cdpor = new CDProductos();
            cboedimedida.DataSource = cdpor.ListarMedida();
            cboedimedida.DisplayMember = "Descripcion";
            cboedimedida.ValueMember = "IdMedida";

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bmedinombre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
