using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPF2._0
{
    public class Control
    {
        public static void BeolvasALl()
        {
            Admin.Beolvas(File.ReadAllLines("adminok.txt", Encoding.UTF8));
            User.userek.AddRange(Admin.adminok);
            Tanar.Beolvas(File.ReadAllLines("tanarok.txt", Encoding.UTF8));
            User.userek.AddRange(Tanar.tanarok);
            Tanulo.Beolvas(File.ReadAllLines("tanulok.txt", Encoding.UTF8));
            User.userek.AddRange(Tanulo.tanulok);
            Jegy.Beolvas(File.ReadAllLines("jegyek.txt", Encoding.UTF8));
        }
        public static void Mentes()
        {
            StreamWriter sw1 = new StreamWriter("adminok.txt", false, Encoding.UTF8);
            foreach (var item in Admin.adminok)
            {
                sw1.WriteLine($"{item.Name};{item.Password};{item.Id}");
            }
            sw1.Close();

            StreamWriter sw2 = new StreamWriter("tanarok.txt", false, Encoding.UTF8);
            foreach (var item in Tanar.tanarok)
            {
                sw2.WriteLine($"{item.Name};{item.Password};{item.Id};{item.Tantargy}");
            }
            sw2.Close();

            StreamWriter sw3 = new StreamWriter("tanulok.txt", false, Encoding.UTF8);
            foreach (var item in Tanulo.tanulok)
            {
                sw3.WriteLine($"{item.Name};{item.Password};{item.Id};{item.Osztaly}");
            }
            sw3.Close();

            StreamWriter sw4 = new StreamWriter("jegyek.txt", false, Encoding.UTF8);
            foreach (var item in Jegy.jegyek)
            {
                sw4.WriteLine($"{item.Tantargy};{item.Ertek};{item.TanarId};{item.TanuloId}");
            }
            sw4.Close();
        }

    }
}
