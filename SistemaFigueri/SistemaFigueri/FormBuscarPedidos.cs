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
     
        }

        private void tbpedidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = tabla.DefaultView;
            dv.RowFilter = string.Format("Responsable like '%{0}%' or NombreEmpresa like '%{0}%'", tbpedidos.Text);
        }
    }
}
