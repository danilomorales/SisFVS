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

namespace SistemaFigueri
{
    public partial class FormProductos : Form
    {

        public FormProductos()
        {
            InitializeComponent();
           
        }
        CNProductos cp = new CNProductos();
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormInsertProducto formMP = new FormInsertProducto();
            formMP.ShowDialog();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            mostarProductos();

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    FormUpdateProducto formUP = new FormUpdateProducto();
                    //Operacion = "Editar";
                    formUP.listarCategoria();
                    formUP.listarMedida();
                    formUP.idProducto = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
                    formUP.bmedinombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                    formUP.cboedicategoria.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                    formUP.cboedimedida.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                    formUP.bmedidescripcion.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
                    formUP.bmeditiempo.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                    formUP.bmedistock.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
                    formUP.bmedistockmax.Text = dgvProductos.CurrentRow.Cells[7].Value.ToString();
                    formUP.bmedistockmini.Text = dgvProductos.CurrentRow.Cells[8].Value.ToString();
                    formUP.bmedivalos_unitario.Text = dgvProductos.CurrentRow.Cells[9].Value.ToString();
                    formUP.bmediprecio1.Text = dgvProductos.CurrentRow.Cells[10].Value.ToString();
                    formUP.bmediprecio2.Text = dgvProductos.CurrentRow.Cells[11].Value.ToString();
                    formUP.bmediprecioOferta.Text = dgvProductos.CurrentRow.Cells[12].Value.ToString();
                    formUP.bmedinota.Text = dgvProductos.CurrentRow.Cells[13].Value.ToString();
                    formUP.bmedifactor.Text = dgvProductos.CurrentRow.Cells[14].Value.ToString();
                    formUP.cboediestado.Text = dgvProductos.CurrentRow.Cells[15].Value.ToString();
                    formUP.bmediItem.Text = dgvProductos.CurrentRow.Cells[16].Value.ToString();
                    formUP.bmedinicial.Text = dgvProductos.CurrentRow.Cells[17].Value.ToString();
                    formUP.bmedicta.Text = dgvProductos.CurrentRow.Cells[18].Value.ToString();
                    formUP.bmedivigente.Text = dgvProductos.CurrentRow.Cells[19].Value.ToString();
                    formUP.ShowDialog();
                    

                }
                else
                    MessageBox.Show("Selecciones una fila por favor");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se obtuvo los datos:" + ex.ToString());
            }
            
            

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                FormUpdateProducto formUP = new FormUpdateProducto();
               // formUP.idProducto = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
                cp.DeleteProduct(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("¿Estas seguro de eliminar este producto?");
                mostarProductos();
                
            }
            else
                MessageBox.Show("Selecciones una fila por favor");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void mostarProductos()
        {
            dgvProductos.DataSource = cp.MostarProductos();

            
            
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {         
            
        }
    }
   
}
