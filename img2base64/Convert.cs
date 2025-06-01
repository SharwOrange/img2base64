using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace img2base64
{
    internal class Convert
    {
        private MainWindow _mainWindow;

        public Convert(MainWindow mainwindow)
        {
            _mainWindow = mainwindow;
        }

        public byte[] ReadFileALlBtyes(string FilePath)
        {
            try
            {
                _mainWindow.LogBoxAddLine($"正在读取: {FilePath}");
                return File.ReadAllBytes(FilePath);
            }
            catch (Exception ex)
            {
                _mainWindow.LogBoxAddLine($"读取文件出错，原因：{ex.Message}");
                return null;
            }
        }

        public string ConvertToBase64(byte[] FileBytes)
        {
            try
            {
                _mainWindow.LogBoxAddLine("正在转换为Base64...");
                return System.Convert.ToBase64String(FileBytes);
            }
            catch (Exception ex)
            {
                _mainWindow.LogBoxAddLine($"转换为Base64出错，原因：{ex.Message}");
                return null;
            }
        }
    }
}
