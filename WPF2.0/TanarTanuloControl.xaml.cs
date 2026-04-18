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
    /// Interaction logic for TanarTanuloControl.xaml
    /// </summary>
    public partial class TanarTanuloControl : UserControl
    {
        User User;
        public TanarTanuloControl()
        {
            InitializeComponent();
            aUserDataGrid.ItemsSource = Jegy.jegyek.Where(j => j.TanuloId == TanarControl.selectedUserId.ToString()).ToList();
            User = User.userek.Where(u => u.Id == TanarControl.selectedUserId).FirstOrDefault();

            nev.Text = User.Name;
            try
            {
                atlag.Text = Jegy.jegyek.Where(j => j.TanuloId == User.Id.ToString()).Average(j => j.Ertek).ToString();
            }
            catch (Exception)
            {
                atlag.Text = "N/A";
            }
        }

        private void JegyBeirasButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new TanarJegyBeiras();
            window.ShowDialog();
        }

        private void JegyTorlesButton_Click(object sender, RoutedEventArgs e)
        {
            if (aUserDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Nincs Jegy kiválasztva!");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Biztosan törölni szeretné?", "Megerősítés", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Jegy.jegyek.Remove((Jegy)aUserDataGrid.SelectedItem);

                aUserDataGrid.ItemsSource = Jegy.jegyek.Where(j => j.TanuloId == TanarControl.selectedUserId.ToString()).ToList();
                aUserDataGrid.Items.Refresh();
                Control.Mentes();
            }
        }

        private void JegyfrissitesButton_Click(object sender, RoutedEventArgs e)
        {
            aUserDataGrid.ItemsSource = Jegy.jegyek.Where(j => j.TanuloId == TanarControl.selectedUserId.ToString()).ToList();
            aUserDataGrid.Items.Refresh();
        }
    }
}
