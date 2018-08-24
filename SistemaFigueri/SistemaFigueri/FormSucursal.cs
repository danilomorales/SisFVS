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
    public partial class FormSucursal : Form
    {
        DataTable tabla = new DataTable();
        List<DataRow> list = new List<DataRow>();
        CNSucursal cnSucu = new CNSucursal();
        private String idsucursal =null;
        private String idTienda = null;
        private String idSector = null;
        private String idpunto_venta = null;
        private bool Editar1 = false;
        private bool update = false;
        private bool Editar3 = false;
        private bool Editar4 = false;
        public FormSucursal()
        {
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
        

       

        private void sucursal_Click(object sender, EventArgs e)
        {
            mostarSucursal();
        }

        private void buTienda_Paint(object sender, PaintEventArgs e)
        {
            mostarTienda();
        }

        public void mostarSucursal()
        {
            SqlDataAdapter adapter = cnSucu.MostarSucursal();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }

            adapter.Fill(tabla);
            dgvsucursal.DataSource = tabla;
            adapter.Dispose();

        }

        public void mostarTienda()
        {
            SqlDataAdapter adapter = cnSucu.MostarTienda();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }

            adapter.Fill(tabla);
            dgvtienda.DataSource = tabla;
            adapter.Dispose();

        }
        public void mostarSector()
        {
            SqlDataAdapter adapter = cnSucu.MostarSector();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }

            adapter.Fill(tabla);
            dgvsector.DataSource = tabla;
            adapter.Dispose();

        }

        public void mostarPunto_Venta()
        {
            SqlDataAdapter adapter = cnSucu.MostarPunto_Venta();
            tabla = new DataTable();
            foreach (DataRow row in tabla.Rows)
            {
                list.Add((DataRow)row);
            }

            adapter.Fill(tabla);
            dgvPunto.DataSource = tabla;
            adapter.Dispose();

        }

        private void bunisector_Paint(object sender, PaintEventArgs e)
        {
            mostarSector();
          
        }

        private void buniPuntoVenta_Paint(object sender, PaintEventArgs e)
        {
            mostarPunto_Venta();
        }

        private void FormSucursal_Load(object sender, EventArgs e)
        {

        }

      

        private void bunifuCards8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvpuntoVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunisucursal_Paint(object sender, PaintEventArgs e)
        {
            mostarSucursal();
            listarSucursal();
            listarEncargado();
            listarTienda();
            listarUsuario();
            listarSector();
        }

        private void buniPunto_Paint(object sender, PaintEventArgs e)
        {
            mostarPunto_Venta();
        }

        private void btnguardarPro_Click(object sender, EventArgs e)
        {
            String fecha1 = dateRegistro.Value.ToString("yyyy-MM-dd");
            if (Editar1 == false) { 
            try
            {
                cnSucu.InsertSucursal(bmsucursal.Text, fecha1);
                MessageBox.Show("Se inserto correctamente");
                mostarSucursal();
                bmsucursal.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
            }
          }
            if (Editar1 == true)
            {
                String fechas = dateRegistro.Value.ToString("yyyy-MM-dd");
                try
                {
                    cnSucu.UpdateSucursal(bmsucursal.Text, fechas,idsucursal);
                    MessageBox.Show("IDDD" + idsucursal);
                    MessageBox.Show("Se actualizo correctamente");
                    mostarSucursal();
                    bmsucursal.Text = "";
                    Editar1 = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar los datos por :" + ex.ToString());
                }
            }
        }

        //LLENAR COMBOBOX SUCURSAL
        private void listarSucursal()
        {
            CDSucursal cdsu = new CDSucursal();
            cboSucursal.DataSource = cdsu.ListarSucursal();
            cboSucursal.DisplayMember = "nombre_sucursal";
            cboSucursal.ValueMember = "ide_sucursal";

        }

        //LLENAR COMBOBOX ENCARGADO
        private void listarEncargado()
        {
            CDSucursal cdsu = new CDSucursal();
            cboencargado.DataSource = cdsu.ListarEncargado();
            cboencargado.DisplayMember = "Nombres";
            cboencargado.ValueMember = "IdResponsable";

        }

        //LLENAR COMBOBOX TIENDA
        private void listarTienda()
        {
            CDSucursal cdsu = new CDSucursal();
            cbotienda.DataSource = cdsu.ListarTienda();
            cbotienda.DisplayMember = "NombreTienda";
            cbotienda.ValueMember = "IdTienda";

        }

        //LLENAR COMBOBOX USUARIO
        private void listarUsuario()
        {
            CDSucursal cdsu = new CDSucursal();
            cbousuario.DataSource = cdsu.ListarUsuario();
            cbousuario.DisplayMember = "Login";
            cbousuario.ValueMember = "IdUsuario";
        }

        //LLENAR COMBOBOX SECTOR
        private void listarSector()
        {
            CDSucursal cdsu = new CDSucursal();
            cbosector.DataSource = cdsu.ListarSector();
            cbosector.DisplayMember = "DescripcionSector";
            cbosector.ValueMember = "IdSector";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (update == false)
            {        
            try
            {
                cnSucu.InsertTienda(cboencargado.SelectedValue.ToString(), bmtienda.Text, bmdireccion.Text, bmtelefono.Text, bmserie.Text, cboSucursal.SelectedValue.ToString());
                MessageBox.Show("Se inserto correctamente la Tienda");
                mostarTienda();
                cboencargado.Text = "";
                bmtienda.Text = "";
                bmdireccion.Text = "";
                bmtelefono.Text = "";
                bmserie.Text = "";
                cboSucursal.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
            }
          }
            if (update == true)
            {
                try{
                    cnSucu.UpdateTienda(cboencargado.SelectedValue.ToString(), bmtienda.Text, bmdireccion.Text, bmtelefono.Text, bmserie.Text, cboSucursal.SelectedValue.ToString(), idTienda);
                    MessageBox.Show("Se editaaaaa" + idTienda);
                    MessageBox.Show("Se actualizo correctamente la Tienda");
                    mostarTienda();
                    cboencargado.Text = "";
                    bmtienda.Text = "";
                    bmdireccion.Text = "";
                    bmtelefono.Text = "";
                    bmserie.Text = "";
                    cboSucursal.Text = "";
                    update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar los datos por :" + ex.ToString());
                }
            }
        }

        private void btnguardarSector_Click(object sender, EventArgs e)
        {
            if (Editar3 == false)
            {
                try
                {
                    cnSucu.InsertSector(bmnomsector.Text, bmnota.Text, cbotienda.SelectedValue.ToString(), bmporcentaje.Text);
                    MessageBox.Show("Se inserto correctamente los datos de SECTOR");
                    mostarSector();
                    bmnomsector.Text = "";
                    bmnota.Text = "";
                    cbotienda.Text = "";
                    bmporcentaje.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
                }
            }
            if (Editar3==true)
            {
                try
                {
                    cnSucu.UpdateSector(bmnomsector.Text, bmnota.Text, cbotienda.SelectedValue.ToString(), bmporcentaje.Text,idSector);
                    MessageBox.Show("Se actualizo correctamente los datos de SECTOR");
                    mostarSector();
                    bmnomsector.Text = "";
                    bmnota.Text = "";
                    cbotienda.Text = "";
                    bmporcentaje.Text = "";
                    Editar3 = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar los datos por :" + ex.ToString());
                }
            }
        }

        private void btnguardarPunto_Click(object sender, EventArgs e)
        {
            String fecha2 = dateFinaliza.Value.ToString("yyyy-MM-dd");
            if (Editar4==false) {
                try
                {
                    cnSucu.InsertPunto_Venta(bmpuntoVenta.Text, bmide.Text, cbosector.SelectedValue.ToString(), bmflg.Text, cbousuario.SelectedValue.ToString(), fecha2);
                    MessageBox.Show("Se inserto correctamente los datos de Punto de Venta");
                    mostarSector();
                    bmpuntoVenta.Text = "";
                    bmide.Text = "";
                    cbosector.Text = "";
                    bmflg.Text = "";
                    cbousuario.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
                }
            }
            if (Editar4==true)
            {
                String fechita = dateFinaliza.Value.ToString("yyyy-MM-dd");
                try
                {
                    cnSucu.UpdatePunto_Venta(bmpuntoVenta.Text, bmide.Text, cbosector.SelectedValue.ToString(), bmflg.Text, cbousuario.SelectedValue.ToString(), fechita,idpunto_venta);
                    MessageBox.Show("Se actualizo correctamente los datos de Punto de Venta");
                    mostarSector();
                    bmpuntoVenta.Text = "";
                    bmide.Text = "";
                    cbosector.Text = "";
                    bmflg.Text = "";
                    cbousuario.Text = "";
                    Editar4 = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar los datos por :" + ex.ToString());
                }
            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            if (dgvsucursal.SelectedRows.Count > 0)
            {
                Editar1 = true;
                bmsucursal.Text = dgvsucursal.CurrentRow.Cells[1].Value.ToString();
                dateRegistro.Value = DateTime.Parse(dgvsucursal.CurrentRow.Cells[3].Value.ToString());
                idsucursal = dgvsucursal.CurrentRow.Cells["ide_sucursal"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneditartienda_Click(object sender, EventArgs e)
        {
            
            if (dgvtienda.SelectedRows.Count > 0)
            {
                MessageBox.Show("IDDD" + idTienda);
                update = true;
                idTienda = dgvtienda.CurrentRow.Cells["IdTienda"].Value.ToString();
                cboencargado.Text = dgvtienda.CurrentRow.Cells["Nombres"].Value.ToString();
                bmtienda.Text = dgvtienda.CurrentRow.Cells["Nombre de la tienda"].Value.ToString();
                bmdireccion.Text = dgvtienda.CurrentRow.Cells["Dirección"].Value.ToString();
                bmtelefono.Text = dgvtienda.CurrentRow.Cells["Telefono"].Value.ToString();
                cboSucursal.Text = dgvtienda.CurrentRow.Cells["Sucursal"].Value.ToString();
                bmserie.Text = dgvtienda.CurrentRow.Cells["Serie"].Value.ToString();
               

            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneditarSector_Click(object sender, EventArgs e)
        {
            if (dgvsector.SelectedRows.Count > 0)
            {
                MessageBox.Show("IDDD" + idSector);
                Editar3 = true;
                bmtienda.Text = dgvsector.CurrentRow.Cells[1].Value.ToString();
                cbosector.Text = dgvsector.CurrentRow.Cells[2].Value.ToString();
                bmnota.Text = dgvsector.CurrentRow.Cells[3].Value.ToString();
                bmporcentaje.Text = dgvsector.CurrentRow.Cells[4].Value.ToString();
                idSector = dgvsector.CurrentRow.Cells["IdSector"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneditarPunto_Click(object sender, EventArgs e)
        {
            if (dgvpuntoVenta.SelectedRows.Count > 0)
            {
                MessageBox.Show("IDDD" + idpunto_venta);
                Editar4 = true;
                cbosector.Text = dgvpuntoVenta.CurrentRow.Cells[1].Value.ToString();
                bmpuntoVenta.Text = dgvpuntoVenta.CurrentRow.Cells[2].Value.ToString();
                cbousuario.Text = dgvpuntoVenta.CurrentRow.Cells[3].Value.ToString();
                bmflg.Text = dgvpuntoVenta.CurrentRow.Cells[4].Value.ToString();
                dateFinaliza.Text = dgvpuntoVenta.CurrentRow.Cells[5].Value.ToString();
                idpunto_venta = dgvpuntoVenta.CurrentRow.Cells["ide_punto_venta"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void bnteliminar_Click(object sender, EventArgs e)
        {
            if (dgvsucursal.SelectedRows.Count > 0)
            {
                idsucursal = dgvsucursal.CurrentRow.Cells["ide_sucursal"].Value.ToString();
                cnSucu.DeleteSucursal(idsucursal);
                MessageBox.Show("Eliminado correctamente");
                mostarSucursal();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneliminartienda_Click(object sender, EventArgs e)
        {
            if (dgvtienda.SelectedRows.Count > 0)
            {
                idTienda = dgvtienda.CurrentRow.Cells["IdTienda"].Value.ToString();
                cnSucu.DeleteTienda(idTienda);
                MessageBox.Show("Eliminado correctamente");
                mostarTienda();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneliminarSector_Click(object sender, EventArgs e)
        {
            if (dgvsector.SelectedRows.Count > 0)
            {
                idSector = dgvsector.CurrentRow.Cells["IdSector"].Value.ToString();
                cnSucu.DeleteSector(idSector);
                MessageBox.Show("Eliminado correctamente");
                mostarSector();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneliminarPunto_Click(object sender, EventArgs e)
        {
            if (dgvpuntoVenta.SelectedRows.Count > 0)
            {
                idpunto_venta = dgvpuntoVenta.CurrentRow.Cells["ide_punto_venta"].Value.ToString();
                cnSucu.DeletePunto_Venta(idSector);
                MessageBox.Show("Eliminado correctamente");
                mostarPunto_Venta();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }
    }
}
