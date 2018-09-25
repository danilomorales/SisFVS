namespace SistemaFigueri
{
    partial class FormCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Caja = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.dgvcaja = new System.Windows.Forms.DataGridView();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.tcAperturaCierre = new MaterialSkin.Controls.MaterialTabControl();
            this.Inicio = new System.Windows.Forms.TabPage();
            this.Apertura = new System.Windows.Forms.TabPage();
            this.panelAperturaCaja = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbNumDocApertura = new System.Windows.Forms.TextBox();
            this.tbMontoApertura = new System.Windows.Forms.TextBox();
            this.Cierre = new System.Windows.Forms.TabPage();
            this.panelCierreCaja = new System.Windows.Forms.Panel();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbAcuentaEmpresa = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton15 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbVoucher = new System.Windows.Forms.TextBox();
            this.tbMontoCierre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbCandelaCaja = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardaCaja = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardaCierre = new Bunifu.Framework.UI.BunifuImageButton();
            this.Caja.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcaja)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            this.tcAperturaCierre.SuspendLayout();
            this.Apertura.SuspendLayout();
            this.panelAperturaCaja.SuspendLayout();
            this.Cierre.SuspendLayout();
            this.panelCierreCaja.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCandelaCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardaCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardaCierre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(416, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "CENTRALIZACIÓN DE CAJA";
            // 
            // Caja
            // 
            this.Caja.Controls.Add(this.tabPage1);
            this.Caja.Controls.Add(this.tabPage2);
            this.Caja.Depth = 0;
            this.Caja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Caja.Location = new System.Drawing.Point(0, 57);
            this.Caja.MouseState = MaterialSkin.MouseState.HOVER;
            this.Caja.Name = "Caja";
            this.Caja.SelectedIndex = 0;
            this.Caja.Size = new System.Drawing.Size(1050, 543);
            this.Caja.TabIndex = 201;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.tabPage1.Controls.Add(this.bunifuCards1);
            this.tabPage1.Controls.Add(this.bunifuCards5);
            this.tabPage1.Controls.Add(this.bunifuCards3);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CAJA";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.AutoSize = true;
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton3);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1036, 46);
            this.bunifuCards1.TabIndex = 237;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Peru;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "CENTRALIZACIÓN DE CAJA";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = false;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = false;
            this.bunifuFlatButton3.IconZoom = 40D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(368, 6);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Peru;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(327, 37);
            this.bunifuFlatButton3.TabIndex = 179;
            this.bunifuFlatButton3.Text = "CENTRALIZACIÓN DE CAJA";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards5.AutoSize = true;
            this.bunifuCards5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = false;
            this.bunifuCards5.color = System.Drawing.Color.Transparent;
            this.bunifuCards5.Controls.Add(this.dgvcaja);
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(32, 151);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = false;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(971, 358);
            this.bunifuCards5.TabIndex = 236;
            // 
            // dgvcaja
            // 
            this.dgvcaja.AllowUserToAddRows = false;
            this.dgvcaja.AllowUserToOrderColumns = true;
            this.dgvcaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.dgvcaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcaja.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcaja.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcaja.EnableHeadersVisualStyles = false;
            this.dgvcaja.GridColor = System.Drawing.Color.SeaShell;
            this.dgvcaja.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvcaja.Location = new System.Drawing.Point(0, 0);
            this.dgvcaja.Name = "dgvcaja";
            this.dgvcaja.ReadOnly = true;
            this.dgvcaja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcaja.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcaja.RowHeadersWidth = 50;
            this.dgvcaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcaja.Size = new System.Drawing.Size(971, 358);
            this.dgvcaja.TabIndex = 66;
            this.dgvcaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcaja_CellClick);
            this.dgvcaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcaja_CellContentClick);
            this.dgvcaja.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcaja_CellMouseDown);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = false;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.bunifuCards3.Controls.Add(this.tcAperturaCierre);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(32, 44);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = false;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(971, 104);
            this.bunifuCards3.TabIndex = 235;
            // 
            // tcAperturaCierre
            // 
            this.tcAperturaCierre.Controls.Add(this.Inicio);
            this.tcAperturaCierre.Controls.Add(this.Apertura);
            this.tcAperturaCierre.Controls.Add(this.Cierre);
            this.tcAperturaCierre.Depth = 0;
            this.tcAperturaCierre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAperturaCierre.Location = new System.Drawing.Point(0, 0);
            this.tcAperturaCierre.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcAperturaCierre.Name = "tcAperturaCierre";
            this.tcAperturaCierre.SelectedIndex = 0;
            this.tcAperturaCierre.Size = new System.Drawing.Size(971, 104);
            this.tcAperturaCierre.TabIndex = 1;
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.Inicio.Location = new System.Drawing.Point(4, 22);
            this.Inicio.Name = "Inicio";
            this.Inicio.Padding = new System.Windows.Forms.Padding(3);
            this.Inicio.Size = new System.Drawing.Size(963, 78);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "tabPage3";
            // 
            // Apertura
            // 
            this.Apertura.Controls.Add(this.panelAperturaCaja);
            this.Apertura.Location = new System.Drawing.Point(4, 22);
            this.Apertura.Name = "Apertura";
            this.Apertura.Padding = new System.Windows.Forms.Padding(3);
            this.Apertura.Size = new System.Drawing.Size(963, 78);
            this.Apertura.TabIndex = 1;
            this.Apertura.Text = "tabPage4";
            this.Apertura.UseVisualStyleBackColor = true;
            // 
            // panelAperturaCaja
            // 
            this.panelAperturaCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.panelAperturaCaja.Controls.Add(this.tbCandelaCaja);
            this.panelAperturaCaja.Controls.Add(this.btnGuardaCaja);
            this.panelAperturaCaja.Controls.Add(this.bunifuFlatButton4);
            this.panelAperturaCaja.Controls.Add(this.bunifuFlatButton5);
            this.panelAperturaCaja.Controls.Add(this.tbNumDocApertura);
            this.panelAperturaCaja.Controls.Add(this.tbMontoApertura);
            this.panelAperturaCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAperturaCaja.Location = new System.Drawing.Point(3, 3);
            this.panelAperturaCaja.Name = "panelAperturaCaja";
            this.panelAperturaCaja.Size = new System.Drawing.Size(957, 72);
            this.panelAperturaCaja.TabIndex = 189;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Peru;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "VOUCHER";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = false;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = false;
            this.bunifuFlatButton4.IconZoom = 40D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(332, 10);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Peru;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(111, 40);
            this.bunifuFlatButton4.TabIndex = 179;
            this.bunifuFlatButton4.Text = "VOUCHER";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Peru;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Monto Inicial";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = false;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = false;
            this.bunifuFlatButton5.IconZoom = 40D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(4, 11);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Peru;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(111, 40);
            this.bunifuFlatButton5.TabIndex = 178;
            this.bunifuFlatButton5.Text = "Monto Inicial";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbNumDocApertura
            // 
            this.tbNumDocApertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.tbNumDocApertura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumDocApertura.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumDocApertura.Location = new System.Drawing.Point(442, 10);
            this.tbNumDocApertura.Multiline = true;
            this.tbNumDocApertura.Name = "tbNumDocApertura";
            this.tbNumDocApertura.Size = new System.Drawing.Size(154, 39);
            this.tbNumDocApertura.TabIndex = 177;
            // 
            // tbMontoApertura
            // 
            this.tbMontoApertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.tbMontoApertura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMontoApertura.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMontoApertura.Location = new System.Drawing.Point(114, 11);
            this.tbMontoApertura.Multiline = true;
            this.tbMontoApertura.Name = "tbMontoApertura";
            this.tbMontoApertura.Size = new System.Drawing.Size(95, 39);
            this.tbMontoApertura.TabIndex = 176;
            // 
            // Cierre
            // 
            this.Cierre.Controls.Add(this.panelCierreCaja);
            this.Cierre.Location = new System.Drawing.Point(4, 22);
            this.Cierre.Name = "Cierre";
            this.Cierre.Padding = new System.Windows.Forms.Padding(3);
            this.Cierre.Size = new System.Drawing.Size(963, 78);
            this.Cierre.TabIndex = 2;
            this.Cierre.Text = "tabPage3";
            this.Cierre.UseVisualStyleBackColor = true;
            // 
            // panelCierreCaja
            // 
            this.panelCierreCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(154)))));
            this.panelCierreCaja.Controls.Add(this.materialRadioButton2);
            this.panelCierreCaja.Controls.Add(this.materialRadioButton1);
            this.panelCierreCaja.Controls.Add(this.btnCerrar);
            this.panelCierreCaja.Controls.Add(this.btnGuardaCierre);
            this.panelCierreCaja.Controls.Add(this.bunifuFlatButton1);
            this.panelCierreCaja.Controls.Add(this.tbAcuentaEmpresa);
            this.panelCierreCaja.Controls.Add(this.bunifuFlatButton2);
            this.panelCierreCaja.Controls.Add(this.bunifuFlatButton15);
            this.panelCierreCaja.Controls.Add(this.tbVoucher);
            this.panelCierreCaja.Controls.Add(this.tbMontoCierre);
            this.panelCierreCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCierreCaja.Location = new System.Drawing.Point(3, 3);
            this.panelCierreCaja.Name = "panelCierreCaja";
            this.panelCierreCaja.Size = new System.Drawing.Size(957, 72);
            this.panelCierreCaja.TabIndex = 3;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(225, 14);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(83, 30);
            this.materialRadioButton2.TabIndex = 187;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "A cuenta";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoCheck = false;
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(313, 13);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(96, 30);
            this.materialRadioButton1.TabIndex = 186;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "A Empresa";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Peru;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(413, 10);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Peru;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(30, 40);
            this.bunifuFlatButton1.TabIndex = 181;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbAcuentaEmpresa
            // 
            this.tbAcuentaEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.tbAcuentaEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAcuentaEmpresa.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAcuentaEmpresa.Location = new System.Drawing.Point(442, 10);
            this.tbAcuentaEmpresa.Multiline = true;
            this.tbAcuentaEmpresa.Name = "tbAcuentaEmpresa";
            this.tbAcuentaEmpresa.Size = new System.Drawing.Size(96, 39);
            this.tbAcuentaEmpresa.TabIndex = 180;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Peru;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "VOUCHER";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 40D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(584, 12);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Peru;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(111, 40);
            this.bunifuFlatButton2.TabIndex = 179;
            this.bunifuFlatButton2.Text = "VOUCHER";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton15
            // 
            this.bunifuFlatButton15.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton15.BackColor = System.Drawing.Color.Peru;
            this.bunifuFlatButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton15.BorderRadius = 0;
            this.bunifuFlatButton15.ButtonText = "MONTO";
            this.bunifuFlatButton15.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuFlatButton15.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton15.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton15.Iconimage = null;
            this.bunifuFlatButton15.Iconimage_right = null;
            this.bunifuFlatButton15.Iconimage_right_Selected = null;
            this.bunifuFlatButton15.Iconimage_Selected = null;
            this.bunifuFlatButton15.IconMarginLeft = 0;
            this.bunifuFlatButton15.IconMarginRight = 0;
            this.bunifuFlatButton15.IconRightVisible = false;
            this.bunifuFlatButton15.IconRightZoom = 0D;
            this.bunifuFlatButton15.IconVisible = false;
            this.bunifuFlatButton15.IconZoom = 40D;
            this.bunifuFlatButton15.IsTab = false;
            this.bunifuFlatButton15.Location = new System.Drawing.Point(4, 11);
            this.bunifuFlatButton15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton15.Name = "bunifuFlatButton15";
            this.bunifuFlatButton15.Normalcolor = System.Drawing.Color.Peru;
            this.bunifuFlatButton15.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton15.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton15.selected = false;
            this.bunifuFlatButton15.Size = new System.Drawing.Size(111, 40);
            this.bunifuFlatButton15.TabIndex = 178;
            this.bunifuFlatButton15.Text = "MONTO";
            this.bunifuFlatButton15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton15.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton15.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbVoucher
            // 
            this.tbVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.tbVoucher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVoucher.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVoucher.Location = new System.Drawing.Point(694, 12);
            this.tbVoucher.Multiline = true;
            this.tbVoucher.Name = "tbVoucher";
            this.tbVoucher.Size = new System.Drawing.Size(154, 39);
            this.tbVoucher.TabIndex = 177;
            // 
            // tbMontoCierre
            // 
            this.tbMontoCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.tbMontoCierre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMontoCierre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMontoCierre.Location = new System.Drawing.Point(114, 11);
            this.tbMontoCierre.Multiline = true;
            this.tbMontoCierre.Name = "tbMontoCierre";
            this.tbMontoCierre.Size = new System.Drawing.Size(95, 39);
            this.tbMontoCierre.TabIndex = 176;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(183)))));
            this.tabPage2.Controls.Add(this.bunifuCards4);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "REPORTE DE CAJA";
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = false;
            this.bunifuCards4.color = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(281, 89);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = false;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(425, 327);
            this.bunifuCards4.TabIndex = 230;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.materialTabSelector1.BaseTabControl = this.Caja;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1050, 57);
            this.materialTabSelector1.TabIndex = 200;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // tbCandelaCaja
            // 
            this.tbCandelaCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.tbCandelaCaja.Image = global::SistemaFigueri.Properties.Resources.cancel;
            this.tbCandelaCaja.ImageActive = null;
            this.tbCandelaCaja.Location = new System.Drawing.Point(901, 12);
            this.tbCandelaCaja.Name = "tbCandelaCaja";
            this.tbCandelaCaja.Size = new System.Drawing.Size(36, 39);
            this.tbCandelaCaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tbCandelaCaja.TabIndex = 183;
            this.tbCandelaCaja.TabStop = false;
            this.tbCandelaCaja.Zoom = 10;
            this.tbCandelaCaja.Click += new System.EventHandler(this.tbCandelaCaja_Click);
            // 
            // btnGuardaCaja
            // 
            this.btnGuardaCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.btnGuardaCaja.Image = global::SistemaFigueri.Properties.Resources.GUARDA;
            this.btnGuardaCaja.ImageActive = null;
            this.btnGuardaCaja.Location = new System.Drawing.Point(850, 12);
            this.btnGuardaCaja.Name = "btnGuardaCaja";
            this.btnGuardaCaja.Size = new System.Drawing.Size(36, 39);
            this.btnGuardaCaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardaCaja.TabIndex = 182;
            this.btnGuardaCaja.TabStop = false;
            this.btnGuardaCaja.Zoom = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.btnCerrar.Image = global::SistemaFigueri.Properties.Resources.cancel;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(913, 13);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 39);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 183;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardaCierre
            // 
            this.btnGuardaCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(103)))));
            this.btnGuardaCierre.Image = global::SistemaFigueri.Properties.Resources.GUARDA;
            this.btnGuardaCierre.ImageActive = null;
            this.btnGuardaCierre.Location = new System.Drawing.Point(867, 12);
            this.btnGuardaCierre.Name = "btnGuardaCierre";
            this.btnGuardaCierre.Size = new System.Drawing.Size(36, 39);
            this.btnGuardaCierre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardaCierre.TabIndex = 182;
            this.btnGuardaCierre.TabStop = false;
            this.btnGuardaCierre.Zoom = 10;
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.Caja);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaja";
            this.Text = "FormAperturaCaja";
            this.Load += new System.EventHandler(this.FormCaja_Load);
            this.Caja.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcaja)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.tcAperturaCierre.ResumeLayout(false);
            this.Apertura.ResumeLayout(false);
            this.panelAperturaCaja.ResumeLayout(false);
            this.panelAperturaCaja.PerformLayout();
            this.Cierre.ResumeLayout(false);
            this.panelCierreCaja.ResumeLayout(false);
            this.panelCierreCaja.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCandelaCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardaCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardaCierre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTabControl Caja;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private MaterialSkin.Controls.MaterialTabControl tcAperturaCierre;
        private System.Windows.Forms.TabPage Inicio;
        private System.Windows.Forms.TabPage Apertura;
        private System.Windows.Forms.Panel panelAperturaCaja;
        private Bunifu.Framework.UI.BunifuImageButton tbCandelaCaja;
        private Bunifu.Framework.UI.BunifuImageButton btnGuardaCaja;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private System.Windows.Forms.TextBox tbNumDocApertura;
        private System.Windows.Forms.TextBox tbMontoApertura;
        private System.Windows.Forms.TabPage Cierre;
        private System.Windows.Forms.Panel panelCierreCaja;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnGuardaCierre;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox tbAcuentaEmpresa;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton15;
        private System.Windows.Forms.TextBox tbVoucher;
        private System.Windows.Forms.TextBox tbMontoCierre;
        private System.Windows.Forms.DataGridView dgvcaja;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
    }
}