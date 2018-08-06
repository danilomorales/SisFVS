namespace SistemaFigueri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbtotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.tbFiltra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtaListaPro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtaListaPro)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuCustomLabel15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(634, 98);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(209, 21);
            this.bunifuCustomLabel15.TabIndex = 219;
            this.bunifuCustomLabel15.Text = "TOTAL DE RESULTADOS";
            this.bunifuCustomLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.lbtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtotal.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.ForeColor = System.Drawing.Color.White;
            this.lbtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbtotal.Location = new System.Drawing.Point(844, 98);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(20, 21);
            this.lbtotal.TabIndex = 220;
            this.lbtotal.Text = "  ";
            this.lbtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel22
            // 
            this.bunifuCustomLabel22.AutoSize = true;
            this.bunifuCustomLabel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuCustomLabel22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel22.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel22.ForeColor = System.Drawing.Color.White;
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
            this.cboestado.BackColor = System.Drawing.Color.DarkGreen;
            this.cboestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboestado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ForeColor = System.Drawing.SystemColors.Menu;
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
            this.tbFiltra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.tbFiltra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFiltra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tbFiltra.ForeColor = System.Drawing.Color.White;
            this.tbFiltra.HintForeColor = System.Drawing.Color.White;
            this.tbFiltra.HintText = "Buscar Cliente";
            this.tbFiltra.isPassword = false;
            this.tbFiltra.LineFocusedColor = System.Drawing.Color.Red;
            this.tbFiltra.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.tbFiltra.LineMouseHoverColor = System.Drawing.Color.SandyBrown;
            this.tbFiltra.LineThickness = 6;
            this.tbFiltra.Location = new System.Drawing.Point(212, 45);
            this.tbFiltra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFiltra.Name = "tbFiltra";
            this.tbFiltra.Size = new System.Drawing.Size(576, 31);
            this.tbFiltra.TabIndex = 216;
            this.tbFiltra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFiltra_KeyUp);
            // 
            // dtaListaPro
            // 
            this.dtaListaPro.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaListaPro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaListaPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaListaPro.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtaListaPro.Location = new System.Drawing.Point(60, 122);
            this.dtaListaPro.Name = "dtaListaPro";
            this.dtaListaPro.Size = new System.Drawing.Size(842, 322);
            this.dtaListaPro.TabIndex = 215;
            this.dtaListaPro.DoubleClick += new System.EventHandler(this.dtaListaPro_DoubleClick);
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(988, 537);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.bunifuCustomLabel22);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.tbFiltra);
            this.Controls.Add(this.dtaListaPro);
            this.Name = "FormBuscarProducto";
            this.Text = "FormBuscarProducto";
            this.Load += new System.EventHandler(this.FormBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaListaPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel22;
        private System.Windows.Forms.ComboBox cboestado;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbFiltra;
        private System.Windows.Forms.DataGridView dtaListaPro;
    }
}