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
    /// Interaction logic for TanarControl.xaml
    /// </summary>
    public partial class TanarControl : UserControl
    {
        public TanarControl()
        {
            InitializeComponent();
            aUsersDataGrid.ItemsSource = Tanulo.tanulok;
        }

        public static int selectedUserId;
        private void aUsersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (aUsersDataGrid.SelectedItem != null)
            {
                selectedUserId = (aUsersDataGrid.SelectedItem as User).Id;

                if (aUsersDataGrid.SelectedItem is Tanulo)
                {
                    afelhasznaloContentControl.Content = new TanarTanuloControl();
                }

            }

        }
    }
}
