using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaNegocio;
using CapaDatos;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFigueri
{
    public partial class FormBuscarCliente : Form
    {
        CNClientes cli = new CNClientes();
        public FormBuscarCliente()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }
        //public DataTable MostarClientes()
        //{
        //    DataTable table = new DataTable();
        //    table = cli.listarClientes();
        //    return table;
        //}
        

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        public void MostrarClientes()
        {
            dataListado.DataSource = cli.MostarClientes();
        }
        private void BuscaApellido()
        {
            //this.dataListado.DataSource = CNClientes.BuscarApellidos(this.txtBuscar.Text);
            //this.OcultarColumnas();
            //lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void tbFiltra_KeyUp(object sender, KeyEventArgs e)
        {
            if(tbFiltra.Text.Equals("Apellidos"))
            {
                this
            }

        }
    }
}
