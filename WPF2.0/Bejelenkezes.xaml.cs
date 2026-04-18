using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for Bejelenkezes.xaml
    /// </summary>
    public partial class Bejelenkezes : UserControl
    {
        public Bejelenkezes()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            int userId = 0;
            string userPassword = passwordBox.Password;

            try
            {
                userId = Convert.ToInt32(idTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nem megfelelő azonosító!");
                return;
            }
            foreach (var item in User.userek)
            {
                if (userId == item.Id && userPassword == item.Password)
                {
                    if (item is Tanulo)
                    {
                        User.actingUser = item;
                        MainWindow parentWindow = (MainWindow)Window.GetWindow(this);
                        parentWindow.ContentControl.Content = new TanuloConrol();
                        return;
                    }
                    else if (item is Tanar)
                    {
                        User.actingUser = item;
                        MainWindow parentWindow = (MainWindow)Window.GetWindow(this);
                        parentWindow.ContentControl.Content = new TanarControl();
                        return;
                    }
                    else if (item is Admin)
                    {
                        User.actingUser = item;
                        MainWindow parentWindow = (MainWindow)Window.GetWindow(this);
                        parentWindow.ContentControl.Content = new AdminControl();
                        return;
                    }
                }
            }
            MessageBox.Show("Sikertlen bejelentkezés!");
            return;
        }
    }
}
