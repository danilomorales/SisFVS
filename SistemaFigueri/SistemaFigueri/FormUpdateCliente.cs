using System;
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
    public partial class FormUpdateCliente : Form
    {
       
        public FormUpdateCliente()
        {
            InitializeComponent();
        }

        
        public string idRecpCliente=null;       

        private void FormUpdateCliente_Load(object sender, EventArgs e)
        {
            //ListarDepartamento();
        }        
      

        private void bmCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bmGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CNClientes cli = new CNClientes();
                cli.UpdateClient(idRecpCliente.ToString(),cboedidocumento.SelectedValue.ToString(), cboediPersona.SelectedValue.ToString(), bmedinumerodoc.Text, bmediruc.Text, bmedirazonSocial.Text, bmedinombreComercial.Text,
                    bmedinombreCliente.Text, bmediapellidoP.Text, bmediapellidoM.Text, bmedicorreo.Text, bmedidireccion.Text, bmedifax.Text, bmedifijo.Text, bmeditelefono.Text, dateediNacimiento.Text,
                    cboedidepartamento.SelectedValue.ToString(), cboediprovincia.SelectedValue.ToString(), cboedidistrito.SelectedValue.ToString(), bmediUsuRegistra.Text, dateediInscripcion.Text, bmediUserModifica.Text,
                    dtedifechaModifica.Text, cboedisector.SelectedValue.ToString(), bmediobservacion.Text);
                MessageBox.Show("Se edito correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actuaizar" + ex.ToString());
            }
        }

        //LISTAR DOCUMENTO
        public void listarDocumento()
        {
            CDCliente cdcli = new CDCliente();
            cboedidocumento.DataSource = cdcli.ListarDocumento();
            cboedidocumento.DisplayMember = "Nombre";
            cboedidocumento.ValueMember = "IdDocIdentidad";

        }

        //LISTAR PERSONA
        public void listarPersona()
        {
            CDCliente cdcli = new CDCliente();
            cboediPersona.DataSource = cdcli.ListarPersona();
            cboediPersona.DisplayMember = "Descripcion";
            cboediPersona.ValueMember = "IdTipoPersona";
        }

        //LISTAR SECTOR
        public void listarSector()
        {
            CDCliente cdcli = new CDCliente();
            cboedisector.DataSource = cdcli.ListarSector();
            cboedisector.DisplayMember = "DescripcionSector";
            cboedisector.ValueMember = "IdSector";
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

            //DataRow fila = dt.NewRow();
            //fila["Departamento"] = "Selecciona Departamento";
            //dt.Rows.InsertAt(fila, 0);

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

            //DataRow fila = dt.NewRow();
            //fila["Provincia"] = "Selecciona Provincia";
            //dt.Rows.InsertAt(fila, 0);

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

            //DataRow fila = dt.NewRow();
            //fila["Distrito"] = "Selecciona Distrito";
            //dt.Rows.InsertAt(fila, 0);

            cboedidistrito.ValueMember = "Distrito";
            cboedidistrito.DisplayMember = "Distrito";
            cboedidistrito.DataSource = dt;
        }

        private void cboedidepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (cboedidepartamento.SelectedValue.ToString() != null)
            //{
            //    string Departamento = cboedidepartamento.SelectedValue.ToString();
            //    ListarProvincia(Departamento);
            //    MessageBox.Show("mostro Depa" + Departamento);
            //}
            //else
            
            //    if (cboedidepartamento.SelectedValue.ToString() == null)
            //    {
            //        string Departamento = cboedidepartamento.SelectedValue.ToString();
            //        ListarProvincia(Departamento);
            //        MessageBox.Show("no se mostro depa" + Departamento);
            //    }
            
        }

        private void cboediprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboediprovincia.SelectedValue.ToString() != null)
            //{
            //    string Provincia = cboediprovincia.SelectedValue.ToString();
            //    ListarDistrito(Provincia);
            //    MessageBox.Show("mostro Provi" + Provincia);
            //}
            //else
            
            //    if (cboediprovincia.SelectedValue.ToString() == null)
            //    {
            //        string Provincia = cboediprovincia.SelectedValue.ToString();
            //        ListarDistrito(Provincia);

            //        MessageBox.Show("no se mostro pro" + Provincia);

            //    }
            

        }
    }
}
