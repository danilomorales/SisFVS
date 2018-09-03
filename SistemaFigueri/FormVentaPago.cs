using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SistemaFigueri
{
    public partial class FormVentaPago : Form
    {
        private String valor;
        Decimal Importe { get; set; }
        Decimal SumaMonto { get; set; }
        Venta Ventas = new Venta();
        private List<Venta> lista = new List<Venta>();
        public FormVentaPago()
        {
            InitializeComponent();
            dgvPago.RowTemplate.Height = 45;
        }

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
            decimal amount = Convert.ToDecimal(tbMonto.Text);
            decimal importe = Convert.ToDecimal(tbImporteTotal.Text);
            if (tbMonto.Text != "")
            {
                Venta ven = new Venta();
                ven.IdTipoPago = Int32.Parse(cboFormaPago.SelectedValue.ToString());
                //MessageBox.Show("Este es idtipo pago: " + cboFormaPago.SelectedValue.ToString());
                ven.IdMoneda = Int32.Parse(cboMoneda.SelectedValue.ToString());
                //MessageBox.Show("Este es idmoneda: " + cboMoneda.SelectedValue.ToString());
                ven.FormaPago = cboFormaPago.Text;
                ven.Moneda = cboMoneda.Text;
                if (amount <= importe)
                {
                    //MessageBox.Show("Este es moneda: " + cboFormaPago.Text + "Forma pago"+ cboMoneda.Text);
                    ven.Monto = Convert.ToDecimal(tbMonto.Text);
                    tbTotalCobrado.Text = String.Format("{0:N}", Convert.ToDecimal(tbMonto.Text));
                    tbVuelto.Text = "0.00";
                }
                else
                {
                    //MessageBox.Show("Este es moneda: " + cboFormaPago.Text + "Forma pago"+ cboMoneda.Text);
                    ven.Monto = importe;
                    tbTotalCobrado.Text = tbMonto.Text;
                    tbVuelto.Text = String.Format("{0:N}", (amount - importe));
                    

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
                dgvPago.Columns[4].DefaultCellStyle.Format = "c2";
                dgvPago.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-PE");
                dgvPago.Rows[i].Cells[4].Value = lista[i].Monto;
                
             
                dgvPago.Rows[i].Cells["ELIMINA"].Value = Properties.Resources.quitar;
                //deleteButton.ImageLayout = DataGridViewImageCellLayout.Stretch;
                //this.dgvPago.Columns.Add(deleteButton);
                /*dgvPago.Rows[i].Cells[4].Value = lista[i].SubTotal;
                dgvPago.Rows[i].Cells[5].Value = lista[i].IdProducto;
                dgvPago.Rows[i].Cells[6].Value = lista[i].Igv;*/

                //SumaMonto += Convert.ToDecimal(dgvPago.Rows[i].Cells[4].Value);
                tbTotalCobrado.Text = tbMonto.Text;
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
            if (e.RowIndex == dgvPago.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgvPago.Columns["ELIMINA"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                MessageBox.Show(e.RowIndex.ToString());
                MessageBox.Show(lista.Count.ToString());
                lista.RemoveAt(e.RowIndex);
                MessageBox.Show(lista.Count.ToString());
               
            }
            LlenarGrilla();
        }

        private void tbMonto_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                if (tbMonto.Text != "")
                {
                    decimal amount = Convert.ToDecimal(tbMonto.Text);
                    decimal importe = Convert.ToDecimal(tbImporteTotal.Text);
                    Venta ven = new Venta();
                    ven.IdTipoPago = Int32.Parse(cboFormaPago.SelectedValue.ToString());
                    //MessageBox.Show("Este es idtipo pago: " + cboFormaPago.SelectedValue.ToString());
                    ven.IdMoneda = Int32.Parse(cboMoneda.SelectedValue.ToString());
                    //MessageBox.Show("Este es idmoneda: " + cboMoneda.SelectedValue.ToString());
                    ven.FormaPago = cboFormaPago.Text;
                    ven.Moneda = cboMoneda.Text;
                    if (amount <= importe)
                    {
                        //MessageBox.Show("Este es moneda: " + cboFormaPago.Text + "Forma pago"+ cboMoneda.Text);
                        ven.Monto = Convert.ToDecimal(tbMonto.Text);
                        tbTotalCobrado.Text = String.Format("{0:N}", Convert.ToDecimal(tbMonto.Text));
                        tbVuelto.Text = "0.00";
                    }
                    else
                    {
                        //MessageBox.Show("Este es moneda: " + cboFormaPago.Text + "Forma pago"+ cboMoneda.Text);
                        ven.Monto = importe;
                        tbTotalCobrado.Text = tbMonto.Text;
                        tbTotalCobrado.Text = String.Format("{0:N}", Convert.ToDecimal(tbMonto.Text));
                        tbVuelto.Text = String.Format("{0:N}", (amount - importe));


                    }
                    lista.Add(ven);
                    LlenarGrilla();
                }
            }
        }
    }
}
