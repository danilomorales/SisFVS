namespace SistemaFigueri
{
    partial class FormComprobanteVenta
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
            this.bcComprobante = new Bunifu.Framework.UI.BunifuCards();
            this.btnout = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bcComprobante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bcComprobante
            // 
            this.bcComprobante.AutoSize = true;
            this.bcComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.bcComprobante.BorderRadius = 5;
            this.bcComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bcComprobante.BottomSahddow = true;
            this.bcComprobante.color = System.Drawing.Color.Tomato;
            this.bcComprobante.Controls.Add(this.btnout);
            this.bcComprobante.Controls.Add(this.bunifuImageButton1);
            this.bcComprobante.Controls.Add(this.label1);
            this.bcComprobante.Controls.Add(this.crystalReportViewer1);
            this.bcComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bcComprobante.LeftSahddow = false;
            this.bcComprobante.Location = new System.Drawing.Point(0, 0);
            this.bcComprobante.Name = "bcComprobante";
            this.bcComprobante.RightSahddow = true;
            this.bcComprobante.ShadowDepth = 20;
            this.bcComprobante.Size = new System.Drawing.Size(592, 859);
            this.bcComprobante.TabIndex = 36;
            // 
            // btnout
            // 
            this.btnout.BackColor = System.Drawing.Color.Transparent;
            this.btnout.Image = global::SistemaFigueri.Properties.Resources._out;
            this.btnout.ImageActive = null;
            this.btnout.Location = new System.Drawing.Point(513, 774);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(66, 59);
            this.btnout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnout.TabIndex = 222;
            this.btnout.TabStop = false;
            this.btnout.Zoom = 10;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::SistemaFigueri.Properties.Resources.Print;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(13, 774);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(70, 59);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 221;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 39);
            this.label1.TabIndex = 220;
            this.label1.Text = "COMPROBANTE DE PAGO";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(13, 73);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(566, 695);
            this.crystalReportViewer1.TabIndex = 218;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormComprobanteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 859);
            this.Controls.Add(this.bcComprobante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComprobanteVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComprobanteVenta";
            this.bcComprobante.ResumeLayout(false);
            this.bcComprobante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bcComprobante;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnout;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}