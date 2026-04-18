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
    /// Interaction logic for AWTanarHozzáadás.xaml
    /// </summary>
    public partial class AWTanarHozzáadás : Window
    {
        public AWTanarHozzáadás()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (AWnameTextBox.Text.Contains(';') || AWpasswordTextBox.Text.Contains(';') || AWTantargyTextBox.Text.Contains(';'))
            {
                MessageBox.Show("Nem lehet ';' karaktert használni!");
            }
            Tanar tanar = new Tanar(AWnameTextBox.Text, AWpasswordTextBox.Text, User.userek.Max(j => j.Id) + 1, AWTantargyTextBox.Text);
            Tanar.tanarok.Add(tanar);
            User.userek.Add(tanar);
            Control.Mentes();
            this.Close();
        }
    }
}
