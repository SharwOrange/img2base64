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
        string Result;

        public MainWindow()
        {
            InitializeComponent();
        }

        public bool LogBoxAddLine(string Log)
        {
            var old_Text = LogBox.Text;
            try
            {
                LogBox.Text = old_Text + "\n" + Log;
                LogBox.ScrollToEnd();
                return true;
            }
            catch
            {
                Console.WriteLine("无法添加日志");
                return false;
            }
        }

        private void Select_Button_Click(object sender, RoutedEventArgs e)
        {
            var OpenImg = new OpenFileDialog() { Title="选择一个文件",
                Filter="图片文件 |*.jpg;*.jpeg;*.jfif;*.pjp;*.png;*.gif;*.bmp;*.webp;*.tiff;*.tif;*.svg;*.ico;*.cur"};
            
            var Img = OpenImg.ShowDialog();
            if (Img == true) 
            {
                ImageFileName = OpenImg.FileName;
                FileName.Text = ImageFileName;
            } else
            {
                MessageBox.Show("你必须选择一个文件");
            };
        }

        private void Copy_Button_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(Result))
            {
                Clipboard.SetText(Result);
                LogBoxAddLine("已将结果复制到剪贴板！");
            }
            else
            {
                LogBoxAddLine("没有可复制的结果，请先进行转换！");
            }
        }

        private void Encode_Button_Click(object sender, RoutedEventArgs e)
        {
            var converter = new Convert(this);

            if(string.IsNullOrEmpty(ImageFileName))
            {
                LogBoxAddLine("请先选择一个文件！");
                return;
            }
            var fileBytes = converter.ReadFileALlBtyes(ImageFileName);
            Result = converter.ConvertToBase64(fileBytes);
            Base64Result.Text = Result;
            LogBoxAddLine("转换完成!");
            Base64Result.ScrollToEnd();
        }
    }
}