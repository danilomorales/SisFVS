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



namespace SistemaFigueri
{
    public partial class FormPerfiles : MaterialSkin.Controls.MaterialForm
    {
        int pageNumber = 1;
        int cellnum = 0;
        int rownum = 0;
        public List<DataRow> list { get; set; }
        public List<String> liston { get; set; }
        DataTable tabla = new DataTable();
        DataTable tablaRol1 = new DataTable();
        DataTable tablaRol2 = new DataTable();
        List<SomeData> data;
        List<SomeData> data2;
        public int idusuario;
        public FormPerfiles()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        public void cargarPerfiles(DataGridView dgv)
        {
            try
            {
                CNUsuario objUsuario = new CNUsuario();
                SqlDataAdapter adapter = objUsuario.cargarPerfiles();
                foreach (DataRow row in tabla.Rows)
                {
                    list.Add((DataRow)row);
                }
             
                //plist = new PagedList<DataRow>(list);
                adapter.Fill(tabla);
                dgv.DataSource = tabla;
                /*dgvPerfiles.Columns["foto"].Width = 60;
                dgvPerfiles.RowTemplate.Height = 120;
                DataGridViewImageColumn imagen = new DataGridViewImageColumn();
                ((DataGridViewImageColumn)this.dgvPerfiles.Columns["foto"]).DefaultCellStyle.NullValue = null;
                imagen = (DataGridViewImageColumn)dgvPerfiles.Columns["foto"];
                imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
                adapter.Dispose();
            } catch (Exception ex) {
                MessageBox.Show("No se pudo llenar la tabla usuario perfil: " + ex.ToString());
            }

        }

        

        private void FormPerfiles_Load(object sender, EventArgs e)
        {
              
            /*dgvPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;*/
            cargarPerfiles(dgvPerfiles);
            dgvPerfiles.Columns[0].Visible = false;
            dgvPerfiles.Columns[1].Visible = false;
            dgvPerfiles.Columns["foto"].Visible = false;
            dgvPerfiles.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["ApellidoPaterno"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["ApellidoMaterno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["Login"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerfiles.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //((DataGridViewImageColumn)dgvPerfiles.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            
           foreach (DataGridViewColumn column in dgvPerfiles.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dgvPerfiles.Columns.Add("Nº", "Nº");
            this.dgvPerfiles.Columns["Nº"].Width = 30;
            this.dgvPerfiles.Columns["Nº"].DisplayIndex = 0;
            dgvPerfiles.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewRow row in dgvPerfiles.Rows)
            {
                cellnum = cellnum + 1;

                dgvPerfiles.Rows[rownum].Cells["Nº"].Value = rownum.ToString();
                rownum = rownum + 1;
            }
            Console.WriteLine("Filas " + rownum);

            //panelbotonUR.Location = new Point(1*this.ClientSize.Width / 3 - panelbotonUR.Size.Width / 2);
            /*4*this.ClientSize.Height/7  - panelUsuRol.Size.Height / 2)*/;
            //panelUsuRol.Anchor = AnchorStyles.None;
            //panelbotonUR.Anchor = AnchorStyles.None;
            panelUsuRol.Location = new Point(
            cardUsuRol.Width / 2 - panelUsuRol.Size.Width / 2, cardUsuRol.Height / 2 - panelUsuRol.Size.Height / 2);
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                DataView dv = tabla.DefaultView;
                dv.RowFilter = string.Format("Login like '%{0}%' or Nombres like '%{0}%' or ApellidoPaterno like '%{0}%'", txtSearch.Text);
         
        }

        private void dgvPerfiles_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            this.dgvPerfiles.Rows[e.RowIndex].Cells["Nº"].Value = (e.RowIndex + 1).ToString();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgUsuarios);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgRoles);
        }

