using AutoPrint.Printing;
using System;
using System.Management;

namespace AutoPrint.Printers
{
    public abstract class Printer
    {
        public Drivers Driver { get; set; }
        public PrinterModels Model { get; set; }
        public string Name { get; set; }

        public abstract void Print(Label label);
        public abstract void Print(String labelText);
        public abstract void Print(Label.Labels type);
    }

}
