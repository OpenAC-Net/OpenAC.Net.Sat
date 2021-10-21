using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using OpenAC.Net.Core.Extensions;

namespace OpenAC.Net.Sat.Demo
{
    public static class Helpers
    {
        public static string OpenFile(string filters)
        {
            using var ofd = new OpenFileDialog();
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            ofd.Filter = filters;

            return ofd.ShowDialog().Equals(DialogResult.Cancel) ? null : ofd.FileName;
        }

        public static string SaveFile(string filename, string filter)
        {
            using var sfd = new SaveFileDialog();
            sfd.CheckPathExists = true;
            sfd.CheckFileExists = false;
            sfd.Filter = filter;
            sfd.FileName = filename;

            return sfd.ShowDialog().Equals(DialogResult.Cancel) ? null : sfd.FileName;
        }

        /// <summary>
        /// To the byte array.
        /// </summary>
        /// <param name="imageIn">The image in.</param>
        /// <param name="format">The format.</param>
        /// <returns>System.Byte[].</returns>
        public static byte[] ToByteArray(this Image imageIn, ImageFormat format = null)
        {
            if (imageIn == null) return null;

            format ??= imageIn.RawFormat;

            using var ms = new MemoryStream();
            imageIn.Save(ms, format);
            return ms.ToArray();
        }

        /// <summary>
        /// To the base64.
        /// </summary>
        /// <param name="imageIn">The image in.</param>
        /// <param name="format">The format.</param>
        /// <returns>System.String.</returns>
        public static string ToBase64(this Image imageIn, ImageFormat format = null)
        {
            if (imageIn == null) return string.Empty;
            var imgBytes = imageIn.ToByteArray(format);
            return imgBytes.ToBase64();
        }

        /// <summary>
        /// To the image.
        /// </summary>
        /// <param name="byteArrayIn">The byte array in.</param>
        /// <returns>Image.</returns>
        public static Image ToImage(this byte[] byteArrayIn)
        {
            if (byteArrayIn == null) return null;

            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
    }
}