﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using System.Data.SqlClient;

namespace SistemaFigueri
{
    public partial class FormUpdateCliente : MaterialSkin.Controls.MaterialForm
    {
       
        public FormUpdateCliente()
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
        CNClientes c = new CNClientes();
        public string idCliente;       

        private void FormUpdateCliente_Load(object sender, EventArgs e)
        {
            //ListarDepartamento();
        }             

        //LISTAR DOCUMENTO
        public void listarDocumento()
        {
            CDCliente cdcli = new CDCliente();
            cboedidocumento.DataSource = cdcli.ListarDocumento();
            cboedidocumento.DisplayMember = "Descripcion";
            cboedidocumento.ValueMember = "IdTipoDocIdent";

        }

        //LISTAR TIENDA
        public void listarTienda()
        {
            CDCliente cdcli = new CDCliente();
            cboediTienda.DataSource = cdcli.ListarTienda();
            cboediTienda.DisplayMember = "NombreTienda";
            cboediTienda.ValueMember = "IdTienda";
        }

        //LISTAR SECTOR
        public void listarSector()
        {
            CDCliente cdcli = new CDCliente();
            cboedisector.DataSource = cdcli.ListarSector();
            cboedisector.DisplayMember = "DescripcionSector";
            cboedisector.ValueMember = "IdSector";
        }

        //LISTAR PERSONA
        public void listarPersona()
        {
            CDCliente cdcli = new CDCliente();
            cboeditipoPersona.DataSource = cdcli.ListarPersona();
            cboeditipoPersona.DisplayMember = "Descripcion";
            cboeditipoPersona.ValueMember = "IdTipoPersona";
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
            cboedidepartamento.ValueMember = "Departamento";
            cboedidepartamento.DisplayMember = "Departamento";
            cboedidepartamento.DataSource = dt;

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
            cboediprovincia.ValueMember = "Provincia";
            cboediprovincia.DisplayMember = "Provincia";
            cboediprovincia.DataSource = dt;

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
            cboedidistrito.ValueMember = "Distrito";
            cboedidistrito.DisplayMember = "Distrito";
            cboedidistrito.DataSource = dt;
        }

        private void cboedidepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboediprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
         
        private void bmpromedioVentas_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buniActualizar_Click(object sender, EventArgs e)
        {
            string fecha1 = dateedinscripcion.Value.ToString("yyyy-MM-dd");
            string fecha2 = datediNacimiento.Value.ToString("yyyy-MM-dd");
            string fecha3 = datedimodificacion.Value.ToString("yyyy-MM-dd");
            try
            {
                c.UpdateClient(cboediTienda.SelectedValue.ToString(),cboedisector.SelectedValue.ToString(),bmedinombreCliente.Text,bmediapellidoP.Text,
                    bmediapellidoM.Text,bmedinombreEmpresa.Text,bmedireccion.Text,bmedicontacto.Text,bmeditelefono.Text,bmedifax.Text,bmediruc.Text,
                    bmedicorreo.Text,cboeditipoPersona.SelectedValue.ToString(),cboedidocumento.SelectedValue.ToString(),bmedinumerodoc.Text,
                    bmediobservacion.Text,fecha1,fecha2,bmedicredito.Text,cboeditipoCliente.SelectedValue.ToString(),cboedidepartamento.SelectedValue.ToString(),
                    cboediprovincia.SelectedValue.ToString(),cboedidistrito.SelectedValue.ToString(),bmediuserModi.Text,bmediuserModi.Text,
                    fecha3,idCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ACTUALIZAR:" + ex);
            }
        }
    }
}
