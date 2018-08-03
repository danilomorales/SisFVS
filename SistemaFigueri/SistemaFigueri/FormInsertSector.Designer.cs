namespace SistemaFigueri
{
    partial class FormInsertSector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertSector));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.bmdescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bmnota = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnguardarSec = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bmCancelarSec = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(570, 203);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // bmdescripcion
            // 
            this.bmdescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmdescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.bmdescripcion.ForeColor = System.Drawing.Color.White;
            this.bmdescripcion.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bmdescripcion.HintText = "Introduce descripcion del sector";
            this.bmdescripcion.isPassword = false;
            this.bmdescripcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmdescripcion.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.bmdescripcion.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.bmdescripcion.LineThickness = 5;
            this.bmdescripcion.Location = new System.Drawing.Point(323, 57);
            this.bmdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.bmdescripcion.Name = "bmdescripcion";
            this.bmdescripcion.Size = new System.Drawing.Size(294, 29);
            this.bmdescripcion.TabIndex = 102;
            this.bmdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            //this.bmdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bmdescripcion_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 26);
            this.panel1.TabIndex = 103;
            // 
            // bmnota
            // 
            this.bmnota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmnota.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.bmnota.ForeColor = System.Drawing.Color.White;
            this.bmnota.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bmnota.HintText = "Introduce nota";
            this.bmnota.isPassword = false;
            this.bmnota.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmnota.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.bmnota.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bmnota.LineThickness = 5;
            this.bmnota.Location = new System.Drawing.Point(323, 122);
            this.bmnota.Margin = new System.Windows.Forms.Padding(4);
            this.bmnota.Name = "bmnota";
            this.bmnota.Size = new System.Drawing.Size(294, 29);
            this.bmnota.TabIndex = 110;
            this.bmnota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            //this.bmnota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bmnota_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 26);
            this.panel2.TabIndex = 104;
            // 
            // btnguardarSec
            // 
            this.btnguardarSec.ActiveBorderThickness = 1;
            this.btnguardarSec.ActiveCornerRadius = 20;
            this.btnguardarSec.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnguardarSec.ActiveForecolor = System.Drawing.Color.White;
            this.btnguardarSec.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnguardarSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnguardarSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardarSec.BackgroundImage")));
            this.btnguardarSec.ButtonText = "GUARDAR";
            this.btnguardarSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarSec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarSec.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnguardarSec.IdleBorderThickness = 1;
            this.btnguardarSec.IdleCornerRadius = 20;
            this.btnguardarSec.IdleFillColor = System.Drawing.Color.Green;
            this.btnguardarSec.IdleForecolor = System.Drawing.Color.White;
            this.btnguardarSec.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnguardarSec.Location = new System.Drawing.Point(127, 228);
            this.btnguardarSec.Margin = new System.Windows.Forms.Padding(5);
            this.btnguardarSec.Name = "btnguardarSec";
            this.btnguardarSec.Size = new System.Drawing.Size(181, 41);
            this.btnguardarSec.TabIndex = 136;
            this.btnguardarSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.btnguardarSec.Click += new System.EventHandler(this.btnguardarSec_Click);
            // 
            // bmCancelarSec
            // 
            this.bmCancelarSec.ActiveBorderThickness = 1;
            this.bmCancelarSec.ActiveCornerRadius = 20;
            this.bmCancelarSec.ActiveFillColor = System.Drawing.Color.Red;
            this.bmCancelarSec.ActiveForecolor = System.Drawing.Color.White;
            this.bmCancelarSec.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bmCancelarSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bmCancelarSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bmCancelarSec.BackgroundImage")));
            this.bmCancelarSec.ButtonText = "CANCELAR";
            this.bmCancelarSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmCancelarSec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmCancelarSec.ForeColor = System.Drawing.Color.White;
            this.bmCancelarSec.IdleBorderThickness = 1;
            this.bmCancelarSec.IdleCornerRadius = 20;
            this.bmCancelarSec.IdleFillColor = System.Drawing.Color.Maroon;
            this.bmCancelarSec.IdleForecolor = System.Drawing.Color.White;
            this.bmCancelarSec.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.bmCancelarSec.Location = new System.Drawing.Point(357, 228);
            this.bmCancelarSec.Margin = new System.Windows.Forms.Padding(5);
            this.bmCancelarSec.Name = "bmCancelarSec";
            this.bmCancelarSec.Size = new System.Drawing.Size(181, 41);
            this.bmCancelarSec.TabIndex = 135;
            this.bmCancelarSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.bmCancelarSec.Click += new System.EventHandler(this.bmCancelarSec_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Nota:";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage_right")));
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 40D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(199, 123);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(125, 29);
            this.bunifuFlatButton5.TabIndex = 109;
            this.bunifuFlatButton5.Text = "Nota:";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Descripcion del Sector:";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage_right")));
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 40D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(199, 49);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(125, 38);
            this.bunifuFlatButton3.TabIndex = 101;
            this.bunifuFlatButton3.Text = "Descripcion del Sector:";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormInsertSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(809, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnguardarSec);
            this.Controls.Add(this.bmCancelarSec);
            this.Controls.Add(this.bmnota);
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bmdescripcion);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.doubleBitmapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInsertSector";
            this.Text = "FormInsertSector";
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bmdescripcion;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmnota;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnguardarSec;
        private Bunifu.Framework.UI.BunifuThinButton2 bmCancelarSec;
        private System.Windows.Forms.Panel panel2;
    }
}