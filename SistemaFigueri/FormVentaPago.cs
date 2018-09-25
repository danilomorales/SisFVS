using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Globalization;
using CapaNegocio;
using CapaEntidades;
using System.IO;

namespace SistemaFigueri
{
    public partial class FormVentaPago : Form
    {
        private String valor;
        Decimal Importe { get; set; }
        Decimal SumaMonto { get; set; }
        Decimal MontoActual { get; set; }
        Venta Ventas = new Venta();
        CETarjeta tarjeta;
        public List<Venta> lista = new List<Venta>();
        public FormVentaPago()
        {
            InitializeComponent();
            dgvPago.RowTemplate.Height = 45;
        }
        // movimiento
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hend, int wsmg, int wparam, int lparam);

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMonto.Text = String.Empty;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVentaPago_Load(object sender, EventArgs e)
        {
            CNVentas dao = new CNVentas();
            tbTipoCambio.Text = dao.traerTipoCambio(2);
            tbTotalCobrado.Text = "0,00";
            tbSaldoSoles.Text = "0,00";
            tbSaldoDolares.Text = "0,00";
            tbVuelto.Text = "0,00";
            panelTarjeta.Visible = false;
            panelTipoTarjeta.Visible = false;
            panelPostExterno.Visible = false;
            panelImpresiones.Visible = false;
            btnVisa.Enabled = false;
            btnMasterCard.Enabled = false;
            tbMonto.Focus();
        }
       
