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
using System.Windows.Shapes;

namespace WPF2._0
{
    /// <summary>
    /// Interaction logic for AdminJegyBeiras.xaml
    /// </summary>
    public partial class AdminJegyBeiras : Window
    {
        public AdminJegyBeiras()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if ( tantargyTextBox.Text.Contains(';'))
            {
                MessageBox.Show("Nem lehet ';' karaktert használni!");
                return;
            }
            try
            {
                int.Parse(ertekTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Számot adjonmeg!");
                return;
            }
            if (int.Parse(ertekTextBox.Text) > 5 || int.Parse(ertekTextBox.Text) < 1)
            {
                MessageBox.Show("1-5 itervalumban adjon jegyet!");
                return;
            }
            Jegy.jegyek.Add(new Jegy(tantargyTextBox.Text, int.Parse(ertekTextBox.Text), User.actingUser.Id.ToString(), AdminControl.selectedUserId.ToString()));
            Control.Mentes();
            this.Close();
        }
    }
}
