using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Lol4eg
{
    public partial class MainWindow : Window
    {
        public void TextBoxHandler(object sender, RoutedEventArgs e)
        {
            string cityName = CityTextBox.Text;

            Bitmap bitmap = ImageGenerator.GenerateImageByCityName(cityName);

            BitmapImage bitmapImage = ImageGenerator.BitmapToImageSource(bitmap);

            ImageViewer1.Source = bitmapImage;
        }

        public void CopyButtonHandler(object sender, RoutedEventArgs e)
        {
            string cityName = CityTextBox.Text;

            Bitmap bitmap = ImageGenerator.GenerateImageByCityName(cityName);

            Clipboard.SetDataObject(bitmap);
        }

        private void SaveButtonHandler(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap files | *.bmp";
            saveFileDialog.DefaultExt = "bmp";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == true)
            {
                string cityName = CityTextBox.Text;

                Bitmap bitmap = ImageGenerator.GenerateImageByCityName(cityName);
                bitmap.Save(saveFileDialog.FileName);
            }
        }
    }
}
