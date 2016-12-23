namespace StickerPrinter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTroute = new System.Windows.Forms.TextBox();
            this.BTNexaminar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNmostrar = new System.Windows.Forms.Button();
            this.GBcodigobarras = new System.Windows.Forms.GroupBox();
            this.TXTcampo4 = new System.Windows.Forms.TextBox();
            this.TXTcampo3 = new System.Windows.Forms.TextBox();
            this.TXTcampo2 = new System.Windows.Forms.TextBox();
            this.TXTcampo1 = new System.Windows.Forms.TextBox();
            this.TXTtitulo = new System.Windows.Forms.TextBox();
            this.CHKcampo4 = new System.Windows.Forms.CheckBox();
            this.CHKcampo3 = new System.Windows.Forms.CheckBox();
            this.CHKcampo2 = new System.Windows.Forms.CheckBox();
            this.CHKcampo1 = new System.Windows.Forms.CheckBox();
            this.CHKtitulo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CMBdetalles4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CMBdetalles3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CMBdetalles2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBdetalles1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CMBcodigobarras = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBtitulo = new System.Windows.Forms.ComboBox();
            this.BTNimprimir = new System.Windows.Forms.Button();
            this.GBpropiedadesimp = new System.Windows.Forms.GroupBox();
            this.NUDrangoF = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.NUDrangoI = new System.Windows.Forms.NumericUpDown();
            this.NUDlinea = new System.Windows.Forms.NumericUpDown();
            this.RBrango = new System.Windows.Forms.RadioButton();
            this.RBlinea = new System.Windows.Forms.RadioButton();
            this.RBtodo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.GBcodigobarras.SuspendLayout();
            this.GBpropiedadesimp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDrangoF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDrangoI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDlinea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StickerPrinter.Properties.Resources.barcode_x32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sticker Printer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccionar archivo:";
            // 
            // TXTroute
            // 
            this.TXTroute.Enabled = false;
            this.TXTroute.Location = new System.Drawing.Point(12, 94);
            this.TXTroute.Name = "TXTroute";
            this.TXTroute.Size = new System.Drawing.Size(337, 23);
            this.TXTroute.TabIndex = 3;
            // 
            // BTNexaminar
            // 
            this.BTNexaminar.Location = new System.Drawing.Point(355, 94);
            this.BTNexaminar.Name = "BTNexaminar";
            this.BTNexaminar.Size = new System.Drawing.Size(75, 23);
            this.BTNexaminar.TabIndex = 4;
            this.BTNexaminar.Text = "Examinar";
            this.BTNexaminar.UseVisualStyleBackColor = true;
            this.BTNexaminar.Click += new System.EventHandler(this.BTNexaminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarFormularioToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // reiniciarFormularioToolStripMenuItem
            // 
            this.reiniciarFormularioToolStripMenuItem.Name = "reiniciarFormularioToolStripMenuItem";
            this.reiniciarFormularioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reiniciarFormularioToolStripMenuItem.Text = "Reiniciar formulario";
            this.reiniciarFormularioToolStripMenuItem.Click += new System.EventHandler(this.reiniciarFormularioToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // BTNmostrar
            // 
            this.BTNmostrar.Location = new System.Drawing.Point(436, 94);
            this.BTNmostrar.Name = "BTNmostrar";
            this.BTNmostrar.Size = new System.Drawing.Size(75, 23);
            this.BTNmostrar.TabIndex = 7;
            this.BTNmostrar.Text = "Mostrar";
            this.BTNmostrar.UseVisualStyleBackColor = true;
            this.BTNmostrar.Click += new System.EventHandler(this.BTNmostrar_Click);
            // 
            // GBcodigobarras
            // 
            this.GBcodigobarras.Controls.Add(this.TXTcampo4);
            this.GBcodigobarras.Controls.Add(this.TXTcampo3);
            this.GBcodigobarras.Controls.Add(this.TXTcampo2);
            this.GBcodigobarras.Controls.Add(this.TXTcampo1);
            this.GBcodigobarras.Controls.Add(this.TXTtitulo);
            this.GBcodigobarras.Controls.Add(this.CHKcampo4);
            this.GBcodigobarras.Controls.Add(this.CHKcampo3);
            this.GBcodigobarras.Controls.Add(this.CHKcampo2);
            this.GBcodigobarras.Controls.Add(this.CHKcampo1);
            this.GBcodigobarras.Controls.Add(this.CHKtitulo);
            this.GBcodigobarras.Controls.Add(this.label8);
            this.GBcodigobarras.Controls.Add(this.CMBdetalles4);
            this.GBcodigobarras.Controls.Add(this.label7);
            this.GBcodigobarras.Controls.Add(this.CMBdetalles3);
            this.GBcodigobarras.Controls.Add(this.label6);
            this.GBcodigobarras.Controls.Add(this.CMBdetalles2);
            this.GBcodigobarras.Controls.Add(this.label5);
            this.GBcodigobarras.Controls.Add(this.CMBdetalles1);
            this.GBcodigobarras.Controls.Add(this.label4);
            this.GBcodigobarras.Controls.Add(this.CMBcodigobarras);
            this.GBcodigobarras.Controls.Add(this.label3);
            this.GBcodigobarras.Controls.Add(this.CMBtitulo);
            this.GBcodigobarras.Location = new System.Drawing.Point(12, 124);
            this.GBcodigobarras.Name = "GBcodigobarras";
            this.GBcodigobarras.Size = new System.Drawing.Size(499, 199);
            this.GBcodigobarras.TabIndex = 9;
            this.GBcodigobarras.TabStop = false;
            this.GBcodigobarras.Text = "Código de barras";
            // 
            // TXTcampo4
            // 
            this.TXTcampo4.Enabled = false;
            this.TXTcampo4.Location = new System.Drawing.Point(406, 164);
            this.TXTcampo4.Name = "TXTcampo4";
            this.TXTcampo4.Size = new System.Drawing.Size(87, 23);
            this.TXTcampo4.TabIndex = 30;
            // 
            // TXTcampo3
            // 
            this.TXTcampo3.Enabled = false;
            this.TXTcampo3.Location = new System.Drawing.Point(406, 135);
            this.TXTcampo3.Name = "TXTcampo3";
            this.TXTcampo3.Size = new System.Drawing.Size(87, 23);
            this.TXTcampo3.TabIndex = 29;
            // 
            // TXTcampo2
            // 
            this.TXTcampo2.Enabled = false;
            this.TXTcampo2.Location = new System.Drawing.Point(406, 107);
            this.TXTcampo2.Name = "TXTcampo2";
            this.TXTcampo2.Size = new System.Drawing.Size(87, 23);
            this.TXTcampo2.TabIndex = 28;
            // 
            // TXTcampo1
            // 
            this.TXTcampo1.Enabled = false;
            this.TXTcampo1.Location = new System.Drawing.Point(406, 77);
            this.TXTcampo1.Name = "TXTcampo1";
            this.TXTcampo1.Size = new System.Drawing.Size(87, 23);
            this.TXTcampo1.TabIndex = 27;
            // 
            // TXTtitulo
            // 
            this.TXTtitulo.Enabled = false;
            this.TXTtitulo.Location = new System.Drawing.Point(406, 19);
            this.TXTtitulo.Name = "TXTtitulo";
            this.TXTtitulo.Size = new System.Drawing.Size(87, 23);
            this.TXTtitulo.TabIndex = 26;
            // 
            // CHKcampo4
            // 
            this.CHKcampo4.AutoSize = true;
            this.CHKcampo4.Location = new System.Drawing.Point(269, 166);
            this.CHKcampo4.Name = "CHKcampo4";
            this.CHKcampo4.Size = new System.Drawing.Size(131, 19);
            this.CHKcampo4.TabIndex = 24;
            this.CHKcampo4.Text = "Texto personalizado:";
            this.CHKcampo4.UseVisualStyleBackColor = true;
            this.CHKcampo4.CheckedChanged += new System.EventHandler(this.CHKcampo4_CheckedChanged);
            // 
            // CHKcampo3
            // 
            this.CHKcampo3.AutoSize = true;
            this.CHKcampo3.Location = new System.Drawing.Point(269, 137);
            this.CHKcampo3.Name = "CHKcampo3";
            this.CHKcampo3.Size = new System.Drawing.Size(131, 19);
            this.CHKcampo3.TabIndex = 23;
            this.CHKcampo3.Text = "Texto personalizado:";
            this.CHKcampo3.UseVisualStyleBackColor = true;
            this.CHKcampo3.CheckedChanged += new System.EventHandler(this.CHKcampo3_CheckedChanged);
            // 
            // CHKcampo2
            // 
            this.CHKcampo2.AutoSize = true;
            this.CHKcampo2.Location = new System.Drawing.Point(269, 109);
            this.CHKcampo2.Name = "CHKcampo2";
            this.CHKcampo2.Size = new System.Drawing.Size(131, 19);
            this.CHKcampo2.TabIndex = 22;
            this.CHKcampo2.Text = "Texto personalizado:";
            this.CHKcampo2.UseVisualStyleBackColor = true;
            this.CHKcampo2.CheckedChanged += new System.EventHandler(this.CHKcampo2_CheckedChanged);
            // 
            // CHKcampo1
            // 
            this.CHKcampo1.AutoSize = true;
            this.CHKcampo1.Location = new System.Drawing.Point(269, 80);
            this.CHKcampo1.Name = "CHKcampo1";
            this.CHKcampo1.Size = new System.Drawing.Size(131, 19);
            this.CHKcampo1.TabIndex = 21;
            this.CHKcampo1.Text = "Texto personalizado:";
            this.CHKcampo1.UseVisualStyleBackColor = true;
            this.CHKcampo1.CheckedChanged += new System.EventHandler(this.CHKcampo1_CheckedChanged);
            // 
            // CHKtitulo
            // 
            this.CHKtitulo.AutoSize = true;
            this.CHKtitulo.Location = new System.Drawing.Point(269, 21);
            this.CHKtitulo.Name = "CHKtitulo";
            this.CHKtitulo.Size = new System.Drawing.Size(131, 19);
            this.CHKtitulo.TabIndex = 20;
            this.CHKtitulo.Text = "Texto personalizado:";
            this.CHKtitulo.UseVisualStyleBackColor = true;
            this.CHKtitulo.CheckedChanged += new System.EventHandler(this.CHKtitulo_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Campo 4:";
            // 
            // CMBdetalles4
            // 
            this.CMBdetalles4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBdetalles4.FormattingEnabled = true;
            this.CMBdetalles4.Location = new System.Drawing.Point(68, 164);
            this.CMBdetalles4.Name = "CMBdetalles4";
            this.CMBdetalles4.Size = new System.Drawing.Size(195, 23);
            this.CMBdetalles4.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Campo 3:";
            // 
            // CMBdetalles3
            // 
            this.CMBdetalles3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBdetalles3.FormattingEnabled = true;
            this.CMBdetalles3.Location = new System.Drawing.Point(68, 135);
            this.CMBdetalles3.Name = "CMBdetalles3";
            this.CMBdetalles3.Size = new System.Drawing.Size(195, 23);
            this.CMBdetalles3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Campo 2:";
            // 
            // CMBdetalles2
            // 
            this.CMBdetalles2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBdetalles2.FormattingEnabled = true;
            this.CMBdetalles2.Location = new System.Drawing.Point(68, 106);
            this.CMBdetalles2.Name = "CMBdetalles2";
            this.CMBdetalles2.Size = new System.Drawing.Size(195, 23);
            this.CMBdetalles2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Campo 1:";
            // 
            // CMBdetalles1
            // 
            this.CMBdetalles1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBdetalles1.FormattingEnabled = true;
            this.CMBdetalles1.Location = new System.Drawing.Point(68, 77);
            this.CMBdetalles1.Name = "CMBdetalles1";
            this.CMBdetalles1.Size = new System.Drawing.Size(195, 23);
            this.CMBdetalles1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código de barras:";
            // 
            // CMBcodigobarras
            // 
            this.CMBcodigobarras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBcodigobarras.FormattingEnabled = true;
            this.CMBcodigobarras.Location = new System.Drawing.Point(110, 48);
            this.CMBcodigobarras.Name = "CMBcodigobarras";
            this.CMBcodigobarras.Size = new System.Drawing.Size(383, 23);
            this.CMBcodigobarras.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Título:";
            // 
            // CMBtitulo
            // 
            this.CMBtitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBtitulo.FormattingEnabled = true;
            this.CMBtitulo.Location = new System.Drawing.Point(61, 19);
            this.CMBtitulo.Name = "CMBtitulo";
            this.CMBtitulo.Size = new System.Drawing.Size(202, 23);
            this.CMBtitulo.TabIndex = 8;
            // 
            // BTNimprimir
            // 
            this.BTNimprimir.Location = new System.Drawing.Point(543, 241);
            this.BTNimprimir.Name = "BTNimprimir";
            this.BTNimprimir.Size = new System.Drawing.Size(166, 23);
            this.BTNimprimir.TabIndex = 23;
            this.BTNimprimir.Text = "Configuración de la impresión";
            this.BTNimprimir.UseVisualStyleBackColor = true;
            this.BTNimprimir.Click += new System.EventHandler(this.BTNimprimir_Click);
            // 
            // GBpropiedadesimp
            // 
            this.GBpropiedadesimp.Controls.Add(this.NUDrangoF);
            this.GBpropiedadesimp.Controls.Add(this.label10);
            this.GBpropiedadesimp.Controls.Add(this.NUDrangoI);
            this.GBpropiedadesimp.Controls.Add(this.NUDlinea);
            this.GBpropiedadesimp.Controls.Add(this.RBrango);
            this.GBpropiedadesimp.Controls.Add(this.RBlinea);
            this.GBpropiedadesimp.Controls.Add(this.RBtodo);
            this.GBpropiedadesimp.Location = new System.Drawing.Point(517, 124);
            this.GBpropiedadesimp.Name = "GBpropiedadesimp";
            this.GBpropiedadesimp.Size = new System.Drawing.Size(202, 111);
            this.GBpropiedadesimp.TabIndex = 27;
            this.GBpropiedadesimp.TabStop = false;
            this.GBpropiedadesimp.Text = "Propiedades de impresión";
            // 
            // NUDrangoF
            // 
            this.NUDrangoF.Location = new System.Drawing.Point(159, 74);
            this.NUDrangoF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDrangoF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDrangoF.Name = "NUDrangoF";
            this.NUDrangoF.Size = new System.Drawing.Size(33, 23);
            this.NUDrangoF.TabIndex = 6;
            this.NUDrangoF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDrangoF.ValueChanged += new System.EventHandler(this.NUDrangoF_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "y";
            // 
            // NUDrangoI
            // 
            this.NUDrangoI.Location = new System.Drawing.Point(102, 74);
            this.NUDrangoI.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDrangoI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDrangoI.Name = "NUDrangoI";
            this.NUDrangoI.Size = new System.Drawing.Size(33, 23);
            this.NUDrangoI.TabIndex = 4;
            this.NUDrangoI.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDrangoI.ValueChanged += new System.EventHandler(this.NUDrangoI_ValueChanged);
            // 
            // NUDlinea
            // 
            this.NUDlinea.Location = new System.Drawing.Point(68, 45);
            this.NUDlinea.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDlinea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDlinea.Name = "NUDlinea";
            this.NUDlinea.Size = new System.Drawing.Size(33, 23);
            this.NUDlinea.TabIndex = 3;
            this.NUDlinea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDlinea.ValueChanged += new System.EventHandler(this.NUDlinea_ValueChanged);
            // 
            // RBrango
            // 
            this.RBrango.AutoSize = true;
            this.RBrango.Location = new System.Drawing.Point(6, 74);
            this.RBrango.Name = "RBrango";
            this.RBrango.Size = new System.Drawing.Size(87, 19);
            this.RBrango.TabIndex = 2;
            this.RBrango.TabStop = true;
            this.RBrango.Text = "Rango entre";
            this.RBrango.UseVisualStyleBackColor = true;
            this.RBrango.CheckedChanged += new System.EventHandler(this.RBrango_CheckedChanged);
            // 
            // RBlinea
            // 
            this.RBlinea.AutoSize = true;
            this.RBlinea.Location = new System.Drawing.Point(6, 49);
            this.RBlinea.Name = "RBlinea";
            this.RBlinea.Size = new System.Drawing.Size(56, 19);
            this.RBlinea.TabIndex = 1;
            this.RBlinea.TabStop = true;
            this.RBlinea.Text = "Linea: ";
            this.RBlinea.UseVisualStyleBackColor = true;
            this.RBlinea.CheckedChanged += new System.EventHandler(this.RBlinea_CheckedChanged);
            // 
            // RBtodo
            // 
            this.RBtodo.AutoSize = true;
            this.RBtodo.Location = new System.Drawing.Point(6, 20);
            this.RBtodo.Name = "RBtodo";
            this.RBtodo.Size = new System.Drawing.Size(104, 19);
            this.RBtodo.TabIndex = 0;
            this.RBtodo.TabStop = true;
            this.RBtodo.Text = "Todo el reporte";
            this.RBtodo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(729, 331);
            this.Controls.Add(this.GBpropiedadesimp);
            this.Controls.Add(this.BTNimprimir);
            this.Controls.Add(this.BTNmostrar);
            this.Controls.Add(this.BTNexaminar);
            this.Controls.Add(this.TXTroute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GBcodigobarras);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sticker Printer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBcodigobarras.ResumeLayout(false);
            this.GBcodigobarras.PerformLayout();
            this.GBpropiedadesimp.ResumeLayout(false);
            this.GBpropiedadesimp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDrangoF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDrangoI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDlinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTroute;
        private System.Windows.Forms.Button BTNexaminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Button BTNmostrar;
        private System.Windows.Forms.GroupBox GBcodigobarras;
        private System.Windows.Forms.ComboBox CMBtitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CMBdetalles4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CMBdetalles3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CMBdetalles2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBdetalles1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMBcodigobarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNimprimir;
        private System.Windows.Forms.TextBox TXTcampo4;
        private System.Windows.Forms.TextBox TXTcampo3;
        private System.Windows.Forms.TextBox TXTcampo2;
        private System.Windows.Forms.TextBox TXTcampo1;
        private System.Windows.Forms.TextBox TXTtitulo;
        private System.Windows.Forms.CheckBox CHKcampo4;
        private System.Windows.Forms.CheckBox CHKcampo3;
        private System.Windows.Forms.CheckBox CHKcampo2;
        private System.Windows.Forms.CheckBox CHKcampo1;
        private System.Windows.Forms.CheckBox CHKtitulo;
        private System.Windows.Forms.ToolStripMenuItem reiniciarFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBpropiedadesimp;
        private System.Windows.Forms.NumericUpDown NUDrangoF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NUDrangoI;
        private System.Windows.Forms.NumericUpDown NUDlinea;
        private System.Windows.Forms.RadioButton RBrango;
        private System.Windows.Forms.RadioButton RBlinea;
        private System.Windows.Forms.RadioButton RBtodo;

    }
}

