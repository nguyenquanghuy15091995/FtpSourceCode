using System;
using System.Net;
using MetroFramework;
using System.Windows.Forms;

namespace FTP_Modern_UI.FTPClass
{
    /// <summary>
    /// This is Extend FTP Method.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class FTPLibraryExtended
    {
        /// <summary>
        /// This is rename file method.
        /// </summary>
        /// <param name="currentFileNameAndPath">the old file name.</param>
        /// <param name="newFileName">the new file name.</param>
        /// <param name="frmRename">The form rename.</param>
        public void Rename(string currentFileNameAndPath, string newFileName, FrmRename frmRename)
        {
            try
            {
                /* Create an FTP Request */
                var ftpRequest = (FtpWebRequest)WebRequest.Create(ServerConstant.GetFullServer() + "/" + currentFileNameAndPath);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(ServerConstant.Username, ServerConstant.Password);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                /* Rename the File */
                ftpRequest.RenameTo = newFileName;
                /* Establish Return Communication with the FTP Server */
                var ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Resource Cleanup */
                ftpResponse.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(frmRename, ex.Message, @"Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }
    }
}
