using System;
using System.Windows.Forms;

namespace PaintPickerv2
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            PaintPickerConnections.Connection.DownloadFile();
        }

        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            frmBucket frmBucket = new frmBucket();
            frmBucket.ShowDialog();
        }

        private void btnPrintBatch_Click(object sender, EventArgs e)
        {
            frmBatch frmBatch = new frmBatch();
            frmBatch.ShowDialog();
        }

        private void btnPrintCustom_Click(object sender, EventArgs e)
        {
            frmCustom frmCustom = new frmCustom();
            frmCustom.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            PaintPickerConnections.Connection.UploadFile();

            Close();
        }
        }
}