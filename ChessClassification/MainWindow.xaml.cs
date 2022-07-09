using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static ChessClassification.ModelClassification;

namespace ChessClassification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Выбор картинки",
                Filter = "Картинки|*.png;*.jpg;*.bmp;|Все файлы (*.*)|*.*",
                CheckFileExists = true,
            };
            if (!dialog.ShowDialog(this) ?? false) return;

            var file = dialog.FileName;

            ImageView.Source = new BitmapImage(new Uri(file));


            var result = Predict(new ModelInput()
            {
                ImageSource = file
            });

            ResultText.Text = $"{result.Prediction} - {result.Score.Max():p0}\n {string.Join(", ", result.Score)}";
        }
    }
}
