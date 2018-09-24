using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaNegocio;
using CapaEntidades;
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
using CapaDatos;
using System.Drawing.Imaging;
using System.Windows;

namespace SistemaFigueri
{
    public partial class FormVenta : Form
    {

        List<Panel> panel = new List<Panel>();
        public int IdUsuario;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private static FormVenta _instancia;
        Venta sales;
        LocalBD serie = new LocalBD();
        CNDetalleVenta Detalle = new CNDetalleVenta();
        private List<Venta> lst = new List<Venta>();
        private int oldvalue { get; set; }
        Decimal SumaTotal { get; set; }
        Decimal SumaSubTotal { get; set; }
        Decimal SumaIgv { get; set; }


        CE_Cliente ECLiente;

        double TCVenta;
        double ImporteNeto = 0.00;
        double MontoPago = 0.00;

        CNVentas dObj_Modelo = new CNVentas();
        public AutoCompleteStringCollection autocompletatb = new AutoCompleteStringCollection();
        public static FormVenta GetInstancia()
        {
            if (_instancia == null)
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
        public void producto(string Alias, string DescripcionProducto,
            decimal Valor_Unitario, int Stock, DateTime TiempoDuracion)
        {

        }

        public FormVenta()
        {
            InitializeComponent();
           
        }
       
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


        //Método Mostrar
        private void Mostrar()
        {
            //this.dataVentas.DataSource = CNVenta.Mostrar();
            
            //lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarFecha
        private void BuscarFechas()
        {
            //this.dataVentas.DataSource = CNVenta.BuscarFechas(this.dpFechaInicio.Value.ToString("dd/MM/yyyy"), this.dpFechafin.Value.ToString("dd/MM/yyyy"));
            
            //lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);

        }

        //Método BuscarDetalles
        private void MostrarDetalles()
        {
            //this.dataVentas.DataSource = CNVenta.MostrarDetalle(this.tbIdVenta.Text);
            
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


        private void btnRegistrarCobro_Click(object sender, EventArgs e)
        {
            FormRegistroCobro frmRegCobro = new FormRegistroCobro();
            frmRegCobro.ShowDialog();
        }

        public void LIstaFormapago()
        {
            CDVenta Cv = new CDVenta();
            
            /*cboTipoPago.DisplayMember = "DescripcionTipo";
            cboTipoPago.ValueMember = "IdtipoPago";
            cboTipoPago.DataSource = Cv.CargaFormaPago();*/
        }
        private void ListaMoneda()
        {
            CDVenta Ds = new CDVenta();
            
           /* CboMoneda.DisplayMember = "DesMoneda";
            CboMoneda.ValueMember = "IdMoneda";
            CboMoneda.DataSource = Ds.CargaMoneda();*/
        }
        private void ListaTipoDoc()
        {
            CNVentas Ds = new CNVentas();
            cboTipoDoc.ValueMember = "Id_comp_pago";
            cboTipoDoc.DisplayMember = "des_comp_pago_breve";
            cboTipoDoc.DataSource = Ds.MostarCboTipoDoc();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            var cards = new Bunifu.Framework.UI.BunifuCards();
            MostrarClientes();
            this.crearTabla();
            
            String fecha2 = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek).ToString("yyyy-MM-dd");
            dtpFechaEmision.Value = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek);
            dtpFechaEmision.Value = DateTime.Today;

            //GenerarIdVenta();
            // GenerarSeriedeDocumento();
            dgvVenta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //bu.autoCompletar(tbBuscaClienteRece);

            //var aux = new Busqueda_Cliente();
            //aux.Lista(dgvProductos);
            LIstaFormapago();
            ListaMoneda();
            ListaTipoDoc();
            crearTabla();

            CNVentas cNVentas = new CNVentas();
            int idcomprobante = Int32.Parse(cboTipoDoc.SelectedValue.ToString());
            cboSerie.ValueMember = "IdSerie";
            cboSerie.DisplayMember = "Serie";
            cboSerie.DataSource = cNVentas.traerSerie(idcomprobante);
            int idserie = Int32.Parse(cboSerie.SelectedValue.ToString());
            String correlativo = cNVentas.traerCorrelativo(idcomprobante,idserie);
            lblSerie.Text = cboSerie.Text;
            lblNroCorrelativo.Text = correlativo;
            double amount =0.00;
            tbImpTotal.Text = String.Format("{0:N}", amount);
            /* tbTotalPagar.Text = String.Format("{0:N}", amount);
             tbTotalCobrado.Text = String.Format("{0:N}", amount);
             tbSaldoSoles.Text = String.Format("{0:N}", amount);
             tbSaldoDolares.Text = String.Format("{0:N}", amount);
             tbVuelto.Text = String.Format("{0:N}", amount);*/
            /*tbTotalPagar.Text = amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PE"));
            tbTotalCobrado.Text = amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PE"));
            tbSaldoSoles.Text = amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PE"));
            tbSaldoDolares.Text = amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ca"));
            tbVuelto.Text = amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PE"));*/
            CNClientes cli = new CNClientes();
            List<String> listaClientes = cli.filtroClienteEmpresa();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach(String c in listaClientes)
            {
                coleccion.Add(c);
            }
            tbrazonsocial.AutoCompleteCustomSource = coleccion;

        }
        private void VAlidaSoloNumero()
        {

            try
            {
                int i = oldvalue; decimal v = 0; String valor, valor_01; Boolean res = false;
                foreach (DataGridViewRow row in dgvVenta.Rows)
                {
                    if (row.Cells[1].Value == null) row.Cells[1].Value = 0;
                    valor = row.Cells[1].Value.ToString();
                    res = int.TryParse(valor, out i);
                    if (res == false)
                    {
                        MessageBox.Show("Solo números 'Cantidad', valor se reducira a cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells[1].Value = i;
                    }
                    if (row.Cells[1].Value == null) row.Cells[3].Value = 0;
                    valor_01 = row.Cells[1].Value.ToString().Replace(".", ",");
                    if (!Decimal.TryParse(valor_01, out v))
                    {
                        //MessageBox.Show(, valor se reducira a cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells[3].Value = 0;
                    }
                    else
                    {
                        row.Cells[1].Value = valor_01;

                    }

                }
            }
            catch
            {

            }

        }

        public void filtrar(DataTable data, String buscarnombre)
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

      

        private void btnBuscaProcto_Click(object sender, EventArgs e)
        {
            if(tbIdCliente.Text == "")
            {
                MessageBox.Show("Elija el cliente primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (FormBuscarProducto form = new FormBuscarProducto())
                {
                    form.idcliente = tbIdCliente.Text;
                    Boolean existe = false;
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
                        ven.IdProducto = form.idproducto;
                        //MessageBox.Show(form.idproducto);
                        for(int j = 0; j < lst.Count; j++)
                        {
                            //MessageBox.Show("En la lista" + lst[j].IdProducto);
                            if (lst[j].IdProducto.ToString() == form.idproducto)
                            {
                                //MessageBox.Show("Producto repetido");
                                existe = true;
                                int quantity = Int32.Parse(lst[j].Cantidad.ToString()) + 1;
                                decimal price = lst[j].PrecioVenta;
                                lst[j].Cantidad = quantity;
                                lst[j].SubTotal = quantity * price;
                            }
                        }
                        if (existe == false)
                        {
                            lst.Add(ven);
                        }
                        
                        LlenarGrilla();

                    }


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

                dgvVenta.Columns[1].Width = 10;
                dgvVenta.Columns[2].Width = 70;
                dgvVenta.Columns[3].Width = 30;
                dgvVenta.Columns[4].Width = 60;

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
            SumaTotal = SumaSubTotal + SumaIgv;
            dgvVenta.Rows[lst.Count + 3].DefaultCellStyle.FormatProvider = format;
            dgvVenta.Rows[lst.Count + 3].Cells[4].Value = SumaTotal;
            tbImpTotal.Text = SumaTotal.ToString();
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
            tbAlias.Clear();
            Program.DescripcionProducto = "";
            Program.Stock = 0;
            Program.Alias = "";
            Program.PrecioVenta = 0;
        }
        private void LimpiarClienteDNI()
        {
            tbtipodoc.Clear();
            tbClienteNombre.Clear();
            tbCliapellido.Clear();
            tbrazonsocial.Clear();
            tbRuc.Clear();
        }
        private void LimpiarClienteRUC()
        {
            tbtipodoc.Clear();
            tbClienteNombre.Clear();
            tbrazonsocial.Clear();
        }
        private void LimpiarProducto()
        {
            tbPrecio.Clear();
            tbAlias.Clear();
            tbDescripcion.Clear();
            tbStock.Clear();
            tbAlias.Clear();
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
                    tbClienteNombre.Text = form.clienteN;
                    tbCliapellido.Text = form.clienteA;
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
                    LimpiarClienteDNI();
                    LimpiarClienteRUC();
                    tbrazonsocial.Text = form.empresa;
                    tbClienteNombre.Text = form.clienteNombres;
                    tbCliapellido.Text = form.clienteApellidos;
                    tbRuc.Text = form.ruc;
                    tbtipodoc.Text = form.tipodoc;
                    tbDocumento.Text = form.ndoc;
                    dtpFechaEmision.Value=(Convert.ToDateTime(form.fechaPedido));
                    Venta ven;
                    Decimal Porcentaje = 0; Decimal SubTotal=0;

                    
                   
                    //MessageBox.Show(ven.PrecioVenta.ToString());


                    Porcentaje = (Convert.ToDecimal(tbIgv.Text) / 100) + 1;
                    
                    CNVentas cn;

                    lst.Clear();
                    foreach (DataRow row in form.tablaDetallePedido.Rows)
                    {
                        cn = new CNVentas();
                        ven = new Venta();
                        //MessageBox.Show(row["IdProducto"].ToString()+ " "+ row["DescripcionProducto"].ToString());
                        ven.Descripcion = row["Alias"].ToString() + " - " + row["DescripcionProducto"].ToString();
                        ven.alias = tbAlias.Text;
                        ven.Cantidad = Convert.ToInt32(row["Cantidad"].ToString());
                        Decimal nuevoPrecio = cn.traerPrecio(form.idcliente, row["IdProducto"].ToString());
                        ven.PrecioVenta = nuevoPrecio;
                        SubTotal = (nuevoPrecio * ven.Cantidad) / Porcentaje;
                        ven.Igv = Math.Round(SubTotal * (Convert.ToDecimal(tbIgv.Text) / (100)), 2);
                        ven.SubTotal = Math.Round(SubTotal, 2);
                        ven.stock = Int32.Parse(row["Stock"].ToString());
                        lst.Add(ven);
                       
                    }
                    LlenarGrilla();


                }
            }
        }

        private void tbRuc_TextChanged(object sender, EventArgs e)
        {
            if (tbRuc.Text == "")
            {
                if (chkruc.Checked == true)
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


        private void btRegistraVenta_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count > 0)
            {
                using (FormComprobanteVenta formC = new FormComprobanteVenta())
                {

                    QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                    QrCode qrCode = new QrCode();
                    qrEncoder.TryEncode(lblSerie + " - " + lblNroCorrelativo, out qrCode);

                    GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                    MemoryStream ms = new MemoryStream();

                    renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                    var imageTemporal = new Bitmap(ms);
                    var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));
                    //panelResultado.BackgroundImage = imagen;

                    ////Guardar en el disco duro la imagen (Carpeta del proyecto)

                    ////String urlSave = "C:\\Users\\AlphaLeader\\Desktop\\SisFVS2\\SistemaFigueri\\SistemaFigueri\\Resources\\" + lblSerie.Text + lblNroCorrelativo.Text + "QR.png";
                    ////imagen.Save(urlSave, ImageFormat.Png);

                    //FileStream fs;
                    //// define te binary reader to read the bytes of image 

                    //BinaryReader br;
                    //// check the existance of image 

                    //if (File.Exists(urlSave))
                    //{
                    //    // open image in file stream 

                    ////    fs = new FileStream(urlSave, FileMode.Open);
                    ////}
                    ////else
                    ////{
                    ////    // if phot does not exist show the nophoto.jpg file 

                    ////    fs = new FileStream(urlSave, FileMode.Open);
                    ////}
                    //// initialise the binary reader from file streamobject 

                    //br = new BinaryReader(fs);
                    //// define the byte array of filelength 

                    //byte[] imgbyte = new byte[fs.Length + 1];
                    //// read the bytes from the binary reader 

                    //imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)));


                    //br.Close();
                    //// close the binary reader 

                    //fs.Close();
                    //// close the file stream 


                    Reportes.DsDetalleVenta dsdet = new Reportes.DsDetalleVenta();
                    int filas = dgvVenta.Rows.Count;
                    //MessageBox.Show(filas.ToString());
                    String client = "";
                    client = chkcliente.Checked == true ? tbClienteNombre.Text : tbrazonsocial.Text;
                    String letraImporte = "";
                    Conversiones conv = new Conversiones();
                    letraImporte = conv.enletras(SumaTotal.ToString());



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
                                    //dtFechaV.Text,
                                    "SOLES",
                                    "18.00 %",
                                     SumaSubTotal,
                                     SumaIgv,
                                     SumaTotal,
                                     letraImporte,
                                     //imgbyte

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
            /*decimal Total = 0;
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
            }*/
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

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void dgvVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.BeginInvoke(new MethodInvoker(() =>
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
                            //MessageBox.Show(precio.ToString());
                            double resultado = cant * precio;
                            int stock = Int32.Parse(dgvVenta.Rows[e.RowIndex].Cells["STOCK"].Value.ToString());
                            //MessageBox.Show(resultado.ToString());
                            if (cant <= stock)
                            {
                                dgvVenta.Rows[e.RowIndex].Cells["IMPORTE"].Value = resultado.ToString();
                                //MessageBox.Show(dgvVenta.Rows[e.RowIndex].Cells["IMPORTE"].Value.ToString());
                                //ImproteTotal.Text = SumaIgv.ToString("0.00");
                            }
                            else
                            {
                                MessageBox.Show("Stock insuficiente");
                                dgvVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldvalue;
                            }
                            String idActual = dgvVenta.Rows[e.RowIndex].Cells[5].Value.ToString();
                            for (int j = 0; j < lst.Count; j++)
                            {

                                if (idActual == lst[j].IdProducto)
                                {
                                    lst[j].Cantidad = cant;
                                    //LlenarGrilla();
                                }
                            }
                            SumaSubTotal = 0; SumaIgv = 0;
                            for (int i = 0; i < lst.Count; i++)
                            {
                                SumaSubTotal += Convert.ToDecimal(dgvVenta.Rows[i].Cells[4].Value);
                                SumaIgv += Convert.ToDecimal(dgvVenta.Rows[i].Cells[6].Value);
                            }
                            //dgvVenta.Columns[4].DefaultCellStyle.BackColor = Color.Tan;
                            dgvVenta.Rows[lst.Count + 1].Cells[3].Value = "SUB-TOTAL  S/.";
                            dgvVenta.Rows[lst.Count + 1].DefaultCellStyle.FormatProvider = format;
                            dgvVenta.Rows[lst.Count + 1].Cells[4].Value = SumaSubTotal;
                            dgvVenta.Rows[lst.Count + 2].Cells[3].Value = "      I.G.V.        %";
                            dgvVenta.Rows[lst.Count + 2].DefaultCellStyle.FormatProvider = format;
                            dgvVenta.Rows[lst.Count + 2].Cells[4].Value = SumaIgv;
                            dgvVenta.Rows[lst.Count + 3].Cells[3].Value = "     TOTAL     S/.";
                            SumaTotal = SumaSubTotal + SumaIgv;
                            dgvVenta.Rows[lst.Count + 3].DefaultCellStyle.FormatProvider = format;
                            dgvVenta.Rows[lst.Count + 3].Cells[4].Value = SumaTotal;
                            tbImpTotal.Text = SumaTotal.ToString();
                            dgvVenta.ClearSelection();
                        }


                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error end edit cell", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }


        private void btnGuarda_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            try
            {
                if (e.RowIndex < dgvVenta.RowCount - 4)
                {
                    tbAlias.Text = dgvVenta.Rows[e.RowIndex].Cells["ALIAS"].Value.ToString();
                    tbDescripcion.Text = dgvVenta.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbStock.Text = dgvVenta.Rows[e.RowIndex].Cells["STOCK"].Value.ToString();
                    //dtFechaV.Text = form.fechavencimiento;
                    tbPrecio.Text = dgvVenta.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                VAlidaSoloNumero();

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //MessageBox.Show(" rowindex" + e.RowIndex + " rowcount " + dgvVenta.RowCount);
           

            */
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            String indice = cboTipoDoc.SelectedValue.ToString();
            int idserie=0; String correlativo = "";
            
            CNVentas cNVentas = new CNVentas();
            switch (indice)
            {
                case "1":
                    

                    cboSerie.ValueMember = "IdSerie";
                    cboSerie.DisplayMember = "Serie";
                    cboSerie.DataSource = cNVentas.traerSerie(Int32.Parse(indice));
                    idserie = Int32.Parse(cboSerie.SelectedValue.ToString());
                    correlativo = cNVentas.traerCorrelativo(Int32.Parse(indice), idserie);

                    lblSerie.Text = cboSerie.Text;
                    lblNroCorrelativo.Text = correlativo;
                    lblTipo.Text = "FACTURA DE VENTA";
                    break;
                case "2":
                 

                    cboSerie.ValueMember = "IdSerie";
                    cboSerie.DisplayMember = "Serie";
                    cboSerie.DataSource = cNVentas.traerSerie(Int32.Parse(indice));
                    idserie = Int32.Parse(cboSerie.SelectedValue.ToString());
                    correlativo = cNVentas.traerCorrelativo(Int32.Parse(indice), idserie);

                    lblSerie.Text = cboSerie.Text;
                    lblNroCorrelativo.Text = correlativo;
                    lblTipo.Text = "BOLETA DE VENTA";
                    break;
                case "96":
                    //MUY PRONTO ...
                    break;
                default:

                    break;
            }    

            
        }
        private void BuscaCLienteEmpresa()
        {
            try
            {
                CECliente c = null;
                String empresa = tbrazonsocial.Text;
                c = CNClientes.Intancia.BuscarClienteEmpresa(0, empresa);
                //MessageBox.Show("Aquii" + c.IdCliente);
                //tbIdCliente.Text = c.IdCliente;
                tbIdCliente.Text = c.Id_Cliente;
                tbClienteNombre.Text = c.Nombres;
                tbCliapellido.Text = c.Apellidos;
                tbDocumento.Text = c.DNI;
                //tbrazonsocial.Text = c.Nombre_Empresa;
                tbtipodoc.Text = c.Documento;
                tbRuc.Text = c.RUC;
                string i = LocalBD.Instancia.ReturnIdCliente(1, c.Id_Cliente);
            }
            catch (ApplicationException)
            {
                DialogResult r = MessageBox.Show("No se encontró al Cliente, ¿realizar Búsqueda avanzada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    using (FormBuscarClienteR form = new FormBuscarClienteR())
                    {
                        if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            tbClienteNombre.Text = form.clienteN;
                            tbCliapellido.Text = form.clienteA;
                            tbRuc.Text = form.ruc;
                            tbDocumento.Text = form.dni;
                            tbtipodoc.Text = form.tipodoc;
                            tbrazonsocial.Text = form.empresa;
                            tbIdCliente.Text = form.idcliente;

                            CNProductos objProducto = new CNProductos();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscaCLienteVentaEmpresa()
        {
            try
            {
                CECliente c = null;
                String num_doc = tbDocumento.Text;
                c = CNClientes.Intancia.BuscarClienteEmpresa(0, num_doc);
                //tbIdCliente.Text = c.IdCliente;
                tbIdCliente.Text = c.Id_Cliente;
                tbClienteNombre.Text = c.Nombres;
                tbCliapellido.Text = c.Apellidos;
                tbrazonsocial.Text = c.Nombre_Empresa;
                tbtipodoc.Text = c.Documento;
                tbRuc.Text = c.RUC;
                string i = LocalBD.Instancia.ReturnIdCliente(1, c.Id_Cliente);
            }
            catch (ApplicationException)
            {
                DialogResult r = MessageBox.Show("No se encontro al Cliente, ¿realizar Búsqueda avanzada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    using (FormBuscarClienteR form = new FormBuscarClienteR())
                    {
                        if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            tbClienteNombre.Text = form.clienteN;
                            tbCliapellido.Text = form.clienteA;
                            tbRuc.Text = form.ruc;
                            tbDocumento.Text = form.dni;
                            tbtipodoc.Text = form.tipodoc;
                            tbrazonsocial.Text = form.empresa;
                            tbIdCliente.Text = form.idcliente;

                            CNProductos objProducto = new CNProductos();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscaCLienteVentaDNI()
        {
            try
            {
                CECliente c = null;
                String num_doc = tbDocumento.Text;
                c = CNClientes.Intancia.BuscarCliente(0, num_doc);
                //tbIdCliente.Text = c.IdCliente;
                tbIdCliente.Text = c.Id_Cliente;
                tbClienteNombre.Text = c.Nombres;
                tbCliapellido.Text = c.Apellidos;
                tbrazonsocial.Text = c.Nombre_Empresa;
                tbtipodoc.Text = c.Documento;
                tbRuc.Text = c.RUC;
                string i = LocalBD.Instancia.ReturnIdCliente(1, c.Id_Cliente);
            }
            catch (ApplicationException)
            {
                DialogResult r = MessageBox.Show("No se encontro al Cliente, ¿realizar Búsqueda avanzada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    using (FormBuscarClienteR form = new FormBuscarClienteR())
                    {
                        if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            tbClienteNombre.Text = form.clienteN;
                            tbCliapellido.Text = form.clienteA;
                            tbRuc.Text = form.ruc;
                            tbDocumento.Text = form.dni;
                            tbtipodoc.Text = form.tipodoc;
                            tbrazonsocial.Text = form.empresa;
                            tbIdCliente.Text = form.idcliente;

                            CNProductos objProducto = new CNProductos();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuscaProductoCB()
        {
            /*try
            {*/
                CEProducto p = null;
                String Cod_barra = tbCodBarras.Text;
                p = CNProductos.Instancia.BuscaProductoBarra(0, Cod_barra);
                //tbIdCliente.Text = c.IdCliente;
                tbAlias.Text = p._Alias;
                sales = new Venta();
            sales.Descripcion = p._DescripcionProducto;
            sales.stock = p._Stock;
            sales.IdProducto = p._IdProdcuto;
            sales.Cantidad = 1;
            // p._precio = Convert.ToDouble(tbPrecio.Text.ToString());       
            // p._precio = Convert.ToDouble(tbPrecio.Text.ToString());       

            tbIdProducto.Text = p._IdProdcuto;
                CNVentas cn = new CNVentas();
                Decimal nuevoPrecio = cn.traerPrecio(tbIdCliente.Text.ToString(), tbIdProducto.Text.ToString());
            sales.PrecioVenta = nuevoPrecio;
                //String i = LocalBD.Instancia.ReturnIdprod(1, p._Codigo);

            /*}
            catch (ApplicationException)
            {
                DialogResult r = MessageBox.Show("No se encontro el producto, ¿realizar Búsqueda avanzada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    using (FormBuscarProducto form = new FormBuscarProducto())
                    {
                        if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            //tbAlias.Text = form.alias;
                            //tbDescripcion.Text = form.descripcion;
                            //tbStock.Text = form.stock;
                            ////dtFechaV.Text = form.fechavencimiento;
                            //tbPrecio.Text = form.precio;
                            ////btnAgregaCarro.Enabled = true;
                            //tbIdProducto.Text = form.idproducto;

                            CNProductos objProducto = new CNProductos();
                            Limpiar();
                            tbAlias.Text = form.alias;
                            tbDescripcion.Text = form.descripcion;
                            tbStock.Text = form.stock;
                            //dtFechaV.Text = form.fechavencimiento;
                            tbPrecio.Text = form.precio;
                            //btnAgregaCarro.Enabled = true;
                            tbIdProducto.Text = form.idproducto;


                        }

                    }
                }
            }*/
            /*catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void BuscaCLienteVentaRUC()
        {

            try
            {
                CECliente c = null;
                String num_doc = tbRuc.Text;
                c = CNClientes.Intancia.BuscarCliente(0, num_doc);
                tbClienteNombre.Text = c.Nombres;
                tbrazonsocial.Text = c.Nombre_Empresa;
                tbtipodoc.Text = c.Documento;
                tbRuc.Text = c.RUC;
                string i = LocalBD.Instancia.ReturnIdCliente(1, c.Id_Cliente);
            }
            catch (ApplicationException)
            {
                DialogResult r = MessageBox.Show("No se encontro al Cliente, ¿realizar Búsqueda avanzada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    using (FormBuscarClienteR form = new FormBuscarClienteR())
                    {
                        if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            tbClienteNombre.Text = form.clienteN;
                            tbCliapellido.Text = form.clienteA;
                            tbRuc.Text = form.ruc;
                            tbDocumento.Text = form.dni;
                            tbtipodoc.Text = form.tipodoc;
                            tbrazonsocial.Text = form.empresa;
                            tbIdCliente.Text = form.idcliente;

                            CNProductos objProducto = new CNProductos();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tbClienteNombre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscaCLienteVentaDNI();
            }
            else
            {
                LimpiarClienteDNI();

            }
        }

        private void tbRuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscaCLienteVentaRUC();

            }
            else
            {
                LimpiarClienteRUC();

            }

        }

        private void tbDocumento_KeyUp(object sender, KeyEventArgs e)
        {

        }

        /*private void tformapago_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tformapago.SelectedTab == tabEfectivo)
            {
                cboTipoPago.SelectedIndex = cboTipoPago.FindStringExact("EN EFECTIVO");
            }
            else if (tformapago.SelectedTab == tabcredito)
            {
                cboTipoPago.SelectedIndex = cboTipoPago.FindStringExact("TARJETA / POS-INTEGRADO");
            }
            else if (tformapago.SelectedTab == tabCheque)
            {
                cboTipoPago.SelectedIndex = cboTipoPago.FindStringExact("CHEQUE");
            }
            else if (tformapago.SelectedTab == tabDeposito)
            {
                cboTipoPago.SelectedIndex = cboTipoPago.FindStringExact("DEPÓSITO");
            }
        }*/

        private void btnGuarda_Click_1(object sender, EventArgs e)
        {
            //CNVentas objUsuario = new CNVentas();
            //if (dgvVenta.Rows.Count > 0)
            //{
            //    if (Convert.ToString(dgvVenta.CurrentRow.Cells[2].Value) != "")
            //    {
            //        VAlidaSoloNumero();
            //        CEVenta v = new CEVenta();
            //        CECliente c = new CECliente();
            //        c.IdCliente = LocalBD.Instancia.ReturnIdClienteNV(0, 0);
            //        //v.Deposito_venta = CEVenta
            //    }
            //    else
            //    {
            //        MessageBox.Show("No Existe Ningún Elemento en la Lista.", "Figeueri.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No Existe Ningún Elemento en la Lista.", "Figueri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            if (ECLiente != null)
            {

                if (cboTipoDoc.SelectedIndex == 0)
                {
                    if (tbImpTotal.Text == "")
                    {
                        MessageBox.Show("Inserte un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {

                        int valorInserta = 0;
                        CE_FE_Comprobante_Venta dObj_Venta = new CE_FE_Comprobante_Venta();
                        List<CE_FE_Comprobante_Vta_Det> dObj_ListaDetalle = new List<CE_FE_Comprobante_Vta_Det>();
                       // CE_FE_Comprobante_VentaPago dObj_VentaPago = new CE_FE_Comprobante_VentaPago();

                        dObj_Venta = Llena_Entidad_Venta();
                        dObj_ListaDetalle = Llena_Entidad_Venta_Det();
                       // dObj_VentaPago = Llena_Entidad_Venta_Pago();
                        valorInserta = dObj_Modelo.Inserta_FEComprobanteVenta(dObj_Venta, dObj_ListaDetalle);
                        if (valorInserta > 0)
                        {
                            MessageBox.Show("Se ha realizado la venta Correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            MontoPago = Convert.ToDouble(tbImpTotal.Text);
                            //ImporteVuelto = (MontoPago - ImporteTotal);
                            //txtVuelto.Text = ImporteVuelto.ToString();
                            //SaldoSoles = 0.00;
                            //SaldoDolares = 0.00;
                            //txtSaldoSoles.Text = SaldoSoles.ToString();
                            //txtSaldoDolares.Text = SaldoDolares.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error al Insertar la Información de la Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

                }
                else if (cboTipoDoc.SelectedIndex == 1)
                {
                    if (tbImpTotal.Text == "")
                    {

                    }
                    else
                    {

                        int valorInserta = 0;
                        CE_FE_Comprobante_Venta dObj_Venta = new CE_FE_Comprobante_Venta();
                        List<CE_FE_Comprobante_Vta_Det> dObj_ListaDetalle = new List<CE_FE_Comprobante_Vta_Det>();
                        // CE_FE_Comprobante_VentaPago dObj_VentaPago = new CE_FE_Comprobante_VentaPago();
                        dObj_Venta = Llena_Entidad_Venta();
                        dObj_ListaDetalle = Llena_Entidad_Venta_Det();
                        // dObj_VentaPago = Llena_Entidad_Venta_Pago();
                        valorInserta = dObj_Modelo.Inserta_FEComprobanteVenta(dObj_Venta, dObj_ListaDetalle);
                        if (valorInserta > 0)
                        {
                            MessageBox.Show("Se ha realizado la venta Correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            MontoPago = Convert.ToDouble(tbImpTotal.Text);
                            //ImporteVuelto = (MontoPago - ImporteTotal);
                            //txtVuelto.Text = ImporteVuelto.ToString();
                            //SaldoSoles = 0.00;
                            //SaldoDolares = 0.00;
                            //txtSaldoSoles.Text = SaldoSoles.ToString();
                            //txtSaldoDolares.Text = SaldoDolares.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error al Insertar la Información de la Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
        }
            else
            {
                MessageBox.Show("Debe seleccionar primero un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


}
        
        private List<CE_FE_Comprobante_Vta_Det> Llena_Entidad_Venta_Det()
        {
          
            int num_item = 0;
            List<CE_FE_Comprobante_Vta_Det> Lista_Detalle = new List<CE_FE_Comprobante_Vta_Det>();

            foreach (DataGridViewRow rowGrid in dgvVenta.Rows)
            {
                num_item += 1;
                CE_FE_Comprobante_Vta_Det dObj_VentaDet = new CE_FE_Comprobante_Vta_Det();
                //dObj_VentaDet.Ide_Venta = ide_venta;
                dObj_VentaDet.Num_Item_Vta_Det = num_item;
                dObj_VentaDet.Ide_Producto = Convert.ToString(rowGrid.Cells[0].Value);
                dObj_VentaDet.Des_Concepto_Vta_Det = Convert.ToString(rowGrid.Cells[1].Value);
                dObj_VentaDet.Imp_Unit_Vta_Det = Convert.ToDouble(rowGrid.Cells[2].Value);
                dObj_VentaDet.Can_Unit_Vta_Det = Convert.ToDouble(rowGrid.Cells[4].Value);
                dObj_VentaDet.Imp_Costo_Vta_Det = Convert.ToDouble(rowGrid.Cells[6].Value);
                dObj_VentaDet.Por_Dscto_Vta_Det = 0.00;
                dObj_VentaDet.Imp_Dscto_Vta_Det = 0.00;
                dObj_VentaDet.Imp_Valor_Vta_Det = Convert.ToDouble(rowGrid.Cells[5].Value);
                dObj_VentaDet.Flg_Inaf_Vta_Det = 0;
                dObj_VentaDet.Por_Impto_Vta_Det = 18;
                dObj_VentaDet.Imp_Impto_Vta_Det = Convert.ToDouble(rowGrid.Cells[3].Value);
                dObj_VentaDet.Imp_Precio_Vta_Det = Convert.ToDouble(rowGrid.Cells[6].Value);

                Lista_Detalle.Add(dObj_VentaDet);
            }
            return Lista_Detalle;


        }
        private CE_FE_Comprobante_Venta Llena_Entidad_Venta()
        {
            CE_FE_Comprobante_Venta dObj_Venta = new CE_FE_Comprobante_Venta();

            dObj_Venta.Ide_Cliente = ECLiente.IdCliente;
            dObj_Venta.Ide_Comp_Pago = Convert.ToInt32(cboTipoDoc.SelectedValue);
            dObj_Venta.Num_Serie_Venta = cboSerie.Text;
            dObj_Venta.Num_Doc_Venta = "0";
            dObj_Venta.Fec_Emite_Venta = Convert.ToDateTime("01/01/1999");
            if (chkndoc.Checked)
            {
                dObj_Venta.Num_Ruc_Venta = ECLiente.NroDocumento;
            }
            else if (chkruc.Checked)
            {
                dObj_Venta.Num_Ruc_Venta = ECLiente.RUC;
            }
            dObj_Venta.Ide_Empresa_Fact = 0;
            dObj_Venta.Des_Nombre_Venta = ECLiente.Nombres + " " + ECLiente.ApellidoPaterno+""+ ECLiente.ApellidoMaterno;
            
          
            dObj_Venta.des_Direc_Venta = ECLiente.Direccion;
            dObj_Venta.Ide_Tipo_Venta = 1;
            dObj_Venta.Can_Dias_Pago_Venta = 0;
            dObj_Venta.Fec_Vmto_Venta = Convert.ToDateTime("01/01/1999");
            dObj_Venta.Ide_Motivo_Notcred = 0;
            dObj_Venta.Ref_Num_Serie_Venta = "";
            dObj_Venta.Ref_Num_Doc_Venta = "";
            dObj_Venta.Imp_Tipo_Cambio_Venta = TCVenta;
            
            dObj_Venta.Imp_Valor_Venta = ImporteNeto;
            dObj_Venta.Imp_Depo_Venta = 0.00;
            //if (cboMoneda.SelectedIndex == 0)
            //{
            //    dObj_Venta.Imp_Total_Venta = ImporteTotal;
            //}
            //else if (cboMoneda.SelectedIndex == 1)
            //{
            //    dObj_Venta.Imp_Total_Venta = ImporteTotalDolares;
            //}
            //dObj_Venta.Por_Impto_Venta = 18;
            //dObj_Venta.Imp_Impto_Venta = TotalIGV;
            //if (cboMoneda.SelectedIndex == 0)
            //{
            //    dObj_Venta.Imp_Impto_Venta = TotalIGV;
            //}
            //else if (cboMoneda.SelectedIndex == 1)
            //{
            //    dObj_Venta.Imp_Impto_Venta = (TotalIGV / TCVenta);
            //}
            //if (cboMoneda.SelectedIndex == 0)
            //{
            //    dObj_Venta.Imp_Precio_Venta = ImporteTotal;
            //}
            //else if (cboMoneda.SelectedIndex == 1)
            //{
            //    dObj_Venta.Imp_Precio_Venta = ImporteTotalDolares;
            //}
            dObj_Venta.Imp_Val_Inaf_Venta = 0.00;
            dObj_Venta.Imp_Depo_Inaf_Venta = 0.00;
            dObj_Venta.Imp_Precio_Inaf_Venta = 0.00;
            //if (cboMoneda.SelectedIndex == 0)
            //{
            //    dObj_Venta.Imp_Precio_Total_Venta = ImporteTotal;
            //}
            //else if (cboMoneda.SelectedIndex == 1)
            //{
            //    dObj_Venta.Imp_Precio_Total_Venta = ImporteTotalDolares;
            //}
            dObj_Venta.Imp_Paga_Venta = MontoPago;
            dObj_Venta.Imp_Saldo_Venta = 0.00;
            //dObj_Venta.Ide_Punto_Venta = IdPuntoVenta;
            //dObj_Venta.Ide_Area = IdArea;
            dObj_Venta.Ide_Estado_Venta = 1;
           // dObj_Venta.Ide_Usuario = IdCajero;
            dObj_Venta.Fec_Factu_Comp_Venta = Convert.ToDateTime("01/01/1999");
            dObj_Venta.Ide_Motivo_Anula_Venta = 0;
            dObj_Venta.Des_Obs_Motivo_Anula = "";
            dObj_Venta.Ide_Sucursal = 1;

            return dObj_Venta;

        }

        private void tbCodBarras_KeyDown(object sender, KeyEventArgs e)
        {
            /*try
            {*/
                if ( e.KeyCode == Keys.Enter)
                {
                    BuscaProductoCB();

                    //CNProductos objProducto = new CNProductos();
                    Venta ven = new Venta();
                    ven = sales;
                    Decimal Porcentaje = 0; Decimal SubTotal;

                       
                        Porcentaje = (Convert.ToDecimal(tbIgv.Text) / 100) + 1;
                        SubTotal = (ven.PrecioVenta * 1) / Porcentaje;
                        ven.Igv = Math.Round(Convert.ToDecimal(SubTotal) * (Convert.ToDecimal(tbIgv.Text) / (100)), 2);
                        ven.SubTotal = Math.Round(SubTotal, 2);
                        lst.Add(ven);
                      
                    
                    LlenarGrilla();
                    LimpiarProducto();
                }
                else
                {
                    LimpiarProducto();

                }

            /*}
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en evento KeyDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        
        }

        private void cboSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idcomprobante = Int32.Parse(cboTipoDoc.SelectedValue.ToString());
            int idserie = Int32.Parse(cboSerie.SelectedValue.ToString());
            CNVentas cNVentas = new CNVentas();
            String correlativo = cNVentas.traerCorrelativo(idcomprobante,idserie);
            lblSerie.Text = cboSerie.Text;
            lblNroCorrelativo.Text = correlativo;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            using (FormVentaPago form = new FormVentaPago())
            {

                CNVentas Ds = new CNVentas();
                //CARGAR COMBO TIPO DOC
                form.cboTipoDoc.ValueMember = "Id_comp_pago";
                form.cboTipoDoc.DisplayMember = "des_comp_pago_breve";
                form.cboTipoDoc.DataSource = Ds.MostarCboTipoDoc();
                int idcomprobante = Int32.Parse(cboTipoDoc.SelectedValue.ToString());
                tbIdComprobante.Text = idcomprobante.ToString();
                //CARGAR COMBO SERIE
                form.cboSerie.ValueMember = "IdSerie";
                form.cboSerie.DisplayMember = "Serie";
                form.cboSerie.DataSource = Ds.traerSerie(idcomprobante);
                //SELECCIONAR VALORES DE LOS COMBOS
                form.cboTipoDoc.SelectedIndex = cboTipoDoc.SelectedIndex;
                form.cboSerie.SelectedIndex = cboSerie.SelectedIndex;
                //CARGAR DATOS DEL CLIENTE
                form.tbDNI.Text = tbDocumento.Text;
                form.tbCliente.Text = tbClienteNombre.Text + " " + tbCliapellido.Text;
                form.tbEmpresa.Text = tbrazonsocial.Text;
                form.tbRUC.Text = tbRuc.Text;
                //CARGAR COMBO TIPO PAGO
                form.cboFormaPago.DisplayMember = "DescripcionTipo";
                form.cboFormaPago.ValueMember = "IdtipoPago";
                form.cboFormaPago.DataSource = Ds.MostarCboTipoPago();
                //CARGAR COMBO MONEDA
                form.cboMoneda.DisplayMember = "DesMoneda";
                form.cboMoneda.ValueMember = "IdMoneda";
                form.cboMoneda.DataSource = Ds.MostarCboMoneda();
                //CARGAR MONTO
                form.tbImporteTotal.Text = tbImpTotal.Text;
                form.tbTotalPagar.Text = tbImpTotal.Text;
                //CARGA TARJETA
                form.cboTarjeta.DisplayMember = "DesTarjeta";
                form.cboTarjeta.ValueMember = "IdTarjeta";
                form.cboTarjeta.DataSource = Ds.MostarCboTarjeta(2);
                //CARGA TIPO TARJETA
                form.cboTipoTarjeta.DisplayMember = "DesTipoTarjeta";
                form.cboTipoTarjeta.ValueMember = "IdTipoTarjeta";
                form.cboTipoTarjeta.DataSource = Ds.MostarCboTipoTarjeta();

                //form.ShowDialog();
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CDVenta cDVenta = new CDVenta();
                    CE_FE_Comprobante_Venta comp = new CE_FE_Comprobante_Venta();
                    comp.Ide_Cliente = tbIdCliente.Text;
                    comp.Ide_Comp_Pago = Int32.Parse(cboTipoDoc.SelectedValue.ToString());
                    comp.Num_Serie_Venta = lblSerie.Text;
                    comp.Fec_Emite_Venta = DateTime.Parse(dtpFechaEmision.Value.ToString("yyyy-MM-dd"));
                    comp.Num_Ruc_Venta = "20268781529";
                    comp.Des_Nombre_Venta = "FIGUERI";
                    comp.des_Direc_Venta = "LA ERA Ñaña LT. 01 MZ.R CP VIRGEN DEL CARMEN";
                    comp.Can_Dias_Pago_Venta = 0;
                    comp.Imp_Tipo_Cambio_Venta = Double.Parse(form.tbTipoCambio.Text);
                    comp.Ide_moneda = form.lista[0].IdMoneda;
                    comp.Imp_Valor_Venta = Double.Parse(SumaSubTotal.ToString());
                    comp.Imp_Total_Venta = Double.Parse(SumaTotal.ToString());
                    comp.Por_Impto_Venta = Double.Parse(tbIgv.Text.ToString());
                    comp.Imp_Impto_Venta = Double.Parse(SumaIgv.ToString());
                    comp.Imp_Paga_Venta = Double.Parse(form.tbTotalCobrado.Text.ToString());
                    comp.Imp_Saldo_Venta = Double.Parse(form.tbSaldoSoles.Text.ToString());
                    comp.Ide_Estado_Venta = 1;

                    //MessageBox.Show(LoginInfo.IdUsuario);
                    comp.Ide_Usuario = Int32.Parse(LoginInfo.IdUsuario);
                    
                    if (cDVenta.Inserta_FEComprobanteVenta(comp)>0)
                    {
                        MessageBox.Show("Se insertó correctamente");
                    }

                    foreach(Venta venta in form.lista){
                        CE_FE_Comprobante_VentaPago pago = new CE_FE_Comprobante_VentaPago();
                        pago.Num_Item_Venta_Pago = 1;
                        //pago.Ide_Forma_Pago = venta.id
                    }

                }
            }
        }

        private void tbImpTotal_TextChanged(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(tbImpTotal.Text.ToString());
            if (valor != 0.00M)
            {
                btnPagar.Enabled = true;
            }
            else
            {
                btnPagar.Enabled = false;
            }
        }

        private void tbrazonsocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscaCLienteEmpresa();
                tbCodBarras.Focus();
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            lst.Clear();
            LlenarGrilla();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarClienteDNI();
            lst.Clear();
            LlenarGrilla();
        }

       
    }
}


