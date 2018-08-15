namespace SistemaFigueri
{
    partial class FormBuscarPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.tbpedidos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.dpdesde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dphasta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnbuscarpedido = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscarpedido)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.AutoSize = true;
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.bunifuCards2.Controls.Add(this.label4);
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.bunifuCards3);
            this.bunifuCards2.Controls.Add(this.btnbuscarpedido);
            this.bunifuCards2.Controls.Add(this.btnCerrar);
            this.bunifuCards2.Controls.Add(this.dphasta);
            this.bunifuCards2.Controls.Add(this.dpdesde);
            this.bunifuCards2.Controls.Add(this.tbpedidos);
            this.bunifuCards2.Controls.Add(this.dgvPedidos);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1204, 848);
            this.bunifuCards2.TabIndex = 37;
            // 
            // tbpedidos
            // 
            this.tbpedidos.BackColor = System.Drawing.Color.Silver;
            this.tbpedidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpedidos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.tbpedidos.ForeColor = System.Drawing.Color.White;
            this.tbpedidos.HintForeColor = System.Drawing.Color.White;
            this.tbpedidos.HintText = "Buscar Pedido";
            this.tbpedidos.isPassword = false;
            this.tbpedidos.LineFocusedColor = System.Drawing.Color.Red;
            this.tbpedidos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.tbpedidos.LineMouseHoverColor = System.Drawing.Color.SandyBrown;
            this.tbpedidos.LineThickness = 5;
            this.tbpedidos.Location = new System.Drawing.Point(635, 171);
            this.tbpedidos.Margin = new System.Windows.Forms.Padding(4);
            this.tbpedidos.Name = "tbpedidos";
            this.tbpedidos.Size = new System.Drawing.Size(512, 44);
            this.tbpedidos.TabIndex = 57;
            this.tbpedidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.Location = new System.Drawing.Point(48, 222);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1099, 564);
            this.dgvPedidos.TabIndex = 33;
            // 
            // dpdesde
            // 
            this.dpdesde.BackColor = System.Drawing.Color.OrangeRed;
            this.dpdesde.BorderRadius = 0;
            this.dpdesde.ForeColor = System.Drawing.Color.White;
            this.dpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpdesde.FormatCustom = null;
            this.dpdesde.Location = new System.Drawing.Point(188, 98);
            this.dpdesde.Name = "dpdesde";
            this.dpdesde.Size = new System.Drawing.Size(357, 46);
            this.dpdesde.TabIndex = 59;
            this.dpdesde.Value = new System.DateTime(2018, 8, 14, 17, 43, 27, 569);
            // 
            // dphasta
            // 
            this.dphasta.BackColor = System.Drawing.Color.OrangeRed;
            this.dphasta.BorderRadius = 0;
            this.dphasta.ForeColor = System.Drawing.Color.White;
            this.dphasta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dphasta.FormatCustom = null;
            this.dphasta.Location = new System.Drawing.Point(715, 98);
            this.dphasta.Name = "dphasta";
            this.dphasta.Size = new System.Drawing.Size(357, 46);
            this.dphasta.TabIndex = 60;
            this.dphasta.Value = new System.DateTime(2018, 8, 14, 17, 43, 27, 569);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCerrar.color = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCerrar.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = null;
            this.btnCerrar.ImagePosition = 4;
            this.btnCerrar.ImageZoom = 20;
            this.btnCerrar.LabelPosition = 30;
            this.btnCerrar.LabelText = "Salir";
            this.btnCerrar.Location = new System.Drawing.Point(1108, 802);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(65, 33);
            this.btnCerrar.TabIndex = 218;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnbuscarpedido
            // 
            this.btnbuscarpedido.BackColor = System.Drawing.Color.CadetBlue;
            this.btnbuscarpedido.Image = global::SistemaFigueri.Properties.Resources.busca;
            this.btnbuscarpedido.ImageActive = null;
            this.btnbuscarpedido.Location = new System.Drawing.Point(1078, 98);
            this.btnbuscarpedido.Name = "btnbuscarpedido";
            this.btnbuscarpedido.Size = new System.Drawing.Size(55, 46);
            this.btnbuscarpedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnbuscarpedido.TabIndex = 219;
            this.btnbuscarpedido.TabStop = false;
            this.btnbuscarpedido.Zoom = 10;
            this.btnbuscarpedido.Click += new System.EventHandler(this.btnbuscarpedido_Click);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.bunifuCards3.BorderRadius = 10;
            this.bunifuCards3.BottomSahddow = false;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.bunifuCards3.Controls.Add(this.label1);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(48, 12);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = false;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(1099, 68);
            this.bunifuCards3.TabIndex = 220;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDOS PENDIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(586, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 221;
            this.label3.Text = "Desde: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(63, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 23);
            this.label4.TabIndex = 222;
            this.label4.Text = "Seleccione (doble click): ";
            // 
            // FormBuscarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 848);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarPedidos";
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscarpedido)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbpedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private Bunifu.Framework.UI.BunifuDatepicker dphasta;
        private Bunifu.Framework.UI.BunifuDatepicker dpdesde;
        private Bunifu.Framework.UI.BunifuTileButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnbuscarpedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}