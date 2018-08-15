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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSector));
            this.dgvSector = new System.Windows.Forms.DataGridView();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btneliminar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bmEditar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnNuevoSector = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bmBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSector)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSector
            // 
            this.dgvSector.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSector.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSector.Location = new System.Drawing.Point(6, 71);
            this.dgvSector.Name = "dgvSector";
            this.dgvSector.Size = new System.Drawing.Size(1030, 395);
            this.dgvSector.TabIndex = 33;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.AutoSize = true;
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.btneliminar);
            this.bunifuCards1.Controls.Add(this.bmEditar);
            this.bunifuCards1.Controls.Add(this.btnNuevoSector);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(685, 11);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(293, 109);
            this.bunifuCards1.TabIndex = 36;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btneliminar.color = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btneliminar.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImagePosition = 18;
            this.btneliminar.ImageZoom = 40;
            this.btneliminar.LabelPosition = 28;
            this.btneliminar.LabelText = "Eliminar";
            this.btneliminar.Location = new System.Drawing.Point(204, 13);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(80, 84);
            this.btneliminar.TabIndex = 37;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // bmEditar
            // 
            this.bmEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(155)))), ((int)(((byte)(31)))));
            this.bmEditar.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(155)))), ((int)(((byte)(31)))));
            this.bmEditar.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bmEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmEditar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bmEditar.ForeColor = System.Drawing.Color.White;
            this.bmEditar.Image = ((System.Drawing.Image)(resources.GetObject("bmEditar.Image")));
            this.bmEditar.ImagePosition = 20;
            this.bmEditar.ImageZoom = 40;
            this.bmEditar.LabelPosition = 30;
            this.bmEditar.LabelText = "Editar";
            this.bmEditar.Location = new System.Drawing.Point(112, 12);
            this.bmEditar.Margin = new System.Windows.Forms.Padding(6);
            this.bmEditar.Name = "bmEditar";
            this.bmEditar.Size = new System.Drawing.Size(80, 84);
            this.bmEditar.TabIndex = 36;
            this.bmEditar.Click += new System.EventHandler(this.bmEditar_Click_1);
            // 
            // btnNuevoSector
            // 
            this.btnNuevoSector.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNuevoSector.color = System.Drawing.Color.SeaGreen;
            this.btnNuevoSector.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevoSector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoSector.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnNuevoSector.ForeColor = System.Drawing.Color.White;
            this.btnNuevoSector.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoSector.Image")));
            this.btnNuevoSector.ImagePosition = 20;
            this.btnNuevoSector.ImageZoom = 40;
            this.btnNuevoSector.LabelPosition = 30;
            this.btnNuevoSector.LabelText = "Nuevo";
            this.btnNuevoSector.Location = new System.Drawing.Point(20, 11);
            this.btnNuevoSector.Margin = new System.Windows.Forms.Padding(6);
            this.btnNuevoSector.Name = "btnNuevoSector";
            this.btnNuevoSector.Size = new System.Drawing.Size(80, 84);
            this.btnNuevoSector.TabIndex = 33;
            this.btnNuevoSector.Click += new System.EventHandler(this.btnNuevoSector_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(103, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA  DE SECTORES";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCards2.AutoSize = true;
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards2.Controls.Add(this.bmBuscar);
            this.bunifuCards2.Controls.Add(this.dgvSector);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 146);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1044, 479);
            this.bunifuCards2.TabIndex = 37;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(710, 30);
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
            this.bmBuscar.Location = new System.Drawing.Point(198, 16);
            this.bmBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bmBuscar.Name = "bmBuscar";
            this.bmBuscar.Size = new System.Drawing.Size(512, 44);
            this.bmBuscar.TabIndex = 57;
            this.bmBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bmBuscar_KeyUp);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Tomato;
            this.bunifuCards3.Controls.Add(this.label1);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(3, 12);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(621, 82);
            this.bunifuCards3.TabIndex = 38;
            // 
            // FormSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1054, 637);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSector";
            this.RightToLeftLayout = true;
            this.Text = "FormSector";
            this.Load += new System.EventHandler(this.FormSector_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSector)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSector;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuTileButton btneliminar;
        private Bunifu.Framework.UI.BunifuTileButton bmEditar;
        private Bunifu.Framework.UI.BunifuTileButton btnNuevoSector;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmBuscar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
    }
}