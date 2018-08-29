namespace SistemaFigueri
{
    partial class FormSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSector));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btneliminar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bmEditar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnNuevoSector = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.dgvSector = new System.Windows.Forms.DataGridView();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bmBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuCards4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.AutoSize = true;
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.btneliminar);
            this.bunifuCards1.Controls.Add(this.bmEditar);
            this.bunifuCards1.Controls.Add(this.btnNuevoSector);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1180, 17);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(315, 95);
            this.bunifuCards1.TabIndex = 36;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.color = System.Drawing.Color.Transparent;
            this.btneliminar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImagePosition = 10;
            this.btneliminar.ImageZoom = 60;
            this.btneliminar.LabelPosition = 5;
            this.btneliminar.LabelText = "";
            this.btneliminar.Location = new System.Drawing.Point(204, 13);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(94, 74);
            this.btneliminar.TabIndex = 37;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // bmEditar
            // 
            this.bmEditar.BackColor = System.Drawing.Color.Transparent;
            this.bmEditar.color = System.Drawing.Color.Transparent;
            this.bmEditar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bmEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmEditar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bmEditar.ForeColor = System.Drawing.Color.White;
            this.bmEditar.Image = ((System.Drawing.Image)(resources.GetObject("bmEditar.Image")));
            this.bmEditar.ImagePosition = 10;
            this.bmEditar.ImageZoom = 60;
            this.bmEditar.LabelPosition = 5;
            this.bmEditar.LabelText = "";
            this.bmEditar.Location = new System.Drawing.Point(112, 12);
            this.bmEditar.Margin = new System.Windows.Forms.Padding(6);
            this.bmEditar.Name = "bmEditar";
            this.bmEditar.Size = new System.Drawing.Size(94, 75);
            this.bmEditar.TabIndex = 36;
            this.bmEditar.Click += new System.EventHandler(this.bmEditar_Click_1);
            // 
            // btnNuevoSector
            // 
            this.btnNuevoSector.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoSector.color = System.Drawing.Color.Transparent;
            this.btnNuevoSector.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevoSector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoSector.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnNuevoSector.ForeColor = System.Drawing.Color.White;
            this.btnNuevoSector.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoSector.Image")));
            this.btnNuevoSector.ImagePosition = 10;
            this.btnNuevoSector.ImageZoom = 60;
            this.btnNuevoSector.LabelPosition = 5;
            this.btnNuevoSector.LabelText = "";
            this.btnNuevoSector.Location = new System.Drawing.Point(20, 11);
            this.btnNuevoSector.Margin = new System.Windows.Forms.Padding(6);
            this.btnNuevoSector.Name = "btnNuevoSector";
            this.btnNuevoSector.Size = new System.Drawing.Size(90, 76);
            this.btnNuevoSector.TabIndex = 33;
            this.btnNuevoSector.Click += new System.EventHandler(this.btnNuevoSector_Click_1);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCards2.AutoSize = true;
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.bunifuCards3);
            this.bunifuCards2.Controls.Add(this.bunifuCards1);
            this.bunifuCards2.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards2.Controls.Add(this.bmBuscar);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 123);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1894, 891);
            this.bunifuCards2.TabIndex = 37;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Transparent;
            this.bunifuCards3.Controls.Add(this.dgvSector);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(120, 113);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(1202, 691);
            this.bunifuCards3.TabIndex = 59;
            this.bunifuCards3.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards3_Paint);
            // 
            // dgvSector
            // 
            this.dgvSector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSector.BackgroundColor = System.Drawing.Color.White;
            this.dgvSector.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSector.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSector.Location = new System.Drawing.Point(14, 13);
            this.dgvSector.Name = "dgvSector";
            this.dgvSector.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvSector.Size = new System.Drawing.Size(1171, 666);
            this.dgvSector.TabIndex = 34;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(391, 59);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 58;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bmBuscar
            // 
            this.bmBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmBuscar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bmBuscar.ForeColor = System.Drawing.Color.White;
            this.bmBuscar.HintForeColor = System.Drawing.Color.White;
            this.bmBuscar.HintText = "Buscar Cliente";
            this.bmBuscar.isPassword = false;
            this.bmBuscar.LineFocusedColor = System.Drawing.Color.Red;
            this.bmBuscar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.bmBuscar.LineMouseHoverColor = System.Drawing.Color.SandyBrown;
            this.bmBuscar.LineThickness = 5;
            this.bmBuscar.Location = new System.Drawing.Point(421, 45);
            this.bmBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bmBuscar.Name = "bmBuscar";
            this.bmBuscar.Size = new System.Drawing.Size(512, 44);
            this.bmBuscar.TabIndex = 57;
            this.bmBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bmBuscar_KeyUp);
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.Tomato;
            this.bunifuCards4.Controls.Add(this.label2);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(726, 28);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(309, 63);
            this.bunifuCards4.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "LISTA  DE SECTORES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1918, 1036);
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1438, 858);
            this.Name = "FormSector";
            this.RightToLeftLayout = true;
            this.Text = "FormSector";
            this.Load += new System.EventHandler(this.FormSector_Load_1);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuTileButton btneliminar;
        private Bunifu.Framework.UI.BunifuTileButton bmEditar;
        private Bunifu.Framework.UI.BunifuTileButton btnNuevoSector;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmBuscar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.DataGridView dgvSector;
    }
}