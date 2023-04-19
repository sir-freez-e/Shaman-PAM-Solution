namespace Shaman_PAM_Solution
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            var RequestForm = new RequestForm();
            RequestForm.Show();

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            // Launch browser to Support Page...
            System.Diagnostics.Process.Start("http://www.shamansecops.orgg");
        }
    }
}