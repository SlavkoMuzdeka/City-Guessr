using System.Windows;
using Kviz.Model;

namespace Kviz
{

    public partial class ShowResults : Window
    {
        public ShowResults()
        {
            InitializeComponent();
            resultGrid.ItemsSource = ResultService.LoadResults();
        }
    }
}
