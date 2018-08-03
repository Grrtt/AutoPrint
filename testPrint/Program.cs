using AutoPrint.Printers;
using AutoPrint.UI;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AutoPrint
{
    class Program
    {
        public static NameValueCollection printersList;
        
        static void Main(string[] args)
        {
            printersList = (NameValueCollection) ConfigurationManager.GetSection("printers");
            Watchdog wd = new Watchdog();
            
            PrinterManager.LoadPrinters();
            
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledException);
            
            Application.Run(new SysTrayApp());
        }

        static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("Exception logged.");
            Exception ex = (Exception)e.ExceptionObject;
            string errorLog = ex.Message + ex.StackTrace +
                DateTime.Now;

            MessageBox.Show(AppDomain.CurrentDomain.FriendlyName + " has crashed due to an error.\n" +
                            "The error has been reported and will be fixed as soon as possible.\n" +
                            "Please restart the program.", "Critical Error " +
                            DateTime.Now.ToBinary(),
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

            Console.WriteLine(errorLog);
            Console.WriteLine("Logging error to:\n" +
                              @"..." + Environment.MachineName + DateTime.Now.ToBinary() + "_Error.txt");
            File.WriteAllText(@"..." + Environment.MachineName + DateTime.Now.ToBinary() + "_Error.txt", errorLog);
            Environment.Exit(1);
        }
    }
}
