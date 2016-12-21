using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Xml;
using System.IO;

namespace StickerPrinter
{
    public partial class Form1 : Form
    {
        private string confPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml");
        private string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app log.txt");

        LabelBuilder sticker = new LabelBuilder();

        public Form1()
        {
            InitializeComponent();

            GBcodigobarras.Enabled = false;
            GBpropiedadesimp.Enabled = false;

            ApplicationPrinter printer = new ApplicationPrinter();
            CMBimpresora.DataSource = printer.InstalledPrinters();
            CMBimpresora.SelectedItem = printer.DefaultZebraPrinter();
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
                    GBcodigobarras.Enabled = true;
                    GBpropiedadesimp.Enabled = true;
                    CsvManager manager = new CsvManager();
                    table = manager.NewDataTable(op.FileName, ";", true);
                    NUDrangoF.Value = table.Rows.Count + 1;
                    TXTroute.Text = op.FileName;
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

        private void NUDrangoI_ValueChanged(object sender, EventArgs e)
        {
            if (NUDrangoI.Value > NUDrangoF.Value)
            {
                MessageBox.Show("El rango inicial debe ser menor o igual que el rango final");
                NUDrangoI.Value = NUDrangoF.Value;
                NUDrangoI.Focus();
            }
        }

        private void NUDrangoF_ValueChanged(object sender, EventArgs e)
        {
            if (NUDrangoI.Value > NUDrangoF.Value)
            {
                MessageBox.Show("El rango inicial debe ser menor o igual que el rango final");
                NUDrangoF.Value = NUDrangoI.Value;
                NUDrangoI.Focus();
            }
        }

        private void BTNimprimir_Click(object sender, EventArgs e)
        {
            if((CMBtitulo.SelectedIndex > -1) && (CMBcodigobarras.SelectedIndex > -1) && (CMBdetalles1.SelectedIndex > -1) && (CMBdetalles2.SelectedIndex > -1) && (CMBdetalles3.SelectedIndex > -1)
                && (CMBdetalles4.SelectedIndex > -1) && (RBtodo.Checked || RBrango.Checked || RBlinea.Checked))
            {
                List<string> linea1 = new List<string>();
                List<string> linea2 = new List<string>();
                //Valida los casos en que solo se debe imprimir un sticker
                if(RBlinea.Checked || (RBrango.Checked && (NUDrangoF.Value-NUDrangoI.Value == 0)) || (RBtodo.Checked && (table.Rows.Count == 1)))
                {
             //       sticker.PrintDelivery(CMBimpresora.SelectedItem.ToString, lblRadicadoCopia.Text, lblDateCopia.Text, lblNomCopia.Text, 1, 2, lblAnexo.Text, lblLeyenda.Text);
                }
                // Cuando se debe imprimir todo
                if (RBtodo.Checked && table.Rows.Count > 1)
                {
                    int onetwo = 1;
                    foreach (DataRow row in table.Rows)
                    {

                        foreach (DataColumn column in table.Columns)
                        {
                            if(onetwo > 2)
                            {
                                linea1 = new List<string>();
                                linea2 = new List<string>();
                                onetwo = 1;
                            }

                            if(onetwo == 1)
                            {
                                linea1.Add(row[column].ToString());
                            }
                            else
                            {
                                linea2.Add(row[column].ToString());
                            }
                            onetwo++;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de especificar los campos requeridos");
            }
        }
    }
}
