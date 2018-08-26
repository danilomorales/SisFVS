﻿using System;
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
using System.Globalization;
using CrystalDecisions.CrystalReports;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using CapaEntidades;
using System.Drawing.Imaging;

namespace SistemaFigueri
{
    public partial class FormVenta : Form
    {


        public int IdUsuario;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private static FormVenta _instancia;
        Venta Ventas = new Venta();
        LocalBD serie = new LocalBD();
        CNDetalleVenta Detalle = new CNDetalleVenta();
        private List<Venta> lst = new List<Venta>();
        private int oldvalue { get; set; }
        Decimal SumaTotal { get; set; }
        Decimal SumaSubTotal { get; set; } Decimal SumaIgv { get; set; }

        public static FormVenta GetInstancia()
        {
            if (_instancia ==null)
            {
                _instancia = new FormVenta();
            }
            else
            {
                return _instancia;
            }
            return _instancia;
        }
        public void SetCliente(String nombre)
        {
            this.tbClienteNombre.Text = nombre;
        }
        public void producto (string Alias, string DescripcionProducto, 
            decimal Valor_Unitario, int Stock, DateTime TiempoDuracion )
        {
           
        }

        public FormVenta()
        {
            InitializeComponent();
            //this.toolTip1.SetToolTip(this.btnCargaCliente, "Seleccione un cliente");

        }
        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Figueri", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Figueri", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario


        private void limpiarDetalle()
        {

            /////*this*/.tbDesProducto.Text = string.Empty;
            //this.tbCantidad.Text = string.Empty;
            //this.tbPrecioV.Text = string.Empty;
            //this.tbStock.Text = String.Empty;
            //this.tbDescuento.Text = "0";
        }
        

        private void OcultarColumnas()
        {
            this.dataVentas.Columns[0].Visible = false;
            this.dataVentas.Columns[1].Visible = false;
        }

