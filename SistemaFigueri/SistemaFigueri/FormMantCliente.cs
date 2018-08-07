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
            manejoSki.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            manejoSki.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue800,
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Blue100,
                MaterialSkin.Accent.LightBlue200,
                MaterialSkin.TextShade.WHITE);
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
            listarPersona();
            ListarDepartamento();

        }      

        //GUARDAR NUEVO CLIENTE
        private void bmGuardar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    cli.InsertClient(cboprovincia.SelectedValue.ToString(),cbosector.SelectedValue.ToString(),bmrazonSocial.Text,bmdireccion.Text,
            //        bmnombreCliente.Text,bmtelefono.Text,bmfax.Text,bmruc.Text,bmcorreo.Text,cbodocumento.SelectedValue.ToString(),
            //        bmnumerodoc.Text,bmobservacion.Text,dateInscripcion.Text,cbodepartamento.SelectedValue.ToString(),bmUsuRegistra.Text,bmnivel.Text,dateNacimiento.Text,
            //        bmnombreComercial.Text,bmcredito.Text,bmqueja.Text,bmsaldo.Text,bmordencliente.Text,cboPersona.SelectedValue.ToString(),bmpromedioventas.Text,bmUsuRegistra.Text);
            //    MessageBox.Show("Se inserto cliente correctamente");
            //    this.Close();
            //    formCliente.MostrarClientes();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("No se creo nuevo cliente" + ex);
            //}
        }

        //LISTAR TIENDA
        private void listarDocumento()
        {
            CDCliente cdcli = new CDCliente();
            cbodocumento.DataSource = cdcli.ListarDocumento();
            cbodocumento.DisplayMember = "Nombre";
            cbodocumento.ValueMember = "IdDocIdentidad";
        }

        //LISTAR SECTOR
        private void listarPersona()
        {
            CDCliente cdcli = new CDCliente();
            cboPersona.DataSource = cdcli.ListarPersona();
            cboPersona.DisplayMember = "Descripcion";
            cboPersona.ValueMember = "IdTipoPersona";
        }

        //LISTAR DOCUMENTO
        private void listarSector()
        {
            CDCliente cdcli = new CDCliente();
            cbosector.DataSource = cdcli.ListarSector();
            cbosector.DisplayMember = "DescripcionSector";
            cbosector.ValueMember = "IdSector";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

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

            cbodepartamento.ValueMember = "IdUbigeo";
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

            cboprovincia.ValueMember = "IdUbigeo";
            cboprovincia.DisplayMember = "Provincia";
            cboprovincia.DataSource = dt;

        }

        private void cbodepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbodepartamento.SelectedValue.ToString() != null)
            {
                string Departamento = cbodepartamento.SelectedValue.ToString();
                ListarProvincia(Departamento);
            }
        }
    }
}
