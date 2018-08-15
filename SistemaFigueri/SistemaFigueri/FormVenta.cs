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


        public int IdUsuario;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private static FormVenta _instancia;
        private List<Venta> lst = new List<Venta>();



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
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        //Habilitar los controles 

        //private void Habilitar(bool valor)
        ////{
        ////    this.tbClienteNombre.ReadOnly = !valor;
        ////    this.tbAlias.ReadOnly = !valor;
        ////    this.txtCorrelativo.ReadOnly = !valor;
        ////    this.txtIgv.Enabled = valor;
        ////    this.dtFecha.Enabled = valor;
        ////    this.cbTipo_Comprobante.Enabled = valor;
        ////    this.txtCantidad.ReadOnly = !valor;
        ////    this.txtPrecio_Compra.ReadOnly = !valor;
        ////    this.txtPrecio_Venta.ReadOnly = !valor;
        ////    this.dtFecha_Vencimiento.Enabled = valor;
        ////    this.btnAgregar.Enabled = valor;
        ////    this.btnQuitar.Enabled = valor;
        ////    this.btnBuscarProveedor.Enabled = valor;
        ////    this.btnBuscarArticulo.Enabled = valor;
        ////}

        //Habilitar los botones
        //private void Botones()
        //{
        //    if (this.IsNuevo) //Alt + 124
        //    {
        //        this.Habilitar(true);
        //        this.btnNuevo.Enabled = false;
        //        this.btnGuardar.Enabled = true;
        //        this.btnCancelar.Enabled = true;
        //    }
        //    else
        //    {
        //        this.Habilitar(false);
        //        this.btnNuevo.Enabled = true;
        //        this.btnGuardar.Enabled = false;
        //        this.btnCancelar.Enabled = false;
        //    }

        //}

        //Método para ocultar columnas
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
        //private void FrmVenta_Load(object sender, EventArgs e)
        //{
        //    //Para ubicar al formulario en la parte superior del contenedor
        //    this.Top = 0;
        //    this.Left = 0;
        //    //Mostrar
        //    this.Mostrar();
        //    //Deshabilita los controles
        //    this.Habilitar(false);
        //    //Establece los botones
        //    this.Botones();
        //    this.crearTabla();

        //}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
        }

        //private void dataListado_DoubleClick(object sender, EventArgs e)
        //{



        //    this.txtIdventa.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idventa"].Value);
        //    this.txtCliente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["cliente"].Value);
        //    this.dtFecha.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha"].Value);
        //    this.cbTipo_Comprobante.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_comprobante"].Value);
        //    this.txtSerie.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["serie"].Value);
        //    this.txtCorrelativo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correlativo"].Value);
        //    this.lblTotalPagado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Total"].Value);
        //    this.MostrarDetalles();
        //    this.tabControl1.SelectedIndex = 1;

        //}

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

        //private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
        //    {
        //        DataGridViewCheckBoxCell ChkEliminar =
        //            (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
        //        ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
        //    }
        //}

        //private void btnNuevo_Click(object sender, EventArgs e)
        //{
        //    this.IsNuevo = true;
        //    this.Botones();
        //    this.Limpiar();
        //    this.limpiarDetalle();
        //    this.Habilitar(true);
        //    this.txtSerie.Focus();
        ////}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    this.IsNuevo = false;
        //    this.Botones();
        //    this.Limpiar();
        //    this.Limpiar();
        //    this.txtIdventa.Text = string.Empty;

        //}

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        //La variable que almacena si se inserto 
        //        //o se modifico la tabla
        //        string Rpta = "";
        //        if (this.txtIdcliente.Text == string.Empty || this.txtSerie.Text == string.Empty || txtCorrelativo.Text == string.Empty || txtIgv.Text == string.Empty)
        //        {
        //            MensajeError("Falta ingresar algunos datos, serán remarcados");
        //            errorIcono.SetError(txtCliente, "Seleccione un Proveedor");
        //            errorIcono.SetError(txtSerie, "Ingrese la serie del comprobante");
        //            errorIcono.SetError(txtCorrelativo, "Ingrese el número del comprobante");
        //            errorIcono.SetError(txtIgv, "Ingrese el porcentaje de IGV");
        //        }
        //        else
        //        {
        //            if (this.IsNuevo)
        //            {
        //                //Vamos a insertar un Ingreso 
        //                Rpta = NVenta.Insertar(Convert.ToInt32(txtIdcliente.Text),
        //                    Idtrabajador,
        //                dtFecha.Value, cbTipo_Comprobante.Text,
        //                txtSerie.Text, txtCorrelativo.Text,
        //                Convert.ToDecimal(txtIgv.Text), "EMITIDO", dtDetalle);

        //            }

        //            //Si la respuesta fue OK, fue porque se  
        //            //o inserto la venta
        //            //de forma correcta
        //            if (Rpta.Equals("OK"))
        //            {

        //                this.MensajeOk("Se insertó de forma correcta el registro");


        //            }
        //            else
        //            {
        //                //Mostramos el mensaje de error
        //                this.MensajeError(Rpta);
        //            }
        //            this.IsNuevo = false;
        //            this.Botones();
        //            this.Limpiar();
        //            this.limpiarDetalle();
        //            this.Mostrar();

        //        }
        //    }

        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message + ex.StackTrace);
        //    }
        //}

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (this.txtIddetalle_ingreso.Text == string.Empty || this.txtCantidad.Text == string.Empty || txtPrecio_Venta.Text == string.Empty)
        //        {
        //            MensajeError("Falta ingresar algunos datos, serán remarcados");
        //            errorIcono.SetError(txtArticulo, "Seleccione un Artículo");
        //            errorIcono.SetError(txtCantidad, "Ingrese el stock inicial");
        //            errorIcono.SetError(txtPrecio_Venta, "Ingrese el precio de Venta");
        //        }
        //        else
        //        {
        //            //Variable que va a indicar si podemos registrar el detalle
        //            bool registrar = true;
        //            foreach (DataRow row in dtDetalle.Rows)
        //            {
        //                if (Convert.ToInt32(row["iddetalle_ingreso"]) == Convert.ToInt32(this.txtIddetalle_ingreso.Text))
        //                {
        //                    registrar = false;
        //                    this.MensajeError("Ya se encuentra el artículo en el detalle");
        //                }
        //            }
        //            //Si podemos registrar el producto en el detalle
        //            if (registrar = true && Convert.ToInt32(this.txtCantidad.Text) <= Convert.ToInt32(this.txtStock.Text))
        //            {
        //                //Calculamos el sub total del detalle sin descuento
        //                decimal subTotal = Convert.ToDecimal(this.txtPrecio_Venta.Text) * Convert.ToDecimal(txtCantidad.Text) - Convert.ToDecimal(txtDescuento.Text);
        //                totalPagado = totalPagado + subTotal;
        //                this.lblTotalPagado.Text = totalPagado.ToString("#0.00#");
        //                //Agregamos al fila a nuestro datatable
        //                DataRow row = this.dtDetalle.NewRow();
        //                row["iddetalle_ingreso"] = Convert.ToInt32(this.txtIddetalle_ingreso.Text);
        //                row["articulo"] = this.txtArticulo.Text;
        //                row["cantidad"] = Convert.ToInt32(this.txtCantidad.Text);
        //                row["precio_venta"] = Convert.ToDecimal(this.txtPrecio_Venta.Text);
        //                row["descuento"] = Convert.ToDecimal(this.txtDescuento.Text);
        //                row["subTotal"] = subTotal;
        //                this.dtDetalle.Rows.Add(row);
        //                this.limpiarDetalle();
        //            }
        //            else
        //            {
        //                this.MensajeError("No hay Stock Disponible");
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message + ex.StackTrace);
        //    }
        //}

        //private void btnQuitar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //Indice dila actualmente seleccionado y que vamos a eliminar
        //        int indiceFila = this.datalistadoDetalle.CurrentCell.RowIndex;
        //        //Fila que vamos a eliminar
        //        DataRow row = this.dtDetalle.Rows[indiceFila];
        //        //Disminuimos el total a pagar
        //        this.totalPagado = this.totalPagado - Convert.ToDecimal(row["subTotal"].ToString());
        //        this.lblTotalPagado.Text = totalPagado.ToString("#0.00#");
        //        //Removemos la fila
        //        this.dtDetalle.Rows.Remove(row);
        //    }
        //    catch (Exception ex)
        //    {
        //        MensajeError("No hay fila para remover");
        //    }
        //}

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

        private void FormVenta_Load(object sender, EventArgs e)
        {
            var cards = new Bunifu.Framework.UI.BunifuCards();
            MostrarClientes();
            this.crearTabla();
            //bu.autoCompletar(tbBuscaClienteRece);

            //var aux = new Busqueda_Cliente();
            //aux.Lista(dgvProductos);

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

        private void tbBuscaClienteRece_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbBuscaProducto_TextAlignChanged(object sender, EventArgs e)
        {

        }
        public void lista(DataGridView dta)
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

    

        private void btnBuscaProcto_Click(object sender, EventArgs e)
        {
            using (FormBuscarProducto form = new FormBuscarProducto())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tbAlias.Text = form.alias;
                    tbDescripcion.Text = form.descripcion;
                    tbStock.Text = form.stock;
                    dtFechaV.Text = form.fechavencimiento;
                    tbPrecio.Text = form.precio;

                    CNProductos objProducto = new CNProductos();

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
            //tbRuc.Text = Program.NumeroRuc;
            //tbDocumento.Text = Program.NroDocIdentidad;
            //tbClienteNombre.Text = Program.ApellidoPaterno + "," + Program.ApellidoMaterno + "," + Program.Nombres;


        }

        private void btnAgregaCarro_Click_1(object sender, EventArgs e)
        {
            Venta ven = new Venta();
            Decimal Porcentaje = 0; Decimal SubTotal;
            if(this.tbClienteNombre.Text.Trim() != "")
            {
                if (tbCantidad.Text.Trim() != "")
                {
                    if (Convert.ToInt32(tbCantidad.Text) >= 0)
                    {
                        if (Convert.ToInt32(tbCantidad.Text) <= Convert.ToInt32(tbStock.Text))
                        {
                            if (tbIgv.Text.Trim() != "")
                            {

                                //ven.IdVenta = Convert.ToInt32(txtIdVenta.Text);
                                ven.Descripcion = tbAlias.Text + " - " + tbDescripcion.Text;
                                ven.Cantidad = Convert.ToInt32(tbCantidad.Text);
                                ven.PrecioVenta = Convert.ToDecimal(tbPrecio.Text);
                                Porcentaje = (Convert.ToDecimal(tbIgv.Text) / 100) + 1;
                                SubTotal = ((Convert.ToDecimal(tbPrecio.Text) * Convert.ToInt32(tbCantidad.Text)) / Porcentaje);
                                ven.Igv = Math.Round(Convert.ToDecimal(SubTotal) * (Convert.ToDecimal(tbIgv.Text) / (100)), 2);
                                ven.SubTotal = Math.Round(SubTotal, 2);
                                lst.Add(ven);
                                LlenarGrilla();
                                Limpiar();
                            }
                            else
                            {
                               
                            }
                        }
                        else
                        {
                            MessageBox.Show("Stock Insuficiente para Realizar la Venta.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {

                    }
                    {
                        MessageBox.Show("Cantidad Ingresada no Válida.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        tbCantidad.Clear();
                        tbCantidad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Ingrese Cantidad a Vender.", "Figueri", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    tbCantidad.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Por Favor Busque el Cliente a Vender.", "Figueri", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void LlenarGrilla()
        {
            Decimal SumaSubTotal = 0; Decimal SumaIgv = 0; Decimal SumaTotal = 0;
            dgvVenta.Rows.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                dgvVenta.Rows.Add();
                dgvVenta.Rows[i].Cells[0].Value = lst[i].IdVenta;
                dgvVenta.Rows[i].Cells[1].Value = lst[i].Cantidad;
                dgvVenta.Rows[i].Cells[2].Value = lst[i].Descripcion;
                dgvVenta.Rows[i].Cells[3].Value = lst[i].PrecioVenta;
                dgvVenta.Rows[i].Cells[4].Value = lst[i].SubTotal;
                dgvVenta.Rows[i].Cells[5].Value = lst[i].IdProducto;
                dgvVenta.Rows[i].Cells[6].Value = lst[i].Igv;
                SumaSubTotal += Convert.ToDecimal(dgvVenta.Rows[i].Cells[4].Value);
                SumaIgv += Convert.ToDecimal(dgvVenta.Rows[i].Cells[6].Value);
            }
            dgvVenta.Rows.Add();
            dgvVenta.Rows.Add();
            dgvVenta.Rows[lst.Count + 1].Cells[3].Value = "SUB-TOTAL  S/.";
            dgvVenta.Rows[lst.Count + 1].Cells[4].Value = SumaSubTotal;
            dgvVenta.Rows.Add();
            dgvVenta.Rows[lst.Count + 2].Cells[3].Value = "      I.G.V.        %";
            dgvVenta.Rows[lst.Count + 2].Cells[4].Value = SumaIgv;
            dgvVenta.Rows.Add();
            dgvVenta.Rows[lst.Count + 3].Cells[3].Value = "     TOTAL     S/.";
            SumaTotal += SumaSubTotal + SumaIgv;
            dgvVenta.Rows[lst.Count + 3].Cells[4].Value = SumaTotal;
            dgvVenta.ClearSelection();
        }
        private void Limpiar()
        {
            tbDescripcion.Clear();
            tbCantidad.Focus();
            tbPrecio.Focus();
            tbStock.Clear();
            Program.DescripcionProducto = "";
            Program.Stock = 0;
            Program.Alias = "";
            Program.PrecioVenta = 0;
        }

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            using (FormBuscarPedidos form = new FormBuscarPedidos())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
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
                    CNProductos objProducto = new CNProductos();

                }

            }

        }
    }

}


