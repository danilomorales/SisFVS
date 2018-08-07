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
using System.Data.SqlClient;
using CapaDatos;

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
            this.dataListado.DataSource = CNClientes.BuscarApellidos(this.tbFiltra.Text);
            this.OcultarColumnas();
            lbtotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = CNClientes.BuscarNum_Documento(this.tbFiltra.Text);
            this.OcultarColumnas();
            lbtotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void tbFiltra_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from caja.CLIENTE where NombreEmpresa like('" + tbFiltra.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataListado.DataSource = dt;
            Conexion.Close();



        }
        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FormVenta form = FormVenta.GetInstancia();
            string par1, par2;
            //par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Nro de Documento"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Apellido Paterno"].Value) + " " + Convert.ToString(this.dataListado.CurrentRow.Cells["Nombres"].Value);
            form.SetCliente(par2);
            this.Hide();
        }


    }


}
