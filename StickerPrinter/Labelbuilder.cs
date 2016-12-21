using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace StickerPrinter
{
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "My C#.NET RAW Document";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            return bSuccess;
        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = (szString.Length + 1) * Marshal.SystemMaxDBCSCharSize;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }

    class LabelBuilder
    {
        public void PrintInvoice2(string printerName, string radicado, string fecha, string nomEmpresa, int conjuntos, int etiquetas, string leyenda1, string leyenda2)
        {
            StringBuilder sb;

            if (printerName == null)
            {
                throw new ArgumentNullException("printerName");
            }

            if (conjuntos == 1)
            {
            }

            sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("N");
            sb.AppendLine("A40,5,0,2,1,2,N,\"" + nomEmpresa + "\"");
            sb.AppendLine("B40,45,0,1A,2,2,50,N,\"" + radicado + "\"");
            sb.AppendLine("A40,103,0,2,1,1,N,\"" + radicado + "\"");
            sb.AppendLine("A40,125,0,2,1,1,N,\"" + fecha + "\"");
            sb.AppendLine("A40,145,0,1,1,1,N,\"" + leyenda1 + "\"");
            sb.AppendLine("A40,165,0,1,1,1,N,\"" + leyenda2 + "\"");

            sb.AppendLine("A450,0,0,2,1,2,N,\"" + nomEmpresa + "\"");
            sb.AppendLine("B450,45,0,1A,2,2,50,N,\"" + radicado + "\"");
            sb.AppendLine("A450,103,0,2,1,1,N,\"" + radicado + "\"");
            sb.AppendLine("A450,125,0,2,1,1,N,\"" + fecha + "\"");
            sb.AppendLine("A450,145,0,1,1,1,N,\"" + leyenda1 + "\"");
            sb.AppendLine("A450,165,0,1,1,1,N,\"" + leyenda2 + "\"");
            sb.AppendLine("P1");

            RawPrinterHelper.SendStringToPrinter(printerName, sb.ToString());
        }

        public void PrintInvoice(string printerName, string radicado, string fecha, string nomEmpresa, int conjuntos, int etiquetas, string leyenda1, string leyenda2)
        {
            StringBuilder sb;

            if (printerName == null)
            {
                throw new ArgumentNullException("printerName");
            }

            if (conjuntos == 1)
            {
            }

            sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("N");
            sb.AppendLine("A40,5,0,2,1,2,N,\"" + nomEmpresa + "\"");
            sb.AppendLine("B40,45,0,1A,2,2,50,N,\"" + radicado + "\"");
            sb.AppendLine("A40,103,0,2,1,1,N,\"" + radicado + "\"");
            sb.AppendLine("A40,125,0,2,1,1,N,\"" + fecha + "\"");
            sb.AppendLine("A40,145,0,1,1,1,N,\"" + leyenda1 + "\"");
            sb.AppendLine("A40,165,0,1,1,1,N,\"" + leyenda2 + "\"");
            sb.AppendLine("P1");

            string sbts = sb.ToString();
            RawPrinterHelper.SendStringToPrinter(printerName, sb.ToString());
        }

        public void PrintDelivery2(string printerName, string radicado, string fecha, string titulo, int conjuntos, int etiquetas, string leyenda1, string leyenda2)
        {
            StringBuilder sb;

            if (printerName == null)
            {
                throw new ArgumentNullException("printerName");
            }

            sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("N");
            sb.AppendLine("A40,0,0,2,1,2,N,\"" + titulo + "\"");
            sb.AppendLine("B40,40,0,1A,2,2,50,N,\"" + radicado + "\"");
            sb.AppendLine("A40,98,0,2,1,1,N,\"" + radicado + "\"");
            sb.AppendLine("A40,120,0,2,1,1,N,\"" + fecha + "\"");
            sb.AppendLine("A40,140,0,1,1,1,N,\"" + leyenda1 + "\"");
            sb.AppendLine("A40,160,0,1,1,1,N,\"" + leyenda2 + "\"");

            sb.AppendLine("A450,0,0,2,1,2,N,\"" + titulo + "\"");
            sb.AppendLine("B450,40,0,1A,2,2,50,N,\"" + radicado + "\"");
            sb.AppendLine("A450,98,0,2,1,1,N,\"" + radicado + "\"");
            sb.AppendLine("A450,120,0,2,1,1,N,\"" + fecha + "\"");
            sb.AppendLine("A450,140,0,1,1,1,N,\"" + leyenda1 + "\"");
            sb.AppendLine("A450,160,0,1,1,1,N,\"" + leyenda2 + "\"");
            sb.AppendLine("P1");

            RawPrinterHelper.SendStringToPrinter(printerName, sb.ToString());
        }

        public void PrintDelivery(string printerName, string radicado, string fecha, string titulo, int conjuntos, int etiquetas, string leyenda1, string leyenda2)
        {
            StringBuilder sb;

            if (printerName == null)
            {
                throw new ArgumentNullException("printerName");
            }

            sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("N");
            sb.AppendLine("A50,0,0,2,1,2,N,\"" + titulo + "\"");
            sb.AppendLine("B40,40,0,1A,2,2,50,N,\"" + radicado + "\"");
            sb.AppendLine("A40,98,0,2,1,1,N,\"" + radicado + "\"");
            sb.AppendLine("A40,120,0,2,1,1,N,\"" + fecha + "\"");
            sb.AppendLine("A40,140,0,1,1,1,N,\"" + leyenda1 + "\"");
            sb.AppendLine("A40,160,0,1,1,1,N,\"" + leyenda2 + "\"");
            sb.AppendLine("P1");

            RawPrinterHelper.SendStringToPrinter(printerName, sb.ToString());
        }
    }
}
