using System;
using System.Windows.Forms;
using FTP_Modern_UI.FTPClass;
using FTP_Modern_UI.Method;
using MetroFramework;

namespace FTP_Modern_UI
{
    /// <summary>
    /// Create new folder form.
    /// </summary>
    public partial class FrmNewFolder : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Call FTP method.
        /// </summary>
        public FTPLibrary.FTPclient FtpClient { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="currDir">Current directory.</param>
        /// <param name="ftpClient">Call create new folder method.</param>
        public FrmNewFolder(string currDir, FTPLibrary.FTPclient ftpClient)
        {
            InitializeComponent();
            FtpClient = ftpClient;
            txtCurrDir.Text = currDir;
            txtFileName.Focus();
            ServerConstant.CheckNewEvironment = false;
        }

        /// <summary>
        /// Button close click event.
        /// Close create new folder form.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Button New folder click event.
        /// Call create folder method and.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtFileName.Text.TrimEnd().Equals("")) return;
            if (!StringExpression.CheckFileName(txtFileName.Text))
            {
                MetroMessageBox.Show(this, "The name doesn't have \\ / : * ?  < > \" |", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                //Create New Directory
                FtpClient.FtpCreateDirectory(txtCurrDir.Text + txtFileName.Text);
                ServerConstant.Filename = txtFileName.Text;
                ServerConstant.Message = @"Folder " + txtFileName.Text + @" is created.";
                ServerConstant.CheckNewEvironment = true;
                Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServerConstant.Message = ex.Message;
                ServerConstant.CheckNewEvironment = true;
            }
        }

        /// <summary>
        /// Set enter event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void txtFileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate_Click(sender, new EventArgs());
            }
        }
    }
}
