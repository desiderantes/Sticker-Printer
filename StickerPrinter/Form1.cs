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

            groupBox1.Enabled = false;
        }

        DataTable table;

        private void fillComboBoxes()
        {
            CMBtitulo.Items.Add("Texto personalizado");
            CMBcodigobarras.Items.Add("Texto personalizado");
            CMBdetalles1.Items.Add("Texto personalizado");
            CMBdetalles2.Items.Add("Texto personalizado");
            CMBdetalles3.Items.Add("Texto personalizado");
            CMBdetalles4.Items.Add("Texto personalizado");
        }

        private void fillComboBoxes(List<string> wordlist)
        {
            CMBtitulo.Items.AddRange(wordlist.ToArray());
            CMBcodigobarras.Items.AddRange(wordlist.ToArray());
            CMBdetalles1.Items.AddRange(wordlist.ToArray());
            CMBdetalles2.Items.AddRange(wordlist.ToArray());
            CMBdetalles3.Items.AddRange(wordlist.ToArray());
            CMBdetalles4.Items.AddRange(wordlist.ToArray());
        }

        private void clearControls() 
        {
            CMBtitulo.Items.Clear();
            CMBcodigobarras.Items.Clear();
            CMBdetalles1.Items.Clear();
            CMBdetalles2.Items.Clear();
            CMBdetalles3.Items.Clear();
            CMBdetalles4.Items.Clear();
        }

        private void BTNexaminar_Click(object sender, EventArgs e)
        {
            clearControls();
            fillComboBoxes();

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivo separado por caracter (.csv)|*.csv";
            op.FilterIndex = 1;
            op.Multiselect = false;

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CsvManager manager = new CsvManager();
                    table = manager.NewDataTable(op.FileName, ";", true);
                    TXTroute.Text = op.FileName;
                    groupBox1.Enabled = true;
                    List<string> titles = new List<string>();
                    foreach (DataColumn col in table.Columns)
                    {
                        titles.Add(col.ColumnName.ToString());
                    }
                    fillComboBoxes(titles);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: no se pudo leer el archivo. " + ex.Message);
                }
            }
        }

        private void BTNmostrar_Click(object sender, EventArgs e)
        {
            Visualizer v = new Visualizer(table);
            v.Show();
        }
    }
}
