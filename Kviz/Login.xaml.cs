using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kviz
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            LoadImage();
        }

        private void LoadImage()
        {
            BitmapImage bitmap = new();
            bitmap.BeginInit();
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            bitmap.UriSource = new Uri(projectFolder + "" + "/images/user.png");
            bitmap.EndInit();
            userImg.Source = bitmap;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text))
            {
                MessageBox.Show("You must enter the name.", "Try again", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                new MainWindow(this, userName.Text).Show();
            }
        }
    }
}
