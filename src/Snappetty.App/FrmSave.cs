using System.Drawing.Imaging;

namespace Snappetty.App
{
    public partial class FrmSave : Form
    {
        public FrmSave(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            InitializeComponent();

            var rect = new Rectangle(x, y, w, h);
            var bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            var g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
            bmp.Save(Path.GetTempFileName(), ImageFormat.Png);
            pbCapture.Image = bmp;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.CheckPathExists = true;
            sfd.FileName = "Capture";
            sfd.Filter = "PNG Image(*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbCapture.Image.Save(sfd.FileName);
            }
        }

        private void FrmSave_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new FrmMain();
            MainForm.Show();
            this.Hide();
        }
    }
}
