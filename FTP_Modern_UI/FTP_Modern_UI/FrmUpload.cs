using System;
using System.Windows.Forms;
using FTP_Modern_UI.FTPClass;
using FTP_Modern_UI.Method;
using MetroFramework;

namespace FTP_Modern_UI
{
    /// <summary>
    /// This is Dialog upload process.
    /// </summary>
    public partial class FrmUpload : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Check upload.
        /// </summary>
        private bool _isUploaded;

        /// <summary>
        /// File name.
        /// </summary>
        private readonly string _fileName;

        /// <summary>
        /// Path of file upload.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Place to upload.
        /// </summary>
        private readonly string _upDir;

        /// <summary>
        /// Call FTP method.
        /// </summary>
        private readonly FTPLibrary.FTPclient _ftpClient;

        /// <summary>
        /// Constructor.
        /// </summary>
        public FrmUpload(string filePath, string upDir, FTPLibrary.FTPclient ftpClient)
        {
            InitializeComponent();
            _ftpClient = ftpClient;
            _fileName = System.IO.Path.GetFileName(filePath);
            txtFileName.Text = _fileName;
            _filePath = filePath;
            _upDir = upDir;
            txtUploadDir.Text = @".root" + upDir;
            _ftpClient.CurrentDirectory = upDir;
            _ftpClient.OnUploadCompleted += FtpClient_OnUploadCompleted;
            _ftpClient.OnUploadProgressChanged += FtpClient_OnUploadProgressChanged;

            _isUploaded = false;
        }

        #region Uploading File Events

        /// <summary>
        /// Do uploading event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void FtpClient_OnUploadProgressChanged(object sender, FTPLibrary.UploadProgressChangedArgs e)
        {
            // Calculate the Upload progress in percentages
            var percentProgress = e.TotleBytes == 0 ? Convert.ToInt64(e.BytesUploaded*100) : Convert.ToInt64((e.BytesUploaded * 100) / e.TotleBytes);
            pgbUpload.Value = Convert.ToInt32(percentProgress);
            pgbUpload.Text = "" + percentProgress;
            pgbUpload.Update();
            txtStatus.Text = @"Uploaded " + Calculator.GetFileSize(e.BytesUploaded) + @" of " + Calculator.GetFileSize(e.TotleBytes);
        }

        /// <summary>
        /// Do upload complete event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void FtpClient_OnUploadCompleted(object sender, FTPLibrary.UploadCompletedArgs e)
        {
            if (e.UploadCompleted)
            {
                //No Error  
                txtStatus.Text = @"Uploaded File Successfully!";
                //change value
                pgbUpload.Value = pgbUpload.Maximum;
                pgbUpload.Update();
                btnControl.Text = @"Close";
                ServerConstant.Message = _fileName + @" is uploaded.";
            }
            else
            {
                
                //Change Texts of various controls.
                txtStatus.Text = e.UploadStatus;
                btnControl.Text = @"Close";
                //Display a Messagebox with the error.
                MetroMessageBox.Show(this, txtStatus.Text, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServerConstant.Message = e.UploadStatus;
            }
            _isUploaded = true;
        }

        #endregion


        /// <summary>
        /// Button Control click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnControl_Click(object sender, EventArgs e)
        {
            if (btnControl.Text == @"Cancel")
            {
                _ftpClient.CancelUpload(_fileName);
                ServerConstant.Message = @"Upload is canceled.";
            }
            Close();
        }

        /// <summary>
        /// Do load form event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void FrmUpload_Load(object sender, EventArgs e)
        {
            pgbUpload.Maximum = 100;   
        }

        /// <summary>
        /// Do Active event.
        /// Call upload method.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void FrmUpload_Activated(object sender, EventArgs e)
        {
            if (!_isUploaded)
            {
                _ftpClient.Upload(_filePath, _upDir + _fileName);
            }
        }
    }
}
