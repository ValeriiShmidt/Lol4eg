using System.Windows;

namespace Lol4eg
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += TextBoxHandler;
            CityTextBox.TextChanged += TextBoxHandler;
            CopyButton.Click += CopyButtonHandler;
            SaveAsButton.Click += SaveButtonHandler;
        }
    }
}
