using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using FTP_Modern_UI.FTPClass;
using MetroFramework;
using MetroFramework.Forms;
using static FTP_Modern_UI.FTPClass.FTPLibrary;
using FTP_Modern_UI.Method;

namespace FTP_Modern_UI
{
    /// <summary>
    /// Form main of this program.
    /// </summary>
    public partial class FrmMain : MetroForm
    {
        /// <summary>
        /// To call FTP method.
        /// </summary>
        public FTPclient FtpClient { get; set; }

        /// <summary>
        /// To call grid view method.
        /// </summary>
        public GridMethod GridMethodControl { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            GridMethodControl = new GridMethod();
            txtCurrDir.Text = @"/";
            ServerConstant.Message = @"Server is not connected!";
            
        }

        /// <summary>
        /// Button Quit click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event when form main are closing.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var askClose = MetroMessageBox.Show(this, @"Do you want to close FTp Application?", @"Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if(askClose != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Button Choose server click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnChooseServer_Click(object sender, EventArgs e)
        {
            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            if (ServerConstant.IsConnect)
            {
                //set all component after connect.
                pnlRightTop.Enabled = true;
                FtpClient = new FTPclient(ServerConstant.GetFullServer(), ServerConstant.Username,
                    ServerConstant.Password);
                GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
                btnBack.Enabled = true;
                btnRefresh.Enabled = true;
                txtCurrServer.Text = ServerConstant.GetFullServer();
                PushRowHandleToTextbox();
            }
            else
            {
                pnlRightTop.Enabled = false;
                btnBack.Enabled = false;
                btnRefresh.Enabled = false;
                txtCurrServer.Text = ServerConstant.GetFullServer();
                GridMethodControl.ClearGridView(gclServer);
            }
            // ReSharper disable once InvertIf
            if (ServerConstant.CheckNewEvironment)
            {
                GridMethodControl.AddNewMessage(gclMessage, gvwMessage, ServerConstant.Message);
                ServerConstant.CheckNewEvironment = false;
            }   
        }

