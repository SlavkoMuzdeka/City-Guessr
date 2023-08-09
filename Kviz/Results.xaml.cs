using System.Windows;

namespace Kviz
{
    public partial class Results : Window
    {
        private readonly MainWindow Win;
        private readonly string UserName;

        public Results(int res, MainWindow win, string userName)
        {
            InitializeComponent();
            result.Content = res + "/10";
            this.Win = win;
            this.UserName = userName;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
            Win.Close();
        }

        private void PlayAgain(object sender, RoutedEventArgs e)
        {
            Win.Close();
            new MainWindow(this, UserName).Show();
        }

        private void ShowResults(object sender, RoutedEventArgs e)
        {
            new ShowResults().ShowDialog();
        }
    }
}
