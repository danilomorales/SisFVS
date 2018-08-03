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
        /*CNSector cnsec = new CNSector();
        CDSector cdsec = new CDSector();
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvSector.SelectedRows.Count > 0)
            {
                FormUpdateProducto formUP = new FormUpdateProducto();
                // formUP.idProducto = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
                cnsec.DeleteSector(dgvSector.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("¿Estas seguro de eliminar este producto?");
                //mostarProductos();
                //dgvSector.Update();
                //dgvSector.Refresh();
                mostarSector();

            }
            else
                MessageBox.Show("Selecciones una fila por favor");
        }

     
        private void FormSector_Load(object sender, EventArgs e)
        {
            mostarSector();
        }

        public void mostarSector()
        {
            dgvSector.DataSource = cnsec.MostarSector();

        }

        private void btnNuevoSector_Click(object sender, EventArgs e)
        {
            FormInsertSector fis = new FormInsertSector();
            fis.ShowDialog();
        }

        private void bmEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSector.SelectedRows.Count > 0)
                {
                    FormUpdateSector formUP = new FormUpdateSector();
                    //Operacion = "Editar";
                    formUP.idSector = dgvSector.CurrentRow.Cells["IdSector"].Value.ToString();
                    formUP.bmedidescripcion.Text = dgvSector.CurrentRow.Cells[1].Value.ToString();
                    formUP.bmedinota.Text = dgvSector.CurrentRow.Cells[2].Value.ToString();
                    formUP.ShowDialog();
                   // cdpro.listarProductos();
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

        private void bmBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from caja.SECTOR where DescripcionSector like('" + bmBuscar.Text + "%')or Nota like ('"+bmBuscar.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSector.DataSource = dt;
            Conexion.Close();
        }*/
    }
}
