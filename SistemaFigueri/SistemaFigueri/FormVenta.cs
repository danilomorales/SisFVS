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

        public void autocompletar(TextBox cajaTexto)
        {
            try
            {
              
                
            }
            catch
            {

            }
        }

        private void ListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbBuscaClientes_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
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

