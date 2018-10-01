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
using CapaEntidades;


namespace SistemaFigueri
{
    public partial class FormBuscarPedidos : Form
    {
        CNPedidos obj = new CNPedidos();
        DataTable tabla;
        public DataTable tablaDetallePedido;
        public List<DataRow> list { get; set; }
        public String IdPedidoProducto { get; set; }
        public String fechaPedido { get; set; }
        public String clienteApellidos { get; set; }
        public String idcliente { get; set; }
        public String clienteNombres { get; set; }
        public String ruc { get; set; }
        public String tipodoc { get; set; }
        public String ndoc { get; set; }
        public String empresa { get; set; }
        public List<DataRow> listaDetalle { get; set; }
        //public CE_Cliente clientes { get; set; }
        //public List<Venta> listaVenta { get; set; }
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
            //MessageBox.Show("fecha1: " + fecha1 + "fecha2: " + fecha2);
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
            clienteNombres = dgvPedidos.Rows[e.RowIndex].Cells["clienteNombres"].Value.ToString();
            clienteApellidos = dgvPedidos.Rows[e.RowIndex].Cells["clienteApellidos"].Value.ToString();
            tipodoc = dgvPedidos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            ndoc = dgvPedidos.Rows[e.RowIndex].Cells["NroDocumento"].Value.ToString();
            ruc = dgvPedidos.Rows[e.RowIndex].Cells["RUC"].Value.ToString();
            fechaPedido = dgvPedidos.Rows[e.RowIndex].Cells["FechaPedido"].Value.ToString();
            CNPedidos cN = new CNPedidos();
            SqlDataAdapter adapter = cN.buscarDetallePedido(IdPedidoProducto);
            //MessageBox.Show("fecha1: " + fecha1 + "fecha2: " + fecha2);
            tablaDetallePedido = new DataTable();
            adapter.Fill(tablaDetallePedido);
            this.DialogResult = DialogResult.OK;
            this.Close();
            //MessageBox.Show("iddp: "+IdPedidoProducto+"id: "+idcliente+" empresa: "+empresa);
                
        }

        private void FormBuscarPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPedidos.AllowUserToResizeRows = false;
            String fecha1 = DateTime.Now.ToString("yyyy-MM-dd");
            //INTERVALO DE FECHA DESDE EL DIA DOMINGO HASTA LA FECHA ACTUAL
            String fecha2 =DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek).ToString("yyyy-MM-dd");
            dpdesde.Value= DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek);
            dphasta.Value = DateTime.Today;
            //MessageBox.Show(((int)DateTime.Now.DayOfWeek).ToString());
            SqlDataAdapter adapter = obj.buscarPedidos(fecha1, fecha2);
            tabla = new DataTable();
            adapter.Fill(tabla);
            dgvPedidos.DataSource = tabla;
            dgvPedidos.Columns[1].Visible = false;

            adapter.Dispose();

            //plist = new PagedList<DataRow>(list);

            dgvPedidos.DataSource = tabla;
            dgvPedidos.Columns[0].Visible = false;
        }
    }
}
