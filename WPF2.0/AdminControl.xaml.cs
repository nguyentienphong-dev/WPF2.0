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

namespace WPF2._0
{
    /// <summary>
    /// Interaction logic for AdminControl.xaml
    /// </summary>
    public partial class AdminControl : UserControl
    {
        List<User> aUsersDataGridUserek = new List<User>();
        public AdminControl()
        {
            InitializeComponent();
        }

        private void TanuloHozzáadásButton_Click(object sender, RoutedEventArgs e)
        {
            Window tanuloHozzaadas = new AWTanuloHozzadas();
            tanuloHozzaadas.ShowDialog();
        }

        private void TanarHozzáadásButton_Click(object sender, RoutedEventArgs e)
        {
            Window tanarHozzaadas = new AWTanarHozzáadás();
            tanarHozzaadas.ShowDialog();
        }

        private void TörlésButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (aUsersDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Nincs kiválasztva felhasználó!");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Biztosan törölni szeretné?", "Megerősítés", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                if (aUsersDataGrid.SelectedItem is Tanulo)
                {

                    foreach (var item in Tanulo.tanulok)
                    {
                        aUsersDataGridUserek.Remove(item);
                    }
                    Tanulo.tanulok.Remove((Tanulo)aUsersDataGrid.SelectedItem);
                    User.userek.Remove((Tanulo)aUsersDataGrid.SelectedItem);
                    aUsersDataGridUserek.AddRange(Tanulo.tanulok);
                    aUsersDataGrid.ItemsSource = aUsersDataGridUserek;
                    aUsersDataGrid.Items.Refresh();
                    Control.Mentes();
                }
                else if (aUsersDataGrid.SelectedItem is Tanar)
                {

                    foreach (var item in Tanar.tanarok)
                    {
                        aUsersDataGridUserek.Remove(item);
                    }
                    Tanar.tanarok.Remove((Tanar)aUsersDataGrid.SelectedItem);
                    User.userek.Remove((Tanar)aUsersDataGrid.SelectedItem);
                    aUsersDataGridUserek.AddRange(Tanar.tanarok);
                    aUsersDataGrid.ItemsSource = aUsersDataGridUserek;
                    aUsersDataGrid.Items.Refresh();
                    Control.Mentes();
                }
            }
        }

        private void aTanuloCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var item in Tanulo.tanulok)
            {
                aUsersDataGridUserek.Remove(item);
            }
            aUsersDataGridUserek.AddRange(Tanulo.tanulok);
            aUsersDataGrid.ItemsSource = aUsersDataGridUserek;
            aUsersDataGrid.Items.Refresh();
        }

        private void aTanuloCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            foreach (var item in Tanulo.tanulok)
            {
                aUsersDataGridUserek.Remove(item);
            }
            aUsersDataGrid.ItemsSource = aUsersDataGridUserek;
            aUsersDataGrid.Items.Refresh();
        }

        private void aTanarCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var item in Tanar.tanarok)
            {
                aUsersDataGridUserek.Remove(item);
            }
            aUsersDataGridUserek.AddRange(Tanar.tanarok);
            aUsersDataGrid.ItemsSource = aUsersDataGridUserek;
            aUsersDataGrid.Items.Refresh();
        }

        private void aTanarCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            foreach (var item in Tanar.tanarok)
            {
                aUsersDataGridUserek.Remove(item);
            }
            aUsersDataGrid.ItemsSource = aUsersDataGridUserek;
            aUsersDataGrid.Items.Refresh();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Tanulo.tanulok)
            {
                aUsersDataGridUserek.Remove(item);
            }
            foreach (var item in Tanar.tanarok)
            {
                aUsersDataGridUserek.Remove(item);
            }
            if (aTanarCheckBox.IsChecked == true)
            {
                aUsersDataGridUserek.AddRange(Tanar.tanarok);
            }
            if (aTanuloCheckBox.IsChecked == true)
            {
                aUsersDataGridUserek.AddRange(Tanulo.tanulok);
            }
            aUsersDataGrid.ItemsSource = aUsersDataGridUserek;
            aUsersDataGrid.Items.Refresh();
        }

        public static int selectedUserId;
        private void aUsersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (aUsersDataGrid.SelectedItem != null)
            {
                selectedUserId = (aUsersDataGrid.SelectedItem as User).Id;
                
                if(aUsersDataGrid.SelectedItem is Tanulo)
                {
                    afelhasznaloContentControl.Content = new AdminTanuloControl();
                }
                
            }
            
        }
    }
}
