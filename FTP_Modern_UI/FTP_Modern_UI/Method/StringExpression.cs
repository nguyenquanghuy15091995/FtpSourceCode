using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace FTP_Modern_UI.Method
{
    /// <summary>
    /// Set format of string.
    /// </summary>
    public class StringExpression
    {
        /// <summary>
        /// Check file name.
        /// </summary>
        /// <param name="fileName">the name of file.</param>
        /// <returns>valid or ilvalid.</returns>
        public static bool CheckFileName(string fileName)
        {
            const string pattern = "[\\]|[/]|[:]|[?]|[<]|[>]|[|]|[\"]";
            var match = Regex.Match(fileName, pattern);
            return !match.Success;
        }

        /// <summary>
        /// Get file name without the extension.
        /// </summary>
        /// <param name="fileName">the file name.</param>
        /// <returns>a file name without the extension.</returns>
        public static string GetFileNameWithoutType(string fileName)
        {
            var partStr = fileName.Split('.');
            var result = partStr[0];
            for (var i = 1; i < partStr.Length - 1; i++)
            {
                result += "." + partStr[i];
            }
            return result;
        }

        /// <summary>
        /// Get the extension of file.
        /// </summary>
        /// <param name="fileName">file name.</param>
        /// <param name="extend">extend.</param>
        /// <returns>the extension.</returns>
        public static string GetFileType(string fileName, string extend)
        {
            var partStr = fileName.Split('.');
            return partStr.Length < 2 ? extend : partStr[partStr.Length - 1];
        }

        /// <summary>
        /// config the name of file.
        /// </summary>
        /// <param name="fileName">file name.</param>
        /// <param name="type">file or folder.</param>
        /// <returns>a file name use for download and upload.</returns>
        public static string ConfigFileName(string fileName, string type)
        {
            var result = fileName.TrimEnd();
            const string pattern = @"\(\d+\)";
            var partStr = Regex.Split(fileName, pattern);
            var match = Regex.Matches(fileName, pattern);
            if (match.Count < 1)
            {
                return result + @" (0)." + type;
            }
            var temp = 0;
            var number = Regex.Match(match[match.Count - 1].Value, @"\d+");
            if (!number.Success) return result;
            result = partStr.Aggregate("", (current, part) => current + part);
            if (number.Value != "") temp = Convert.ToInt32(number.Value) + 1;
            result += @" (" + temp + @")";

            if (!type.Equals(@"Folder")) result += "." + type;

            return result;
        }
    }
}
