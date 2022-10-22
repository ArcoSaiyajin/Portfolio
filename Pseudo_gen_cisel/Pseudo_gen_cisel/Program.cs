using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudo_gen_cisel
{
    class Program
    {
        int x, a, c;

        void Reset(int x)
        {
            this.x = x; // nastavení seed
            a = 69069;
            c = 1;
        }

        public int GenerateNext()
        {
            x = x * a + c;
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\"konec\" ukonci program \n\"seed\" nastavi vas seed \n\"gen\" generuj cislo \n Za kazdy prikaz Enter!");
            Program b = new Program();
            Random rnd = new Random();
            int i = rnd.Next(Int32.MinValue, Int32.MaxValue);
            b.Reset(i);
            string c = "";
            while (c != "konec")
            {
                c = Console.ReadLine();

                if (c == "seed")
                {
                    int d = Convert.ToInt32(Console.ReadLine());
                    b.Reset(d);
                    int a = b.GenerateNext();
                    Console.WriteLine(a);
                }
                else if (c == "gen")
                {
                    int a = b.GenerateNext();
                    Console.WriteLine(a);
                }



            }
            Console.WriteLine("Stisknete jakoukoliv klavesu");
            Console.ReadKey();
        }
    }
} 
