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
    public partial class FormComprobante_Venta : Form
    {
        CNComporbante_Venta cnventa = new CNComporbante_Venta();
        public List<DataRow> list { get; set; }
        DataTable tabla;
        public FormComprobante_Venta()
        {
            InitializeComponent();
        }

        public void MostrarCompro_venta()
        {


            SqlDataAdapter adapter = cnventa.MostarComprobante_Venta();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }

            //plist = new PagedList<DataRow>(list);
            adapter.Fill(tabla);
            dgvCompro_Venta.DataSource = tabla;
            adapter.Dispose();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {
            MostrarCompro_venta();
        }

        private void dgvCompro_Venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormComprobanteVenta comproVenta = new FormComprobanteVenta();
            //DataGridViewRow llenar = dgvCompro_Venta.Rows[e.RowIndex];
            comproVenta.Show();

        }
    }
}
