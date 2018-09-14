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
using CapaDatos;   

namespace SistemaFigueri
{
    public partial class FormComprobante_Pago : Form
    {
        DataTable tabla = new DataTable();
        List<DataRow> lista = new List<DataRow>();
        CNComprobante_Pago compro = new CNComprobante_Pago();
        private string idcomPago = null;
        private bool Editar = false;
        public FormComprobante_Pago()
        {
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {
            mostarComprobante_Pago();
            listarUsuario();
        }

        public void mostarComprobante_Pago()
        {
            SqlDataAdapter adapter = compro.MostarComprobante_Pago();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                lista.Add((DataRow)row);

            }
            adapter.Fill(tabla);
            dgvcomprobante_pago.DataSource = tabla;
            adapter.Dispose();
        }

        private void btnagregarcomprobante_Click(object sender, EventArgs e)
        {
            String fecha1 = dateultimo.Value.ToString("yyyy-MM-dd");
            if (Editar == false)
            {
                try
                {
                    compro.InsertComprobante_Pago(bmcod_sunat.Text,bmdes_comp.Text,bmcom_breve.Text,
                        cbousuario.SelectedValue.ToString(),fecha1);
                    MessageBox.Show("Se inserto correctamente");
                    mostarComprobante_Pago();
                    bmcod_sunat.Text = "";
                    bmdes_comp.Text = "";
                    bmcom_breve.Text = "";
                    cbousuario.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
                }
            }
            if (Editar == true)
            {
                String fecha2 = dateultimo.Value.ToString("yyyy-MM-dd");
                try
                {
                    compro.UpdateComprobante_Pago(bmcod_sunat.Text, bmdes_comp.Text, bmcom_breve.Text,
                        cbousuario.SelectedValue.ToString(), fecha2,idcomPago);
                    MessageBox.Show("Se inserto correctamente");
                    mostarComprobante_Pago();
                    bmcod_sunat.Text = "";
                    bmdes_comp.Text = "";
                    bmcom_breve.Text = "";
                    cbousuario.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar los datos por :" + ex.ToString());
                }
            }
        }

        private void bnteditarcomprobante_Click(object sender, EventArgs e)
        {
            if (dgvcomprobante_pago.SelectedRows.Count > 0)
            {

                idcomPago = dgvcomprobante_pago.CurrentRow.Cells["Id_comp_pago"].Value.ToString();
                MessageBox.Show(idcomPago);
                Editar = true;
                bmcod_sunat.Text = dgvcomprobante_pago.CurrentRow.Cells[1].Value.ToString();
                bmdes_comp.Text = dgvcomprobante_pago.CurrentRow.Cells[2].Value.ToString();
                bmcom_breve.Text = dgvcomprobante_pago.CurrentRow.Cells[3].Value.ToString();
                cbousuario.Text = dgvcomprobante_pago.CurrentRow.Cells[4].Value.ToString();
                dateultimo.Value = DateTime.Parse(dgvcomprobante_pago.CurrentRow.Cells[5].Value.ToString());

            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneliminarcomprobante_Click(object sender, EventArgs e)
        {
            if (dgvcomprobante_pago.SelectedRows.Count > 0)
            {
                idcomPago = dgvcomprobante_pago.CurrentRow.Cells["Id_comp_pago"].Value.ToString();
                compro.DeleteComprobante_Pago(idcomPago);
                MessageBox.Show("Eliminado correctamente");
                mostarComprobante_Pago();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        //LLENAR COMBOBOX USUARIO
        private void listarUsuario()
        {
            CDComprobante_Pago cdsu = new CDComprobante_Pago();
            cbousuario.DataSource = cdsu.ListarUsuario();
            cbousuario.DisplayMember = "Login";
            cbousuario.ValueMember = "IdUsuario";
        }
    }
}
