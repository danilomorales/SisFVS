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
    public partial class FormSerie : Form
    {
        DataTable tabla = new DataTable();
        List<DataRow> lista = new List<DataRow>();
        CNSerie cnserie = new CNSerie();
        private string idSerie = null;
        private bool Editar = false;
        public FormSerie()
        {
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {
            mostarSerie();
        }
        public void mostarSerie()
        {
            SqlDataAdapter adapter = cnserie.MostarSerie();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                lista.Add((DataRow)row);

            }
            adapter.Fill(tabla);
            dgvserie.DataSource = tabla;
            adapter.Dispose();

        }

        private void btnagregarserie_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    cnserie.InsertSerie(bmserie.Text,bmFcorrelativo.Text,bmBcorrelativo.Text,
                        bmNcorrelativo.Text,bmCorreBoleta.Text,bmCorreFac.Text);
                    MessageBox.Show("Se inserto correctamente");
                    mostarSerie();
                    bmserie.Text = "";
                    bmFcorrelativo.Text = "";
                    bmBcorrelativo.Text = "";
                    bmNcorrelativo.Text = "";
                    bmCorreBoleta.Text = "";
                    bmCorreFac.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
                }
            }
            if (Editar == true)
            {
                try
                {
                    cnserie.UpdateSerie(bmserie.Text, bmFcorrelativo.Text, bmBcorrelativo.Text,
                         bmNcorrelativo.Text, bmCorreBoleta.Text, bmCorreFac.Text,idSerie);
                    MessageBox.Show("Se actualizo correctamente");
                    mostarSerie();
                    bmserie.Text = "";
                    bmFcorrelativo.Text = "";
                    bmBcorrelativo.Text = "";
                    bmNcorrelativo.Text = "";
                    bmCorreBoleta.Text = "";
                    bmCorreFac.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar los datos por :" + ex.ToString());
                }
            }
        }

        private void bnteditarserie_Click(object sender, EventArgs e)
        {
            if (dgvserie.SelectedRows.Count > 0)
            {

                idSerie = dgvserie.CurrentRow.Cells["IdSerie"].Value.ToString();
                MessageBox.Show(idSerie);
                Editar = true;
                bmserie.Text = dgvserie.CurrentRow.Cells[1].Value.ToString();
                bmFcorrelativo.Text = dgvserie.CurrentRow.Cells[2].Value.ToString();
                bmBcorrelativo.Text = dgvserie.CurrentRow.Cells[3].Value.ToString();
                bmNcorrelativo.Text = dgvserie.CurrentRow.Cells[4].Value.ToString();
                bmCorreBoleta.Text = dgvserie.CurrentRow.Cells[5].Value.ToString();
                bmCorreFac.Text = dgvserie.CurrentRow.Cells[6].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneliminarserie_Click(object sender, EventArgs e)
        {
            if (dgvserie.SelectedRows.Count > 0)
            {
                idSerie = dgvserie.CurrentRow.Cells["ide_sucursal"].Value.ToString();
                cnserie.DeleteSerie(idSerie);
                MessageBox.Show("Eliminado correctamente");
                mostarSerie();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }
    }
}
