using System;
using System.Windows.Forms;
using FTP_Modern_UI.FTPClass;
using FTP_Modern_UI.Method;
using MetroFramework;

namespace FTP_Modern_UI
{
    /// <summary>
    /// This is Download process form.
    /// </summary>
    public partial class FrmDownload : MetroFramework.Forms.MetroForm
    {
        public bool IsDownloaded;

        public string FileName { get; }
        public string CurrentDirectory { get; }
        public string SaveFilePath { get; }

        public FTPLibrary.FTPclient FtpClient { get; }
        /// <summary>
        /// Constructor.
        /// </summary>
        public FrmDownload(string fileName, string currentDirectory, string saveFilePath, FTPLibrary.FTPclient ftpClient)
        {
            InitializeComponent();
            FileName = fileName;
            CurrentDirectory = currentDirectory;
            SaveFilePath = saveFilePath;
            FtpClient = ftpClient;
            txtFileName.Text = fileName;
            txtDownloadDir.Text = saveFilePath;
            IsDownloaded = false;

            //Setup our Download Client and Start Downloading
            FtpClient.CurrentDirectory = currentDirectory;
            FtpClient.OnDownloadProgressChanged += FtpClient_OnDownloadProgressChanged;
            FtpClient.OnDownloadCompleted += FtpClient_OnDownloadCompleted;
        }

        //Event fires when the Download has completed.
        private void FtpClient_OnDownloadCompleted(object sender, FTPLibrary.DownloadCompletedArgs e)
        {
            if (e.DownloadCompleted)
            {   
                //Display the appropriate information to the User regarding the Download.
                txtStatus.Text = @"Downloaded File Successfully!";
                pgbDownload.Value = pgbDownload.Maximum;
                pgbDownload.Update();
                btnControl.Text = @"Close";
                ServerConstant.Message = txtFileName.Text + @" is downloaded.";
            }
            else
            {
                txtStatus.Text = e.DownloadStatus;
                btnControl.Text = @"Close";
                MetroMessageBox.Show(this, txtStatus.Text, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServerConstant.Message = e.DownloadStatus;
            }
            IsDownloaded = true;
        }

        //Event Fires whenever the Download Progress in changed.
        private void FtpClient_OnDownloadProgressChanged(object sender, FTPLibrary.DownloadProgressChangedArgs e)
        {
           

            // Calculate the download progress in percentages
            var percentProgress = e.TotleBytes == 0 ? Convert.ToInt64(e.BytesDownloaded * 100) : Convert.ToInt64((e.BytesDownloaded * 100) / e.TotleBytes);
            pgbDownload.Value = Convert.ToInt32(percentProgress);
            pgbDownload.Text = "" + percentProgress;
            pgbDownload.Update();

            txtStatus.Text = @"Downloaded " + Calculator.GetFileSize(e.BytesDownloaded) + @" of " + Calculator.GetFileSize(e.TotleBytes);
        }

        /// <summary>
        /// Button Control click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnControl_Click(object sender, EventArgs e)
        {
            if (btnControl.Text == @"Cancel")
            {
                FtpClient.CancelDownload();
                ServerConstant.Message = @"Download is canceled.";
            }
            Close();
        }

        /// <summary>
        /// When the form loading event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void FrmDownload_Load(object sender, EventArgs e)
        {
            pgbDownload.Maximum = 100;
        }

        /// <summary>
        /// When the form active event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void FrmDownload_Activated(object sender, EventArgs e)
        {
            if (!IsDownloaded)
            {
                FtpClient.Download(FileName, SaveFilePath, true);
            }
        }

    }
}
