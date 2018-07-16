using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaFigueri
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //
        int LX, LY;
        int sw, sh;
        //arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hend, int wsmg, int wparam, int lparam);


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }

       //Cerrar, maximizar, minimizar formulario
        private void btnAmpliar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            LX = Location.X;
            LY = Location.Y;
            sw = Size.Width;
            sh = Size.Height;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnAmpliar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;

            Size = new Size(sw, sh);
            Location = new Point (LX, LY);
            btnRestaurar.Visible = false;
            btnAmpliar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        private void btnCerrarPrincipal_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }

        }

        //animacion boton Barra
        private void btnSlide_Click(object sender, EventArgs e)
        {

            if (BarraLateral.Width == 250)
            {
                tmOcultarbarra.Enabled = true;
            }
            else
            {
                tmMostrarBarra.Enabled = true;
            }

        }
        private void tmMostrarBarra_Tick(object sender, EventArgs e)
        {
            if (BarraLateral.Width >= 250)
                tmMostrarBarra.Enabled = false;
            else
                BarraLateral.Width = BarraLateral.Width + 60;


        }

        private void tmOcultarBarra_Tick(object sender, EventArgs e)
        {
            if (BarraLateral.Width <= 70)
                tmOcultarbarra.Enabled = false;
            else
                BarraLateral.Width = BarraLateral.Width - 60;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        //metodo para mostrar formulario en panel 
        private void AbreFormEnPanel(object Formhijo)
        {
            if (PanelContenedor.Controls.Count > 0)
                PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(fh);
            PanelContenedor.Tag = fh;
            fh.Show();
        }
        //icial logo
        //private void mostrarHomelogo()
        //{
        //    AbreFormEnPanel(new FormPrincipalPage());
        //}
        //private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        //{
        //    mostrarHomelogo();
        //}
        //click botones
        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbreFormEnPanel(new FormProductos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbreFormEnPanel(new FormVenta());
        }
        private void btnCentralizacioncaja_Click(object sender, EventArgs e)
        {
            AbreFormEnPanel(new FormAperturaCaja());
        }

       
       
        //tamaño 
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
                    var hitPoint = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //Rectangulo de lineas 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(ClientRectangle.Width - tolerance, ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            PanelContenedor.Region = region;
            Invalidate();
        }

        private void btnRestaurar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        //color rectangulo fondo
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(52, 73, 94));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

    }
}
