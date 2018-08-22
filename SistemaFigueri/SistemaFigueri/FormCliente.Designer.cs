namespace SistemaFigueri
{
    partial class FormCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnNuevoProducto = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bmBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(6, 82);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(1629, 689);
            this.dgvCliente.TabIndex = 61;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA  DE CLIENTES\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCards2.AutoSize = true;
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.bunifuCards1);
            this.bunifuCards2.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards2.Controls.Add(this.bmBuscar);
            this.bunifuCards2.Controls.Add(this.dgvCliente);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 121);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1646, 837);
            this.bunifuCards2.TabIndex = 61;
            this.bunifuCards2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards2_Paint);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.btnNuevoProducto);
            this.bunifuCards1.Controls.Add(this.bunifuTileButton2);
            this.bunifuCards1.Controls.Add(this.btneliminar);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1149, 7);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(320, 69);
            this.bunifuCards1.TabIndex = 36;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoProducto.color = System.Drawing.Color.Transparent;
            this.btnNuevoProducto.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProducto.Image = global::SistemaFigueri.Properties.Resources.addCliente;
            this.btnNuevoProducto.ImagePosition = 0;
            this.btnNuevoProducto.ImageZoom = 60;
            this.btnNuevoProducto.LabelPosition = 5;
            this.btnNuevoProducto.LabelText = "";
            this.btnNuevoProducto.Location = new System.Drawing.Point(17, 4);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(6);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(95, 57);
            this.btnNuevoProducto.TabIndex = 33;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 10;
            this.bunifuTileButton2.ImageZoom = 60;
            this.bunifuTileButton2.LabelPosition = 5;
            this.bunifuTileButton2.LabelText = "";
            this.bunifuTileButton2.Location = new System.Drawing.Point(124, 6);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(68, 55);
            this.bunifuTileButton2.TabIndex = 36;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.color = System.Drawing.Color.Transparent;
            this.btneliminar.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btneliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImagePosition = 10;
            this.btneliminar.ImageZoom = 60;
            this.btneliminar.LabelPosition = 5;
            this.btneliminar.LabelText = "";
            this.btneliminar.Location = new System.Drawing.Point(215, 6);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(68, 55);
            this.btneliminar.TabIndex = 37;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(169, 30);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 62;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bmBuscar
            // 
            this.bmBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmBuscar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bmBuscar.ForeColor = System.Drawing.Color.White;
            this.bmBuscar.HintForeColor = System.Drawing.Color.Black;
            this.bmBuscar.HintText = "Buscar Cliente por DNI";
            this.bmBuscar.isPassword = false;
            this.bmBuscar.LineFocusedColor = System.Drawing.Color.Red;
            this.bmBuscar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.bmBuscar.LineMouseHoverColor = System.Drawing.Color.SandyBrown;
            this.bmBuscar.LineThickness = 5;
            this.bmBuscar.Location = new System.Drawing.Point(198, 16);
            this.bmBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bmBuscar.Name = "bmBuscar";
            this.bmBuscar.Size = new System.Drawing.Size(711, 44);
            this.bmBuscar.TabIndex = 57;
            this.bmBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bmBuscar_KeyPress);
            this.bmBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bmBuscar_KeyUp);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Tomato;
            this.bunifuCards3.Controls.Add(this.label1);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(651, 12);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(304, 86);
            this.bunifuCards3.TabIndex = 35;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1670, 970);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCliente;
        private Bunifu.Framework.UI.BunifuTileButton btneliminar;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton btnNuevoProducto;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmBuscar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
    }
}