        /// <summary>
        /// Button upload click event.
        /// upload a file to server.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            var objOpenDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = @"All files (*.*)|*.*",
                RestoreDirectory = true        
            };
            if (objOpenDialog.ShowDialog() == DialogResult.OK)
            {
                var frmUpload = new FrmUpload(objOpenDialog.FileName, txtCurrDir.Text, FtpClient);
                frmUpload.ShowDialog();
                GridMethodControl.AddNewMessage(gclMessage, gvwMessage, ServerConstant.Message);
            }
            //Call RefreshDirectory; Refresh the Files and Folders for Current Directory.
            GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
            //Select new row upload.
            GridMethodControl.FindFocusedRow(gvwServer, System.IO.Path.GetFileName(objOpenDialog.FileName));
            PushRowHandleToTextbox();
        }

        /// <summary>
        /// Button download click event.
        /// Download a file to local PC or laptop.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            var currRow = gvwServer.FocusedRowHandle;
            if (gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString().Equals(@"Folder"))
            {
                //Set Directory to txtRemoteDirectory.Text + selectedItem + "/"
                //Result - /SelectedDirecotory/  -- good for navigation, keeping user informed and code :)
                txtCurrDir.Text += gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[0] + @"/";
                GridMethodControl.ClearGridView(gclServer);
                
                //Set Current Dir
                FtpClient.CurrentDirectory = txtCurrDir.Text;

            }
            //download file.
            else if (gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString().Equals(@"File"))
            {
                var saveDialog = new SaveFileDialog
                {
                    FileName = txtFileName.Text,
                    Title = @"Save File to...",
                    Filter = @"File (*." + txtFileType.Text + @")|*." + txtFileType.Text    
                };
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {          
                    //Setup and Open Download Form
                    var downloadForm = new FrmDownload(txtFileName.Text, txtCurrDir.Text, saveDialog.FileName, FtpClient);
                    downloadForm.ShowDialog();
                    GridMethodControl.AddNewMessage(gclMessage, gvwMessage, ServerConstant.Message);
                }  
            }
            //Setup and Show 
            //Call RefreshDirectory; Refresh the Files and Folders for Current Directory.
            GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
            gvwServer.FocusedRowHandle = currRow;
        }

        /// <summary>
        /// Button rename click event.
        /// Rename a file or a folder.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnRename_Click(object sender, EventArgs e)
        {      
            try
            {
                FrmRename frmRename;
                if (gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString().Equals(@"File"))
                {
                    var extension = StringExpression.GetFileType(txtFileName.Text, "");
                    //Create a RenameDialog and display it.
                    frmRename = new FrmRename(txtFileName.Text, txtCurrDir.Text, FtpClient, @"." + extension);
                    frmRename.ShowDialog();

                }
                else
                {
                    frmRename = new FrmRename(txtFileName.Text, txtCurrDir.Text, FtpClient, "");
                    frmRename.ShowDialog();
                }//Refresh, because the Filename has been changed by the user.
                GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServerConstant.Message = ex.Message;
                ServerConstant.CheckNewEvironment = true;
            }

            GridMethodControl.FindFocusedRow(gvwServer, ServerConstant.Filename);

            // ReSharper disable once InvertIf
            if (ServerConstant.CheckNewEvironment)
            {
                GridMethodControl.AddNewMessage(gclMessage, gvwMessage, ServerConstant.Message);
                ServerConstant.CheckNewEvironment = false;
            }       
        }

        /// <summary>
        /// Button clear message click event.
        /// Clear all message of message grid view.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnClearMessage_Click(object sender, EventArgs e)
        {
            GridMethodControl.ClearGridView(gclMessage);
        }

        /// <summary>
        /// To show file information on textbox.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void gvwServer_RowClick(object sender, RowClickEventArgs e)
        {
            PushRowHandleToTextbox();
        }

        /// <summary>
        /// Push Row Handle To Textbox.
        /// </summary>
        private void PushRowHandleToTextbox()
        {
            txtFileName.Text = gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[0].ToString();
            txtFileType.Text =
                StringExpression.GetFileType(gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[0].ToString(),
                gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString());
            txtFileDate.Text = gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[3].ToString();
            txtFileSize.Text = gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[4].ToString();
        }

        /// <summary>
        /// Do if user double click to grid view.
        /// give message if click file.
        /// enter if click folder.
        /// go back if click '...'.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void gvwServer_DoubleClick(object sender, EventArgs e)
        {
            if (gvwServer.RowCount <= 0) return;
            try
            {
                if (gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString().Equals(@"File"))
                {
                    MetroMessageBox.Show(this, @"Cannot open this file! We do not support that. :V", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
                else if (gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString().Equals(@"Folder")) // Its a Directory
                {
                    //Set Directory to txtRemoteDirectory.Text + selectedItem + "/"
                    //Result - /SelectedDirecotory/  -- good for navigation, keeping user informed and code :)
                    txtCurrDir.Text += gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[0] + @"/";
                    GridMethodControl.ClearGridView(gclServer);

                    //Set Current Dir
                    FtpClient.CurrentDirectory = txtCurrDir.Text;

                    //Get Files and Folders from Selected Direcotry
                    GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
                }
                else if (gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString().Equals(@"..."))
                {
                    txtCurrDir.Text = GridMethodControl.GetDirBack(txtCurrDir.Text, FtpClient);
                    GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, @"Cannot connect server. :V", @"Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PushRowHandleToTextbox();
        }

        /// <summary>
        /// Put Back folder "..." to the top.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void gvwServer_EndSorting(object sender, EventArgs e)
        {
            if (gvwServer.RowCount < 2) return;
            var rowHandle = 0;
            rowHandle = gvwServer.LocateByValue(rowHandle, gvwServer.Columns[@"File Type"], @"...");
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            while (rowHandle > 0)
            {
                var row1 = gvwServer.GetDataRow(rowHandle);
                var row2 = gvwServer.GetDataRow(rowHandle - 1);

                var row = row1.ItemArray;
                row1.ItemArray = row2.ItemArray;
                row2.ItemArray = row;

                rowHandle--;
            }
        }

        /// <summary>
        /// Button Delete click event.
        /// Delete a file or a folder.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvwServer.RowCount <= 1) return;

            var currFocusedRow = gvwServer.FocusedRowHandle;
            var firstCount = gvwServer.RowCount;

            //Check if File or Folder
            if (gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString().Equals(@"...")) return;
            try
            {
                //delete file.
                if (gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString().Equals(@"File"))
                {
                    FtpClient.CurrentDirectory = txtCurrDir.Text;
                    ServerConstant.Message = gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[0].ToString();
                    FtpClient.FtpDelete(gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[0].ToString());
                    ServerConstant.Message = @"File " + ServerConstant.Message + @" is deleted.";
                }
                //delete folder
                else if (gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[1].ToString().Equals(@"Folder")) // Its a Directory
                {
                    //ask user.
                    var dialogResult = MetroMessageBox.Show(this,
                        @"Do you want to delete folder " + gvwServer.GetDataRow(gvwServer.FocusedRowHandle)[0] + " ?",
                        "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    if (dialogResult == DialogResult.Cancel) return;
                    gclServer.Enabled = false;
                    var currRow = gvwServer.FocusedRowHandle;
                    var tempName = gvwServer.GetDataRow(currRow)[0].ToString();
                    //delete all file in folder.
                    do
                    {                    
                        GridMethodControl.DeleteAllFolderFile(gclServer, gvwServer, FtpClient,
                            txtCurrDir.Text + gvwServer.GetDataRow(currRow)[0] + @"/",
                            gvwServer.GetDataRow(currRow)[0].ToString());
                        GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
                    } while (tempName == gvwServer.GetDataRow(currRow)[0].ToString());
                    ServerConstant.Message = @"Folder " + tempName + @" is deleted.";
                    gclServer.Enabled = true;
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, @"Cannot delete file. :V", @"Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //refresh gridview server.
            GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
            var secondCount = gvwServer.RowCount;
            //Check delete to show message.
            // ReSharper disable once InvertIf
            if (firstCount - secondCount > 0)
            {
                //set focused row.
                gvwServer.FocusedRowHandle = currFocusedRow - 1;
                PushRowHandleToTextbox();
                GridMethodControl.AddNewMessage(gclMessage, gvwMessage, ServerConstant.Message);
            }
        }

        /// <summary>
        /// Button Refresh click event.
        /// Refresh server grid view.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
            PushRowHandleToTextbox();
        }

        /// <summary>
        /// Button Back click event.
        /// Back the previos directory.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnBack_Click(object sender, EventArgs e)
        {
            txtCurrDir.Text = GridMethodControl.GetDirBack(txtCurrDir.Text, FtpClient);
            GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
            PushRowHandleToTextbox();
        }

        /// <summary>
        /// Button New folder click event.
        /// Create a new folder on current directory.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            var frmNewFolder = new FrmNewFolder(txtCurrDir.Text, FtpClient);
            frmNewFolder.ShowDialog();
            GridMethodControl.GetDirectory(gclServer, FtpClient, gvwServer, txtCurrDir.Text);
            GridMethodControl.FindFocusedRow(gvwServer, ServerConstant.Filename);
            // ReSharper disable once InvertIf
            if (ServerConstant.CheckNewEvironment)
            {
                GridMethodControl.AddNewMessage(gclMessage, gvwMessage, ServerConstant.Message);
                ServerConstant.CheckNewEvironment = false;
            }
        }

        /// <summary>
        /// Button Information click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            var frmInfo = new FrmInfo();frmInfo.ShowDialog();
        }
    }
}
