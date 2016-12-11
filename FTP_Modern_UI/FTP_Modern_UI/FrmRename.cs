using System;
using System.Windows.Forms;
using FTP_Modern_UI.FTPClass;
using FTP_Modern_UI.Method;
using MetroFramework;

namespace FTP_Modern_UI
{
    /// <summary>
    /// This is Rename form.
    /// </summary>
    public partial class FrmRename : MetroFramework.Forms.MetroForm
    {
        public string Path { get; }
        public FTPLibrary.FTPclient FtpClient { get; }
        /// <summary>
        /// Constructor.
        /// </summary>
        public FrmRename(string fileName, string currentDir, FTPLibrary.FTPclient ftpClient, string extension)
        {
            InitializeComponent();
            Path = currentDir;
            FtpClient = ftpClient;
            txtFileOld.Text = fileName;
            txtExtension.Text = extension;
            ServerConstant.CheckNewEvironment = false;
        }

        /// <summary>
        /// Button cancel click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Button create click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnRename_Click(object sender, EventArgs e)
        {
            if (txtFileNew.Text.TrimEnd().Equals("")) return;
            if (!StringExpression.CheckFileName(txtFileNew.Text))
            {
                MetroMessageBox.Show(this, "The name doesn't have \\ / : * ?  < > \" |", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            FtpClient.FtpRename(Path + txtFileOld.Text, txtFileNew.Text + txtExtension.Text);
            ServerConstant.Message = txtFileOld.Text + @" rename to " + txtFileNew.Text + txtExtension.Text;
            ServerConstant.CheckNewEvironment = true;
            ServerConstant.Filename = txtFileNew.Text + txtExtension.Text;
            Close();
        }

        /// <summary>
        /// Set enter event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void txtFileNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRename_Click(sender, new EventArgs());
            }
        }
    }
}
