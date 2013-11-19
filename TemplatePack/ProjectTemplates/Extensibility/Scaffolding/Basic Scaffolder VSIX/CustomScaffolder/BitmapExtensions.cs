using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace $safeprojectname$ {
    internal static class BitmapExtensions {
        public static ImageSource ToImageSource(this Bitmap bitmap) {
            if (bitmap == null) {
                throw new ArgumentNullException("bitmap");
            }

            using (MemoryStream stream = new MemoryStream()) {
                bitmap.Save(stream, ImageFormat.Png);

                stream.Position = 0;

                BitmapImage result = new BitmapImage();
                result.BeginInit();

                // This option is required to force an eager load from the stream
                result.CacheOption = BitmapCacheOption.OnLoad;
                result.StreamSource = stream;

                // Forces a load
                result.EndInit();

                if (result.CanFreeze) {
                    result.Freeze();
                }
                else {
                    // This is just here to prevent introducing bugs sharing copies of this object.
                    Contract.Assert(false, "The bitmapsource should be freezable.");
                }

                return result;
            }
        }
    }
}
