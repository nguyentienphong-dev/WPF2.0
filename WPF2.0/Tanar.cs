using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF2._0
{
    sealed class Tanar : User
    {
        public string Tantargy { get; set; }
        public Tanar(string name, string password, int id, string tantargy)
        {
            this.Name = name;
            this.Password = password;
            this.Id = id;
            this.Tantargy = tantargy;
        }

        public static List<Tanar> tanarok = new List<Tanar>();

        static public void Beolvas(string[] s)
        {
            foreach (var item in s)
            {
                string[] adatok = item.Split(';');
                tanarok.Add(new Tanar(adatok[0], adatok[1], Convert.ToInt32(adatok[2]), adatok[3]));
            }
        }


    }
}
