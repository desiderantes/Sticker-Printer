using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace StickerPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNexaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Filter = "Archivo separado por caracter (.csv)|*.csv";
            op.FilterIndex = 1;
            op.Multiselect = false;

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CsvImport import = new CsvImport();
                    DataTable table = import.NewDataTable(op.FileName, ";", true);
                    foreach (DataRow row in table.Rows)
                    {
                        DGdisplay.Rows.Add(row);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: no se pudo leer el archivo " + ex.Message);
                    
                }
            }
        }
    }
}
