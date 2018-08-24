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
using CapaNegocio;
using CapaDatos;


namespace SistemaFigueri
{
    public partial class FormMantCliente : MaterialSkin.Controls.MaterialForm
    {
        public FormMantCliente()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manejoSki = MaterialSkin.MaterialSkinManager.Instance;
            manejoSki.AddFormToManage(this);
            manejoSki.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manejoSki.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Orange100,
                MaterialSkin.Primary.Orange300,
                MaterialSkin.Primary.Orange100,
                MaterialSkin.Accent.Orange100,
                MaterialSkin.TextShade.BLACK);
        }
        CNClientes cli = new CNClientes();
        FormCliente formCliente = new FormCliente();
        private void btnCancelarMant_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantCliente_Load(object sender, EventArgs e)
        {           
            listarSector();
            listarDocumento();
            //listarPersona();
            ListarDepartamento();
            listarTienda();

        }      

        //GUARDAR NUEVO CLIENTE
        private void bmGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cli.InsertClient(cboTienda.SelectedValue.ToString(), cbosector.SelectedValue.ToString(),
                    bmnombreEmpresa.Text, bmnombreCliente.Text, bmapellidoP.Text, bmapellidoM.Text, bmdireccion.Text,
                    bmcontacto.Text, bmtelefono.Text, bmfax.Text, bmruc.Text, bmcorreo.Text, cbodocumento.SelectedValue.ToString(),
                    bmnumerodoc.Text, bmobservacion.Text, dateinscripcion.Text, bmcorriente.Text, dateNacimiento.Text,
                    bmtipoCompra.Text, bmcredito.Text, bmqueja.Text, bmordenCliente.Text, bmpromedioVentas.Text,
                    bmcta_cli.Text, cbodepartamento.SelectedValue.ToString(), cboprovincia.SelectedValue.ToString(),
                    cbodistrito.SelectedValue.ToString(),bmUsuRegistra.Text);
                MessageBox.Show("SE  registro CLIENTE");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se registro CLIENTE" + ex.ToString());
            }
        }

        //LISTAR DOCUMENTO
        private void listarDocumento()
        {
            CDCliente cdcli = new CDCliente();
            cbodocumento.DataSource = cdcli.ListarDocumento();
            cbodocumento.DisplayMember = "Descripcion";
            cbodocumento.ValueMember = "IdTipoDocIdent";

        }

        ////LISTAR PERSONA
        //private void listarPersona()
        //{
        //    CDCliente cdcli = new CDCliente();
        //    cboTienda.DataSource = cdcli.ListarPersona();
        //    cboTienda.DisplayMember = "Descripcion";
        //    cboTienda.ValueMember = "IdTipoPersona";
        //}

        //LISTAR SECTOR
        private void listarSector()
        {
            CDCliente cdcli = new CDCliente();
            cbosector.DataSource = cdcli.ListarSector();
            cbosector.DisplayMember = "DescripcionSector";
            cbosector.ValueMember = "IdSector";
        }

        //LISTAR TIENDA
        private void listarTienda()
        {
            CDCliente cdcli = new CDCliente();
            cboTienda.DataSource = cdcli.ListarTienda();
            cboTienda.DisplayMember = "NombreTienda";
            cboTienda.ValueMember = "IdTienda";
        }


        private void cancelaMant_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboPersona.SelectedIndex.Equals("Persona Juridica"))
            //{
            //    bmruc.Visible = true;
            //    bmruc.Visible = true;
            //}
            //else
            //{
            //    bmruc.Visible = false;
            //    bmruc.Visible = false;
            //}
        }

        SqlConnection Con = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123;MultipleActiveResultSets=true;");
        public void ListarDepartamento()
        {           
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Departamento from caja.Ubigeo group by Departamento;", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Con.Close();

            DataRow fila = dt.NewRow();
            fila["Departamento"] = "Selecciona Departamento";
            dt.Rows.InsertAt(fila, 0);

            cbodepartamento.ValueMember = "Departamento";
            cbodepartamento.DisplayMember = "Departamento";
            cbodepartamento.DataSource = dt;

        }

        public void ListarProvincia(String departamento)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Provincia from caja.Ubigeo u where u.Departamento= @departamento group by Provincia", Con);
            cmd.Parameters.AddWithValue("Departamento", departamento);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Con.Close();

            DataRow fila = dt.NewRow();
            fila["Provincia"] = "Selecciona Provincia";
            dt.Rows.InsertAt(fila, 0);

            cboprovincia.ValueMember = "Provincia";
            cboprovincia.DisplayMember = "Provincia";
            cboprovincia.DataSource = dt;

        }
        
        public void ListarDistrito(String provincia)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Distrito from caja.Ubigeo u where u.Provincia=@provincia group by Distrito", Con);
            cmd.Parameters.AddWithValue("Provincia", provincia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Con.Close();

            DataRow fila = dt.NewRow();
            fila["Distrito"] = "Selecciona Distrito";
            dt.Rows.InsertAt(fila, 0);

            cbodistrito.ValueMember = "Distrito";
            cbodistrito.DisplayMember = "Distrito";
            cbodistrito.DataSource = dt;
        }

        private void cbodepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbodepartamento.SelectedValue.ToString() != null)
            {
                string Departamento = cbodepartamento.SelectedValue.ToString();
                ListarProvincia(Departamento);
                //MessageBox.Show("sfsfds" + Departamento);
            }
        }

        private void cboprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboprovincia.SelectedValue.ToString() !=null)
            {
                string Provincia = cboprovincia.SelectedValue.ToString();
                ListarDistrito(Provincia);

            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {

        }
    }
}
