using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_33
{
    internal class Program
    {
        class BankovniRacun
        {
            public double stanje;
            public double Stanje
            {
                get { return stanje; }
                set
                {
                    if (value >= 0)
                    {
                        stanje = value;
                    }
                    else
                    {
                        Console.WriteLine("Greska: stanje racuna ne moze biti negativno!");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            BankovniRacun racun = new BankovniRacun();
            racun.Stanje = 1000;
            Console.WriteLine("Stanje racuna: " + racun.Stanje);
            racun.Stanje = -200;
            Console.WriteLine("Stanje racuna: " + racun.Stanje);
            Console.ReadKey();
        }
    }
}
