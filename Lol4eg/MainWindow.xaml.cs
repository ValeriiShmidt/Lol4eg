using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.Win32;

namespace Lol4eg
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Bitmap bitmap = ImageGenerator.GenerateImageByCityName(CityTextBox.Text);

            BitmapImage bitmapImage = ImageGenerator.BitmapToImageSource(bitmap);

            ImageViewer1.Source = bitmapImage;

            CityTextBox.KeyUp += TextBoxHandler;
            CopyButton.Click += CopyButtonHandler;
            SaveAsButton.Click += SaveButtonHandler;
        }
    }
}
