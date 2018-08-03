using AutoPrint.Printers;
using AutoPrint.Printing;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Threading;

namespace AutoPrint
{
    class Watchdog
    {
        public string WdDirectory { get; set; }
        
        FileSystemWatcher _watchFolder;

        public Watchdog()
        {
            NameValueCollection wdSection = (NameValueCollection) ConfigurationManager.GetSection("watchdog");
            string directory = wdSection["Directory"];

            WdDirectory = directory;
            StartActivityMonitoring(WdDirectory);
        }

        private void StartActivityMonitoring(string sPath)
        {
            _watchFolder = new FileSystemWatcher();

            // This is the path we want to monitor
            _watchFolder.Path = sPath;

            // Make sure you use the OR on each Filter because we need to monitor
            // all of those activities

            _watchFolder.NotifyFilter = NotifyFilters.LastWrite; // | NotifyFilters.Attributes;

            // Now hook the triggers(events) to our handler (eventRaised)
            _watchFolder.Changed += _watchFolder_Changed;
            //_watchFolder.Created += _watchFolder_Created;
            //_watchFolder.Deleted += new FileSystemEventHandler(eventRaised);

            try
            {
                _watchFolder.EnableRaisingEvents = true;
            }
            catch (ArgumentException) { }
        }

        private void _watchFolder_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File attributes changed.");

            if (e.Name.StartsWith("printout") && (e.Name.EndsWith(".epl") | (e.Name.EndsWith(".zpl"))))
            {
                try
                {
                    Console.WriteLine("Printout found.\n");
                    
                    // Add delay for FireFox downloads.
                    Thread.Sleep(250);

                    Label label = new Label(e.FullPath);
                    
                    Console.WriteLine($"File {e.FullPath} has been modified.");

                    PrintingManager.SaveLabel(label);
                    label.Print();
                }
                catch { }


                File.Delete(e.FullPath);
            }
        }
    }
}
