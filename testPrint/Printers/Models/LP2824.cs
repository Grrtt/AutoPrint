using AutoPrint.Printing;
using System;
using System.Text;

namespace AutoPrint.Printers.Models
{
    class LP2824 : Printer
    {
        public LP2824(string printerName)
        {
            Driver = Drivers.Zebra_LP2824;
            Model = PrinterModels.LP2824;
            Name = printerName;
        }

        public override void Print(Label label)
        {
            string labelText = FormatLabel(label.ToString());
            RawPrinterHelper.SendStringToPrinter(Name, labelText);
        }

        public override void Print(string labelText)
        {
            labelText = FormatLabel(labelText);
            RawPrinterHelper.SendStringToPrinter(Name, labelText);
        }

        public override void Print(Label.Labels type)
        {
            string timeStamp = PrintingManager.CreateTimeStamp();
            timeStamp = FormatLabel(timeStamp);
            RawPrinterHelper.SendStringToPrinter(Name, timeStamp);
        }

        private string FormatLabel(string labelText)
        {
            string formattedText = labelText.Replace("R220,20", "R20,20");
            return formattedText;
        }
    }
}
