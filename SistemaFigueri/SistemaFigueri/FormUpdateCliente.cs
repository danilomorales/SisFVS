using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace SistemaFigueri
{
    public partial class FormUpdateCliente : Form
    {
        public FormUpdateCliente()
        {
            InitializeComponent();
        }
        public string idCliente;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpdateCliente_Load(object sender, EventArgs e)
        {
           
        }        

        private void bmediCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //LISTAR TIENDA
        public void listarTienda()
        {
            CDCliente cdcli = new CDCliente();
            cboeditienda.DataSource = cdcli.ListarTienda();
            cboeditienda.DisplayMember = "NombreTienda";
            cboeditienda.ValueMember = "IdTienda";
        }

        //LISTAR SECTOR
        public void listarSector()
        {
            CDCliente cdcli = new CDCliente();
            cboedisector.DataSource = cdcli.ListarSector();
            cboedisector.DisplayMember = "DescripcionSector";
            cboedisector.ValueMember = "IdSector";
        }

        //LISTAR DOCUMENTO
        public void listarDocumento()
        {
            CDCliente cdcli = new CDCliente();
            cboedidocumento.DataSource = cdcli.ListarDocumento();
            cboedidocumento.DisplayMember = "Descripcion";
            cboedidocumento.ValueMember = "IdTipoDocIdent";
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {

        }

        private void fechaNacimiento_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bmediGuardar_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bfruc_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton27_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
