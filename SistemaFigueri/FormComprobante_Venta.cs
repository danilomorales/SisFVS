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
            DataGridViewRow llenar = dgvCompro_Venta.Rows[e.RowIndex];
            //Reportes.DsDetalleVenta dsdet = new Reportes.DsDetalleVenta();
            int filas = dgvCompro_Venta.Rows.Count;
            //for (int i = 0; i < filas - 4; i++)
            //{
            //    dsdet.Tables[0].Rows.Add(
            //        new Object[]
            //        {
            //                        dgvCompro_Venta["Nombres",i].Value.ToString(),
            //                        dgvCompro_Venta["ApellidoPaterno",i].Value.ToString(),
            //                        dgvCompro_Venta["ApellidoMaterno",i].Value.ToString(),
            //                        dgvCompro_Venta["des_comp_pago",i].Value.ToString(),
            //                        dgvCompro_Venta["num_serie_venta",i].Value.ToString(),
            //                        dgvCompro_Venta["num_doc_venta",i].Value.ToString(),
            //                        dgvCompro_Venta["fec_emite_venta",i].Value.ToString(),
            //                        dgvCompro_Venta["RUC",i].Value.ToString(),
            //                        dgvCompro_Venta["imp_precio_total_venta",i].Value.ToString(),
            //                        dgvCompro_Venta["des_punto_venta",i].Value.ToString(),
            //                        dgvCompro_Venta["Descripcion",i].Value.ToString(),
            //                        dgvCompro_Venta["fec_factu_comp_venta",i].Value.ToString(),
            //        }
            //        );
            //}
            //dsdet.Tables[1].Rows.Add(
            //                new Object[]
            //                {
            //                        //DIRECCION
            //                        "---- LA ERA Ñaña LT. 01 MZ. R ---- CP VIRGEN DEL CARMEN",
            //                        //SUCURSAL
            //                        "LURIGANCHO - LIMA - LIMA",
            //                        //RUC FIGUERI
            //                        "RUC 20268781529",
            //                        //TIPO DOC
            //                        //lblTipo.Text+" ELECTRÓNICA",
            //                        ////N DOC
            //                        //lblSerie+" - "+lblNroCorrelativo,
            //                        ////DNI
            //                        //tbDocumento.Text,
            //                        ////CLIENTE
            //                        //client,
            //                        ////FECHA EMISION
            //                        //dtpFechaEmision.Text,
            //                        ////FECHA VENCIMIENTO
            //                        ////dtFechaV.Text,
            //                        //"SOLES",
            //                        //"18.00 %",
            //                        // SumaSubTotal,
            //                        // SumaIgv,
            //                        // SumaTotal,
            //                        // letraImporte,
            //                         //imgbyte

            //                }
            //                );


            Reportes.FilterComprobante comp = new Reportes.FilterComprobante();
            comp.Load("C:\\Users\\AlphaLeader\\Desktop\\SisFVS2\\SistemaFigueri\\SistemaFigueri\\Reportes\\FilterComprobante.rpt");
            //comp.SetDataSource(dsdet);
            comproVenta.crystalReportViewer1.ReportSource = comp;
            comproVenta.ShowDialog();

            comproVenta.Show();

        }
    }
}
