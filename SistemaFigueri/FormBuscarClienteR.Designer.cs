namespace SistemaFigueri
{
    partial class FormBuscarClienteR
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.tbFiltraCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCerrarFiltro = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbtotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.AutoSize = true;
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.bunifuImageButton2);
            this.bunifuCards2.Controls.Add(this.dgvCliente);
            this.bunifuCards2.Controls.Add(this.tbFiltraCliente);
            this.bunifuCards2.Controls.Add(this.btnCerrarFiltro);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel15);
            this.bunifuCards2.Controls.Add(this.lbtotal);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel22);
            this.bunifuCards2.Controls.Add(this.cboestado);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(984, 507);
            this.bunifuCards2.TabIndex = 35;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.Location = new System.Drawing.Point(16, 112);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(926, 308);
            this.dgvCliente.TabIndex = 224;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick_1);
            // 
            // tbFiltraCliente
            // 
            this.tbFiltraCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.tbFiltraCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFiltraCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tbFiltraCliente.ForeColor = System.Drawing.Color.Black;
            this.tbFiltraCliente.HintForeColor = System.Drawing.Color.Black;
            this.tbFiltraCliente.HintText = "Buscar Producto ";
            this.tbFiltraCliente.isPassword = false;
            this.tbFiltraCliente.LineFocusedColor = System.Drawing.Color.Red;
            this.tbFiltraCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.tbFiltraCliente.LineMouseHoverColor = System.Drawing.Color.SandyBrown;
            this.tbFiltraCliente.LineThickness = 6;
            this.tbFiltraCliente.Location = new System.Drawing.Point(193, 57);
            this.tbFiltraCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFiltraCliente.Name = "tbFiltraCliente";
            this.tbFiltraCliente.Size = new System.Drawing.Size(504, 31);
            this.tbFiltraCliente.TabIndex = 223;
            this.tbFiltraCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltraCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFiltraCliente_KeyUp);
            // 
            // btnCerrarFiltro
            // 
            this.btnCerrarFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrarFiltro.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrarFiltro.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCerrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarFiltro.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnCerrarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnCerrarFiltro.Image = null;
            this.btnCerrarFiltro.ImagePosition = 4;
            this.btnCerrarFiltro.ImageZoom = 20;
            this.btnCerrarFiltro.LabelPosition = 30;
            this.btnCerrarFiltro.LabelText = "Cancelar";
            this.btnCerrarFiltro.Location = new System.Drawing.Point(845, 456);
            this.btnCerrarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarFiltro.Name = "btnCerrarFiltro";
            this.btnCerrarFiltro.Size = new System.Drawing.Size(123, 36);
            this.btnCerrarFiltro.TabIndex = 217;
            this.btnCerrarFiltro.Click += new System.EventHandler(this.btnCerrarFiltro_Click);
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.bunifuCustomLabel15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(704, 67);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(209, 21);
            this.bunifuCustomLabel15.TabIndex = 213;
            this.bunifuCustomLabel15.Text = "TOTAL DE RESULTADOS";
            this.bunifuCustomLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.lbtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtotal.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.ForeColor = System.Drawing.Color.White;
            this.lbtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbtotal.Location = new System.Drawing.Point(914, 67);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(20, 21);
            this.lbtotal.TabIndex = 214;
            this.lbtotal.Text = "  ";
            this.lbtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel22
            // 
            this.bunifuCustomLabel22.AutoSize = true;
            this.bunifuCustomLabel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.bunifuCustomLabel22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel22.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel22.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel22.Location = new System.Drawing.Point(12, 45);
            this.bunifuCustomLabel22.Name = "bunifuCustomLabel22";
            this.bunifuCustomLabel22.Size = new System.Drawing.Size(125, 21);
            this.bunifuCustomLabel22.TabIndex = 191;
            this.bunifuCustomLabel22.Text = "BUSCAR POR";
            this.bunifuCustomLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.cboestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboestado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ForeColor = System.Drawing.Color.Black;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Items.AddRange(new object[] {
            "Numero de Doc ",
            "Apellidos"});
            this.cboestado.Location = new System.Drawing.Point(12, 67);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(125, 24);
            this.cboestado.TabIndex = 126;
            this.cboestado.Text = "Número de Doc";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.bunifuImageButton2.Image = global::SistemaFigueri.Properties.Resources.buscador;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(156, 57);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(38, 31);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 225;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // FormBuscarClienteR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 507);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarClienteR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarCliente";
            this.Load += new System.EventHandler(this.FormBuscarCliente_Load);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuTileButton btnCerrarFiltro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel22;
        private System.Windows.Forms.ComboBox cboestado;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbFiltraCliente;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}