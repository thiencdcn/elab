using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
using Microsoft.Win32;
using Path = System.IO.Path;

namespace Check
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            dog!
            Cat!
            Human!
        }

        private void CheckMD5_OnClick(object sender, RoutedEventArgs e)
        {
              var openFileDialog = new OpenFileDialog
                                     {
                                         Title = "Open File",
                                         Filter = "All File|*.*",
                                         DefaultExt = "*.*"
                                     };
              if (openFileDialog.ShowDialog() == true)
              {
                  using (var fs = new FileStream(openFileDialog.FileName,FileMode.Open))
                  {
                    var md5 =  Convert.ToBase64String(new MD5CryptoServiceProvider().ComputeHash(fs));
                      File.WriteAllText("E:\\Code.xml",md5);
                      MessageBox.Show("Complete!");
                  }
              }
        }

        private void ButtonWriteFile_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
                                     {
                                         Title = "Open File",
                                         Filter = "All File|*.*",
                                         DefaultExt = "*.*"
                                     };
            if (openFileDialog.ShowDialog() == true)
            {
                var stream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate,FileAccess.ReadWrite);
                 var length = (int) stream.Length;
                var buf = new byte[length];

                stream.Read(buf, 0, length);
                for (var i = length; i < buf.Length; i++)
                {
                    buf[i] += 1;
                }
                stream.Position = 0;
                stream.Write(buf, 0, length);

                stream.Close();
                
                MessageBox.Show("Complete!");
                MessageBox.Show("Complete!");

            }
        }
    }
}
