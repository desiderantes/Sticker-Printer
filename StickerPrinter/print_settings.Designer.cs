namespace StickerPrinter
{
    partial class Print_settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMBimpresora = new System.Windows.Forms.ComboBox();
            this.BTNimprimir = new System.Windows.Forms.Button();
            this.BTNguardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CMBimpresora);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 53);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar impresora";
            // 
            // CMBimpresora
            // 
            this.CMBimpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBimpresora.FormattingEnabled = true;
            this.CMBimpresora.Location = new System.Drawing.Point(14, 19);
            this.CMBimpresora.Name = "CMBimpresora";
            this.CMBimpresora.Size = new System.Drawing.Size(178, 21);
            this.CMBimpresora.TabIndex = 24;
            // 
            // BTNimprimir
            // 
            this.BTNimprimir.Location = new System.Drawing.Point(38, 71);
            this.BTNimprimir.Name = "BTNimprimir";
            this.BTNimprimir.Size = new System.Drawing.Size(75, 23);
            this.BTNimprimir.TabIndex = 28;
            this.BTNimprimir.Text = "Imprimir";
            this.BTNimprimir.UseVisualStyleBackColor = true;
            this.BTNimprimir.Click += new System.EventHandler(this.BTNimprimir_Click);
            // 
            // BTNguardar
            // 
            this.BTNguardar.Location = new System.Drawing.Point(119, 71);
            this.BTNguardar.Name = "BTNguardar";
            this.BTNguardar.Size = new System.Drawing.Size(75, 23);
            this.BTNguardar.TabIndex = 29;
            this.BTNguardar.Text = "Guardar";
            this.BTNguardar.UseVisualStyleBackColor = true;
            this.BTNguardar.Click += new System.EventHandler(this.BTNguardar_Click);
            // 
            // Print_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 103);
            this.Controls.Add(this.BTNguardar);
            this.Controls.Add(this.BTNimprimir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Print_settings";
            this.Text = "print_settings";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CMBimpresora;
        private System.Windows.Forms.Button BTNimprimir;
        private System.Windows.Forms.Button BTNguardar;
    }
}