using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;
using CapaNegocio;

namespace SistemaFigueri
{
    public partial class FormSector : Form
    {
        public FormSector()
        {
            InitializeComponent();
        }
        CNSector cnsec = new CNSector();
        CDSector cdsec = new CDSector();
        DataTable tabla = new DataTable();
        List<DataRow> list = new List<DataRow>();

        public void mostarSector()
        {
            SqlDataAdapter adapter = cnsec.MostarSector();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }

            adapter.Fill(tabla);
            dgvSector.DataSource = tabla;
            adapter.Dispose();

        }

        private void FormSector_Load_1(object sender, EventArgs e)
        {
            mostarSector();
        }

        private void btnNuevoSector_Click_1(object sender, EventArgs e)
        {
         
            
            using (FormInsertSector fis = new FormInsertSector())
            {
                if (fis.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    mostarSector();
                }
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvSector.SelectedRows.Count > 0)
            {
                FormUpdateProducto formUP = new FormUpdateProducto();
                // formUP.idProducto = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
                cnsec.DeleteSector(dgvSector.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("¿Estas seguro de eliminar este producto?");
               
                mostarSector();

            }
            else
                MessageBox.Show("Selecciones una fila por favor");
        }

        private void bmEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvSector.SelectedRows.Count > 0)
                {
                    using (FormUpdateSector formUP = new FormUpdateSector())
                    {
                        formUP.idSector = dgvSector.CurrentRow.Cells["IdSector"].Value.ToString();
                        formUP.bmedidescripcion.Text = dgvSector.CurrentRow.Cells[1].Value.ToString();
                        formUP.bmedinota.Text = dgvSector.CurrentRow.Cells[2].Value.ToString();
                        formUP.bmediporcentaje.Text = dgvSector.CurrentRow.Cells[3].Value.ToString();
                        formUP.ShowDialog();
                        if (formUP.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {

                            mostarSector();
                        }
                    }                       
                    mostarSector();
                }
                else
                    MessageBox.Show("Selecciones una fila por favor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se obtuvo los datos:" + ex.ToString());
            }
        }

        private void bmBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from caja.SECTOR where DescripcionSector like('" + bmBuscar.Text + "%')or Nota like ('" + bmBuscar.Text + "%')or Porcentaje like ('" + bmBuscar.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSector.DataSource = dt;
            Conexion.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
