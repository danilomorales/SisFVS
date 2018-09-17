namespace SistemaFigueri
{
    partial class FormComprobante_Venta
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.dgvCompro_Venta = new System.Windows.Forms.DataGridView();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompro_Venta)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Controls.Add(this.bunifuCards3);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(924, 594);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Tomato;
            this.bunifuCards3.Controls.Add(this.label1);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(262, 12);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(402, 86);
            this.bunifuCards3.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPROBANTE DE VENTAS";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.dgvCompro_Venta);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 161);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(900, 421);
            this.bunifuCards2.TabIndex = 37;
            // 
            // dgvCompro_Venta
            // 
            this.dgvCompro_Venta.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompro_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompro_Venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompro_Venta.Location = new System.Drawing.Point(0, 5);
            this.dgvCompro_Venta.Name = "dgvCompro_Venta";
            this.dgvCompro_Venta.Size = new System.Drawing.Size(898, 413);
            this.dgvCompro_Venta.TabIndex = 1;
            this.dgvCompro_Venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompro_Venta_CellContentClick);
            // 
            // FormComprobante_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(924, 594);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComprobante_Venta";
            this.Text = "FormComprobante_Venta";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompro_Venta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.DataGridView dgvCompro_Venta;
    }
}