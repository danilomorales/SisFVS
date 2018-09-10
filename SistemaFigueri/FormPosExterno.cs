using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;

namespace SistemaFigueri
{
    public partial class FormPosExterno : Form
    {
        public CETarjeta tarjeta;
        

        public FormPosExterno()
        {
            InitializeComponent();
        }

        private void btnClearMonto_Click(object sender, EventArgs e)
        {
            tbMonto.Text = String.Empty; 
        }

        private void btnClearOperacion_Click(object sender, EventArgs e)
        {
            tbOperacion.Text = String.Empty;
        }

        private void btnClearReferencia_Click(object sender, EventArgs e)
        {
            tbReferencia.Text = String.Empty;
        }

        private void btnClearLote_Click(object sender, EventArgs e)
        {
            tbLote.Text = String.Empty;
        }

        private void btnClearTerminal_Click(object sender, EventArgs e)
        {
            tbTerminal.Text = String.Empty;
        }

        private void btnClearTarjeta_Click(object sender, EventArgs e)
        {
            tbTarjeta.Text = String.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tarjeta = new CETarjeta();
            tarjeta.idtarjeta = Int32.Parse(cboTarjeta.SelectedValue.ToString());
            tarjeta.idtipotarjeta = Int32.Parse(cboTipoTarjeta.SelectedValue.ToString());
            tarjeta.idmoneda = Int32.Parse(cboMoneda.SelectedValue.ToString());
            tarjeta.monto = tbMonto.Text;
            tarjeta.noperacion = tbOperacion.Text;
            tarjeta.nreferencia = tbReferencia.Text;
            tarjeta.nlote = tbLote.Text;
            tarjeta.nterminal = tbTerminal.Text;
            tarjeta.ntarjeta = tbTarjeta.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