        private void tbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (tbMonto.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }

        }

        private void tbMonto_Leave(object sender, EventArgs e)
        {
            /*string input = tbMonto.Text.Trim();
            string temp = input.Replace("S/. ", "");
            string specifier = "C";
            valor = tbMonto.Text.Replace("R$", "");
            CultureInfo culture = CultureInfo.CreateSpecificCulture("es-PE");
            tbMonto.Text = Decimal.Parse(temp).ToString(specifier, culture);*/
            /*double amount = 0.0d;
            if (Double.TryParse(tbMonto.Text, NumberStyles.Currency, null, out amount))
            {
                tbMonto.Text = amount.ToString("C");
            }*/
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevoPago();
            
        }

        private void nuevoPagoTarjeta(CETarjeta tarjeta)
        {
            decimal amount = Convert.ToDecimal(tarjeta.monto);
            decimal dollarAmount = 0.00M;
            decimal importe = Convert.ToDecimal(tbImporteTotal.Text);
            decimal tipoCambio = Convert.ToDecimal(tbTipoCambio.Text);
            decimal totalCobrado = Convert.ToDecimal(tbTotalCobrado.Text);
            decimal saldoSoles = Convert.ToDecimal(tbSaldoSoles.Text);
            decimal saldoDolares = Convert.ToDecimal(tbSaldoDolares.Text); ;
            decimal vuelto = Convert.ToDecimal(tbVuelto.Text);
            Venta ven = new Venta();
            ven.IdTipoPago = Int32.Parse(cboFormaPago.SelectedValue.ToString());
            //MessageBox.Show("Este es idtipo pago: " + cboFormaPago.SelectedValue.ToString());
            ven.IdMoneda = tarjeta.idmoneda;
            //MessageBox.Show("Este es idmoneda: " + cboMoneda.SelectedValue.ToString());
            ven.FormaPago = cboFormaPago.Text;
            ven.Moneda = cboMoneda.Text;
            if (cboMoneda.SelectedValue.ToString() == "2")
            {
                dollarAmount = amount;
                amount = amount * tipoCambio;

            }
            if (totalCobrado+amount <= importe)
            {
                //MessageBox.Show("Este es moneda: " + cboFormaPago.Text + "Forma pago"+ cboMoneda.Text);
                if (cboMoneda.SelectedValue.ToString() == "2")
                { ven.Monto = dollarAmount; }
                else { ven.Monto = amount; }

                totalCobrado = totalCobrado + amount;
                ven.Cobrado = totalCobrado;
                tbTotalCobrado.Text = String.Format("{0:N}", totalCobrado);
                tbVuelto.Text = "0,00";
                tbSaldoSoles.Text = String.Format("{0:N}", importe - totalCobrado);
                tbSaldoDolares.Text = String.Format("{0:N}", (importe - totalCobrado) / tipoCambio);
            }
            else
            {
                //MessageBox.Show("Este es moneda: " + cboFormaPago.Text + "Forma pago"+ cboMoneda.Text);
                dollarAmount = importe / tipoCambio;
                if (cboMoneda.SelectedValue.ToString() == "2")
                { ven.Monto = dollarAmount; }
                else { ven.Monto = amount; }

                ven.Cobrado = totalCobrado+amount;
                tbTotalCobrado.Text = String.Format("{0:N}", totalCobrado+amount);
                tbVuelto.Text = String.Format("{0:N}", totalCobrado+ amount - importe);
                tbSaldoSoles.Text = "0,00";
                tbSaldoDolares.Text = "0,00";
                btnAgregar.Visible = false;
            }
            ven.tarjeta = tarjeta.tarjeta;
            ven.noperacion = tarjeta.noperacion;
            ven.nreferencia = tarjeta.nreferencia;
            lista.Add(ven);
            LlenarGrilla();
        }

            private void nuevoPago()
        {
            if (!string.IsNullOrWhiteSpace(tbMonto.Text))
            {
                decimal amount = Convert.ToDecimal(tbMonto.Text);
                decimal dollarAmount = 0.00M;
                decimal importe = Convert.ToDecimal(tbImporteTotal.Text);
                decimal tipoCambio = Convert.ToDecimal(tbTipoCambio.Text);
                decimal totalCobrado = Convert.ToDecimal(tbTotalCobrado.Text);
                decimal saldoSoles = Convert.ToDecimal(tbSaldoSoles.Text);
                decimal saldoDolares = Convert.ToDecimal(tbSaldoDolares.Text); ;
                decimal vuelto = Convert.ToDecimal(tbVuelto.Text);
                Venta ven = new Venta();
                ven.IdTipoPago = Int32.Parse(cboFormaPago.SelectedValue.ToString());
                //MessageBox.Show("Este es idtipo pago: " + cboFormaPago.SelectedValue.ToString());
                ven.IdMoneda = Int32.Parse(cboMoneda.SelectedValue.ToString());
                //MessageBox.Show("Este es idmoneda: " + cboMoneda.SelectedValue.ToString());
                ven.FormaPago = cboFormaPago.Text;
                ven.Moneda = cboMoneda.Text;
                if (cboMoneda.SelectedValue.ToString() == "2")
                {
                    dollarAmount = amount;
                    amount = amount * tipoCambio;

                }
                if (totalCobrado+amount <= importe)
                {
                    //MessageBox.Show("Este es moneda: " + cboFormaPago.Text + "Forma pago"+ cboMoneda.Text);
                    if (cboMoneda.SelectedValue.ToString() == "2")
                    { ven.Monto = dollarAmount; }
                    else { ven.Monto = amount; }
                       
                    totalCobrado = totalCobrado + amount;
                    ven.Cobrado = totalCobrado;
                    tbTotalCobrado.Text = String.Format("{0:N}", totalCobrado);
                    tbVuelto.Text = "0,00";
                    tbSaldoSoles.Text = String.Format("{0:N}",importe - totalCobrado);
                    tbSaldoDolares.Text = String.Format("{0:N}", (importe - totalCobrado) / tipoCambio);
                }
                else
                {
                    //MessageBox.Show("Este es moneda: " + cboFormaPago.Text + "Forma pago"+ cboMoneda.Text);
                    dollarAmount = amount / tipoCambio;
                    if (cboMoneda.SelectedValue.ToString() == "2")
                    { ven.Monto = dollarAmount; }
                    else { ven.Monto = amount; }
   
                    ven.Cobrado = totalCobrado+amount;
                    tbTotalCobrado.Text = String.Format("{0:N}", totalCobrado+amount);
                    tbVuelto.Text = String.Format("{0:N}", totalCobrado+amount - importe);
                    tbSaldoSoles.Text = "0,00";
                    tbSaldoDolares.Text = "0,00";
                    btnAgregar.Visible = false;
                }
                lista.Add(ven);
                LlenarGrilla();

            }
        }

        private void LlenarGrilla()
        {
            var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            format.CurrencySymbol = "";
            SumaMonto = 0;
            dgvPago.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                dgvPago.Rows.Add();
                dgvPago.Rows[i].Cells[0].Value = lista[i].IdTipoPago;
                dgvPago.Rows[i].Cells[1].Value = lista[i].IdMoneda;
                dgvPago.Rows[i].Cells[2].Value = lista[i].FormaPago;
                dgvPago.Rows[i].Cells[3].Value = lista[i].Moneda;
                dgvPago.Rows[i].Cells[6].Value = lista[i].tarjeta;
                dgvPago.Rows[i].Cells[9].Value = lista[i].noperacion;
                dgvPago.Rows[i].Cells[10].Value = lista[i].nreferencia;
                //MessageBox.Show(cboMoneda.SelectedValue.ToString());
                if (cboMoneda.SelectedValue.ToString() == "2")
                {
                    
                    dgvPago.Columns[4].DefaultCellStyle.Format = "N2";
                    dgvPago.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
                }
                else
                {
                    dgvPago.Columns[4].DefaultCellStyle.Format = "N2";
                    dgvPago.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-PE");
                }
                
                dgvPago.Columns[5].DefaultCellStyle.Format = "N2";
                dgvPago.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-PE");
                dgvPago.Rows[i].Cells[4].Value = lista[i].Monto;
                dgvPago.Rows[i].Cells[5].Value = lista[i].Cobrado;

                dgvPago.Rows[i].Cells["ELIMINA"].Value = Properties.Resources.quitar;
                //deleteButton.ImageLayout = DataGridViewImageCellLayout.Stretch;
                //this.dgvPago.Columns.Add(deleteButton);
                /*dgvPago.Rows[i].Cells[4].Value = lista[i].SubTotal;
                dgvPago.Rows[i].Cells[5].Value = lista[i].IdProducto;
                dgvPago.Rows[i].Cells[6].Value = lista[i].Igv;*/

                SumaMonto += Convert.ToDecimal(dgvPago.Rows[i].Cells[4].Value);
                //tbTotalCobrado.Text = tbMonto.Text;
                tbMonto.Text = String.Empty;
            }
            dgvPago.ClearSelection();
        }

        private void dgvPago_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            /*if (e.RowIndex == dgvPago.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvPago.Columns["dgvbtnEliminar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.quitar.Width;
                var h = Properties.Resources.quitar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.quitar, new Rectangle(x, y, w, h));

                e.Handled = true;
            }*/
        }

        private void dgvPago_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }

        private void dgvPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal importe = Convert.ToDecimal(tbImporteTotal.Text);
            decimal tipoCambio = Convert.ToDecimal(tbTipoCambio.Text);
            decimal totalCobrado = Convert.ToDecimal(tbTotalCobrado.Text);
            decimal saldoSoles = Convert.ToDecimal(tbSaldoSoles.Text);
            decimal saldoDolares = Convert.ToDecimal(tbSaldoDolares.Text); ;
            decimal vuelto = Convert.ToDecimal(tbVuelto.Text);
            SumaMonto = 0; MontoActual = 0;
            if (e.RowIndex == dgvPago.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgvPago.Columns["ELIMINA"].Index)
            {
                
                //Put some logic here, for example to remove row from your binding list.
                

                /*for (int i = 0; i < lista.Count; i++)
                {
                    SumaMonto += Convert.ToDecimal(dgvPago.Rows[e.RowIndex].Cells[5].Value);
                }*/
                MontoActual = Convert.ToDecimal(dgvPago.Rows[e.RowIndex].Cells[4].Value);
                totalCobrado = totalCobrado - MontoActual;
                lista.RemoveAt(e.RowIndex);
                tbTotalCobrado.Text = String.Format("{0:N}", totalCobrado);
                //SI EL TOTAL COBRADO ES MENOR O IGUAL A LO QUE DEBE PAGAR
                if (totalCobrado <= importe)
                {
                    if (totalCobrado == 0.00M)
                    {
                        tbSaldoSoles.Text = "0,00";
                        tbSaldoDolares.Text = "0,00";
                    }
                    else
                    {
                        tbSaldoSoles.Text = String.Format("{0:N}", importe - totalCobrado);
                        tbSaldoDolares.Text = String.Format("{0:N}", (importe - totalCobrado) / tipoCambio);
                    }
                    if (cboFormaPago.SelectedValue.ToString() != "12")
                    {
                        btnAgregar.Visible = true;
                    }
                    
                    tbVuelto.Text = "0,00";
                    btnPosExterno.Enabled = true;
                    chkPosExterno.Checked = false;
                }
                else
                {
                    tbVuelto.Text = String.Format("{0:N}", totalCobrado - importe);
                    tbSaldoSoles.Text = "0,00";
                    tbSaldoDolares.Text = "0,00";
                }
                
            }
            LlenarGrilla();
        }

        private void tbMonto_KeyDown(object sender, KeyEventArgs e)
        {
           
            
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String valor = cboFormaPago.SelectedValue.ToString();
            switch (valor)
            {
                case "01":
                    panelTarjeta.Visible = false;
                    panelTipoTarjeta.Visible = false;
                    panelPostExterno.Visible = false;
                    panelImpresiones.Visible = false;
                    cboMoneda.Enabled = true;
                    tbMonto.Focus();
                    if (tbTotalCobrado.Text != "")
                    {
                        decimal importe = Convert.ToDecimal(tbImporteTotal.Text);
                        decimal totalCobrado = Convert.ToDecimal(tbTotalCobrado.Text);
                        if (importe < totalCobrado)
                        {
                            btnAgregar.Visible = false;
                        }
                        else
                        {
                            btnAgregar.Visible = true;
                        }
                    }
                    
                    break;
                case "12":
                    panelTarjeta.Visible = true;
                    panelTipoTarjeta.Visible = true;
                    panelPostExterno.Visible = true;
                    panelImpresiones.Visible = true;
                    btnAgregar.Visible = false;
                    cboMoneda.SelectedValue = "1";
                    cboMoneda.Enabled = false;
                    break;
                case "13":
                    break;
            }
        }

        private void tbMonto_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal importe = Convert.ToDecimal(tbImporteTotal.Text);
                decimal totalCobrado = Convert.ToDecimal(tbTotalCobrado.Text);
                if (importe > totalCobrado)
                {
                    if (cboFormaPago.SelectedValue.ToString() != "12")
                    {
                        nuevoPago();
                    }
                    
                }
      
            }
        }

        private void cboTarjeta_SelectedValueChanged(object sender, EventArgs e)
        {
            CNVentas cNVentas = new CNVentas();
            /*int idTipoTarjeta = Int32.Parse(cboTarjeta.SelectedValue.ToString());
            cboTarjeta.DataSource = cNVentas.MostarCboTarjeta(idTipoTarjeta);*/
        }

        private void cboTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idtarjeta = cboTarjeta.SelectedValue.ToString();
            if (idtarjeta=="1")
            {
                btnVisa.Enabled = true;
                btnMasterCard.Enabled = false;
            }
            else{
                btnMasterCard.Enabled = true;
                btnVisa.Enabled = false;
            }
        }

        private void btnPosExterno_Click(object sender, EventArgs e)
        {
            using (FormPosExterno form = new FormPosExterno())
            {
                CNVentas Ds = new CNVentas();
                //CARGAR COMBO MONEDA
                form.cboMoneda.DisplayMember = "DesMoneda";
                form.cboMoneda.ValueMember = "IdMoneda";
                form.cboMoneda.DataSource = Ds.MostarCboMoneda();
                form.cboMoneda.SelectedValue = cboMoneda.SelectedValue;
                //CARGAR MONTO
                form.tbMonto.Text = tbMonto.Text;
                //CARGA TARJETA
                form.cboTarjeta.DisplayMember = "DesTarjeta";
                form.cboTarjeta.ValueMember = "IdTarjeta";
                DataTable tablaTarjeta = Ds.MostarCboTarjeta(2);
                form.cboTarjeta.DataSource = tablaTarjeta;
                form.cboTarjeta.SelectedValue = cboTarjeta.SelectedValue;
                
                String idtarjeta = cboTipoTarjeta.SelectedValue.ToString();
                DataRow[] filteredRows= tablaTarjeta.Select("IdTarjeta="+idtarjeta);
                String nlote = filteredRows[0][3].ToString();
                String nterminal = filteredRows[0][4].ToString();
                form.tbLote.Text = nlote;
                form.tbTerminal.Text = nterminal;
                
                //CARGA TIPO TARJETA
                form.cboTipoTarjeta.DisplayMember = "DesTipoTarjeta";
                form.cboTipoTarjeta.ValueMember = "IdTipoTarjeta";
                form.cboTipoTarjeta.DataSource = Ds.MostarCboTipoTarjeta();
                form.cboTipoTarjeta.SelectedValue = cboTipoTarjeta.SelectedValue;
                //form.ShowDialog();
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tarjeta = form.tarjeta;
                    //MessageBox.Show(tarjeta.monto);
                    tbMonto.Text = String.Empty;
                    chkPosExterno.Checked = true;
                    nuevoPagoTarjeta(tarjeta);
                    btnPosExterno.Enabled = false;
                }

            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            tbMonto.Text = String.Empty;
        }

        private void tbMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMonto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (tbMonto.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lista.Count>0){
                if (MessageBox.Show("¿Desea confirmar la venta?", "Confirmar venta",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                    
                }
            }
            else{
                MessageBox.Show("No se ha seleccionado la forma de pago aún", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void BarraCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
