namespace StickerPrinter
{
    partial class Visualizer
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
            this.DGcsv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGcsv)).BeginInit();
            this.SuspendLayout();
            // 
            // DGcsv
            // 
            this.DGcsv.AllowUserToAddRows = false;
            this.DGcsv.AllowUserToDeleteRows = false;
            this.DGcsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGcsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGcsv.Location = new System.Drawing.Point(0, 0);
            this.DGcsv.Name = "DGcsv";
            this.DGcsv.ReadOnly = true;
            this.DGcsv.Size = new System.Drawing.Size(602, 501);
            this.DGcsv.TabIndex = 0;
            // 
            // Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 501);
            this.Controls.Add(this.DGcsv);
            this.Name = "Visualizer";
            this.Text = "Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.DGcsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGcsv;
    }
}