using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF2._0
{
    internal class Tanulo : User
    {
        public string Osztaly { get; set; }
        public Tanulo(string name, string password, int id, string osztaly)
        {
            this.Name = name;
            this.Password = password;
            this.Id = id;
            this.Osztaly = osztaly;
        }

        public static List<Tanulo> tanulok = new List<Tanulo>();

        static public void Beolvas(string[] s)
        {
            foreach (var item in s)
            {
                string[] adatok = item.Split(';');
                tanulok.Add(new Tanulo(adatok[0], adatok[1], Convert.ToInt32(adatok[2]), adatok[3]));
            }
        }


    }
}

