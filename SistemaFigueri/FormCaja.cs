using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;


namespace SistemaFigueri
{
    public partial class FormCaja : Form
    {
        //definiciones
        public List<DataRow> list { get; set; }
        CNCaja cncaja = new CNCaja();



        public FormCaja()
        {
            InitializeComponent();
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        // metodo crea tabla
        private void CrearTabla()
        {
            //dgvcaja.Columns.Add("ColOperacion", "OPERACIÓN");
            DataGridViewImageColumn dgvImagenColumn = new DataGridViewImageColumn();
            dgvImagenColumn.HeaderText = "Estado";
            dgvImagenColumn.Name = "ColumnEstado";
            dgvcaja.Columns.Add(dgvImagenColumn);
            dgvImagenColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvcaja.Columns.Add("ColCaja","CAJA");
            dgvcaja.Columns.Add("ColMontoInicial","MONTO INICIAL");
            dgvcaja.Columns.Add("ColMontofinal","MONTO FINAL");
            dgvcaja.Columns.Add("ColCajero","CAJERO");
            dgvcaja.Columns.Add("colFecha","F. CIERRE");
            dgvcaja.Columns.Add("colvoucher", "voucher");
            dgvcaja.Columns[6].Visible = false;
            dgvcaja.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            DataGridViewImageColumn dgvimg = new DataGridViewImageColumn();
            Image abre = Properties.Resources.llave;
            dgvimg.Image = abre;
            dgvcaja.Columns.Add(dgvimg);
            dgvimg.HeaderText = "APERTURAR";
            dgvimg.Name = "APERTURA";
            dgvimg.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvimg.Width = 70;

            DataGridViewImageColumn dgvc = new DataGridViewImageColumn();
            Image cierra = Properties.Resources.cerrado;
            dgvc.Image = cierra;
            dgvcaja.Columns.Add(dgvc);
            dgvc.HeaderText = "CERRAR";
            dgvc.Name = "CERRAR";
            dgvc.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvc.Width = 40;
            //dgvimg.HeaderText = "CAJERO PERFIL";
            //dgvimg.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //dgvcaja.Columns.Add(dgvimg);

        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
            try
            {
                CrearTabla();
                CargaGridCaja();
            }
            catch(Exception ex)
            {
               
                MessageBox.Show(ex.Message, "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //metodo carga datos tabla
        private void CargaGridCaja()
        {
            try
            {
                dgvcaja.Rows.Clear();
                List<CECaja> Lista = CNCaja.Instancia.ListaCaja();
                int num = 0;
                Image img = null;
                for (int i = 0; i < Lista.Count(); i++)
                { 
                    if(Lista[i].TipoOper == "1")
                    {
                        img = Properties.Resources.add;
                    }
                    else if (Lista[i].TipoOper == "0")
                    {
                        img = Properties.Resources.sector;
                    }
                    num++;
                    String[] fila = new String[] {
                        Lista[i].TipoOper.ToString(),
                        Lista[i].Nombre.ToString(),
                        Lista[i].Ingreso.ToString(),
                        Lista[i].Egreso.ToString(),
                        Lista[i].Cajero.ToString(),
                        Lista[i].FechaOperacion.ToString(),
                        Lista[i].Voucher.ToString()};
                        dgvcaja.Rows.Add(fila);
                    dgvcaja.Rows[i].Cells[0].Value = img;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dgvcaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnGuardaCaja_Click(object sender, EventArgs e)
        {
            CNCaja objCaja = new CNCaja();
            try
            {
                //cncaja.InsertaIngresoEgreso_Caja(tbtipoopera.Text, tbidsupervisor.Text, tbidcajero.Text,tbtipoDoc.Text,tbingreso.Text,tbegreso.Text,tbVoucher.Text);
                //MessageBox.Show("sdsdsd");
                //CargaGridCaja();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
            }
        }

        private void dgvcaja_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dgvcaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)               
            {
                tcAperturaCierre.SelectedTab = Apertura;
            }
   
            if (e.ColumnIndex == 8)
            {
                tcAperturaCierre.SelectedTab = Cierre;
            }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panelCierreCaja_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvcaja_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialTabSelector2_Click(object sender, EventArgs e)
        {

        }
    }
}
