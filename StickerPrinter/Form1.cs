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

        DataTable table;

        public Form1()
        {
            InitializeComponent();

            initialize_variables();
        }

        public void initialize_variables()
        {
            GBcodigobarras.Enabled = false;   
            BTNmostrar.Enabled = false;

            GBpropiedadesimp.Enabled = false;

            GBpropiedadesimp.Enabled = RBtodo.Checked = true;
            NUDlinea.Enabled = NUDrangoI.Enabled = NUDrangoF.Enabled = false;

        }       

        private void resetAll()
        {
            this.Controls.Clear();
            InitializeComponent();
            initialize_variables();
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

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivo separado por caracter (.csv)|*.csv";
            op.FilterIndex = 1;
            op.Multiselect = false;

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show("Verifique que los campos a imprimir no tengan una longitud de mas de 25 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    GBcodigobarras.Enabled = BTNmostrar.Enabled = true;
                    
                    CsvManager manager = new CsvManager();
                    table = manager.NewDataTable(op.FileName, ";", true);

                    NUDrangoF.Value = table.Rows.Count;
                    
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
                    MessageBox.Show("La aplicación ha encontrado una excepción, " + ex.Message);
                }
            }
        }

        private void BTNmostrar_Click(object sender, EventArgs e)
        {
            Visualizer v = new Visualizer(table);
            v.MinimizeBox = false;
            v.MaximizeBox = false;
            v.ShowIcon = false;
            v.Show();
        }

        

        private void BTNimprimir_Click(object sender, EventArgs e)
        {
            if (CMBcodigobarras.SelectedIndex != -1)
            {
                Print_settings ps = new Print_settings(table, CMBtitulo.SelectedIndex, CMBcodigobarras.SelectedIndex, CMBdetalles1.SelectedIndex, CMBdetalles2.SelectedIndex, CMBdetalles3.SelectedIndex, CMBdetalles4.SelectedIndex, TXTtitulo.Text, TXTcampo1.Text, TXTcampo2.Text, TXTcampo3.Text, TXTcampo4.Text, CHKtitulo.Checked, CHKcampo1.Checked, CHKcampo2.Checked, CHKcampo3.Checked, CHKcampo4.Checked, RBlinea.Checked, RBrango.Checked, RBtodo.Checked, (int)NUDrangoF.Value, (int)NUDrangoI.Value, (int)NUDlinea.Value);
                ps.MaximizeBox = false;
                ps.ShowIcon = false;
                ps.Show();
            }
            else
            {
                MessageBox.Show("Asegúrese de especificar los campos requeridos");
            }
        }

        private void CHKtitulo_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKtitulo.Checked)
            {
                TXTtitulo.Enabled = true;
                CMBtitulo.Enabled = false;
            }
            else
            {
                TXTtitulo.Enabled = false;
                CMBtitulo.Enabled = true;
            }
        }

        private void CHKcampo1_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKcampo1.Checked)
            {
                TXTcampo1.Enabled = true;
                CMBdetalles1.Enabled = false;
            }
            else
            {
                TXTcampo1.Enabled = false;
                CMBdetalles1.Enabled = true;
            }
        }

        private void CHKcampo2_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKcampo2.Checked)
            {
                TXTcampo2.Enabled = true;
                CMBdetalles2.Enabled = false;
            }
            else
            {
                TXTcampo2.Enabled = false;
                CMBdetalles2.Enabled = true;
            }
        }

        private void CHKcampo3_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKcampo3.Checked)
            {
                TXTcampo3.Enabled = true;
                CMBdetalles3.Enabled = false;
            }
            else
            {
                TXTcampo3.Enabled = false;
                CMBdetalles3.Enabled = true;
            }
        }

        private void CHKcampo4_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKcampo4.Checked)
            {
                TXTcampo4.Enabled = true;
                CMBdetalles4.Enabled = false;
            }
            else
            {
                TXTcampo4.Enabled = false;
                CMBdetalles4.Enabled = true;
            }
        }

        private void reiniciarFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetAll();
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
                MessageBox.Show("El rango final debe ser mayor o igual que el rango final");
                NUDrangoF.Value = NUDrangoI.Value;
                NUDrangoF.Focus();
            }
            if (NUDrangoF.Value > table.Rows.Count)
            {
                MessageBox.Show("El rango final no puede superar el número de lineas del documento");
                NUDrangoF.Value = table.Rows.Count;
                NUDrangoF.Focus();
            }
        }

        private void RBlinea_CheckedChanged(object sender, EventArgs e)
        {
            if (RBlinea.Checked) NUDlinea.Enabled = true;
            else NUDlinea.Enabled = false;
        }

        private void RBrango_CheckedChanged(object sender, EventArgs e)
        {
            if (RBrango.Checked) NUDrangoI.Enabled = NUDrangoF.Enabled = true;
            else NUDrangoI.Enabled = NUDrangoF.Enabled = false;
        }

        private void NUDlinea_ValueChanged(object sender, EventArgs e)
        {
            if (NUDlinea.Value > table.Rows.Count)
            {
                MessageBox.Show("El rango final no puede superar el número de lineas del documento");
                NUDlinea.Value = table.Rows.Count;
                NUDlinea.Focus();
            }
        }
    }
}
