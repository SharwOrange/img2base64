using Microsoft.Win32;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace img2base64
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ImageFileName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var OpenImg = new OpenFileDialog() { Title="Select Image",
                Filter="Image Files |*.jpg;*.jpeg;*.jfif;*.pjp;*.png;*.gif;*.bmp;*.webp;*.tiff;*.tif;*.svg;*.ico;*.cur|AllFiles |*.*"};
            
            var Img = OpenImg.ShowDialog();
            if (Img == true) 
            {
                ImageFileName = OpenImg.FileName;
                FileName.Text = ImageFileName;
            } else
            {
                MessageBox.Show("You must select a file!");
            };
        }
    }
}