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
    public partial class FormProductos : Form
    {
       
        CNProductos cp = new CNProductos();
        CDProductos cdpro = new CDProductos();
        DataTable tabla = new DataTable();
        public FormProductos()
        {
            InitializeComponent();
           
        }
       
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormInsertProducto formMP = new FormInsertProducto();
            formMP.ShowDialog();
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
                    formUP.ShowDialog();
                    
                    cdpro.listarProductos();
                    mostarProductos();


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
                //mostarProductos();
                dgvProductos.Update();
                dgvProductos.Refresh();
                mostarProductos();
                
            }
            else
                MessageBox.Show("Selecciones una fila por favor");

        }       

        public void mostarProductos()
        {
            dgvProductos.DataSource = cp.MostarProductos();           
            
        }
         
        private void bmBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from caja.PRODUCTO where Alias like('" + bmBuscar.Text + "%') or DescripcionProducto like('" + bmBuscar.Text + "')or TiempoDuracion like('" + bmBuscar.Text + "')" +
                "or Stock like('" + bmBuscar.Text + "')or StockMaximo like('" + bmBuscar.Text + "') or StockMinimo like('" + bmBuscar.Text + "')or Valor_Unitario like('" + bmBuscar.Text + "')" +
                "or PrecioVenta1 like('" + bmBuscar.Text + "')or PrecioVenta2 like('" + bmBuscar.Text + "') or PrecioOferta like('" + bmBuscar.Text + "')or Nota like('" + bmBuscar.Text + "')" +
                "or Factor like('" + bmBuscar.Text + "')or Estado like('" + bmBuscar.Text + "')or Item like('" + bmBuscar.Text + "') or StockInicial like('" + bmBuscar.Text + "')" +
                "or cta_vnt like('" + bmBuscar.Text + "')or Vigente like('" + bmBuscar.Text + "')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvProductos.DataSource = dt;
            Conexion.Close();
        }

        private void bmBuscar_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //actualizar();
           
        }
        public void actualizar()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataset = new DataTable();
            dataset.Clear();
            dataAdapter.Fill(dataset);
            dgvProductos.DataSource = cp.MostarProductos();
        }

        private void bmBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataView dv = tabla.DefaultView;
            //dv.RowFilter = string.Format("Stock like '%{0}%' or Nota like '%{0}%' or Factor like '%{0}%' or Estado like '%{0}%'", bmBuscar.Text);
        }
    }
   
}
