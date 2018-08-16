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
    public partial class FormBuscarPedidos : Form
    {
        CNPedidos obj = new CNPedidos();
        DataTable tabla;
        public List<DataRow> list { get; set; }
        public String IdPedidoProducto { get; set; }
        public String idcliente { get; set; }
        public String empresa { get; set; }
        public FormBuscarPedidos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscarpedido_Click(object sender, EventArgs e)
        {
            dgvPedidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPedidos.AllowUserToResizeRows = false;
            string fecha1 = dpdesde.Value.ToString("yyyy-MM-dd");
            string fecha2 = dphasta.Value.ToString("yyyy-MM-dd");
            SqlDataAdapter adapter = obj.buscarPedidos(fecha1, fecha2);
            MessageBox.Show("fecha1: " + fecha1 + "fecha2: " + fecha2);
            tabla = new DataTable();
            adapter.Fill(tabla);
            dgvPedidos.DataSource = tabla;
 
            adapter.Dispose();

            //plist = new PagedList<DataRow>(list);

            dgvPedidos.DataSource = tabla;
            dgvPedidos.Columns[0].Visible = false;

        }

        private void tbpedidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = tabla.DefaultView;
            dv.RowFilter = string.Format("Responsable like '%{0}%' or NombreEmpresa like '%{0}%'", tbpedidos.Text);
        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPedidoProducto = dgvPedidos.Rows[e.RowIndex].Cells["IdPedidoProducto"].Value.ToString();
            idcliente = dgvPedidos.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString();
            empresa = dgvPedidos.Rows[e.RowIndex].Cells["NombreEmpresa"].Value.ToString();

            MessageBox.Show("iddp: "+IdPedidoProducto+"id: "+idcliente+" empresa: "+empresa);
                
        }

        private void FormBuscarPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPedidos.AllowUserToResizeRows = false;
            String fecha1 = DateTime.Now.ToString("yyyy-MM-dd");
            String fecha2 =DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            dpdesde.Value= DateTime.Today.AddDays(-7);
            dphasta.Value = DateTime.Today;
            MessageBox.Show(fecha1+" "+ fecha2);
            SqlDataAdapter adapter = obj.buscarPedidos(fecha1, fecha2);
            tabla = new DataTable();
            adapter.Fill(tabla);
            dgvPedidos.DataSource = tabla;

            adapter.Dispose();

            //plist = new PagedList<DataRow>(list);

            dgvPedidos.DataSource = tabla;
            dgvPedidos.Columns[0].Visible = false;
        }
    }
}
