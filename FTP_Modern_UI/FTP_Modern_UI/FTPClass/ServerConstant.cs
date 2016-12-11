using System.Text.RegularExpressions;

namespace FTP_Modern_UI.FTPClass
{
    /// <summary>
    /// ServerConstant to remember Server, Username, Password.
    /// </summary>
    public class ServerConstant
    {
        /// <summary>
        /// To remember Server name.
        /// </summary>
        public static string Protocol = @"ftp://";

        /// <summary>
        /// To remember Server name.
        /// </summary>
        public static string Server = "";

        /// <summary>
        /// To remember Username.
        /// </summary>
        public static string Username = "";

        /// <summary>
        /// To remember Password.
        /// </summary>
        public static string Password = "";

        /// <summary>
        /// Get full server + Protocol.
        /// </summary>
        /// <returns>A perfect server name.</returns>
        public static string GetFullServer()
        {
            var part = Regex.Split(Server, Protocol);
            if(part.Length > 2)
            {
                return "";
            }
            return Protocol + part[part.Length - 1];
        }

        /// <summary>
        /// A message for grid view message.
        /// </summary>
        public static string Message = "";

        /// <summary>
        /// Check server is a new or current server.
        /// </summary>
        public static bool CheckNewEvironment = false;

        /// <summary>
        /// Remember server connected or not connected. 
        /// </summary>
        public static bool IsConnect = false;

        /// <summary>
        /// Remember new file name after drename or create new folder.
        /// </summary>
        public static string Filename = "";
    }
}
