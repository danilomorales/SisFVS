using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaNegocio;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFigueri
{
    public partial class FormVenta : Form
    {
        CNBuscarCliente objCN = new CNBuscarCliente();
        public FormVenta()

        {
            InitializeComponent();
        }

        private void btnVenCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       
        private void tbBuscarcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FormRegistroCobro formRp = new FormRegistroCobro();
            formRp.ShowDialog();
        }

        private void bunifuDropdown6_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMantCliente_Click(object sender, EventArgs e)
        {
            FormMantCliente formMP = new FormMantCliente();
            formMP.ShowDialog();
        }

        private void bunifuDropdown4_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCobro_Click(object sender, EventArgs e)
        {
            FormRegistroCobro frmRegCobro = new FormRegistroCobro();
            frmRegCobro.ShowDialog();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            var cards = new Bunifu.Framework.UI.BunifuCards();
            MostrarClientes();
          


        }
        public void MostrarClientes()
        {
            ListaCliente.DataSource = objCN.MostrarResultadoCliente();

        }
        public void FiltrarDatosCliente (Bunifu.Framework.UI.BunifuCustomDataGrid , String BuscarNombre)
        {
            try
            {

          
            }
            catch
            {

            }
        }

        private void FormVenta_Resize(object sender, EventArgs e)
        {
            //tamaño card tipo ducumento
            //bnTipoDoc.Width = this.Width - 1290;
            //bnTipoDoc.Height = this.Height - 680;

            ////tamaño card bnDatosCliente
            //bnDatosCliente.Width = this.Width - 590;
            //bnDatosCliente.Height = this.Height - 680;

            ////tamaño card bnVenta
            //bnVenta.Width = this.Width - 640;
            //bnVenta.Height = this.Height - 320;

            ////tamaño card bnPago
            //bnPago.Width = this.Width - 990;
            //bnVenta.Height = this.Height - 590;

            ////tamaño card bnResumen de pago 
            //bnResumePago.Width = this.Width - 760;
            //bnResumePago.Height = this.Height - 443;

   


            //btnFinalizar.Top = this.Top - 100;
            //btnFinalizar.Left = this.Left - 150;


        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        //public void autoCompletar(TextBox cajaTexto)
        //{
        //    try
        //    {
        //        SqlCommand comando = new SqlCommand ("SELECT NombreEmpresa, NroDocumento FROM DBFIGUE2.Caja.CLIENTE; ", Conexion.AbrirConexion());
        //        leer = comando.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            cajaTexto.AutoCompleteCustomSource.Add(dr["Nombre"].ToString());
        //        }
        //        dr.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo autocompletar el TextBox: " + ex.ToString());
        //    }
        //}
    }
}
