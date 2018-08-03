using AutoPrint.Printers;
using System.IO;
using System.Text;

namespace AutoPrint.Printing
{
    public class Label
    {
        public string FilePath { get; set; }
        public string[] Text { get; set; }
        public Labels Type { get; set; }

        public Label(string path)
        {
            FilePath = path;
            Text = ReadText();
            Type = ParseType(Text);
        }

        public Label(string[] text)
        {
            Text = text;
            Type = ParseType(text);
        }
        
        private Labels ParseType(string[] labelText)
        {
            switch (labelText[2])
            {
                case "R50,20":
                    return Labels.barcode;
                case "R50,50":
                    return Labels.box;
                case "R220,20":
                    if (PrinterManager.BarcodePrinter.Driver == (Drivers.ZDesigner_LP_2824 | Drivers.Zebra_LP2824))
                        FormatForLP2824();
                    return Labels.barcode;
                case "^FO50,40,^A0,32,40":
                    return Labels.other;
                default:
                    return Labels.other;
            }
        }

        private string GetListingNumber()
        {
            string listingNumber = "";

            try
            {
                string line6 = Text[6];
                listingNumber = line6.Split('/')[2];
                listingNumber = listingNumber.Replace("\"", "").Replace("\\", "").Trim();
            }
            catch { listingNumber = "NO LISTING"; }

            return listingNumber;
        }

        public void Print()
        {
            Printer printer = PrinterManager.RequestPrinter(Type);
            Print(printer.Name);

            if (PrintingManager.ListingAfterBarcode && (Type != (Labels.other | Labels.timeStamp)))
            {
                RawPrinterHelper.SendStringToPrinter(printer.Name, GetListingNumber());
            }
        }
        
        public void Print(string printerName)
        {
            RawPrinterHelper.SendStringToPrinter(printerName, this.ToString());
        }

        public void Print(Labels type)
        {
            switch (type)
            {
                case Labels.timeStamp:
                    
                    break;
                case Labels.other:
                    RawPrinterHelper.SendFileToPrinter(PrinterManager.LabelPrinter.Name, this.FilePath);
                    break;
                default:
                    break;
            }
        }
          
        private void FormatForLP2824()
        {
            foreach (string s in Text)
                s.Replace(Text[2], "R50,20");
        }

        private string[] ReadText()
        {
            string[] text;
            
            using (StreamReader sr = new StreamReader(FilePath))
                text = sr.ReadToEnd().Split(("\n\r").ToCharArray());

            return text;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (string s in Text)
                sb.AppendLine(s);

            return sb.ToString();
        }

        public enum Labels
        {
            box, barcode, timeStamp, other
        }
    }
}