        //Método Mostrar
        private void Mostrar()
        {
            //this.dataVentas.DataSource = CNVenta.Mostrar();
            this.OcultarColumnas();
            //lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarFecha
        private void BuscarFechas()
        {
            //this.dataVentas.DataSource = CNVenta.BuscarFechas(this.dpFechaInicio.Value.ToString("dd/MM/yyyy"), this.dpFechafin.Value.ToString("dd/MM/yyyy"));
            this.OcultarColumnas();
            //lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);

        }

        //Método BuscarDetalles
        private void MostrarDetalles()
        {
            //this.dataVentas.DataSource = CNVenta.MostrarDetalle(this.tbIdVenta.Text);
            this.OcultarColumnas();
            //lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            this.dataVentas.AutoGenerateColumns = false;
        }

        //Crea la tabla de Detalle 
        private void crearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("dataVentas");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.dataVentas.DataSource = this.dtDetalle;

        }   
      
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
        }

      
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminar.Checked)
            {
                this.dataVentas.Columns[0].Visible = true;
            }
            else
            {
                this.dataVentas.Columns[0].Visible = false;
            }
        }

      
        private void FrmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        //private void btnBuscarProveedor_Click(object sender, EventArgs e)
        //{
        //    FrmVistaCliente_Venta vista = new FrmVistaCliente_Venta();
        //    vista.ShowDialog();
        //}

        //private void btnBuscarArticulo_Click(object sender, EventArgs e)
        //{
        //    FrmVistaArticulo_Venta vista = new FrmVistaArticulo_Venta();
        //    vista.ShowDialog();
        //}

        private void btnVenCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FormRegistroCobro formRp = new FormRegistroCobro();
            formRp.ShowDialog();
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

        private void btnRegistrarCobro_Click(object sender, EventArgs e)
        {
            FormRegistroCobro frmRegCobro = new FormRegistroCobro();
            frmRegCobro.ShowDialog();
        }
       /* private void rbnFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFactura.Checked == true)
                lblTipo.Text = "FACTURA";
            CNVentas cNVentas = new CNVentas();
            String correlativo = cNVentas.traerCorrelativo(1);
            lblSerie.Text = "F001";
            lblNroCorrelativo.Text = correlativo.ToString();

        }*/

        /*private void rbnBoleta_CheckedChanged(object sender, EventArgs e)
        {
            GenerarNumeroComprobante();
            if (rbnBoleta.Checked == true)
                lblTipo.Text = "BOLETA";
            CNVentas cNVentas = new CNVentas();
            String correlativo = cNVentas.traerCorrelativo(2);
            lblSerie.Text = "B001";
            lblNroCorrelativo.Text = correlativo.ToString();
        }*/

       

        private void FormVenta_Load(object sender, EventArgs e)
        {
            var cards = new Bunifu.Framework.UI.BunifuCards();
            MostrarClientes();
            this.crearTabla();
            GenerarNumeroComprobante();

            //GenerarIdVenta();
           // GenerarSeriedeDocumento();
            dgvVenta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //bu.autoCompletar(tbBuscaClienteRece);

            //var aux = new Busqueda_Cliente();
            //aux.Lista(dgvProductos);

            CNVentas cNVentas = new CNVentas();
            String correlativo = cNVentas.traerCorrelativo(2);
            lblSerie.Text = "001";
            lblNroCorrelativo.Text = correlativo.ToString();
            cboTipoDoc.DataSource = cNVentas.MostarCboTipoDoc();
            cboTipoDoc.ValueMember = "IdTipoDoc";
            cboTipoDoc.DisplayMember = "DescripcionDoc";
            cboTipoPago.DataSource = cNVentas.MostarCboTipoPago();
            cboTipoPago.ValueMember = "IdTipoPago";
            cboTipoPago.DisplayMember = "DescripcionTipo";
            CboMoneda.DataSource = cNVentas.MostarCboMoneda();
            CboMoneda.ValueMember = "IdMoneda";
            CboMoneda.DisplayMember = "DesMoneda";
        }
        private void GenerarNumeroComprobante()
        {
            //if (rbnBoleta.Checked == true)
            //    //lblNroCorrelativo.Text = Ventas.NumeroComprobante("Boleta");
            //else
            //   // lblNroCorrelativo.Text = Ventas.NumeroComprobante("Factura");
        }

        private void cargarSerie()
        {
            try
            {
                //serie = negVenta.Intancia.CargarSerie(1, 1);
                //ser = serie.Numero_Serie;
                //lblSerie.Text = serie.Numero_Serie + "-";
                //lblCorrelativo.Text = "Nº " + negVenta.Intancia.CargarCorrelativo(1, serie.Numero_Serie);
                //corr = negVenta.Intancia.CargarCorrelativo(1, serie.Numero_Serie);
            }
            catch (Exception)
            {

                throw;
            }
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


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormMantCliente formMP = new FormMantCliente();
            formMP.ShowDialog();
        }

        private void tbBuscaProducto_TextAlignChanged(object sender, EventArgs e)
        {

        }
        public void lista(DataGridView dta)
        {

        }


        private void btnSumaCan_Click(object sender, EventArgs e)
        {
            try
            {
                //int contar = int.Parse(tbCantidad.Text);
                //contar++;
                //tbCantidad.Text = contar.ToString();
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
                /*int descontar = int.Parse(tbCantidad.Text);
                descontar--;
                tbCantidad.Text = descontar.ToString();*/

            }
            catch (Exception )
            {
                MessageBox.Show("Ingrese Cantidad Correcta");
            }

        }

    

        private void btnBuscaProcto_Click(object sender, EventArgs e)
        {
            using (FormBuscarProducto form = new FormBuscarProducto())
            {
                if (this.tbrazonsocial.Text.Trim() != "")
                {
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Limpiar();
                        tbAlias.Text = form.alias;
                        tbDescripcion.Text = form.descripcion;
                        tbStock.Text = form.stock;
                        //dtFechaV.Text = form.fechavencimiento;
                        tbPrecio.Text = form.precio;
                        //btnAgregaCarro.Enabled = true;
                        tbIdProducto.Text = form.idproducto;
                                              

                        CNProductos objProducto = new CNProductos();
                        Venta ven = new Venta();
                        Decimal Porcentaje = 0; Decimal SubTotal;

                        ven.Descripcion = tbAlias.Text + " - " + tbDescripcion.Text;
                        ven.alias = form.alias;
                        ven.Cantidad = 1;
                        ven.PrecioVenta = Convert.ToDecimal(tbPrecio.Text);
                        Porcentaje = (Convert.ToDecimal(tbIgv.Text) / 100) + 1;
                        SubTotal = ((Convert.ToDecimal(tbPrecio.Text) * 1) / Porcentaje);
                        ven.Igv = Math.Round(Convert.ToDecimal(SubTotal) * (Convert.ToDecimal(tbIgv.Text) / (100)), 2);
                        ven.SubTotal = Math.Round(SubTotal, 2);
                        ven.stock = Int32.Parse(tbStock.Text);
                        lst.Add(ven);
                        LlenarGrilla();
      

                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Busque el Cliente a Vender.", "Figueri", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                
                }

            }


        }

        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void ListaCLiente_Click(object sender, EventArgs e)
        {
            FormBuscarClienteR formMP = new FormBuscarClienteR();
            formMP.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetalleNotaVenta_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void FormVenta_Activated(object sender, EventArgs e)
        {
          

        }

        /*private void btnAgregaCarro_Click_1(object sender, EventArgs e)
        {
            Venta ven = new Venta();
            Decimal Porcentaje = 0; Decimal SubTotal;
            if(this.tbrazonsocial.Text.Trim() != "")
            {
                if (tbDescripcion.Text.Trim() != "")
                {
                    ven.Descripcion = tbAlias.Text + " - " + tbDescripcion.Text;
                    ven.Cantidad = 1;
                    ven.PrecioVenta = Convert.ToDecimal(tbPrecio.Text);
                    Porcentaje = (Convert.ToDecimal(tbIgv.Text) / 100) + 1;
                    SubTotal = ((Convert.ToDecimal(tbPrecio.Text) * 1) / Porcentaje);
                    ven.Igv = Math.Round(Convert.ToDecimal(SubTotal) * (Convert.ToDecimal(tbIgv.Text) / (100)), 2);
                    ven.SubTotal = Math.Round(SubTotal, 2);
                    ven.stock = Int32.Parse(tbStock.Text);
                    lst.Add(ven);
                    LlenarGrilla();
                    Limpiar();
                    
                }
                else
                {
                    MessageBox.Show("Busque Producto a Vender", "Figueri", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    tbPrecio.Focus();
                    tbDescripcion.Focus();
                    tbAlias.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por Favor Busque el Cliente a Vender.", "Figueri", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }*/

        private void LlenarGrilla()
        {
            var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            format.CurrencySymbol = "";
            SumaSubTotal = 0; SumaIgv = 0; SumaTotal = 0;
            dgvVenta.Rows.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                dgvVenta.Rows.Add();
                dgvVenta.Rows[i].Cells[0].Value = lst[i].IdVenta;
                dgvVenta.Rows[i].DefaultCellStyle.FormatProvider = format;
                dgvVenta.Rows[i].Cells[1].Value = lst[i].Cantidad;
                dgvVenta.Rows[i].Cells[2].Value = lst[i].Descripcion;
                dgvVenta.Rows[i].Cells[3].Value = lst[i].PrecioVenta;
                dgvVenta.Rows[i].Cells[4].Value = lst[i].SubTotal;
                dgvVenta.Rows[i].Cells[5].Value = lst[i].IdProducto;
                dgvVenta.Rows[i].Cells[6].Value = lst[i].Igv;
                dgvVenta.Rows[i].Cells["STOCK"].Value = lst[i].stock;
                dgvVenta.Rows[i].Cells[8].Value = lst[i].alias;
                SumaSubTotal += Convert.ToDecimal(dgvVenta.Rows[i].Cells[4].Value);
                SumaIgv += Convert.ToDecimal(dgvVenta.Rows[i].Cells[6].Value);
            }

            dgvVenta.Rows.Add();
            dgvVenta.Rows.Add();
            dgvVenta.Rows[lst.Count + 1].Cells[3].Value = "SUB-TOTAL  S/.";
            dgvVenta.Rows[lst.Count + 1].DefaultCellStyle.FormatProvider = format;
            dgvVenta.Rows[lst.Count + 1].Cells[4].Value = SumaSubTotal;
            dgvVenta.Rows.Add();
            dgvVenta.Rows[lst.Count + 2].Cells[3].Value = "      I.G.V.        %";
            dgvVenta.Rows[lst.Count + 2].DefaultCellStyle.FormatProvider = format;
            dgvVenta.Rows[lst.Count + 2].Cells[4].Value = SumaIgv;
            dgvVenta.Rows.Add();
            dgvVenta.Rows[lst.Count + 3].Cells[3].Value = "     TOTAL     S/.";
            SumaTotal += SumaSubTotal + SumaIgv;
            dgvVenta.Rows[lst.Count + 3].DefaultCellStyle.FormatProvider = format;
            dgvVenta.Rows[lst.Count + 3].Cells[4].Value = SumaTotal;
            dgvVenta.ClearSelection();
        }


        //otr csa
        private void Limpiar()
        {
            //tbDescripcion.Clear();
            //tbCantidad.Clear();
            tbPrecio.Clear();
            tbAlias.Clear();
            tbDescripcion.Clear();
            tbStock.Clear();
            Program.DescripcionProducto = "";
            Program.Stock = 0;
            Program.Alias = "";
            Program.PrecioVenta = 0;
        }
        private void Carga_FormaPago()
        {


        }


        private void btnCargaCliente_Click(object sender, EventArgs e)
        {
            using (FormBuscarClienteR form = new FormBuscarClienteR())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tbClienteNombre.Text = form.cliente;
                    tbRuc.Text = form.ruc;
                    tbDocumento.Text = form.dni;
                    tbtipodoc.Text = form.tipodoc;
                    tbrazonsocial.Text = form.empresa;
                    tbIdCliente.Text = form.idcliente;

                    CNProductos objProducto = new CNProductos();

                }

            }

        }

        private void btnpedidos_Click_1(object sender, EventArgs e)
        {
            using (FormBuscarPedidos form = new FormBuscarPedidos())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tbrazonsocial.Text = form.empresa;
                    tbClienteNombre.Text = form.cliente;
                    tbRuc.Text = form.ruc;
                    tbtipodoc.Text = form.tipodoc;
                    tbDocumento.Text = form.ndoc;
                }
            }
        }

        private void tbRuc_TextChanged(object sender, EventArgs e)
        {
            if (tbRuc.Text=="")
            {
                if(chkruc.Checked == true)
                {
                    chkruc.Checked = false;
                }
            }
            else
            {
                if (chkruc.Checked == false)
                {
                    chkruc.Checked = true;
                }
            }
            
        }

        private void tbrazonsocial_TextChanged(object sender, EventArgs e)
        {
            if (tbrazonsocial.Text == "")
            {
                if (chkempresa.Checked == true)
                {
                    chkempresa.Checked = false;
                }
            }
            else
            {
                if (chkempresa.Checked == false)
                {
                    chkempresa.Checked = true;
                }
            }
                
        }

        private void tbClienteNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbClienteNombre.Text == "")
            {
                if (chkcliente.Checked == true)
                {
                    chkcliente.Checked = false;
                }
            }
            else
            {
                if (chkcliente.Checked == false)
                {
                    chkcliente.Checked = true;
                }
            }
            
                
        }

        private void tbDocumento_TextChanged(object sender, EventArgs e)
        {
            if (tbDocumento.Text == "")
            {
                if (chkndoc.Checked == true)
                {
                    chkndoc.Checked = false;
                }
            }
            else
            {
                if (chkndoc.Checked == false)
                {
                    chkndoc.Checked = true;
                }
            }
        }

        private void tbtipodoc_TextChanged(object sender, EventArgs e)
        {
            if (tbtipodoc.Text == "")
            {
                if (chktipodoc.Checked == true)
                {
                    chktipodoc.Checked = false;
                }
            }
            else
            {
                if (chktipodoc.Checked == false)
                {
                    chktipodoc.Checked = true;
                }
            }
        }

        public void LIstaFormapago()
        {
            CDVenta Cv = new CDVenta();
            cboTipoPago.DataSource = Cv.CargaFormaPago();
            cboTipoPago.DisplayMember = "DescripcionTipo";
            cboTipoPago.ValueMember = "IdtipoPago";
        }
        private void ListaMoneda()
        {
            CDVenta Ds = new CDVenta();
            CboMoneda.DataSource = Ds.CargaMoneda();
            CboMoneda.DisplayMember = "DesMoneda";
            CboMoneda.ValueMember = "IdMoneda";
        }

        private void btRegistraVenta_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count > 0)
            {
                using (FormComprobanteVenta formC = new FormComprobanteVenta()) {

                    /*if(formC.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                       
                           
                    }*/
                    QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                    QrCode qrCode = new QrCode();
                    qrEncoder.TryEncode(lblSerie + " - " + lblNroCorrelativo, out qrCode);

                    GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                    MemoryStream ms = new MemoryStream();

                    renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                    var imageTemporal = new Bitmap(ms);
                    var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));
                    //panelResultado.BackgroundImage = imagen;

                    //Guardar en el disco duro la imagen (Carpeta del proyecto)

                    String urlSave = "C:\\Users\\AlphaLeader\\Desktop\\SisFVS2\\SistemaFigueri\\SistemaFigueri\\Resources\\" + lblSerie.Text + lblNroCorrelativo.Text + "QR.png";
                    imagen.Save(urlSave, ImageFormat.Png);

                    FileStream fs;
                    // define te binary reader to read the bytes of image 

                    BinaryReader br;
                    // check the existance of image 

                    if (File.Exists(urlSave))
                    {
                        // open image in file stream 

                        fs = new FileStream(urlSave, FileMode.Open);
                    }
                    else
                    {
                        // if phot does not exist show the nophoto.jpg file 

                        fs = new FileStream(urlSave, FileMode.Open);
                    }
                    // initialise the binary reader from file streamobject 

                    br = new BinaryReader(fs);
                    // define the byte array of filelength 

                    byte[] imgbyte = new byte[fs.Length + 1];
                    // read the bytes from the binary reader 

                    imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)));
                 

                    br.Close();
                    // close the binary reader 

                    fs.Close();
                    // close the file stream 


                    Reportes.DsDetalleVenta dsdet = new Reportes.DsDetalleVenta();
                    int filas = dgvVenta.Rows.Count;
                    //MessageBox.Show(filas.ToString());
                    String client = "";
                    client = chkcliente.Checked == true ? tbClienteNombre.Text : tbrazonsocial.Text;
                    String letraImporte = "";
                    Conversiones conv = new Conversiones();
                    letraImporte=conv.enletras(SumaTotal.ToString());
                   
                  

                    for (int i = 0; i < filas - 4; i++)
                    {
                        dsdet.Tables[0].Rows.Add(
                            new Object[]
                            {
                                    dgvVenta["CANTIDAD",i].Value.ToString(),
                                    dgvVenta["DESCRIPCION",i].Value.ToString(),
                                    Double.Parse(dgvVenta["PRECIO",i].Value.ToString()),
                                    Double.Parse(dgvVenta["IMPORTE",i].Value.ToString())
                            }
                            );
                    }
                    dsdet.Tables[1].Rows.Add(
                            new Object[]
                            {
                                    //DIRECCION
                                    "---- LA ERA Ñaña LT. 01 MZ. R ---- CP VIRGEN DEL CARMEN",
                                    //SUCURSAL
                                    "LURIGANCHO - LIMA - LIMA",
                                    //RUC FIGUERI
                                    "RUC 20268781529",
                                    //TIPO DOC
                                    lblTipo.Text+" ELECTRÓNICA",
                                    //N DOC
                                    lblSerie+" - "+lblNroCorrelativo,
                                    //DNI
                                    tbDocumento.Text,
                                    //CLIENTE
                                    client,
                                    //FECHA EMISION
                                    dtpFechaEmision.Text,
                                    //FECHA VENCIMIENTO
                                    dtFechaV.Text,
                                    "SOLES",
                                    "18.00 %",
                                     SumaSubTotal,
                                     SumaIgv,
                                     SumaTotal,
                                     letraImporte,
                                     imgbyte

                            }
                            );
                    Reportes.ComprobanteVenta comp = new Reportes.ComprobanteVenta();
                    comp.Load("C:\\Users\\AlphaLeader\\Desktop\\SisFVS2\\SistemaFigueri\\SistemaFigueri\\Reportes\\ComprobanteVenta.rpt");
                    comp.SetDataSource(dsdet);
                    formC.crystalReportViewer1.ReportSource = comp;
                    formC.ShowDialog();
                }
                    /*if (Convert.ToString(dgvVenta.CurrentRow.Cells[2].Value) != "")
                    {
                        GuardarVenta();
                        try
                        {
                            for (int i = 0; i < dgvVenta.Rows.Count; i++)
                            {
                                Decimal SumaIgv = 0; Decimal SumaSubTotal = 0;
                                if (Convert.ToString(dgvVenta.Rows[i].Cells[1].Value) != "")
                                {
                                    SumaIgv += Convert.ToDecimal(dgvVenta.Rows[i].Cells[6].Value);
                                    SumaSubTotal += Convert.ToDecimal(dgvVenta.Rows[i].Cells[4].Value);
                                    GuardarDetalleVenta(
                                    Convert.ToString(dgvVenta.Rows[i].Cells[5].Value),
                                    Convert.ToInt32(dgvVenta.Rows[i].Cells[0].Value),
                                    Convert.ToInt32(dgvVenta.Rows[i].Cells[1].Value),
                                    Convert.ToDecimal(dgvVenta.Rows[i].Cells[3].Value),
                                    SumaIgv, SumaSubTotal
                                    );
                                    MessageBox.Show("Contiene Datos.");
                                }
                                else
                                {
                                    MessageBox.Show("Fila Vacia.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Existe Ningún Elemento en la Lista.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
                
            }
            else
            {
                MessageBox.Show("No Existe Ningún Elemento en la Lista.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GuardarVenta()
        {
            decimal Total = 0;
            if (Convert.ToString(dgvVenta.CurrentRow.Cells[2].Value) != "")
            {
                for (int i = 0; i < dgvVenta.Rows.Count; i++)
                {
                    Total = Convert.ToDecimal(dgvVenta.Rows[i].Cells[4].Value);
                }
                string TipoDocumento = "";
                //TipoDocumento = rbnBoleta.Checked == true ? "Boleta" : "Factura";
                //Ventas.IdUser = Program.UserLogueado;
                Ventas.IdCliente = Program.IdCliente;
                Ventas.Serie = lblSerie.Text;
                Ventas.NroNroComprobante = lblNroCorrelativo.Text;
                Ventas.TipoDocumento = TipoDocumento;
                Ventas.FechaVenta = Convert.ToDateTime(dpFechafin.Value);
                Ventas.Total = Total;
                //MessageBox.Show(Ventas.RegistrarVenta(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GuardarDetalleVenta(string objIdProducto, Int32 objIdVenta, Int32 objCantidad, Decimal objPUnitario,
            Decimal objIgv, Decimal objSubTotal)
        {
            Detalle.IdProducto = objIdProducto;
            Detalle.IdVenta = objIdVenta;
            Detalle.Cantidad = objCantidad;
            Detalle.PrecioUnitario = objPUnitario;
            Detalle.Igv = objIgv;
            Detalle.SubTotal = objSubTotal;
            //Detalle.RegistrarDetalleVenta();
            
            //GenerarIdVenta();
            //GenerarNumeroComprobante();
        }

        private void btnEliminaritem_Click(object sender, EventArgs e)
        {

            if (dgvVenta.Rows.Count > 0)
            {
                if (dgvVenta.Rows[dgvVenta.CurrentRow.Index].Selected == true)
                {
                    if (Convert.ToString(dgvVenta.CurrentRow.Cells[2].Value) != "")
                    {
                        dgvVenta.Rows.RemoveAt(dgvVenta.CurrentRow.Index);
                        lst.RemoveAt(dgvVenta.CurrentRow.Index);
                        LlenarGrilla();
                        MessageBox.Show("Producto Eliminado de la Lista.", "Figueri.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Existe Ningun Elemento en la Lista.", "Figueri.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvVenta.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione Item Para Quitar", "Figueri.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No Existe Ningun Elemento en la Lista", "Figueri.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbnBoleta_CheckedChanged_1(object sender, EventArgs e)
        {
            GenerarNumeroComprobante();
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /*private void rbnNC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnNC.Checked == true)
                lblTipo.Text = "NOTA DE CRÉDITO";
            CNVentas cNVentas = new CNVentas();
            String correlativo = cNVentas.traerCorrelativo(3);
            lblSerie.Text = "NC001";
            lblNroCorrelativo.Text = correlativo.ToString();
        }*/

        private void dgvVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgvVenta.RowCount - 4)
            {
                var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                format.CurrencySymbol = "";
                if (dgvVenta.Columns[e.ColumnIndex].Name == "CANTIDAD")
                {
                    int cant = Int32.Parse(dgvVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    //MessageBox.Show(cant.ToString());
                    double precio = Double.Parse(dgvVenta.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString());
                    // MessageBox.Show(precio.ToString());
                    double resultado = cant * precio;
                    int stock = Int32.Parse(dgvVenta.Rows[e.RowIndex].Cells["STOCK"].Value.ToString());
                    if (cant <= stock)
                    {
                        dgvVenta.Rows[e.RowIndex].Cells["IMPORTE"].Value = resultado.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Stock insuficiente");
                        dgvVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldvalue;
                    }
                    dgvVenta.Rows[lst.Count + 1].Cells[3].Value = "SUB-TOTAL  S/.";
                    dgvVenta.Rows[lst.Count + 1].DefaultCellStyle.FormatProvider = format;
                    dgvVenta.Rows[lst.Count + 1].Cells[4].Value = SumaSubTotal;
                    dgvVenta.Rows[lst.Count + 2].Cells[3].Value = "      I.G.V.        %";
                    dgvVenta.Rows[lst.Count + 2].DefaultCellStyle.FormatProvider = format;
                    dgvVenta.Rows[lst.Count + 2].Cells[4].Value = SumaIgv;
                    dgvVenta.Rows[lst.Count + 3].Cells[3].Value = "     TOTAL     S/.";
                    SumaTotal += SumaSubTotal + SumaIgv;
                    dgvVenta.Rows[lst.Count + 3].DefaultCellStyle.FormatProvider = format;
                    dgvVenta.Rows[lst.Count + 3].Cells[4].Value = SumaTotal;
                    dgvVenta.ClearSelection();
                }
            }

                
        }

        private void dgvVenta_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < dgvVenta.RowCount - 4)
                oldvalue = (int)dgvVenta[e.ColumnIndex, e.RowIndex].Value;
        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(dgvVenta.CurrentRow.Cells[2].Value) != "")
                {
                    GuardarVenta();
                    try
                    {
                        for (int i = 0; i < dgvVenta.Rows.Count; i++)
                        {
                            Decimal SumaIgv = 0; Decimal SumaSubTotal = 0;
                                SumaIgv += Convert.ToDecimal(dgvVenta.Rows[i].Cells[6].Value);
                                SumaSubTotal += Convert.ToDecimal(dgvVenta.Rows[i].Cells[4].Value);
                                GuardarDetalleVenta(
                                Convert.ToString(dgvVenta.Rows[i].Cells[5].Value),
                                Convert.ToInt32(dgvVenta.Rows[i].Cells[0].Value),
                                Convert.ToInt32(dgvVenta.Rows[i].Cells[1].Value),
                                Convert.ToDecimal(dgvVenta.Rows[i].Cells[3].Value),
                                SumaIgv, SumaSubTotal
                                );
                           
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No Existe Ningún Elemento en la Lista.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DialogResult r = MessageBox.Show("¿Desea guardar", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    //CeldaNumerico();

                    CEVenta v = new CEVenta();

                    //CECliente c = new CECliente();
                    tbIdCliente.Text = tbIdCliente.ToString();

                   
                }
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea realizar una nueva venta?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    FormVenta ven = new FormVenta();

                }
                else
                {  // no hacer nada 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(" rowindex" + e.RowIndex + " rowcount " + dgvVenta.RowCount);
            if (e.RowIndex < dgvVenta.RowCount-4)
            {
                tbAlias.Text = dgvVenta.Rows[e.RowIndex].Cells["ALIAS"].Value.ToString();
                tbDescripcion.Text = dgvVenta.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbStock.Text = dgvVenta.Rows[e.RowIndex].Cells["STOCK"].Value.ToString();
                //dtFechaV.Text = form.fechavencimiento;
                tbPrecio.Text = dgvVenta.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            String indice = cboTipoDoc.SelectedValue.ToString();
            if (indice == "1")
            {
                lblTipo.Text = "FACTURA";
                CNVentas cNVentas = new CNVentas();
                String correlativo = cNVentas.traerCorrelativo(1);
                lblSerie.Text = "F001";
                lblNroCorrelativo.Text = correlativo.ToString();
            }else if (indice=="3")
            {
        
                lblTipo.Text = "BOLETA";
                CNVentas cNVentas = new CNVentas();
                String correlativo = cNVentas.traerCorrelativo(2);
                lblSerie.Text = "B001";
                lblNroCorrelativo.Text = correlativo.ToString();
            }else if(indice == "96")
            {
                lblTipo.Text = "NOTA DE CRÉDITO";
                CNVentas cNVentas = new CNVentas();
                String correlativo = cNVentas.traerCorrelativo(3);
                lblSerie.Text = "NC001";
                lblNroCorrelativo.Text = correlativo.ToString();
            }
                
        }
    }   
}

