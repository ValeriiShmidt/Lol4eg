﻿using Microsoft.Win32;
using System.Drawing;
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
            saveFileDialog.FileName = "Untitled";

            if (saveFileDialog.ShowDialog() == true)
            {
                string cityName = CityTextBox.Text;

                Bitmap bitmap = ImageGenerator.GenerateImageByCityName(cityName);
                bitmap.Save(saveFileDialog.FileName);
            }
        }
    }
}
