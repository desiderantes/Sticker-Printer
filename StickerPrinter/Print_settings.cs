using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace StickerPrinter
{
    public partial class Print_settings : Form
    {
        ApplicationPrinter printer;
        LabelBuilder sticker;

        private string confPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml");
        private string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app log.txt");

        DataTable table;

        bool boolTitulo, boolCampo1, boolCampo2, boolCampo3, boolCampo4, CHKlinea, CHKrango, CHKtodo;
        int tituloI, codigobarrasI, detalles1I, detalles2I, detalles3I, detalles4I, intRangoF, intRangoI, intLinea;
        string TXTtitulo, TXTcampo1, TXTcampo2, TXTcampo3, TXTcampo4;

        public Print_settings(DataTable t, int titu, int cob, int det1, int det2, int det3, int det4, string txtt, string txtc1, string txtc2, string txtc3, string txtc4, bool bt, bool bc1, bool bc2, bool bc3, bool bc4, bool chkl, bool chkr, bool chkt, int rf, int ri, int li)
        {
            InitializeComponent();

            printer = new ApplicationPrinter();
            sticker = new LabelBuilder();

            XElement main = XElement.Load(@confPath);

            table = t;

            tituloI = titu;
            codigobarrasI = cob;
            detalles1I = det1;
            detalles2I = det2;
            detalles3I = det3;
            detalles4I = det4;
            TXTtitulo = txtt;
            TXTcampo1 = txtc1;
            TXTcampo2 = txtc2;
            TXTcampo3 = txtc3;
            TXTcampo4 = txtc4;
            boolTitulo = bt;
            boolCampo1 = bc1;
            boolCampo2 = bc2;
            boolCampo3 = bc3;
            boolCampo4 = bc4;
            CHKrango = chkr;
            CHKlinea = chkl;
            CHKtodo = chkt;
            intRangoI = ri;
            intRangoF = rf;
            intLinea = li;

            CMBimpresora.DataSource = printer.InstalledPrinters();
            CMBimpresora.SelectedItem = printer.DefaultZebraPrinter();

        }

        private void BTNimprimir_Click(object sender, EventArgs e)
        {

            if (CMBimpresora.SelectedIndex > -1)
            {
                List<string> linea1 = new List<string>();
                List<string> linea2 = new List<string>();


                //Valida los casos en que solo se debe imprimir un sticker
                if (CHKlinea || (CHKrango && (intRangoF - intRangoI == 0)) || (CHKtodo && (table.Rows.Count == 1)))
                {
                    int index = 0;

                    if (CHKlinea) index = (int)intLinea - 1;
                    if (CHKrango) index = (int)intRangoI - 1;

                    DataRow row = table.Rows[index];
                    foreach (DataColumn column in table.Columns)
                    {
                        linea1.Add(row[column].ToString());
                    }
                    if (!(boolTitulo) && !(boolCampo1) && !(boolCampo2) && !(boolCampo3) && !(boolCampo4))
                    {
                        sticker.PrintDelivery(CMBimpresora.SelectedItem.ToString(), linea1[codigobarrasI], linea1[detalles1I], linea1[tituloI], 1, 2, linea1[detalles3I], linea1[detalles4I]);
                    }
                    else
                    {
                        string titulo = "", campo1 = "", campo2 = "", campo3 = "", campo4;

                        if (boolTitulo) titulo = TXTtitulo;
                        else titulo = linea1[tituloI];

                        if (boolCampo1) campo1 = TXTcampo1;
                        else campo1 = linea1[detalles1I];

                        if (boolCampo2) campo2 = TXTcampo2;
                        else campo2 = linea1[detalles2I];

                        if (boolCampo3) campo3 = TXTcampo3;
                        else campo3 = linea1[detalles3I];

                        if (boolCampo4) campo4 = TXTcampo4;
                        else campo4 = linea1[detalles4I];

                        sticker.PrintDelivery(CMBimpresora.SelectedItem.ToString(), linea1[codigobarrasI], campo1, titulo, 1, 2, campo3, campo4);
                    }
                }

                // Impresión por rango
                if (CHKrango && (intRangoF - intRangoI > 0))
                {
                    int indexI = (int)intRangoI - 1;
                    int indexF = (int)intRangoF - 1;

                    int onetwo = 1, count = 0;

                    for (int i = indexI; i <= indexF; i++)
                    {
                        count++;
                        DataRow row = table.Rows[i];

                        foreach (DataColumn column in table.Columns)
                        {
                            if (onetwo > 2)
                            {
                                linea1 = new List<string>();
                                linea2 = new List<string>();
                                onetwo = 1;
                            }

                            if (onetwo == 1)
                            {
                                linea1.Add(row[column].ToString());
                            }
                            else
                            {
                                linea2.Add(row[column].ToString());
                            }
                        }
                        onetwo++;

                        //Si la diferencia es impar, se debe imprimir un número par de lineas y viceversa
                        if ((indexF - indexI) % 2 != 0)
                        {
                            if (onetwo > 2)
                            {
                                if (!(boolTitulo) && !(boolCampo1) && !(boolCampo2) && !(boolCampo3) && !(boolCampo4))
                                {
                                    sticker.PrintDelivery2(CMBimpresora.SelectedItem.ToString(), 1, 2, linea1[codigobarrasI], linea1[detalles2I], linea1[tituloI], linea1[detalles3I], linea1[detalles4I], linea2[tituloI], linea2[codigobarrasI], linea2[detalles2I], linea2[detalles3I], linea2[detalles4I]);
                                }
                                else
                                {
                                    string titulo = "", titulo2 = "", campo1 = "", campo21 = "", campo2 = "", campo22 = "", campo3 = "", campo23 = "", campo4 = "", campo24 = "";

                                    if (boolTitulo) titulo = titulo2 = TXTtitulo;
                                    else
                                    {
                                        titulo = linea1[tituloI];
                                        titulo2 = linea2[tituloI];
                                    }

                                    if (boolCampo1) campo1 = campo21 = TXTcampo1;
                                    else
                                    {
                                        campo1 = linea1[detalles1I];
                                        campo21 = linea2[detalles1I];
                                    }

                                    if (boolCampo2) campo2 = campo22 = TXTcampo2;
                                    else
                                    {
                                        campo2 = linea1[detalles2I];
                                        campo22 = linea2[detalles2I];
                                    }

                                    if (boolCampo3) campo3 = campo23 = TXTcampo3;
                                    else
                                    {
                                        campo3 = linea1[detalles3I];
                                        campo23 = linea2[detalles3I];
                                    }

                                    if (boolCampo4) campo4 = campo24 = TXTcampo4;
                                    else
                                    {
                                        campo4 = linea1[detalles4I];
                                        campo24 = linea2[detalles4I];
                                    }

                                    sticker.PrintDelivery2(CMBimpresora.SelectedItem.ToString(), 1, 2, linea1[codigobarrasI], campo2, titulo, campo3, campo4, titulo2, linea2[codigobarrasI], campo22, campo23, campo24);
                                }
                            }
                        }
                        else
                        {
                            if (count - 1 == indexF - indexI)
                            {
                                if (!(boolTitulo) && !(boolCampo1) && !(boolCampo2) && !(boolCampo3) && !(boolCampo4))
                                {
                                    sticker.PrintDelivery(CMBimpresora.SelectedItem.ToString(), linea1[codigobarrasI], linea1[detalles1I], linea1[tituloI], 1, 2, linea1[detalles3I], linea1[detalles4I]);
                                }
                                else
                                {
                                    string titulo, campo1, campo2, campo3, campo4;

                                    if (boolTitulo) titulo = TXTtitulo;
                                    else titulo = linea1[tituloI];

                                    if (boolCampo1) campo1 = TXTcampo1;
                                    else campo1 = linea1[detalles1I];

                                    if (boolCampo2) campo2 = TXTcampo2;
                                    else campo2 = linea1[detalles2I];

                                    if (boolCampo3) campo3 = TXTcampo3;
                                    else campo3 = linea1[detalles3I];

                                    if (boolCampo4) campo4 = TXTcampo4;
                                    else campo4 = linea1[detalles4I];

                                    sticker.PrintDelivery(CMBimpresora.SelectedItem.ToString(), linea1[codigobarrasI], campo1, titulo, 1, 2, campo3, campo4);
                                }
                            }
                            else
                            {
                                if (onetwo > 2)
                                {
                                    if (!(boolTitulo) && !(boolCampo1) && !(boolCampo2) && !(boolCampo3) && !(boolCampo4))
                                    {
                                        sticker.PrintDelivery2(CMBimpresora.SelectedItem.ToString(), 1, 2, linea1[codigobarrasI], linea1[detalles2I], linea1[tituloI], linea1[detalles3I], linea1[detalles4I], linea2[tituloI], linea2[codigobarrasI], linea2[detalles2I], linea2[detalles3I], linea2[detalles4I]);
                                    }
                                    else
                                    {
                                        string titulo = "", titulo2 = "", campo1 = "", campo21 = "", campo2 = "", campo22 = "", campo3 = "", campo23 = "", campo4 = "", campo24 = "";

                                        if (boolTitulo) titulo = titulo2 = TXTtitulo;
                                        else
                                        {
                                            titulo = linea1[tituloI];
                                            titulo2 = linea2[tituloI];
                                        }

                                        if (boolCampo1) campo1 = campo21 = TXTcampo1;
                                        else
                                        {
                                            campo1 = linea1[detalles1I];
                                            campo21 = linea2[detalles1I];
                                        }

                                        if (boolTitulo) campo2 = campo22 = TXTcampo2;
                                        else
                                        {
                                            campo2 = linea1[detalles2I];
                                            campo22 = linea2[detalles2I];
                                        }

                                        if (boolTitulo) campo3 = campo23 = TXTcampo3;
                                        else
                                        {
                                            campo3 = linea1[detalles3I];
                                            campo23 = linea2[detalles3I];
                                        }

                                        if (boolTitulo) campo4 = campo24 = TXTcampo4;
                                        else
                                        {
                                            campo4 = linea1[detalles4I];
                                            campo24 = linea2[detalles4I];
                                        }

                                        sticker.PrintDelivery2(CMBimpresora.SelectedItem.ToString(), 1, 2, linea1[codigobarrasI], campo2, titulo, campo3, campo4, titulo2, linea2[codigobarrasI], campo22, campo23, campo24);
                                    }
                                }
                            }
                        }
                    }
                }
                // Cuando se debe imprimir todo
                if (CHKtodo && table.Rows.Count > 1)
                {
                    int onetwo = 1, count = 0;
                    foreach (DataRow row in table.Rows)
                    {
                        count++;

                        foreach (DataColumn column in table.Columns)
                        {
                            if (onetwo > 2)
                            {
                                linea1 = new List<string>();
                                linea2 = new List<string>();
                                onetwo = 1;
                            }

                            if (onetwo == 1)
                            {
                                linea1.Add(row[column].ToString());
                            }
                            else
                            {
                                linea2.Add(row[column].ToString());
                            }
                        }
                        onetwo++;

                        //documento par o impar
                        if (table.Rows.Count % 2 != 0)
                        {
                            if (count == table.Rows.Count)
                            {
                                if (!(boolTitulo) && !(boolCampo1) && !(boolCampo2) && !(boolCampo3) && !(boolCampo4))
                                {
                                    sticker.PrintDelivery(CMBimpresora.SelectedItem.ToString(), linea1[codigobarrasI], linea1[detalles1I], linea1[tituloI], 1, 2, linea1[detalles3I], linea1[detalles4I]);
                                }
                                else
                                {
                                    string titulo = "", campo1 = "", campo2 = "", campo3 = "", campo4;

                                    if (boolTitulo) titulo = TXTtitulo;
                                    else titulo = linea1[tituloI];

                                    if (boolCampo1) campo1 = TXTcampo1;
                                    else campo1 = linea1[detalles1I];

                                    if (boolCampo2) campo2 = TXTcampo2;
                                    else campo2 = linea1[detalles2I];

                                    if (boolCampo3) campo3 = TXTcampo3;
                                    else campo3 = linea1[detalles3I];

                                    if (boolCampo4) campo4 = TXTcampo4;
                                    else campo4 = linea1[detalles4I];

                                    sticker.PrintDelivery(CMBimpresora.SelectedItem.ToString(), linea1[codigobarrasI], campo1, titulo, 1, 2, campo3, campo4);
                                }
                            }
                            else
                            {
                                if (onetwo > 2)
                                {
                                    if (!(boolTitulo) && !(boolCampo1) && !(boolCampo2) && !(boolCampo3) && !(boolCampo4))
                                    {
                                        sticker.PrintDelivery2(CMBimpresora.SelectedItem.ToString(), 1, 2, linea1[codigobarrasI], linea1[detalles2I], linea1[tituloI], linea1[detalles3I], linea1[detalles4I], linea2[tituloI], linea2[codigobarrasI], linea2[detalles2I], linea2[detalles3I], linea2[detalles4I]);
                                    }
                                    else
                                    {
                                        string titulo, titulo2, campo1, campo21, campo2, campo22, campo3, campo23, campo4, campo24;

                                        if (boolTitulo) titulo = titulo2 = TXTtitulo;
                                        else
                                        {
                                            titulo = linea1[tituloI];
                                            titulo2 = linea2[tituloI];
                                        }

                                        if (boolCampo1) campo1 = campo21 = TXTcampo1;
                                        else
                                        {
                                            campo1 = linea1[detalles1I];
                                            campo21 = linea2[detalles1I];
                                        }

                                        if (boolTitulo) campo2 = campo22 = TXTcampo2;
                                        else
                                        {
                                            campo2 = linea1[detalles2I];
                                            campo22 = linea2[detalles2I];
                                        }

                                        if (boolTitulo) campo3 = campo23 = TXTcampo3;
                                        else
                                        {
                                            campo3 = linea1[detalles3I];
                                            campo23 = linea2[detalles3I];
                                        }

                                        if (boolTitulo) campo4 = campo24 = TXTcampo4;
                                        else
                                        {
                                            campo4 = linea1[detalles4I];
                                            campo24 = linea2[detalles4I];
                                        }

                                        sticker.PrintDelivery2(CMBimpresora.SelectedItem.ToString(), 1, 2, linea1[codigobarrasI], campo2, titulo, campo3, campo4, titulo2, linea2[codigobarrasI], campo22, campo23, campo24);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (onetwo > 2)
                            {
                                if (!(boolTitulo) && !(boolCampo1) && !(boolCampo2) && !(boolCampo3) && !(boolCampo4))
                                {
                                    sticker.PrintDelivery2(CMBimpresora.SelectedItem.ToString(), 1, 2, linea1[codigobarrasI], linea1[detalles2I], linea1[tituloI], linea1[detalles3I], linea1[detalles4I], linea2[tituloI], linea2[codigobarrasI], linea2[detalles2I], linea2[detalles3I], linea2[detalles4I]);
                                }
                                else
                                {
                                    string titulo = "", titulo2 = "", campo1 = "", campo21 = "", campo2 = "", campo22 = "", campo3 = "", campo23 = "", campo4 = "", campo24 = "";

                                    if (boolTitulo) titulo = titulo2 = TXTtitulo;
                                    else
                                    {
                                        titulo = linea1[tituloI];
                                        titulo2 = linea2[tituloI];
                                    }

                                    if (boolCampo1) campo1 = campo21 = TXTcampo1;
                                    else
                                    {
                                        campo1 = linea1[detalles1I];
                                        campo21 = linea2[detalles1I];
                                    }

                                    if (boolCampo2) campo2 = campo22 = TXTcampo2;
                                    else
                                    {
                                        campo2 = linea1[detalles2I];
                                        campo22 = linea2[detalles2I];
                                    }

                                    if (boolCampo3) campo3 = campo23 = TXTcampo3;
                                    else
                                    {
                                        campo3 = linea1[detalles3I];
                                        campo23 = linea2[detalles3I];
                                    }

                                    if (boolCampo4) campo4 = campo24 = TXTcampo4;
                                    else
                                    {
                                        campo4 = linea1[detalles4I];
                                        campo24 = linea2[detalles4I];
                                    }

                                    sticker.PrintDelivery2(CMBimpresora.SelectedItem.ToString(), 1, 2, linea1[codigobarrasI], campo2, titulo, campo3, campo4, titulo2, linea2[codigobarrasI], campo22, campo23, campo24);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de especificar los campos requeridos");
            }

        }

        private void BTNguardar_Click(object sender, EventArgs e)
        {
            if (CMBimpresora.SelectedIndex > -1)
            {
                XDocument doc = new XDocument(new XElement("Configuration",
                                                                        new XElement("printerIndex", CMBimpresora.SelectedIndex)));
                try
                {
                    doc.Save(confPath);
                    MessageBox.Show("Configuración guardada exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la configuracion, " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de especificar los campos requeridos");
            }
        }

    }
}
