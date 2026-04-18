using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF2._0
{
    abstract class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        public static List<User> userek = new List<User>();


        static public User actingUser { get; set; }
    }
}
