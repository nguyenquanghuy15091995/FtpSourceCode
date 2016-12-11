using FTP_Modern_UI.FTPClass;
using System;
using System.Windows.Forms;
using static FTP_Modern_UI.FTPClass.FTPLibrary;
using MetroFramework;

namespace FTP_Modern_UI
{
    /// <summary>
    /// This is form login to connect server.
    /// </summary>
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            ServerConstant.CheckNewEvironment = false;
            // ReSharper disable once InvertIf
            if (ServerConstant.IsConnect)
            {
                txtServer.Text = ServerConstant.Server;
                txtUsername.Text = ServerConstant.Username;
                radStatus.Text = ServerConstant.GetFullServer() + @" is connected!";
                radStatus.Checked = true;
                txtServer.ReadOnly = true;
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }

        }

        /// <summary>
        /// Button close click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Button Connect click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ServerConstant.Server = txtServer.Text;
            ServerConstant.Username = txtUsername.Text;
            ServerConstant.Password = txtPassword.Text;
            try
            {
                var objFtp = new FTPclient(ServerConstant.GetFullServer(), txtUsername.Text, txtPassword.Text);
                objFtp.ListDirectoryDetail(@"/"); 
            }
            catch (Exception ex)
            {
                ServerConstant.IsConnect = false;
                MetroMessageBox.Show(this, ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServerConstant.Message = ex.Message;
                txtServer.Focus();
                return;
            }
            
            ServerConstant.IsConnect = true;
            ServerConstant.Message = @"Login " + ServerConstant.GetFullServer() + @" Successfully!";

            MetroMessageBox.Show(this, @"Connect is successful!", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtPassword.Text = "";
            txtServer.ReadOnly = true;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            radStatus.Text = ServerConstant.GetFullServer() + @" is connected!";
            radStatus.Checked = true;
            ServerConstant.Message = ServerConstant.GetFullServer() + @" is connected!";
            ServerConstant.CheckNewEvironment = true;
            btnClose.Focus();
        }

        /// <summary>
        /// Text box enter event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (ServerConstant.IsConnect)
            {
                return;
            }
            btnConnect_Click(sender, new EventArgs());
            if (!ServerConstant.IsConnect)
            {
                txtServer.Focus();
                return;
            }
            btnClose.Focus();
        }

        /// <summary>
        /// Button Disconnect click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ServerConstant.IsConnect = false;
            ServerConstant.Server = "";
            ServerConstant.Username = "";
            ServerConstant.Password = "";
            ServerConstant.Message = @"Server is not connected!";

            txtUsername.Text = "";
            txtServer.ReadOnly = false;
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            radStatus.Text = @"Not Connected!";
            radStatus.Checked = false;
            ServerConstant.CheckNewEvironment = true;
            txtServer.Focus();
        }
    }
}