        private void btnPrivilegios_Click(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgPrivilegios);
        }
        

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgUsuarios);
        }

        private void btnRoles_Click_1(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgRoles);
        }

        private void btnPrivilegios_Click_1(object sender, EventArgs e)
        {
            tabPerfiles.SelectTab(pgPrivilegios);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormNuevoPerfil formMC = new FormNuevoPerfil();
            formMC.ShowDialog();
        }

        private void FormPerfiles_Resize(object sender, EventArgs e)
        {
            //panelUsuRol.Width = Convert.ToInt32(this.Width*0.8);
            //MessageBox.Show(this.Width + " " + panelUsuRol.Width);
            /*panelbotonUR.Width = Convert.ToInt32(panelUsuRol.Width * 0.33);
            panellb1.Width= Convert.ToInt32(panelUsuRol.Width * 0.33);
            panellb2.Width= Convert.ToInt32(panelUsuRol.Width * 0.33);*/
            panelUsuRol.Location = new Point(
            cardUsuRol.Width / 2 - panelUsuRol.Size.Width / 2, cardUsuRol.Height / 2 - panelUsuRol.Size.Height / 2);
            //MessageBox.Show(panellb1.Width.ToString()+" "+panellb2.Width.ToString() + " "+panelbotonUR.Width.ToString()+" "+ panelUsuRol.Width);
        }

        private void tabPerfiles_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void cardUsuRol_Resize(object sender, EventArgs e)
        {
            panelUsuRol.Location = new Point(
            cardUsuRol.Width / 2 - panelUsuRol.Size.Width / 2, cardUsuRol.Height / 2 - panelUsuRol.Size.Height / 2);
        }

        private void cardRolPrivilegio_Resize(object sender, EventArgs e)
        {
            panelRolPrivilegio.Location = new Point(
            cardRolPrivilegio.Width / 2 - panelRolPrivilegio.Size.Width / 2, cardRolPrivilegio.Height / 2 - panelRolPrivilegio.Size.Height / 2);
        }

        private void cardrolsearch_Resize(object sender, EventArgs e)
        {
            panelusersearch.Location = new Point(
            cardrolsearch.Width / 2 - panelusersearch.Size.Width / 2, cardrolsearch.Height / 2 - panelusersearch.Size.Height / 2);
        }

        private void btnrolsearch_Click(object sender, EventArgs e)
        {
            /*FormBuscarUsuario formMC = new FormBuscarUsuario();
            formMC.ShowDialog();*/
            using (FormBuscarUsuario form = new FormBuscarUsuario())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    btnrolright.Enabled = true;
                    btnrolright2.Enabled = true;
                    btnrolleft.Enabled = true;
                    btnrolleft2.Enabled = true;
                    btnrolsave.Enabled = true;
                    tbrolsearch.Text = form.usuario;
                    CNUsuario objUsuario = new CNUsuario();
                    idusuario = form.idusuario;
                    SqlDataReader reader = objUsuario.rolSegunIdUsuario(idusuario);
                    SqlDataReader reader2 = objUsuario.rolSegunIdUsuario2(idusuario);
                    /*tablaRol1.Reset();
                    tablaRol1.Load(reader);
                    tablaRol2.Reset();
                    tablaRol2.Load(reader2);
                    lbRoles1.DataSource = tablaRol1;
                    lbRoles1.DisplayMember = "nomRol";
                    lbRoles1.ValueMember = "IdRol";
                    lbRoles2.DataSource = tablaRol2;
                    lbRoles2.DisplayMember = "nomRol";
                    lbRoles2.ValueMember = "IdRol";*/
                    data = new List<SomeData>();
                    data2 = new List<SomeData>();
                    while (reader.Read())
                    {
                        //MessageBox.Show(reader["nomRol"].ToString());
                        data.Add(new SomeData() { Value = reader["IdRol"].ToString(), Text = reader["nomRol"].ToString() });
                    }
                    while (reader2.Read())
                    {
                        //MessageBox.Show(reader["nomRol"].ToString());
                        data2.Add(new SomeData() { Value2 = reader2["IdRol"].ToString(), Text2 = reader2["nomRol"].ToString() });
                    }
                    
                    lbRoles1.DataSource = data;
                    lbRoles1.DisplayMember = "Text";
                    
                    lbRoles2.DataSource = data2;
                    lbRoles2.DisplayMember = "Text2";
                    
                }
               

            }
        }

        private void tbrolsearch_DoubleClick(object sender, EventArgs e)
        {
            FormBuscarUsuario formMC = new FormBuscarUsuario();
            formMC.ShowDialog();
        }

        private void dgvPerfiles_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvPerfiles.Rows[e.RowIndex].Cells["Nº"].Value = (e.RowIndex + 1).ToString();
        }

        private void cardprisearch_Resize(object sender, EventArgs e)
        {
            panelprisearch.Location = new Point(
            cardprisearch.Width / 2 - panelprisearch.Size.Width / 2, cardprisearch.Height / 2 - panelprisearch.Size.Height / 2);
        }

        private void btnrolright_Click(object sender, EventArgs e)
        {
            int index = lbRoles1.SelectedIndex; //Or wherever else you want to get the index from.
            if (index < 0)
            {
                MessageBox.Show("Elija primero un elemento");
            }
            else
            {
                int id = Int32.Parse((lbRoles1.SelectedItem as SomeData).Value);
                String rol = String.Format((lbRoles1.SelectedItem as SomeData).Text);
                //MessageBox.Show(rol);
                data2.Add(new SomeData() { Value2 = id.ToString(), Text2 = rol });
                data.RemoveAt(index);

                lbRoles1.DataSource = null;
                lbRoles1.DataSource = data;
                lbRoles1.DisplayMember = "Text";
                lbRoles2.DataSource = null;
                lbRoles2.DataSource = data2;
                lbRoles2.DisplayMember = "Text2";
                if (lbRoles1.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnrolright.Enabled = true;
                }
                else
                {
                    btnrolright.Enabled = false;
                }
                if (lbRoles2.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnrolleft.Enabled = true;
                }
            }
        

        }


        private void lbRoles1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnrolleft_Click(object sender, EventArgs e)
        {
            int index = lbRoles2.SelectedIndex; //Or wherever else you want to get the index from.
            if (index < 0)
            {
                MessageBox.Show("Elija primero un elemento");
               
            }
            else
            {
                int id = Int32.Parse((lbRoles2.SelectedItem as SomeData).Value2);
                String rol = String.Format((lbRoles2.SelectedItem as SomeData).Text2);
                //MessageBox.Show(rol);
                data.Add(new SomeData() { Value = id.ToString(), Text = rol });
                data2.RemoveAt(index);

                lbRoles1.DataSource = null;
                lbRoles1.DataSource = data;
                lbRoles1.DisplayMember = "Text";
                lbRoles2.DataSource = null;
                lbRoles2.DataSource = data2;
                lbRoles2.DisplayMember = "Text2";
                //MessageBox.Show(lbRoles2.Items.Count.ToString());
                if (lbRoles2.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnrolleft.Enabled = true;
                }
                else
                {
                    btnrolleft.Enabled = false;
                }
                if (lbRoles1.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnrolright.Enabled = true;
                }
            }
            
        }

        private void btnrolsave_Click(object sender, EventArgs e)
        {
            CNUsuario objUsuario = new CNUsuario();
            int index = lbRoles2.SelectedIndex;
            if (MessageBox.Show("¿Está seguro(a) de actualizar los roles de este usuario?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (lbRoles2.Items.Count==0)
                {
                    //MessageBox.Show("estoy vacío");
                    SqlDataReader reader = objUsuario.controlUsuarioRol(idusuario, 0);
                    objUsuario.eliminarUsuarioRol(idusuario);
                    MessageBox.Show("Se ha actualizado los datos");
                }
                else
                {
                    //MessageBox.Show("No estoy vacío");
                    objUsuario.eliminarUsuarioRol(idusuario);
                    foreach (SomeData item in data2)
                    {
                        SqlDataReader reader = objUsuario.controlUsuarioRol(idusuario, Int32.Parse(item.Value2));
                        
                    }
                    MessageBox.Show("Se ha actualizado los datos");

                }
            }            
            
        }
    }
}
