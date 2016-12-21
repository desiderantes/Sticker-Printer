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
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNmostrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label9 = new System.Windows.Forms.Label();
            this.TXTpersonalizado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CMBdetalles4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CMBdetalles3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CMBdetalles2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CMBdetalles1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CMBcodigobarras);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CMBtitulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 199);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código de barras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Detalles:";
            // 
            // CMBdetalles4
            // 
            this.CMBdetalles4.FormattingEnabled = true;
            this.CMBdetalles4.Location = new System.Drawing.Point(61, 164);
            this.CMBdetalles4.Name = "CMBdetalles4";
            this.CMBdetalles4.Size = new System.Drawing.Size(270, 23);
            this.CMBdetalles4.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Detalles:";
            // 
            // CMBdetalles3
            // 
            this.CMBdetalles3.FormattingEnabled = true;
            this.CMBdetalles3.Location = new System.Drawing.Point(61, 135);
            this.CMBdetalles3.Name = "CMBdetalles3";
            this.CMBdetalles3.Size = new System.Drawing.Size(270, 23);
            this.CMBdetalles3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Detalles:";
            // 
            // CMBdetalles2
            // 
            this.CMBdetalles2.FormattingEnabled = true;
            this.CMBdetalles2.Location = new System.Drawing.Point(61, 106);
            this.CMBdetalles2.Name = "CMBdetalles2";
            this.CMBdetalles2.Size = new System.Drawing.Size(270, 23);
            this.CMBdetalles2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Detalles:";
            // 
            // CMBdetalles1
            // 
            this.CMBdetalles1.FormattingEnabled = true;
            this.CMBdetalles1.Location = new System.Drawing.Point(61, 77);
            this.CMBdetalles1.Name = "CMBdetalles1";
            this.CMBdetalles1.Size = new System.Drawing.Size(270, 23);
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
            this.CMBcodigobarras.FormattingEnabled = true;
            this.CMBcodigobarras.Location = new System.Drawing.Point(110, 48);
            this.CMBcodigobarras.Name = "CMBcodigobarras";
            this.CMBcodigobarras.Size = new System.Drawing.Size(221, 23);
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
            this.CMBtitulo.FormattingEnabled = true;
            this.CMBtitulo.Location = new System.Drawing.Point(61, 19);
            this.CMBtitulo.Name = "CMBtitulo";
            this.CMBtitulo.Size = new System.Drawing.Size(270, 23);
            this.CMBtitulo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Texto personalizado:";
            // 
            // TXTpersonalizado
            // 
            this.TXTpersonalizado.Location = new System.Drawing.Point(122, 326);
            this.TXTpersonalizado.Name = "TXTpersonalizado";
            this.TXTpersonalizado.Size = new System.Drawing.Size(227, 23);
            this.TXTpersonalizado.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(602, 501);
            this.Controls.Add(this.TXTpersonalizado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BTNmostrar);
            this.Controls.Add(this.BTNexaminar);
            this.Controls.Add(this.TXTroute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sticker Printer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button BTNmostrar;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTpersonalizado;

    }
}

