using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Globalization;
using static FTP_Modern_UI.FTPClass.FTPLibrary;

namespace FTP_Modern_UI.Method
{
    /// <summary>
    /// use to contain Grid Control method.
    /// </summary>
    public class GridMethod
    {
        /// <summary>
        /// Clear the Grid view of server.
        /// </summary>
        /// <param name="gridControl">a grid control is handling</param>
        public void ClearGridView(GridControl gridControl)
        {
            gridControl.DataSource = null;
        }

        /// <summary>
        /// It's refresh Directory.
        /// </summary>
        /// <param name="gridControl">a grid control use to contain all Directory.</param>
        /// <param name="ftpClient">To call FTp method.</param>
        /// <param name="gridView">to view grid control file.</param>
        /// <param name="path">The link of Directory.</param>
        public void GetDirectory(GridControl gridControl, FTPclient ftpClient, GridView gridView, string path)
        {
            //Clear all items

            ClearGridView(gridControl);
            var dataTable = CreateDataTable();
            var firstRow = dataTable.NewRow();
            firstRow[0] = "...";
            firstRow[1] = "...";
            firstRow[2] = "...";
            firstRow[3] = "...";
            firstRow[4] = "...";

            dataTable.Rows.Add(firstRow);
            //Open and Display Root Directory
            foreach (var folder in ftpClient.ListDirectoryDetail(path))
            {

                var newRow = dataTable.NewRow();
                newRow[0] = folder.Filename;
                if (folder.FileType == FTPfileInfo.DirectoryEntryTypes.Directory)
                    newRow[1] = @"Folder";
                else
                    newRow[1] = @"File";

                newRow[2] = folder.FullName;        
                newRow[3] = folder.FileDateTime.ToShortTimeString() + " " + folder.FileDateTime.ToShortDateString();
                newRow[4] = Calculator.GetFileSize(folder.Size);

                dataTable.Rows.Add(newRow);
            }
            gridControl.DataSource = dataTable;

        }

        /// <summary>
        /// Create new a data table.
        /// </summary>
        /// <returns> a data table.</returns>
        // ReSharper disable once RedundantAssignment
        private DataTable CreateDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add(@"File Name");
            dataTable.Columns.Add(@"File Type");
            dataTable.Columns.Add(@"File Path");
            dataTable.Columns.Add(@"Date");
            dataTable.Columns.Add(@"Size");
            return dataTable;
        }

        /// <summary>
        /// Get the previous path.
        /// </summary>
        /// <param name="path">a current path.</param>
        /// <param name="ftpClient">To call FTP method.</param>
        /// <returns></returns>
        public string GetDirBack(string path, FTPclient ftpClient)
        {
            if (path.Equals(@"/")) return path;
            var temp = path.Split('/');
            path = "";
            for (var i = 0; i < temp.Length - 2; i++)
            {
                if (!temp[i].Equals(""))
                    path += @"/" + temp[i];
            }

            // ReSharper disable once RedundantAssignment
            path += @"/";
            return path;
        }

        /// <summary>
        /// Add message to grid view message.
        /// </summary>
        /// <param name="gridControl">a grid control.</param>
        /// <param name="gridView"> a grid view in grid control.</param>
        /// <param name="message">a message to show.</param>
        public void AddNewMessage(GridControl gridControl, GridView gridView, string message)
        {       
            var dataTable = new DataTable();
            dataTable.Columns.Add(@"Message");
            dataTable.Columns.Add(@"Date and Time");
            var currTime = DateTime.Now;
            DataRow newRow;
            for(var i = 0; i < gridView.RowCount; i++)
            {
                newRow = dataTable.NewRow();
                newRow[0] = gridView.GetDataRow(i)[0];
                newRow[1] = gridView.GetDataRow(i)[1];
                dataTable.Rows.Add(newRow);
            }
            newRow = dataTable.NewRow();
            newRow[0] = message;
            newRow[1] = currTime.ToString(CultureInfo.InstalledUICulture);
            dataTable.Rows.Add(newRow);
            ClearGridView(gridControl);
            gridControl.DataSource = dataTable;
        }

        /// <summary>
        /// Delete all file in folder before delete folder.
        /// </summary>
        /// <param name="gridControl">a grid control.</param>
        /// <param name="gridView">a grid view in grid control.</param>
        /// <param name="ftpClient">Call FTP method.</param>
        /// <param name="currDir">Current directory.</param>
        /// <param name="folderName">name of folder to delete.</param>
        public void DeleteAllFolderFile(GridControl gridControl, GridView gridView, FTPclient ftpClient, string currDir, string folderName)
        {   
            GetDirectory(gridControl, ftpClient, gridView, currDir);
            ftpClient.CurrentDirectory = currDir;
            var currCount = gridView.RowCount;
            while (currCount > 1)
            {   
                if (gridView.GetDataRow(currCount - 1)[1].ToString().Equals(@"Folder"))
                {
                    DeleteAllFolderFile(gridControl, gridView, ftpClient, currDir + gridView.GetDataRow(currCount - 1)[0] + "/",
                        gridView.GetDataRow(currCount - 1)[0].ToString());
                    GetDirectory(gridControl, ftpClient, gridView, currDir);
                    currCount = gridView.RowCount;
                    if (currCount <= 1)
                    {
                        break;
                    }
                    currCount--;
                }
                
                ftpClient.FtpDelete(gridView.GetDataRow(currCount - 1)[0].ToString());
                      
                currCount--;
            }      
            ftpClient.FtpDeleteDirectory(GetDirBack(currDir, ftpClient) + folderName);
        }

        /// <summary>
        /// Find the true focused row.
        /// </summary>
        /// <param name="gridView">a grid view in grid control.</param>
        /// <param name="rowHandleName">name of row handle.</param>
        public void FindFocusedRow(GridView gridView, string rowHandleName)
        {
            for (var i = 0; i < gridView.RowCount; i++)
            {
                if (!gridView.GetDataRow(i)[0].ToString().Equals(rowHandleName)) continue;
                gridView.FocusedRowHandle = i;
                return;
            }
        }
      
    }
}
