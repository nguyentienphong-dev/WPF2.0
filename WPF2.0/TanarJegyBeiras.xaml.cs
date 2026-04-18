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
    /// Interaction logic for TanarJegyBeiras.xaml
    /// </summary>
    public partial class TanarJegyBeiras : Window
    {
        public TanarJegyBeiras()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
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
            Jegy.jegyek.Add(new Jegy((User.actingUser as Tanar).Tantargy, int.Parse(ertekTextBox.Text), User.actingUser.Id.ToString(), TanarControl.selectedUserId.ToString()));
            Control.Mentes();
            this.Close();
        }
    }
}
