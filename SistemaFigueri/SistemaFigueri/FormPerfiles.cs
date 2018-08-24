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
        DataTable tabla;
        DataTable tablaRol1 = new DataTable();
        DataTable tablaRol2 = new DataTable();
        List<SomeData> data;
        List<SomeData> data2;
        List<SomeData> data3;
        List<SomeData> data4;
        public int idusuario; public int idrol;
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
                tabla = new DataTable();
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
                Console.WriteLine("No se pudo llenar la tabla usuario perfil: " + ex.ToString());
            }

        }

        

        private void FormPerfiles_Load(object sender, EventArgs e)
        {

            /*dgvPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;*/
            dgvPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPerfiles.AllowUserToResizeRows = false;
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
                    btnrolsearch.Focus();

                    if (lbRoles2.Items.Count > 0)
                    {
                        //MessageBox.Show("vacío");
                        btnrolleft.Enabled = true;
                        btnrolleft2.Enabled = true;
                    }
                    else
                    {
                        btnrolleft.Enabled = false;
                        btnrolleft2.Enabled = false;
                    }
                    if (lbRoles1.Items.Count > 0)
                    {
                        //MessageBox.Show("vacío");
                        btnrolright.Enabled = true;
                        btnrolright2.Enabled = true;
                    }
                    else
                    {
                        btnrolright.Enabled = false;
                        btnrolright2.Enabled = false;
                    }
                }
               

            }
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
                    btnrolright2.Enabled = true;
                }
                else
                {
                    btnrolright.Enabled = false;
                    btnrolright2.Enabled = false;
                }
                if (lbRoles2.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnrolleft.Enabled = true;
                    btnrolleft2.Enabled = true;
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
                    btnrolleft2.Enabled = true;
                }
                else
                {
                    btnrolleft.Enabled = false;
                    btnrolleft2.Enabled = false;
                }
                if (lbRoles1.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnrolright.Enabled = true;
                    btnrolright2.Enabled = true;
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

        private void btnrolright2_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadItems = lbRoles1.Items.Count;
                //MessageBox.Show(cantidadItems.ToString());
                for (int n = cantidadItems - 1; n >= 0; --n)
                {
                    String idrol = ((SomeData)lbRoles1.Items[n]).Value.ToString();
                    String nomrol = ((SomeData)lbRoles1.Items[n]).Text.ToString();
                    data2.Add(new SomeData() { Value2 = idrol, Text2 = nomrol });
                    //MessageBox.Show("zz" + n + " " + idrol + " " + nomrol);
                    data.RemoveAt(n);
                    
                }
                //MessageBox.Show(count.ToString());
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
                    btnrolright2.Enabled = true;
                }
                else
                {
                    btnrolright.Enabled = false;
                    btnrolright2.Enabled = false;
                }
                if (lbRoles2.Items.Count > 0)
                {
                    //MessageBox.Show("no vacío");
                    btnrolleft.Enabled = true;
                    btnrolleft2.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error btnrolright2 " + ex);
            }
            
        }

        private void btnrolleft2_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadItems = lbRoles2.Items.Count;
                //MessageBox.Show(cantidadItems.ToString());
                for (int n = cantidadItems - 1; n >= 0; --n)
                {
                    String idrol = ((SomeData)lbRoles2.Items[n]).Value2.ToString();
                    String nomrol = ((SomeData)lbRoles2.Items[n]).Text2.ToString();
                    data.Add(new SomeData() { Value = idrol, Text = nomrol });
                    //MessageBox.Show("zz" + n + " " + idrol + " " + nomrol);
                    data2.RemoveAt(n);

                }
                //MessageBox.Show(count.ToString());
                lbRoles1.DataSource = null;
                lbRoles1.DataSource = data;
                lbRoles1.DisplayMember = "Text";
                lbRoles2.DataSource = null;
                lbRoles2.DataSource = data2;
                lbRoles2.DisplayMember = "Text2";
                if (lbRoles2.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    
                    btnrolleft.Enabled = true;
                    btnrolleft2.Enabled = true;
                }
                else
                {
                    btnrolleft.Enabled = false;
                    btnrolleft2.Enabled = false;
                }
                if (lbRoles1.Items.Count > 0)
                {
                    //MessageBox.Show("no vacío");
                    btnrolright.Enabled = true;
                    btnrolright2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error btnrolright2 " + ex);
            }
        }

        private void btnprivisearch_Click(object sender, EventArgs e)
        {
            using (FormBuscarRoles form = new FormBuscarRoles())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    btnprisave.Enabled = true;
                    tbprivisearch.Text = form.nomRol;
                    CNUsuario objUsuario = new CNUsuario();
                    idrol = form.idrol;
                    SqlDataReader reader = objUsuario.privSegunIdRol(idrol);
                    SqlDataReader reader2 = objUsuario.privSegunIdRol2(idrol);
                    data3 = new List<SomeData>();
                    data4 = new List<SomeData>();
                    while (reader.Read())
                    {
                        //MessageBox.Show(reader["nomRol"].ToString());
                        data3.Add(new SomeData() { Value3 = reader["IdPrivilegio"].ToString(), Text3 = reader["nombre"].ToString() });
                    }
                    while (reader2.Read())
                    {
                        //MessageBox.Show(reader["nomRol"].ToString());
                        data4.Add(new SomeData() { Value4 = reader2["IdPrivilegio"].ToString(), Text4 = reader2["nombre"].ToString() });
                    }

                    lbPrivi1.DataSource = data3;
                    lbPrivi1.DisplayMember = "Text3";

                    lbPrivi2.DataSource = data4;
                    lbPrivi2.DisplayMember = "Text4";
                    btnprivisearch.Focus();

                    if (lbPrivi2.Items.Count > 0)
                    {
                        //MessageBox.Show("vacío");

                        btnprileft.Enabled = true;
                        btnprileft2.Enabled = true;
                    }
                    else
                    {
                        btnprileft.Enabled = false;
                        btnprileft2.Enabled = false;
                    }
                    if (lbPrivi1.Items.Count > 0)
                    {
                        //MessageBox.Show("no vacío");
                        btnpriright.Enabled = true;
                        btnpriright2.Enabled = true;
                    }
                    else{
                        btnpriright.Enabled = false;
                        btnpriright2.Enabled = false;
                    }
                }


            }
        }

        private void btnpriright_Click(object sender, EventArgs e)
        {
            int index = lbPrivi1.SelectedIndex; //Or wherever else you want to get the index from.
            if (index < 0)
            {
                MessageBox.Show("Elija primero un elemento");
            }
            else
            {
                int id = Int32.Parse((lbPrivi1.SelectedItem as SomeData).Value3);
                String rol = String.Format((lbPrivi1.SelectedItem as SomeData).Text3);
                //MessageBox.Show(rol);
                data4.Add(new SomeData() { Value4 = id.ToString(), Text4 = rol });
                data3.RemoveAt(index);

                lbPrivi1.DataSource = null;
                lbPrivi1.DataSource = data3;
                lbPrivi1.DisplayMember = "Text3";
                lbPrivi2.DataSource = null;
                lbPrivi2.DataSource = data4;
                lbPrivi2.DisplayMember = "Text4";
                if (lbPrivi1.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnpriright.Enabled = true;
                    btnpriright2.Enabled = true;
                }
                else
                {
                    btnpriright.Enabled = false;
                    btnpriright2.Enabled = false;
                }
                if (lbPrivi2.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnprileft.Enabled = true;
                    btnprileft2.Enabled = true;
                }
            }
        }

        private void btnprileft_Click(object sender, EventArgs e)
        {
            int index = lbPrivi2.SelectedIndex; //Or wherever else you want to get the index from.
            if (index < 0)
            {
                MessageBox.Show("Elija primero un elemento");

            }
            else
            {
                int id = Int32.Parse((lbPrivi2.SelectedItem as SomeData).Value4);
                String rol = String.Format((lbPrivi2.SelectedItem as SomeData).Text4);
                //MessageBox.Show(rol);
                data3.Add(new SomeData() { Value3 = id.ToString(), Text3 = rol });
                data4.RemoveAt(index);

                lbPrivi1.DataSource = null;
                lbPrivi1.DataSource = data3;
                lbPrivi1.DisplayMember = "Text3";
                lbPrivi2.DataSource = null;
                lbPrivi2.DataSource = data4;
                lbPrivi2.DisplayMember = "Text4";
                //MessageBox.Show(lbRoles2.Items.Count.ToString());
                if (lbPrivi2.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnprileft.Enabled = true;
                    btnprileft2.Enabled = true;
                }
                else
                {
                    btnprileft.Enabled = false;
                    btnprileft2.Enabled = false;
                }
                if (lbPrivi1.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnpriright.Enabled = true;
                    btnpriright2.Enabled = true;
                }
            }
        }

        private void btnpriright2_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadItems = lbPrivi1.Items.Count;
                //MessageBox.Show(cantidadItems.ToString());
                for (int n = cantidadItems - 1; n >= 0; --n)
                {
                    String idrol = ((SomeData)lbPrivi1.Items[n]).Value3.ToString();
                    String nomrol = ((SomeData)lbPrivi1.Items[n]).Text3.ToString();
                    data4.Add(new SomeData() { Value4 = idrol, Text4 = nomrol });
                    //MessageBox.Show("zz" + n + " " + idrol + " " + nomrol);
                    data3.RemoveAt(n);
                    
                }
                //MessageBox.Show(count.ToString());
                lbPrivi1.DataSource = null;
                lbPrivi1.DataSource = data3;
                lbPrivi1.DisplayMember = "Text3";
                lbPrivi2.DataSource = null;
                lbPrivi2.DataSource = data4;
                lbPrivi2.DisplayMember = "Text4";
                if (lbPrivi1.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");
                    btnpriright.Enabled = true;
                    btnpriright2.Enabled = true;
                }
                else
                {
                    btnpriright.Enabled = false;
                    btnpriright2.Enabled = false;
                }
                if (lbPrivi2.Items.Count > 0)
                {
                    //MessageBox.Show("no vacío");
                    btnprileft.Enabled = true;
                    btnprileft2.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error btnpriright2 " + ex);
            }
        }

        private void btnprileft2_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadItems = lbPrivi2.Items.Count;
                //MessageBox.Show(cantidadItems.ToString());
                for (int n = cantidadItems - 1; n >= 0; --n)
                {
                    String idrol = ((SomeData)lbPrivi2.Items[n]).Value4.ToString();
                    String nomrol = ((SomeData)lbPrivi2.Items[n]).Text4.ToString();
                    data3.Add(new SomeData() { Value3 = idrol, Text3 = nomrol });
                    //MessageBox.Show("zz" + n + " " + idrol + " " + nomrol);
                    data4.RemoveAt(n);

                }
                //MessageBox.Show(count.ToString());
                lbPrivi1.DataSource = null;
                lbPrivi1.DataSource = data3;
                lbPrivi1.DisplayMember = "Text3";
                lbPrivi2.DataSource = null;
                lbPrivi2.DataSource = data4;
                lbPrivi2.DisplayMember = "Text4";
                if (lbPrivi2.Items.Count > 0)
                {
                    //MessageBox.Show("vacío");

                    btnprileft.Enabled = true;
                    btnprileft2.Enabled = true;
                }
                else
                {
                    btnprileft.Enabled = false;
                    btnprileft2.Enabled = false;
                }
                if (lbPrivi1.Items.Count > 0)
                {
                    //MessageBox.Show("no vacío");
                    btnpriright.Enabled = true;
                    btnpriright2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error btnpriright2 " + ex);
            }
        }

        private void btnprisave_Click(object sender, EventArgs e)
        {
            CNUsuario objUsuario = new CNUsuario();
            int index = lbPrivi2.SelectedIndex;
            if (MessageBox.Show("¿Está seguro(a) de actualizar los privilegios de este rol?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (lbPrivi2.Items.Count == 0)
                {
                    //MessageBox.Show("estoy vacío");
                    SqlDataReader reader = objUsuario.controlRolPrivilegio(idrol, 0);
                    objUsuario.eliminarRolPrivilegio(idrol);
                    MessageBox.Show("Se ha actualizado los datos");
                }
                else
                {
                    //MessageBox.Show("No estoy vacío");
                    objUsuario.eliminarRolPrivilegio(idrol);
                    foreach (SomeData item in data4)
                    {
                        SqlDataReader reader = objUsuario.controlRolPrivilegio(idrol, Int32.Parse(item.Value4));

                    }
                    MessageBox.Show("Se ha actualizado los datos");

                }
            }
        }

        private void txtSearch_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            DataView dv = tabla.DefaultView;
            dv.RowFilter = string.Format(" Login like '%{0}%' or Nombres like '%{0}%' or ApellidoPaterno like '%{0}%' or ApellidoMaterno like '%{0}%' or DNI like '%{0}%'", txtSearch.Text);
        }

        private void btnusueditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            /*FormNuevoPerfil formMC = new FormNuevoPerfil();
            formMC.ShowDialog();*/
            using (FormNuevoPerfil form = new FormNuevoPerfil())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    cargarPerfiles(dgvPerfiles);
                }
            }
        }

        private void btneditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                int index = dgvPerfiles.CurrentCell.RowIndex;
                int value = Int32.Parse(dgvPerfiles.Rows[index].Cells["IdUsuario"].Value.ToString());
                //MessageBox.Show("id: " + value);
                using (FormEditarUsuario obj = new FormEditarUsuario())
                {
                    obj.idusu = value;
                    if (obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        cargarPerfiles(dgvPerfiles);
                    }


                    //obj.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro(a) de eliminar este usuario?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                CNUsuario objUsuario = new CNUsuario();
                int index = dgvPerfiles.CurrentCell.RowIndex;
                int idusuario = Int32.Parse(dgvPerfiles.Rows[index].Cells["IdUsuario"].Value.ToString());
                objUsuario.eliminarUsuario(idusuario);
                MessageBox.Show("Se ha eliminado el usuario");
                cargarPerfiles(dgvPerfiles);
            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
