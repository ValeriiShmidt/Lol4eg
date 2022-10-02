using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

namespace Lol4eg
{
    public static class ImageGenerator
    {
        public static Bitmap GenerateImageByCityName(string cityName)
        {

            Bitmap outputImage = Resources.input_image;
            string firstLine = "Путин подписал указ об исключении " +
                                 cityName +
                                 " из состава";

            string secondLine = "Российской Федерации";

            PointF firstLocation = new PointF(40f, 308f);
            PointF secondLocation = new PointF(13f, 328f);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                using (Font font = new Font("Arial", 12))
                {
                    graphics.DrawString(firstLine, font, Brushes.Black, firstLocation);

                    graphics.DrawString(secondLine, font, Brushes.Black, secondLocation);
                }
            }

            return outputImage;
        }

        public static BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }
    }
}
