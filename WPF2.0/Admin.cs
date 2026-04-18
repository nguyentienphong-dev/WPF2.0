using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF2._0
{
    sealed class Admin : User
    {
        public Admin(string name, string password, int id)
        {
            this.Name = name;
            this.Password = password;
            this.Id = id;
        }

        public static List<Admin> adminok = new List<Admin>();

        public static void Beolvas(string[] s)
        {
            foreach (var item in s)
            {
                string[] adatok = item.Split(';');
                adminok.Add(new Admin(adatok[0], adatok[1], Convert.ToInt32(adatok[2])));
            }
        }


    }
}
