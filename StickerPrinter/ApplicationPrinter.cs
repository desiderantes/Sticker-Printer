using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerPrinter
{
    class ApplicationPrinter
    {
        public IList<string> InstalledPrinters()
        {
            return ToSortedStringArray(PrinterSettings.InstalledPrinters);
        }

        public string DefaultZebraPrinter()
        {
            foreach (string printer in InstalledPrinters())
            {
                if (!string.IsNullOrEmpty(printer)
                    && printer.ToUpper().Contains("ZEBRA"))
                {
                    return printer;
                }
            }
            return null;
        }

        private IList<string> ToSortedStringArray(PrinterSettings.StringCollection printers)
        {
            List<string> stringList = new List<string>();
            foreach (string printer in printers)
            {
                stringList.Add(printer);
            }
            stringList.Sort(StringComparer.Ordinal);
            return stringList;
        }
    }
}
