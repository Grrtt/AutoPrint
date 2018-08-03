using AutoPrint.Printers;
using AutoPrint.Printing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPrint.UI
{
    class SysTrayApp : Form
    {
        //public AboutForm AboutForm { get; set; }
        public static PrinterConfiguration PrinterConfig { get; set; }
        public static About AboutWindow { get; set; }

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        public SysTrayApp()
        {
            HotKeyManager.RegisterHotKey(Keys.Oemtilde, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.D0, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.D1, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);

            this.KeyPreview = true;

            PrintingManager.ListingAfterBarcode = false;
            
            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            
            PrinterConfig = new PrinterConfiguration();
            AboutWindow = new About();

            trayMenu.MenuItems.Add("Multi-Queue");
            trayMenu.MenuItems.Add("Configure Printers...", OpenPrinterConfiguration);
            trayMenu.MenuItems.Add("About", OpenAbout);
            //trayMenu.MenuItems.Add("About", OpenAbout);
            //trayMenu.MenuItems.Add("Check For ZPL");
            trayMenu.MenuItems.Add("Exit", OnExit);

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "AutoPrint";

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }


        static void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            switch (e.Key)
            {
                case Keys.D0:
                    Console.WriteLine("----- Timestamp -----");
                    Printing.Label timeStamp = new Printing.Label(PrintingManager.CreateTimeStamp());
                    timeStamp.Print();
                    break;
                case Keys.Oemtilde:
                    Console.WriteLine("----- Reprint -----");
                    if (PrintingManager.LastLabel != null)
                        PrintingManager.LastLabel.Print();
                    break;
                case Keys.D1:
                    //PrinterManager.QueueLabel();
                    break;
                default:
                    break;
            }
        }

        private static void OpenAbout(object sender, EventArgs e)
        {
            if(AboutWindow.Visible == false)
            {
                AboutWindow.Visible = true;
            }
            else
            {
                AboutWindow = new About();
            }
        }

        private static void OpenPrinterConfiguration(object sender, EventArgs e)
        {
            if(PrinterConfig.Visible == false)
            {
                PrinterConfig.Visible = true;
            }
            else
            {
                PrinterConfig = new PrinterConfiguration();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            AboutWindow.Dispose();
            PrinterConfig.Dispose();
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }
    }
}
