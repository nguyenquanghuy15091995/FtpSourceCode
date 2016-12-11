using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FTP_Modern_UI.FTPClass
{
    // ReSharper disable once InconsistentNaming
    public class FTPLibrary
    {
        #region "FTP client class"
        /// <summary>
        /// A wrapper class for FTP.
        /// </summary>
        /// <remarks>
        /// This class does not hold open an FTP connection but
        /// instead is stateless: for each FTP request it
        /// connects, performs the request and disconnects.
        /// </remarks>
        // ReSharper disable once InconsistentNaming
        public class FTPclient
        {
            #region Delegated & Events
            //Download Progress Changed Event
            public delegate void DownloadProgressChangedHandler(object sender, DownloadProgressChangedArgs e);
            public event DownloadProgressChangedHandler OnDownloadProgressChanged;

            //Download Completed Event
            public delegate void DownloadCompletedHandler(object sender, DownloadCompletedArgs e);
            public event DownloadCompletedHandler OnDownloadCompleted;


            //Upload Progress Changed Event
            //Download Progress Changed Event
            public delegate void UploadProgressChangedHandler(object sender, UploadProgressChangedArgs e);
            public event UploadProgressChangedHandler OnUploadProgressChanged;

            //Upload Completed Event
            public delegate void UploadCompletedHandler(object sender, UploadCompletedArgs e);
            public event UploadCompletedHandler OnUploadCompleted;
            #endregion

            #region "CONSTRUCTORS"
            /// <summary>
            /// Blank constructor
            /// </summary>
            /// <remarks>Hostname, username and password must be set manually</remarks>
            public FTPclient()
            {
            }

            /// <summary>
            /// Constructor just taking the hostname
            /// </summary>
            /// <param name="hostname">in either 127.0.0.1 form</param>
            /// <remarks></remarks>
            public FTPclient(string hostname)
            {
                Hostname = hostname;
            }

            /// <summary>
            /// Constructor taking hostname, username and password
            /// </summary>
            /// <param name="hostname">in either 127.0.0.1 form</param>
            /// <param name="username">Leave blank to use but set password</param>
            /// <param name="password"></param>
            /// <remarks></remarks>
            public FTPclient(string hostname, string username, string password)
            {
                Hostname = hostname;
                _username = username;
                Password = password;
            }
            #endregion

            #region "Directory functions"
            /// <summary>
            /// Return a simple directory listing
            /// </summary>
            /// <param name="directory">Directory to list, e.g. /pub</param>
            /// <returns>A list of filenames and directories as a List(of String)</returns>
            /// <remarks>For a detailed directory listing, use ListDirectoryDetail</remarks>
            public List<string> ListDirectory(string directory)
            {
                //return a simple list of filenames in directory
                var ftp = GetRequest(GetDirectory(directory));
                //Set request to do simple list
                ftp.Method = WebRequestMethods.Ftp.ListDirectory;
                //Give Message of Command

                string str = GetStringResponse(ftp);
                //replace CRLF to CR, remove last instance
                str = str.Replace("\r\n", "\r").TrimEnd('\r');
                //split the string into a list
                List<string> result = new List<string>();
                result.AddRange(str.Split('\r'));
                return result;
            }

            /// <summary>
            /// Return a detailed directory listing
            /// </summary>
            /// <param name="directory">Directory to list, e.g. /pub/etc</param>
            /// <returns>An FTPDirectory object</returns>
            public FTPdirectory ListDirectoryDetail(string directory)
            {
                var ftp = GetRequest(GetDirectory(directory));
                //Set request to do simple list
                ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                //Give Message of Command 
                string str = GetStringResponse(ftp);
                //replace CRLF to CR, remove last instance
                str = str.Replace("\r\n", "\r").TrimEnd('\r');
                //split the string into a list
                return new FTPdirectory(str, _lastDirectory);
            }

            #endregion

            #region "Upload: File transfer TO ftp server"
            /// <summary>
            /// Copy a local file to the FTP server
            /// </summary>
            /// <param name="localFilename">Full path of the local file</param>
            /// <param name="targetFilename">Target filename, if required</param>
            /// <returns></returns>
            /// <remarks>If the target filename is blank, the source filename is used
            /// (assumes current directory). Otherwise use a filename to specify a name
            /// or a full path and filename if required.</remarks>
            public bool Upload(string localFilename, string targetFilename)
            {
                //1. check source
                if (!File.Exists(localFilename))
                {
                    throw (new ApplicationException("File " + localFilename + " not found"));
                }
                //copy to FI
                var fi = new FileInfo(localFilename);
                return Upload(fi, targetFilename);
            }

            #region Upload Variables

            public FtpWebRequest UploadFtpRequest { get; set; }
            public FileStream UploadFileStream { get; private set; }
            public Stream UploadStream { get; private set; }
            public bool UploadCanceled { get; private set; }
            public FileInfo UploadFileInfo { get; private set; }

            #endregion

            /// <summary>
            /// Upload a local file to the FTP server
            /// </summary>
            /// <param name="fi">Source file</param>
            /// <param name="targetFilename">Target filename (optional)</param>
            /// <returns></returns>
            public bool Upload(FileInfo fi, string targetFilename)
            {
                //copy the file specified to target file: target file can be full path or just filename (uses current dir)

                //1. check target
                string target;
                if (targetFilename.Trim() == "")
                {
                    //Blank target: use source filename & current dir
                    target = CurrentDirectory + fi.Name;
                }
                else if (targetFilename.Contains("/"))
                {
                    //If contains / treat as a full path
                    target = AdjustDir(targetFilename);
                }
                else
                {
                    //otherwise treat as filename only, use current directory
                    target = CurrentDirectory + targetFilename;
                }

                string uri = Hostname + target;
                //perform copy
                UploadFtpRequest = GetRequest(uri);

                //Set request to upload a file in binary
                UploadFtpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                UploadFtpRequest.UseBinary = true;
                //Notify FTP of the expected size
                UploadFtpRequest.ContentLength = fi.Length;
                UploadFileInfo = fi;

                //create byte array to store: ensure at least 1 byte!
                const int bufferSize = 2048;
                var content = new byte[bufferSize - 1 + 1];

                //open file for reading
                using (UploadFileStream = fi.OpenRead())
                {
                    try
                    {
                        //open request to send
                        var totalBytesUploaded = 0;
                        var fileSize = fi.Length;

                        using (UploadStream = UploadFtpRequest.GetRequestStream())
                        {

                            //Get File Size
                            int dataRead;
                            do
                            {
                                if (UploadCanceled)
                                {
                                    UploadCanceled = false;
                                    return false;
                                }

                                dataRead = UploadFileStream.Read(content, 0, bufferSize);
                                UploadStream.Write(content, 0, dataRead);
                                totalBytesUploaded += dataRead;
                                //Declare Event
                                var downloadProgress = new UploadProgressChangedArgs(totalBytesUploaded, fileSize);

                                //Progress changed, Raise the event.
                                // ReSharper disable once PossibleNullReferenceException
                                OnUploadProgressChanged(this, downloadProgress);

                                Application.DoEvents();
                            } while (!(dataRead < bufferSize));

                            //Declare Event
                            var args = new UploadCompletedArgs("Successful", true);
                            //Raise Event
                            // ReSharper disable once PossibleNullReferenceException
                            OnUploadCompleted(this, args);

                            UploadStream.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        //Declare Event
                        var args = new UploadCompletedArgs("Error: " + ex.Message, false);
                        //Raise Event
                        // ReSharper disable once PossibleNullReferenceException
                        OnUploadCompleted(this, args);
                    }
                    finally
                    {
                        //ensure file closed
                        UploadFileStream.Close();
                    }

                }


                UploadFtpRequest = null;
                return true;

            }

            public void CancelUpload(string uploadFileName)
            {
                if (UploadFileStream == null) return;
                UploadFileStream.Close();
                UploadFtpRequest.Abort();
                //UploadFileInfo.Delete();
                UploadCanceled = true;
                UploadFtpRequest = null;
                FtpDelete(uploadFileName);
            }
            #endregion

            #region "Download: File transfer FROM ftp server"

            /// <summary>
            /// Copy a file from FTP server to local
            /// </summary>
            /// <param name="sourceFilename">Target filename, if required</param>
            /// <param name="localFilename">Full path of the local file</param>
            /// <param name="permitOverwrite"/>
            /// <returns></returns>
            /// <remarks>Target can be blank (use same filename), or just a filename
            /// (assumes current directory) or a full path and filename</remarks>
            public bool Download(string sourceFilename, string localFilename, bool permitOverwrite)
            {
                //2. determine target file
                var fi = new FileInfo(localFilename);
                return Download(sourceFilename, fi, permitOverwrite);
            }

            //Version taking an FtpFileInfo
            public bool Download(FTPfileInfo file, string localFilename, bool permitOverwrite)
            {
                return Download(file.FullName, localFilename, permitOverwrite);
            }

            //Another version taking FtpFileInfo and FileInfo
            public bool Download(FTPfileInfo file, FileInfo localFi, bool permitOverwrite)
            {
                return Download(file.FullName, localFi, permitOverwrite);
            }

            #region Download Variables
            FtpWebRequest _downloadFtpRequest;
            FtpWebResponse _downloadResponse;
            Stream _downloadResponseStream;
            FileStream _downloadFileStream;
            FileInfo _targetFileInfo;
            bool _downloadCanceled;
            #endregion
            //Version taking string/FileInfo
            public bool Download(string sourceFilename, FileInfo targetFi, bool permitOverwrite)
            {
                //1. check target
                if (targetFi.Exists && !(permitOverwrite))
                {
                    throw (new ApplicationException("Target file already exists"));               
                }

                //2. check source
                string target;
                if (sourceFilename.Trim() == "")
                {
                    throw (new ApplicationException("File not specified"));
                }
                if (sourceFilename.Contains("/"))
                {
                    //treat as a full path
                    target = AdjustDir(sourceFilename);
                }
                else
                {
                    //treat as filename only, use current directory
                    target = CurrentDirectory + sourceFilename;
                }

                var uri = Hostname + target;

                //3. perform copy
                _downloadFtpRequest = GetRequest(uri);

                //Set request to download a file in binary mode
                _downloadFtpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                _downloadFtpRequest.UseBinary = true;
                _targetFileInfo = targetFi;
                //open request and get response stream
                using (_downloadResponse = (FtpWebResponse)_downloadFtpRequest.GetResponse())
                {
                    using (_downloadResponseStream = _downloadResponse.GetResponseStream())
                    {
                        //System.Security.AccessControl.FileSecurity fileSecurity = new System.Security.AccessControl.FileSecurity(targetFI.FullName, System.Security.AccessControl.AccessControlSections.All);
                        //targetFI.SetAccessControl(fileSecurity);
                        //loop to read & write to file
                        using (_downloadFileStream = new FileStream(targetFi.FullName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                        {
                            try
                            {
                                var buffer = new byte[2048];
                                int read;
                                var totalBytesRead = 0;
                                var fileSize = GetFileSize(sourceFilename);
                                _downloadCanceled = false;
                                do
                                {
                                    if (_downloadCanceled)
                                    {

                                        _downloadCanceled = false;
                                        return false;
                                    }

                                    // ReSharper disable once PossibleNullReferenceException
                                    read = _downloadResponseStream.Read(buffer, 0, buffer.Length);
                                    _downloadFileStream.Write(buffer, 0, read);
                                    totalBytesRead += read;
                                    //Declare Event
                                    var downloadProgress = new DownloadProgressChangedArgs(totalBytesRead, fileSize);

                                    //Progress changed, Raise the event.
                                    // ReSharper disable once PossibleNullReferenceException
                                    OnDownloadProgressChanged(this, downloadProgress);

                                    Application.DoEvents();

                                } while (read != 0);

                                //Declare Event
                                var args = new DownloadCompletedArgs("Successful", true);
                                //Raise Event
                                // ReSharper disable once PossibleNullReferenceException
                                OnDownloadCompleted(this, args);

                                _downloadResponseStream.Close();
                                _downloadFileStream.Flush();
                                _downloadFileStream.Close();
                                _downloadFileStream = null;
                                _downloadResponseStream = null;
                            }
                            catch (Exception ex)
                            {
                                //catch error and delete file only partially downloaded
                                // ReSharper disable once PossibleNullReferenceException
                                _downloadFileStream.Close();
                                //delete target file as it's incomplete
                                targetFi.Delete();

                                //Decalre Event for Error
                                var downloadCompleted = new DownloadCompletedArgs("Error: " + ex.Message, false);
                                //Raise Event
                                // ReSharper disable once PossibleNullReferenceException
                                OnDownloadCompleted(this, downloadCompleted);
                            }
                        }
                        if (_downloadFileStream != null)
                            // ReSharper disable once PossibleNullReferenceException
                            _downloadResponseStream.Close();
                    }
                    if (_downloadFileStream != null)
                        _downloadResponse.Close();
                }
                return true;
            }

            public void CancelDownload()
            {
                if (_downloadFileStream == null) return;
                _downloadFileStream.Close();

                _downloadFtpRequest.Abort();

                _downloadResponse.Close();
                _downloadResponseStream.Close();
                //DownloadFileStream = null;
                //DownloadResponseStream = null;
                _targetFileInfo.Delete();
                _downloadCanceled = true;
            }
            #endregion

            #region "Other functions: Delete rename etc."
            /// <summary>
            /// Delete remote file
            /// </summary>
            /// <param name="filename">filename or full path</param>
            /// <returns></returns>
            /// <remarks></remarks>
            public bool FtpDelete(string filename)
            {
                //Determine if file or full path
                var uri = Hostname + GetFullPath(filename);

                var ftp = GetRequest(uri);
                //Set request to delete
                ftp.Method = WebRequestMethods.Ftp.DeleteFile;
                try
                {
                    //get response but ignore it
                    // ReSharper disable once UnusedVariable
                    var str = GetStringResponse(ftp);
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }

            /// <summary>
            /// Determine if file exists on remote FTP site
            /// </summary>
            /// <param name="filename">Filename (for current dir) or full path</param>
            /// <returns></returns>
            /// <remarks>Note this only works for files</remarks>
            public bool FtpFileExists(string filename)
            {
                //Try to obtain filesize: if we get error msg containing "550"
                //the file does not exist
                try
                {
                    // ReSharper disable once UnusedVariable
                    var size = GetFileSize(filename);
                    return true;

                }
                catch (Exception ex)
                {
                    //only handle expected not-found exception
                    if (ex is WebException)
                    {
                        //file does not exist/no rights error = 550
                        if (ex.Message.Contains("550"))
                        {
                            //clear
                            return false;
                        }
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            /// <summary>
            /// Determine size of remote file
            /// </summary>
            /// <param name="filename"></param>
            /// <returns></returns>
            /// <remarks>Throws an exception if file does not exist</remarks>
            public long GetFileSize(string filename)
            {
                string path;
                if (filename.Contains("/"))
                {
                    path = AdjustDir(filename);
                }
                else
                {
                    path = CurrentDirectory + filename;
                }
                var uri = Hostname + path;
                var ftp = GetRequest(uri);
                //Try to get info on file/dir?
                ftp.Method = WebRequestMethods.Ftp.GetFileSize;
                // ReSharper disable once UnusedVariable
                var tmp = GetStringResponse(ftp);
                return GetSize(ftp);
            }

            /// <summary>
            /// Rename a file on server.
            /// </summary>
            /// <param name="sourceFilename">old file name.</param>
            /// <param name="newName">new file name.</param>
            /// <returns></returns>
            public bool FtpRename(string sourceFilename, string newName)
            {
                //Does file exist?
                var source = GetFullPath(sourceFilename);
                if (!FtpFileExists(source))
                {
                    throw (new FileNotFoundException("File " + source + " not found"));
                }

                //build target name, ensure it does not exist
                var target = GetFullPath(newName);
                if (target == source)
                {
                    throw (new ApplicationException("Source and target are the same"));
                }
                if (FtpFileExists(target))
                {
                    throw (new ApplicationException("Target file " + target + " already exists"));
                }

                //perform rename
                var uri = Hostname + source;

                var ftp = GetRequest(uri);
                //Set request to delete
                ftp.Method = WebRequestMethods.Ftp.Rename;
                ftp.RenameTo = target;
                try
                {
                    //get response but ignore it
                    // ReSharper disable once UnusedVariable
                    var str = GetStringResponse(ftp);
                    
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }

            public bool FtpCreateDirectory(string dirpath)
            {
                //perform create
                var uri = Hostname + AdjustDir(dirpath);
                var ftp = GetRequest(uri);
                //Set request to MkDir
                ftp.Method = WebRequestMethods.Ftp.MakeDirectory;
                try
                {
                    //get response but ignore it
                    // ReSharper disable once UnusedVariable
                    var ftpgr = (FtpWebResponse)ftp.GetResponse();

                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }

            public bool FtpDeleteDirectory(string dirpath)
            {
                //perform remove
                var uri = Hostname + AdjustDir(dirpath);
                var ftp = GetRequest(uri);
                //Set request to RmDir
                ftp.Method = WebRequestMethods.Ftp.RemoveDirectory;
                try
                {
                    //get response but ignore it
                    // ReSharper disable once UnusedVariable
                    var str = GetStringResponse(ftp);
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            #endregion

            #region "private supporting fns"
            //Get the basic FtpWebRequest object with the
            //common settings and security
            private FtpWebRequest GetRequest(string uri)
            {
                //create request
                // ReSharper disable once AccessToStaticMemberViaDerivedType
                var result = (FtpWebRequest)FtpWebRequest.Create(uri);
                //Set the login details
                result.Credentials = GetCredentials();
                //Do not keep alive (stateless mode)
                result.KeepAlive = false;
                return result;
            }


            /// <summary>
            /// Get the credentials from username/password
            /// </summary>
            private ICredentials GetCredentials()
            {
                return new NetworkCredential(Username, Password);
            }

            /// <summary>
            /// returns a full path using CurrentDirectory for a relative file reference
            /// </summary>
            private string GetFullPath(string file)
            {
                if (file.Contains("/"))
                {
                    return AdjustDir(file);
                }
                return CurrentDirectory + file;
            }

            /// <summary>
            /// Amend an FTP path so that it always starts with /
            /// </summary>
            /// <param name="path">Path to adjust</param>
            /// <returns></returns>
            /// <remarks></remarks>
            private string AdjustDir(string path)
            {
                return ((path.StartsWith("/")) ? "" : "/") + path;
            }

            private string GetDirectory(string directory)
            {
                string uri;
                if (directory == "")
                {
                    //build from current
                    uri = Hostname + CurrentDirectory;
                    _lastDirectory = CurrentDirectory;
                }
                else
                {
                    if (!directory.StartsWith("/"))
                    {
                        throw (new ApplicationException("Directory should start with /"));
                    }
                    uri = Hostname + directory;
                    _lastDirectory = directory;
                }
                return uri;
            }

            //stores last retrieved/set directory
            private string _lastDirectory = "";

            /// <summary>
            /// Obtains a response stream as a string
            /// </summary>
            /// <param name="ftp">current FTP request</param>
            /// <returns>String containing response</returns>
            /// <remarks>FTP servers typically return strings with CR and
            /// not CRLF. Use respons.Replace(vbCR, vbCRLF) to convert
            /// to an MSDOS string</remarks>
            private string GetStringResponse(FtpWebRequest ftp = null)
            {
                if (ftp == null) throw new ArgumentNullException(nameof(ftp));
                //Get the result, streaming to a string
                string result;
                using (var response = (FtpWebResponse)ftp.GetResponse())
                {
                    using (var datastream = response.GetResponseStream())
                    {
                        // ReSharper disable once AssignNullToNotNullAttribute
                        using (var sr = new StreamReader(datastream))
                        {
                            WelcomeMessage = response.WelcomeMessage;
                            ExitMessage = response.ExitMessage;
                            result = sr.ReadToEnd();
                            sr.Close();
                        }

                        // ReSharper disable once PossibleNullReferenceException
                        datastream.Close();
                    }
                    response.Close();
                }
                return result;
            }

            /// <summary>
            /// Gets the size of an FTP request
            /// </summary>
            /// <param name="ftp"></param>
            /// <returns></returns>
            /// <remarks></remarks>
            private long GetSize(FtpWebRequest ftp)
            {
                long size;
                using (FtpWebResponse response = (FtpWebResponse)ftp.GetResponse())
                {
                    size = response.ContentLength;
                    response.Close();
                }

                return size;
            }
            #endregion

            #region "Properties"

            /// <summary>
            /// Hostname </summary>
            /// <value></value>
            /// <remarks>Hostname can be in either the full URL format
            /// ftp://ftp.myhost.com or just ftp.myhost.com
            /// </remarks>
            public string Hostname { get; set; }
            private string _username;
            /// <summary>
            /// Username property
            /// </summary>
            /// <value></value>
            /// <remarks>Can be left blank, in which case '' is returned</remarks>
            public string Username
            {
                get
                {
                    return (_username == "" ? "" : _username);
                }
                set
                {
                    _username = value;
                }
            }

            public string Password { get; set; }

            /// <summary>
            /// The CurrentDirectory value
            /// </summary>
            /// <remarks>Defaults to the root '/'</remarks>
            private string _currentDirectory = "/";
            public string CurrentDirectory
            {
                get
                {
                    //return directory, ensure it ends with /
                    return _currentDirectory + ((_currentDirectory.EndsWith("/")) ? "" : "/");
                }
                set
                {
                    if (!value.StartsWith("/"))
                    {
                        throw (new ApplicationException("Directory should start with /"));
                    }
                    _currentDirectory = value;
                }
            }


            #endregion

            #region Server Messages

            public string WelcomeMessage { get; set; }

            public string ExitMessage { get; set; }

            #endregion

        }
        #endregion

        #region "FTP file info class"
        /// <summary>
        /// Represents a file or directory entry from an FTP listing
        /// </summary>
        /// <remarks>
        /// This class is used to parse the results from a detailed
        /// directory list from FTP. It supports most formats of
        /// </remarks>
        // ReSharper disable once InconsistentNaming
        public class FTPfileInfo
        {

            //Stores extended info about FTP file

            #region "Properties"
            public string FullName => Path + Filename;
            public string Filename { get; }

            public string Path { get; }

            public DirectoryEntryTypes FileType { get; }

            public long Size => _size;
            public DateTime FileDateTime { get; }

            public string Permission { get; }

            public string Extension
            {
                get
                {
                    var i = Filename.LastIndexOf(".", StringComparison.Ordinal);
                    if (i >= 0 && i < (Filename.Length - 1))
                    {
                        return Filename.Substring(i + 1);
                    }
                    return "";
                }
            }
            public string NameOnly
            {
                get
                {
                    var i = Filename.LastIndexOf(".", StringComparison.Ordinal);
                    return i > 0 ? Filename.Substring(0, i) : Filename;
                }
            }

            private readonly long _size;

            #endregion

            /// <summary>
            /// Identifies entry as either File or Directory
            /// </summary>
            public enum DirectoryEntryTypes
            {
                File,
                Directory
            }

            /// <summary>
            /// Constructor taking a directory listing line and path
            /// </summary>
            /// <param name="line">The line returned from the detailed directory list</param>
            /// <param name="path">Path of the directory</param>
            /// <remarks></remarks>
            public FTPfileInfo(string line, string path)
            {
                //parse line
                // ReSharper disable once DoNotCallOverridableMethodsInConstructor
                var m = GetMatchingRegex(line);
                if (m == null)
                {
                    //failed
                    throw (new ApplicationException("Unable to parse line: " + line));
                }
                Filename = m.Groups["name"].Value;
                Path = path;

                Int64.TryParse(m.Groups["size"].Value, out _size);
                //_size = System.Convert.ToInt32(m.Groups["size"].Value);

                Permission = m.Groups["permission"].Value;
                var dir = m.Groups["dir"].Value;
                if (dir != "" && dir != "-")
                {
                    FileType = DirectoryEntryTypes.Directory;
                }
                else
                {
                    FileType = DirectoryEntryTypes.File;
                }

                try
                {
                    FileDateTime = DateTime.Parse(m.Groups["timestamp"].Value);
                }
                catch (Exception)
                {
                    FileDateTime = Convert.ToDateTime(null);
                }
            }

            protected virtual Match GetMatchingRegex(string line)
            {
                for (var i = 0; i <= ParseFormats.Length - 1; i++)
                {
                    var rx = new Regex(ParseFormats[i]);
                    var m = rx.Match(line);
                    if (m.Success)
                    {
                        return m;
                    }
                }
                return null;
            }

            #region "Regular expressions for parsing LIST results"
            /// <summary>
            /// List of REGEX formats for different FTP server listing formats
            /// </summary>
            /// <remarks>
            /// The first three are various UNIX/LINUX formats, fourth is for MS FTP
            /// in detailed mode and the last for MS FTP in 'DOS' mode.
            /// I wish VB.NET had support for Const arrays like C# but there you go
            /// </remarks>
            private static readonly string[] ParseFormats = {
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})\\s+\\d+\\s+\\w+\\s+\\w+\\s+(?<size>\\d+)\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{4})\\s+(?<name>.+)",
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})\\s+\\d+\\s+\\d+\\s+(?<size>\\d+)\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{4})\\s+(?<name>.+)",
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})\\s+\\d+\\s+\\d+\\s+(?<size>\\d+)\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{1,2}:\\d{2})\\s+(?<name>.+)",
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})\\s+\\d+\\s+\\w+\\s+\\w+\\s+(?<size>\\d+)\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{1,2}:\\d{2})\\s+(?<name>.+)",
            "(?<dir>[\\-d])(?<permission>([\\-r][\\-w][\\-xs]){3})(\\s+)(?<size>(\\d+))(\\s+)(?<ctbit>(\\w+\\s\\w+))(\\s+)(?<size2>(\\d+))\\s+(?<timestamp>\\w+\\s+\\d+\\s+\\d{2}:\\d{2})\\s+(?<name>.+)",
            "(?<timestamp>\\d{2}\\-\\d{2}\\-\\d{2}\\s+\\d{2}:\\d{2}[Aa|Pp][mM])\\s+(?<dir>\\<\\w+\\>){0,1}(?<size>\\d+){0,1}\\s+(?<name>.+)" };
            #endregion
        }
        #endregion

        #region "FTP Directory class"
        /// <summary>
        /// Stores a list of files and directories from an FTP result
        /// </summary>
        /// <remarks></remarks>
        // ReSharper disable once InconsistentNaming
        public class FTPdirectory : List<FTPfileInfo>
        {


            public FTPdirectory()
            {
                //creates a blank directory listing
            }

            /// <summary>
            /// Constructor: create list from a (detailed) directory string
            /// </summary>
            /// <param name="dir">directory listing string</param>
            /// <param name="path"></param>
            /// <remarks></remarks>
            public FTPdirectory(string dir, string path)
            {
                foreach (var line in dir.Replace("\n", "").Split(Convert.ToChar('\r')))
                {
                    if (line != "")
                    {
                        Add(new FTPfileInfo(line, path));
                    }
                }
            }

            /// <summary>
            /// Filter out only files from directory listing
            /// </summary>
            /// <param name="ext">optional file extension filter</param>
            /// <returns>FTPdirectory listing</returns>
            public FTPdirectory GetFiles(string ext)
            {
                return GetFileOrDir(FTPfileInfo.DirectoryEntryTypes.File, ext);
            }

            /// <summary>
            /// Returns a list of only subdirectories
            /// </summary>
            /// <returns>FTPDirectory list</returns>
            /// <remarks></remarks>
            public FTPdirectory GetDirectories()
            {
                return GetFileOrDir(FTPfileInfo.DirectoryEntryTypes.Directory, "");
            }

            //internal: share use function for GetDirectories/Files
            private FTPdirectory GetFileOrDir(FTPfileInfo.DirectoryEntryTypes type, string ext)
            {
                var result = new FTPdirectory();
                foreach (var fi in this.Where(fi => fi.FileType == type))
                {
                    if (ext == "")
                    {
                        result.Add(fi);
                    }
                    else if (ext == fi.Extension)
                    {
                        result.Add(fi);
                    }
                }
                return result;

            }

            public bool FileExists(string filename)
            {
                return this.Any(ftpfile => ftpfile.Filename == filename);
            }

            private const char Slash = '/';

            public static string GetParentDirectory(string dir)
            {
                var tmp = dir.TrimEnd(Slash);
                var i = tmp.LastIndexOf(Slash);
                if (i > 0)
                {
                    return tmp.Substring(0, i - 1);
                }
                throw (new ApplicationException("No parent for root"));
            }
        }
        #endregion

        #region Events
        public class DownloadProgressChangedArgs : EventArgs
        {
            //Private Members
            // ReSharper disable once FieldCanBeMadeReadOnly.Local
            // ReSharper disable once FieldCanBeMadeReadOnly.Local

            //Constructor
            public DownloadProgressChangedArgs(long bytesDownload, long totleBytes)
            {
                BytesDownloaded = bytesDownload;
                TotleBytes = totleBytes;
            }

            //Public Members
            public long BytesDownloaded { get; }
            public long TotleBytes { get; }
        }

        public class DownloadCompletedArgs : EventArgs
        {
            //Private Members

            //Constructor
            public DownloadCompletedArgs(string status, bool completed)
            {
                DownloadCompleted = completed;
                DownloadStatus = status;
            }

            //Public Members
            public string DownloadStatus { get; }
            public bool DownloadCompleted { get; }
        }

        public class NewMessageEventArgs : EventArgs
        {
            //Private Members

            //Constructor
            public NewMessageEventArgs(string type, string status, string code)
            {
                StatusMessage = status;
                StatusCode = code;
                StatusType = type;
            }

            //Public Members
            public string StatusMessage { get; }
            public string StatusCode { get; }
            public string StatusType { get; }
        }

        public class UploadProgressChangedArgs : EventArgs
        {
            //Private Members

            //Constructor
            public UploadProgressChangedArgs(long bytesUpload, long totleBytes)
            {
                BytesUploaded = bytesUpload;
                TotleBytes = totleBytes;
            }

            //Public Members
            public long BytesUploaded { get; }
            public long TotleBytes { get; }
        }

        public class UploadCompletedArgs : EventArgs
        {
            //Private Members

            //Constructor
            public UploadCompletedArgs(string status, bool completed)
            {
                UploadCompleted = completed;
                UploadStatus = status;
            }

            //Public Members
            public string UploadStatus { get; }
            public bool UploadCompleted { get; }
        }
        #endregion
    }
}
