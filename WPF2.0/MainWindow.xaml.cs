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

namespace WPF2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Control.BeolvasALl();
            ContentControl.Content = new Bejelenkezes();
        }
        private void LogoutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Control.Mentes();
            User.actingUser = null;
            ContentControl.Content = new Bejelenkezes();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Control.Mentes();
            Environment.Exit(0);
        }

        private void MetesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Control.Mentes();
        }
    }
}