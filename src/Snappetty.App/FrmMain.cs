namespace Snappetty.App
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            var captureForm = new FrmCapture();
            this.Hide();
            captureForm.Show();
        }
    }
}