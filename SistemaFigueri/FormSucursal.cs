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
    public partial class FormSucursal : MaterialSkin.Controls.MaterialForm
    {
        DataTable tablaSucursal = new DataTable();
        DataTable tablaTienda = new DataTable();
        DataTable tablaSector = new DataTable();
        DataTable tablaPuntoVenta = new DataTable();
        DataTable tablaCajero = new DataTable();
        List<DataRow> listSucursal = new List<DataRow>();
        List<DataRow> listTienda = new List<DataRow>();
        List<DataRow> listSector = new List<DataRow>();
        List<DataRow> listPuntoVenta = new List<DataRow>();
        List<DataRow> listCajero = new List<DataRow>();
        CNSucursal cnSucu = new CNSucursal();
        private string idsucursal =null;
        private string idTienda { get; set; }
        private string idSector = null;
        private string idpunto_venta { get; set; }
        private string idCaja = null;
        private bool Editar1 = false;
        private bool update = false;
        private bool Editar3 = false;
        private bool Editar4 = false;
        private bool Edcajero = false;
        public FormSucursal()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange100, MaterialSkin.Primary.Orange300, MaterialSkin.Primary.Orange100, MaterialSkin.Accent.Orange100, MaterialSkin.TextShade.BLACK);
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
            dgvtienda.Columns[0].Visible = false;
        }

        public void mostarSucursal()
        {
            SqlDataAdapter adapter = cnSucu.MostarSucursal();
            tablaSucursal = new DataTable();
            foreach (DataRow row in tablaSucursal.Rows)
            {
                listSucursal.Add((DataRow)row);
               
            }
            
            adapter.Fill(tablaSucursal);
            dgvsucursal.DataSource = tablaSucursal;
            adapter.Dispose();

        }

        public void mostarTienda()
        {
            SqlDataAdapter adapter = cnSucu.MostarTienda();
            tablaTienda = new DataTable();
            foreach (DataRow row in tablaTienda.Rows)
            {
                listTienda.Add((DataRow)row);
            }

            adapter.Fill(tablaTienda);
            dgvtienda.DataSource = tablaTienda;
            adapter.Dispose();

        }
        public void mostarSector()
        {
            SqlDataAdapter adapter = cnSucu.MostarSector();
            tablaSector = new DataTable();
            foreach (DataRow row in tablaSector.Rows)
            {
                listSector.Add((DataRow)row);
            }

            adapter.Fill(tablaSector);
            dgvsector.DataSource = tablaSector;
            adapter.Dispose();

        }

        public void mostarPunto_Venta()
        {
            SqlDataAdapter adapter = cnSucu.MostarPunto_Venta();
            tablaPuntoVenta = new DataTable();
            foreach (DataRow row in tablaPuntoVenta.Rows)
            {
                listPuntoVenta.Add((DataRow)row);
            }

            adapter.Fill(tablaPuntoVenta);
            dgvPunto.DataSource = tablaPuntoVenta;
            adapter.Dispose();

        }

        public void mostarCajero()
        {
            SqlDataAdapter adapter = cnSucu.MostarCajero();
            tablaCajero = new DataTable();
            foreach (DataRow row in tablaCajero.Rows)
            {
                listCajero.Add((DataRow)row);
            }

            adapter.Fill(tablaCajero);
            dgvcajero.DataSource = tablaCajero;
            adapter.Dispose();

        }

        private void bunisector_Paint(object sender, PaintEventArgs e)
        {
            mostarSector();
            dgvsector.Columns[0].Visible = false;

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
            dgvsucursal.Columns[0].Visible = false;
            listarSucursal();
            listarEncargado();
            listarTienda();
            listarUsuario();
            listarSector();
            listarPunto_Venta();
            listarSupervisor();
            listarUser();
        }

        private void buniPunto_Paint(object sender, PaintEventArgs e)
        {
            mostarPunto_Venta();
            dgvPunto.Columns[0].Visible = false;
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

        //LLENAR COMBOBOX supervisor
        private void listarSupervisor()
        {
            CDSucursal cdsu = new CDSucursal();
            cbosupervisor.DataSource = cdsu.ListarSupervisor();
            cbosupervisor.DisplayMember = "IdUsuario";
            cbosupervisor.ValueMember = "IdSupervisor";
        }

        //LLENAR COMBOBOX Punto_Venta
        private void listarPunto_Venta()
        {
            CDSucursal cdsu = new CDSucursal();
            cbopunto.DataSource = cdsu.ListarPunto_Venta();
            cbopunto.DisplayMember = "des_punto_venta";
            cbopunto.ValueMember = "ide_punto_venta";
        }

        //LLENAR COMBOBOX USUARIO x2
        private void listarUser()
        {
            CDSucursal cdsu = new CDSucursal();
            cbouser.DataSource = cdsu.ListarUsuario();
            cbouser.DisplayMember = "Login";
            cbouser.ValueMember = "IdUsuario";
        }

        private void btneditarSector_Click(object sender, EventArgs e)
        {
            if (dgvsector.SelectedRows.Count > -1)
            {
                idSector = dgvsector.CurrentRow.Cells["IdSector"].Value.ToString();
                MessageBox.Show("IDDD" + idSector);               
                cbotienda.Text = dgvsector.CurrentRow.Cells[1].Value.ToString();
                bmnomsector.Text = dgvsector.CurrentRow.Cells[2].Value.ToString();
                bmnota.Text = dgvsector.CurrentRow.Cells[3].Value.ToString();
                bmporcentaje.Text = dgvsector.CurrentRow.Cells[4].Value.ToString();
                Editar3 = true;

            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneditarPunto_Click(object sender, EventArgs e)
        {
            if (dgvPunto.SelectedRows.Count > 0)
            {
                MessageBox.Show(dgvPunto.CurrentRow.ToString());
                idpunto_venta = dgvPunto.CurrentRow.Cells["ide_punto_venta"].Value.ToString();
                MessageBox.Show("IDDD" + idpunto_venta);
                String sector = dgvPunto.CurrentRow.Cells["Sector"].Value.ToString();
                String venta = dgvPunto.CurrentRow.Cells["Punto de Venta"].Value.ToString();
                String usuario = dgvPunto.CurrentRow.Cells["Usuario"].Value.ToString();
                String flg = dgvPunto.CurrentRow.Cells["flg_punto_venta"].Value.ToString();
                dateFinaliza.Value = DateTime.Parse(dgvPunto.CurrentRow.Cells["Fecha de ultimo Registro"].Value.ToString());
                MessageBox.Show(sector + " " + venta + " " + usuario + " " + flg+"  "+ dateFinaliza);
                Editar4 = true;
                cbosector.Text = sector;
                bmpuntoVenta.Text = venta;
                cbousuario.Text = usuario;
                bmflg.Text = flg;               
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

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardarTienda_Click(object sender, EventArgs e)
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
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
                }
            }
            if (update == true)
            {
                try
                {
                    MessageBox.Show(dgvtienda.CurrentRow.ToString());
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

        private void btnsector_Click(object sender, EventArgs e)
        {
            if (Editar3 == false)
            {
                try
                {
                    //Console.Write("Se inserto SECTOR:" + bmnomsector.Text + " " + bmnota.Text + "  " + cbotienda.SelectedValue.ToString() + "  " + bmporcentaje.Text);
                    cnSucu.InsertSector(bmnomsector.Text, bmnota.Text, cbotienda.SelectedValue.ToString(), bmporcentaje.Text);
                    //MessageBox.Show("id tienda" + cbotienda.SelectedValue);
                    //MessageBox.Show("id porcentaje" + bmporcentaje.Text);
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
            if (Editar3 == true)
            {
                try
                {
                    cnSucu.UpdateSector(bmnomsector.Text, bmnota.Text, cbotienda.SelectedValue.ToString(), bmporcentaje.Text, idSector);                   
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

        private void btnguardarPunto_Venta_Click(object sender, EventArgs e)
        {
            String fecha2 = dateFinaliza.Value.ToString("yyyy-MM-dd");
            if (Editar4 == false)
            {
                try
                {
                    cnSucu.InsertPunto_Venta(bmpuntoVenta.Text,cbosector.SelectedValue.ToString(), bmflg.Text, cbousuario.SelectedValue.ToString(), fecha2);
                    MessageBox.Show("Id sector: " + cbosector.SelectedValue);
                    MessageBox.Show("Se inserto correctamente los datos de Punto de Venta");
                    mostarSector();
                    bmpuntoVenta.Text = "";
                    cbosector.Text = "";
                    bmflg.Text = "";
                    cbousuario.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
                }
            }
            if (Editar4 == true)
            {
                String fechita = dateFinaliza.Value.ToString("yyyy-MM-dd");
                try
                {
                    cnSucu.UpdatePunto_Venta(bmpuntoVenta.Text,cbosector.SelectedValue.ToString(), bmflg.Text, cbousuario.SelectedValue.ToString(), fechita, idpunto_venta);
                    MessageBox.Show("Se actualizo correctamente los datos de Punto de Venta");
                    mostarSector();
                    bmpuntoVenta.Text = "";
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

        private void btneliminarPunto_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvPunto.SelectedRows.Count > 0)
                {
                    idpunto_venta = dgvPunto.CurrentRow.Cells["ide_punto_venta"].Value.ToString();
                    cnSucu.DeletePunto_Venta(idpunto_venta);
                    MessageBox.Show("Eliminado correctamente");
                    mostarPunto_Venta();
                }
                else
                    MessageBox.Show("Seleccione una fila por favor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar los datos por :" + ex.ToString());
            }
           
        }

        private void btnEditarTienda_Click(object sender, EventArgs e)
        {
            if (dgvtienda.SelectedRows.Count > -1)
            {
                MessageBox.Show(dgvtienda.CurrentRow.ToString());
                idTienda = dgvtienda.CurrentRow.Cells["IdTienda"].Value.ToString();
                MessageBox.Show("IDDD" + idTienda);
                String nombres = dgvtienda.CurrentRow.Cells["Nombres"].Value.ToString();
                String tienda = dgvtienda.CurrentRow.Cells["Nombre de la tienda"].Value.ToString();
                String direcion = dgvtienda.CurrentRow.Cells["Dirección"].Value.ToString();
                String telefono = dgvtienda.CurrentRow.Cells["Telefono"].Value.ToString();
                String serie = dgvtienda.CurrentRow.Cells["Serie"].Value.ToString();
                String sucursal = dgvtienda.CurrentRow.Cells["Sucursal"].Value.ToString();
                MessageBox.Show(nombres + " " + tienda + " " + direcion + " " + telefono + " " + serie + " " + sucursal);
                update = true;
                cboencargado.Text = nombres;
                bmtienda.Text = tienda;
                bmdireccion.Text = direcion;
                bmtelefono.Text = telefono;
                bmserie.Text = serie;
                cboSucursal.Text = sucursal;              
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            String fecha1 = dateRegistro.Value.ToString("yyyy-MM-dd");
            if (Editar1 == false)
            {
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
                    cnSucu.UpdateSucursal(bmsucursal.Text, fechas, idsucursal);
                    //MessageBox.Show("IDDD" + idsucursal);
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

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            
            if (dgvsucursal.SelectedRows.Count > 0)
            {
                
                idsucursal = dgvsucursal.CurrentRow.Cells["ide_sucursal"].Value.ToString();
                MessageBox.Show(idsucursal);
                Editar1 = true;              
                bmsucursal.Text = dgvsucursal.CurrentRow.Cells[1].Value.ToString();
                dateRegistro.Value = DateTime.Parse(dgvsucursal.CurrentRow.Cells[3].Value.ToString());

            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
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

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvsucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void pgRoles_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvtienda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pgPrivilegios_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvsector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPunto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bmflg_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dateFinaliza_onValueChanged(object sender, EventArgs e)
        {

        }

        private void cbosector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bmpuntoVenta_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Cajero_Paint(object sender, PaintEventArgs e)
        {
            mostarCajero();
        }

        private void bunifuTileButton1_Click_2(object sender, EventArgs e)
        {
            if (Edcajero == false)
            {
                try
                {
                    cnSucu.InsertCajero(cbouser.SelectedValue.ToString(),cbosupervisor.SelectedValue.ToString(),
                        cbopunto.SelectedValue.ToString(),bmfondo.Text,bmefectivo.Text);
                    MessageBox.Show("Se inserto correctamente");
                    mostarCajero();
                    cbouser.Text = "";
                    cbosupervisor.Text = "";
                    cbopunto.Text = "";
                    bmfondo.Text = "";
                    bmefectivo.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por :" + ex.ToString());
                }
            }
            if (Edcajero == true)
            {
                try
                {
                    cnSucu.UpdateCajero(cbouser.SelectedValue.ToString(), cbosupervisor.SelectedValue.ToString(),
                       cbopunto.SelectedValue.ToString(), bmfondo.Text, bmefectivo.Text,idCaja);
                    MessageBox.Show("Se actualizo correctamente los datos");
                    mostarCajero();
                    cbouser.Text = "";
                    cbosupervisor.Text = "";
                    cbopunto.Text = "";
                    bmfondo.Text = "";
                    bmefectivo.Text = "";
                    Edcajero = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar los datos por :" + ex.ToString());
                }
            }
        }

        private void bnteditarCajero_Click(object sender, EventArgs e)
        {
            if (dgvcajero.SelectedRows.Count > 0)
            {

                idCaja = dgvcajero.CurrentRow.Cells["IdCajero"].Value.ToString();
                MessageBox.Show(idCaja);
                String user = dgvcajero.CurrentRow.Cells[1].Value.ToString();
                String supervisor = dgvcajero.CurrentRow.Cells[2].Value.ToString();
                String punto = dgvcajero.CurrentRow.Cells[3].Value.ToString();
                String fondo = dgvcajero.CurrentRow.Cells[4].Value.ToString();
                String efectivo = dgvcajero.CurrentRow.Cells[5].Value.ToString();
                Edcajero = true;
                cbouser.Text = user;
                cbosupervisor.Text = supervisor;
                cbopunto.Text = punto;
                bmfondo.Text = fondo;
                bmefectivo.Text = efectivo;
                

            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btneliminarcajero_Click(object sender, EventArgs e)
        {
            if (dgvcajero.SelectedRows.Count > 0)
            {
                idCaja = dgvcajero.CurrentRow.Cells["IdCajero"].Value.ToString();
                cnSucu.DeleteCajero(idCaja);
                MessageBox.Show("Eliminado correctamente");
                mostarCajero();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }
    }
}
