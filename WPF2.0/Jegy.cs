using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF2._0
{
    internal class Jegy
    {
        public string Tantargy { get; set; }
        public int Ertek { get; set; }
        public string TanarId { get; set; }
        public string TanuloId { get; set; }

        public static List<Jegy> jegyek = new List<Jegy>();

        public Jegy(string tantargy, int ertek, string tanarId, string tanuloId)
        {
            this.Tantargy = tantargy;
            this.Ertek = ertek;
            this.TanarId = tanarId;
            this.TanuloId = tanuloId;
        }

        public static void Beolvas(string[] s)
        {
            foreach (var item in s)
            {
                string[] adatok = item.Split(';');
                jegyek.Add(new Jegy(adatok[0], Convert.ToInt32(adatok[1]), adatok[2], adatok[3]));
            }
        }
    }
}
