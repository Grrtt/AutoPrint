using AutoPrint.Printers.Models;
using AutoPrint.Printing;
using System;
using System.Management;

namespace AutoPrint.Printers
{
    public static class PrinterManager
    {
        public static Printer BarcodePrinter { get; set; }
        public static Printer LabelPrinter { get; set; }
        
        public static Printer AssignPrinter(string printerName)
        {
            string driverName = GetPrinterDetails("DriverName", printerName);
            Console.WriteLine(printerName + " driver : " + driverName);
            Drivers driverType = AssignDriver(driverName);

            switch (driverType)
            {
                case Drivers.ZDesigner_LP_2824:
                    return new LP2824(printerName);
                case Drivers.Zebra_LP2824:
                    return new LP2824(printerName);
                case Drivers.ZDesigner_LP_2844:
                    return new LP2844(printerName);
                case Drivers.Zebra_LP2844:
                    return new LP2844(printerName);
                default:
                    return new LP2844("NO PRINTER");
            }
        }

        private static string GetPrinterDetails(string propertyName, string printerName)
        {
            String query = String.Format("Select {0} from Win32_Printer WHERE Name = '{1}'", propertyName, printerName);
            ManagementObjectSearcher queryResult = new ManagementObjectSearcher(query);

            string value = "";
            foreach (ManagementObject printer in queryResult.Get())
            {
                value = (string)printer.GetPropertyValue("DriverName");
            }

            return value;
        }

        private static Drivers AssignDriver(string driver)
        {
            switch (driver)
            {
                case "Zebra LP2824":
                    return Drivers.Zebra_LP2824;
                case "ZDesigner LP 2824":
                    return Drivers.ZDesigner_LP_2824;
                case "Zebra LP2844":
                    return Drivers.Zebra_LP2844;
                case "ZDesigner LP 2844":
                    return Drivers.ZDesigner_LP_2844;
                default:
                    return Drivers.Zebra_LP2844;
            }
        }

        public static void LoadPrinters()
        {
            Console.WriteLine("Loading Printers");
            string printerName;

            printerName = Program.printersList["Small_EPL_Label"];
            BarcodePrinter = AssignPrinter(printerName);
            Console.WriteLine("Barcode printer is : " + BarcodePrinter.Driver);
 
            printerName = Program.printersList["Big_EPL_Label"];
            LabelPrinter = AssignPrinter(printerName);
            Console.WriteLine("Label printer is : " + LabelPrinter.Driver);

            if (BarcodePrinter == null)
                BarcodePrinter = LabelPrinter;
        }

        public static Printer RequestPrinter(Label.Labels labelType)
        {
            switch (labelType)
            {
                case Label.Labels.barcode:
                    return BarcodePrinter;
                case Label.Labels.box:
                    return LabelPrinter;
                case Label.Labels.timeStamp:
                    return BarcodePrinter;
                case Label.Labels.other:
                    return LabelPrinter;             
                default:
                    return BarcodePrinter;
            }
        }
    }

    public enum PrinterModels
    {
        LP2844, LP2824
    }

    public enum Drivers
    {
        Zebra_LP2844, Zebra_LP2824,
        ZDesigner_LP_2844, ZDesigner_LP_2824
    }
}
