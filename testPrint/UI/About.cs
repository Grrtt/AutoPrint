using System.Windows.Forms;

namespace AutoPrint.UI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
