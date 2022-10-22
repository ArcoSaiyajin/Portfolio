using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibenice
{
    public class Hraci
    {
        public string hrac { get; set; }
        public int pocetChyb { get; set; }
        public string hledaneSlovo { get; set; }

        public Hraci(string jmeno, int pocetChyb, string slovo)
        {
            hrac = jmeno;
            this.pocetChyb = pocetChyb;
            hledaneSlovo = slovo;
        }

        public Hraci()
        {

        }

       
    }
}
