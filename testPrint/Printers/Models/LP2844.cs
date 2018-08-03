using AutoPrint.Printing;
using System;
using System.Text;

namespace AutoPrint.Printers.Models
{
    class LP2844 : Printer
    {
        public LP2844(string printerName)
        {
            Driver = Drivers.Zebra_LP2844;
            Model = PrinterModels.LP2844;
            Name = printerName;
        }

        public override void Print(Label label)
        {
            switch (label.Type)
            {
                case Label.Labels.other:
                    Console.WriteLine("Printing file to " + Name);
                    RawPrinterHelper.SendFileToPrinter(Name, label.FilePath);
                    break;
                default:
                    Console.WriteLine("Print string to " + Name);
                    Print(label.ToString());
                    break;
            }
        }

        public override void Print(string labelText)
        {
            RawPrinterHelper.SendStringToPrinter(Name, labelText);
        }

        public override void Print(Label.Labels type)
        {
            switch (type)
            {
                case Label.Labels.timeStamp:
                    string timeStamp = PrintingManager.CreateTimeStamp();
                    RawPrinterHelper.SendStringToPrinter(Name, timeStamp);
                    break;
                default:
                    break;
            }
        }
    }
}
