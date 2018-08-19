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
        List<DataRow> list = new List<DataRow>();
        public FormProductos()
        {
            InitializeComponent();
           
        }
       
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            using (FormInsertProducto formMC = new FormInsertProducto())
            {
                if (formMC.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    mostarProductos();
                }
            }
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
                    using (FormUpdateProducto formUP = new FormUpdateProducto())
                    {
                        formUP.listarCategoria();
                        formUP.listarMedida();
                        formUP.idProducto = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
                        //MessageBox.Show("Llego"+ dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString());
                        formUP.bmedinombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                        formUP.cboedicategoria.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                        formUP.cboedimedida.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                        formUP.bmedidescripcion.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
                        formUP.dpediduracion.Value = DateTime.Parse( dgvProductos.CurrentRow.Cells[5].Value.ToString());
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
                        if (formUP.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {

                            mostarProductos();
                        }
                    }


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
                cp.DeleteProduct(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("¿Estas seguro de eliminar este producto?");
                mostarProductos();
                
            }
            else
                MessageBox.Show("Selecciones una fila por favor");

        }       

        public void mostarProductos()
        {
            SqlDataAdapter adapter = cp.MostarProductos();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }

            adapter.Fill(tabla);
            dgvProductos.DataSource = tabla;
            adapter.Dispose();

        }
         
        private void bmBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select p.IdProducto,p.Alias as Nombre,c.Descripcion as Categoria,m.Descripcion as Medida,p.DescripcionProducto as 'Descripcion del producto'," +
                "p.TiempoDuracion as Duración,p.Stock,p.StockMaximo as 'Stock Maximo', p.StockMinimo as 'Stock Minimo',p.Valor_Unitario as 'Valor Unitario',p.PrecioVenta1 as 'P. Venta 1'," +
                "p.PrecioVenta2 as 'P. Venta 2',p.PrecioOferta as 'Precio Oferta',p.Nota,p.Factor,p.Estado,p.Item,p.StockInicial as 'Stock Inicial', p.cta_vnt as 'Cta vnt',p.Vigente " +
                "from caja.PRODUCTO p, dbo.CATEGORIA c, dbo.MEDIDA m " +
                "where p.IdCategoria = c.IdCategoria  AND p.IdMedida = m.IdMedida and Alias like('%" + bmBuscar.Text + "%')";
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

        private void bunKardex_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    FormKardex formUP = new FormKardex();

                    formUP.idProducto = dgvProductos.CurrentRow.Cells["idProducto"].Value.ToString();                 
                    formUP.bmproducto.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                    formUP.bmcategoria.Text = dgvProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                    formUP.ShowDialog();
                }
                else
                    MessageBox.Show("Selecciones una fila por favor para observar kardex");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se obtuvo los datos:" + ex.ToString());
            }
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
