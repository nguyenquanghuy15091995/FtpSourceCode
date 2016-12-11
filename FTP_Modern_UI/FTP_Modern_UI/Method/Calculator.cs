using System.Globalization;

namespace FTP_Modern_UI.Method
{
    public class Calculator
    {
        /// <summary>
        /// change size.
        /// </summary>
        /// <param name="byteCount">Byte</param>
        /// <returns>
        /// SetBytes(1024) 'returns "1 KB'.
        /// SetBytes(1048576) 'returns "1 MB'.
        /// SetBytes(1073741824) 'returns "1 GB'.
        /// </returns>
        public static string GetFileSize(double byteCount)
        {
            var size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                // ReSharper disable once UseStringInterpolation
                size = string.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                // ReSharper disable once UseStringInterpolation
                size = string.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                // ReSharper disable once UseStringInterpolation
                size = string.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString(CultureInfo.InvariantCulture) + " Bytes";

            return size;
        }
    }
}
