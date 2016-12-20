using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StickerPrinter
{
    public partial class Visualizer : Form
    {
        public Visualizer(DataTable t)
        {
            InitializeComponent();

            DGcsv.DataSource = t;
        }
    }
}
