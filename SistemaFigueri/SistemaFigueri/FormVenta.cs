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
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SistemaFigueri
{
    public partial class FormVenta : Form
    {
        CNBusqueda objCN = new CNBusqueda();
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
            Busqueda_clinete bu = new Busqueda_clinete();
            bu.autoCompletar(tbBuscaClienteRece);
           
            var aux = new Busqueda_Cliente();
            aux.Lista(dgvProductos);

        }

        public void filtrar (DataTable data, String buscarnombre)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.Fill(dt);
            
        }
        public void MostrarClientes()
        {
            //ListaCliente.DataSource = objCN.MostrarResultadoCliente();

        }

        public void autocompleta(TextBox cajadetexto)
        {
            
        }

        private void ListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbBuscaClientes_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tbBuscaClienteReceptor_Enter(object sender, EventArgs e)
        {

        }

        private void tbBuscaClienteReceptor_Leave(object sender, EventArgs e)
        {

        }

        private void tbBuscaClienteReceptor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBuscaClienteRece_Enter(object sender, EventArgs e)
        {
            if (tbBuscaClienteRece.Text == "Buscar Cliente Receptor")
            {
                tbBuscaClienteRece.Text = "";
                tbBuscaClienteRece.ForeColor = Color.White;
                
            }
        }

        private void tbBuscaClienteRece_Leave(object sender, EventArgs e)
        {
            if (tbBuscaClienteRece.Text == "")
            {
                tbBuscaClienteRece.Text = "Buscar Cliente Receptor";
                tbBuscaClienteRece.ForeColor = Color.FromArgb (236, 240, 241); 

            }

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormMantCliente formMP = new FormMantCliente();
            formMP.ShowDialog();
        }

        private void tbBuscaClienteRece_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123");
            String cadcone = "select * from CLIENTE where NombreEmpresa='" + tbBuscaClienteRece.Text + "'";
            SqlCommand cm = new SqlCommand(cadcone, cnn);
            cnn.Open();

            SqlDataReader leer = cm.ExecuteReader();
            if(leer.Read()==true)
            {
                tlClienteNombres.Text = leer["NombreEmpresa"].ToString();
                tlRuc.Text = leer["RUC"].ToString();
                tlDocumento.Text = leer["NroDocumento"].ToString();

            }
            else
            {
                
                tlClienteNombres.Text = " ";
                tlRuc.Text = " ";
                tlDocumento.Text = "";
                
            }
            cnn.Close();
        }

        private void tbBuscaProducto_TextAlignChanged(object sender, EventArgs e)
        {

        }
        public void lista(DataGridView dta)
        {

        }
        private void tbBuscaProducto_TextChanged(object sender, EventArgs e)
        {
           
                   
            
        }

        private void btnAgregaCarro_Click(object sender, EventArgs e)
        {

            //SqlConnection cnn = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123");
            //String cadcone = "select * from Producto where Alias='" + tbBuscaProducto.Text + "'";
            //SqlCommand cm = new SqlCommand(cadcone, cnn);
            //cnn.Open();



            //String AliasProducto = tbBuscaProducto.Text;
            //MessageBox.Show(AliasProducto);
        }

        private void btnSumaCan_Click(object sender, EventArgs e)
        {
            try
            {
                int contar = int.Parse(tbCantidad.Text);
                contar++;
                tbCantidad.Text = contar.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese Cantidad Correcta");
            }

        }

        private void btnRestaCan_Click(object sender, EventArgs e)
        {

            try
            {
                int descontar = int.Parse(tbCantidad.Text);
                descontar--;
                tbCantidad.Text = descontar.ToString();

            }
            catch (Exception )
            {
                MessageBox.Show("Ingrese Cantidad Correcta");
            }

        }

        private void Venta_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscaProcto_Click(object sender, EventArgs e)
        {
            FormBuscarProducto formBuscarPro = new FormBuscarProducto();
            formBuscarPro.ShowDialog();
        }


        //private void tbBuscaClienteReceptor_Enter_1(object sender, EventArgs e)
        //{
        //    if (tbBuscaClienteReceptor.Text == "BUSCAR CLIENTE RECEPTOR")
        //    {
        //        tbBuscaClienteReceptor.Text = "";
        //        tbBuscaClienteReceptor.ForeColor = Color.WhiteSmoke;
        //        tbBuscaClienteReceptor.UseSystemPasswordChar = true;
        //    }
        //}

        //private void tbBuscaClienteReceptor_Leave_1(object sender, EventArgs e)
        //{

        //    if (tbBuscaClienteReceptor.Text == "")
        //    {
        //        tbBuscaClienteReceptor.Text = "BUSCAR CLIENTE RECEPTOR";
        //        tbBuscaClienteReceptor.ForeColor = Color.DimGray;
        //        tbBuscaClienteReceptor.UseSystemPasswordChar = false;
        //    }



    }

}


