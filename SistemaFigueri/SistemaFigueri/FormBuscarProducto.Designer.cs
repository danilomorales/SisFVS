﻿namespace SistemaFigueri
{
    partial class FormBuscarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbtotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.tbFiltra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvlListaProducto = new System.Windows.Forms.DataGridView();
            this.btnCerrarFiltroCliente = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbIdCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlListaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.bunifuCustomLabel15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(817, 66);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(209, 21);
            this.bunifuCustomLabel15.TabIndex = 219;
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
            this.lbtotal.Location = new System.Drawing.Point(1027, 66);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(20, 21);
            this.lbtotal.TabIndex = 220;
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
            this.bunifuCustomLabel22.Location = new System.Drawing.Point(56, 45);
            this.bunifuCustomLabel22.Name = "bunifuCustomLabel22";
            this.bunifuCustomLabel22.Size = new System.Drawing.Size(125, 21);
            this.bunifuCustomLabel22.TabIndex = 218;
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
            this.cboestado.Location = new System.Drawing.Point(56, 67);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(125, 24);
            this.cboestado.TabIndex = 217;
            this.cboestado.Text = "codigo";
            // 
            // tbFiltra
            // 
            this.tbFiltra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.tbFiltra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFiltra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tbFiltra.ForeColor = System.Drawing.Color.Black;
            this.tbFiltra.HintForeColor = System.Drawing.Color.White;
            this.tbFiltra.HintText = "Buscar Producto";
            this.tbFiltra.isPassword = false;
            this.tbFiltra.LineFocusedColor = System.Drawing.Color.Red;
            this.tbFiltra.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.tbFiltra.LineMouseHoverColor = System.Drawing.Color.SandyBrown;
            this.tbFiltra.LineThickness = 6;
            this.tbFiltra.Location = new System.Drawing.Point(287, 56);
            this.tbFiltra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFiltra.Name = "tbFiltra";
            this.tbFiltra.Size = new System.Drawing.Size(523, 31);
            this.tbFiltra.TabIndex = 216;
            this.tbFiltra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFiltra_KeyUp);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgvlListaProducto
            // 
            this.dgvlListaProducto.AllowUserToAddRows = false;
            this.dgvlListaProducto.AllowUserToDeleteRows = false;
            this.dgvlListaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlListaProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlListaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlListaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlListaProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlListaProducto.Location = new System.Drawing.Point(27, 114);
            this.dgvlListaProducto.Name = "dgvlListaProducto";
            this.dgvlListaProducto.ReadOnly = true;
            this.dgvlListaProducto.RowHeadersVisible = false;
            this.dgvlListaProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvlListaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlListaProducto.Size = new System.Drawing.Size(1020, 308);
            this.dgvlListaProducto.TabIndex = 222;
            this.dgvlListaProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlListaProducto_CellDoubleClick);
            // 
            // btnCerrarFiltroCliente
            // 
            this.btnCerrarFiltroCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarFiltroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrarFiltroCliente.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrarFiltroCliente.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCerrarFiltroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarFiltroCliente.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnCerrarFiltroCliente.ForeColor = System.Drawing.Color.White;
            this.btnCerrarFiltroCliente.Image = null;
            this.btnCerrarFiltroCliente.ImagePosition = 4;
            this.btnCerrarFiltroCliente.ImageZoom = 20;
            this.btnCerrarFiltroCliente.LabelPosition = 30;
            this.btnCerrarFiltroCliente.LabelText = "Cancelar";
            this.btnCerrarFiltroCliente.Location = new System.Drawing.Point(950, 470);
            this.btnCerrarFiltroCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarFiltroCliente.Name = "btnCerrarFiltroCliente";
            this.btnCerrarFiltroCliente.Size = new System.Drawing.Size(123, 36);
            this.btnCerrarFiltroCliente.TabIndex = 223;
            this.btnCerrarFiltroCliente.Click += new System.EventHandler(this.btnCerrarFiltroCliente_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::SistemaFigueri.Properties.Resources.buscador;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(249, 56);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(38, 31);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 226;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Location = new System.Drawing.Point(164, 456);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(30, 13);
            this.lbIdCliente.TabIndex = 227;
            this.lbIdCliente.Text = "Clien";
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1095, 537);
            this.Controls.Add(this.lbIdCliente);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.btnCerrarFiltroCliente);
            this.Controls.Add(this.dgvlListaProducto);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.bunifuCustomLabel22);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.tbFiltra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarProducto";
            this.Load += new System.EventHandler(this.FormBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlListaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel22;
        private System.Windows.Forms.ComboBox cboestado;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbFiltra;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dgvlListaProducto;
        private Bunifu.Framework.UI.BunifuTileButton btnCerrarFiltroCliente;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label lbIdCliente;
    }
}