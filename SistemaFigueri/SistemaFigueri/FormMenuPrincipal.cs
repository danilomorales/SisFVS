using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaFigueri
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }
        int lx, ly;
        int sw, sh;
        //Metodos para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Métodos de Minimizar, Normalizar, Maximizar, Cerrar:

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximiza_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            /*btnMaximiza.Visible = false;
            btnNormal.Visible = true;*/
        }

       
        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
           /* btnNormal.Visible = false;
            btnMaximiza.Visible = true;*/
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                /*holon*/


            }
        }

        //Método pra animación del menú lateral 
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 240)
            {
                this.tmOcultarMenu.Enabled = true;
            }
            else if (panelMenu.Width == 80)
                this.tmMostrarMenu.Enabled = true;
        }

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 240)
                this.tmMostrarMenu.Enabled = false;
            else
                panelMenu.Width = panelMenu.Width + 32;

        }
        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 80)
                this.tmOcultarMenu.Enabled = false;
            else
                panelMenu.Width = panelMenu.Width - 32;
        }
        //Método para todo los formularios y carga en Panel principal 
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        //para mostrar el panel de menú 
        private void MostrarFormInicio()
        {
            AbrirFormEnPanel(new FormPrincipalPage());
            
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

            /*Label label = new Label();
            label.Text = "Nombre del usuario";
            label.Font= new Font("Arial", label.Font.Size, FontStyle.Bold);
            label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label.BackColor = Color.FromArgb(39, 57, 80);
            label.Location = new Point(22, 33);
            this.panelMenu.Controls.Add(label);*/
            
            MostrarFormInicio();


        }


        private void MostrarFormInicioAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormInicio();
        }

       

        //Metodo para mostrar los formularios en contenedor 
        private void btnProductos_Click(object sender, EventArgs e)
        {           
            AbrirFormEnPanel(new FormProductos());
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
           
            AbrirFormEnPanel(new FormVenta());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormCliente());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {

        }

        private void btnCaja_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        //Fecha y HOra 
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFechadia.Text = DateTime.Now.ToLongDateString();
            lbHora1.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
        //redimencionar tamaño de os formularios 

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void panel1ContenedorPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbHora1_Click(object sender, EventArgs e)
        {

        }

        private void lbFechadia_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMenuPrincipal_Load_1(object sender, EventArgs e)
        {
            btnProductos.selected = true;
            /*label1.Text = "";
            label1.Text = "Carlos Romero";*/
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            /*btnMaximiza.Visible = false;
            btnNormal.Visible = true;*/
            List<String> listonazo = FormLogin.liston;

            List<Bunifu.Framework.UI.BunifuFlatButton> lstBtnCalc = new List<Bunifu.Framework.UI.BunifuFlatButton>
            {
                btnProductos,btnClientes,btnCaja,btnSector,btnReportes,btnVentas,btnPromociones,btnPerfiles
            };

            
                //MessageBox.Show(listonazo[i].ToString());
                //MessageBox.Show(boton.Name);

                //for (int j = 0; j < lstBtnCalc.Capacity-1; j++)
                //{
                //    for (int i = 0; i < listonazo.Capacity - 1; i++)
                //    {
                //        if (lstBtnCalc[j].Name== listonazo[i].ToString())
                //        {
                //            if (lstBtnCalc[j].Visible == false)
                //            {
                //                lstBtnCalc[j].Visible = true;
                //            }
                //        }

                //    }

                //}
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormPerfiles());
        }

        //rectagulo en la parte inferior
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panel1ContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //Color del rectangulo
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
    }
}
