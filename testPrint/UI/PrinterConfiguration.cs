using AutoPrint.Printers;
using AutoPrint.Printing;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace AutoPrint.UI
{
    public partial class PrinterConfiguration : Form
    {
        public PrinterConfiguration()
        {
            InitializeComponent();
            txtbx_LabelName.Text = PrinterManager.LabelPrinter.Name;
            txtbx_BarcodeName.Text = PrinterManager.BarcodePrinter.Name;
            checkbx_ListingAfterBarcode.Checked = PrintingManager.ListingAfterBarcode;
        }

        private void checkbx_ListingAfterBarcode_CheckedChanged(object sender, EventArgs e)
        {
            PrintingManager.ListingAfterBarcode = !PrintingManager.ListingAfterBarcode;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void btn_SaveConfiguration_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
            this.Visible = false;
        }

        private void SaveConfiguration()
        {
            XmlDocument config = new XmlDocument();
            config.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            XmlNode node; 
            node = config.SelectSingleNode("//printers/add[@key='Big_EPL_Label']");
            node.Attributes["value"].Value = txtbx_LabelName.Text;
            ChangeLabelPrinter(txtbx_LabelName.Text);

            node = config.SelectSingleNode("//printers/add[@key='Small_EPL_Label']");
            node.Attributes["value"].Value = txtbx_BarcodeName.Text;
            ChangeBarcodePrinter(txtbx_BarcodeName.Text);

            config.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("printers");
        }

        private void ChangeLabelPrinter(string printerName)
        {
            PrinterManager.LabelPrinter = PrinterManager.AssignPrinter(printerName);
        }

        private void ChangeBarcodePrinter(string printerName)
        {
            PrinterManager.BarcodePrinter = PrinterManager.AssignPrinter(printerName);
        }
    }
}
