using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_28
{
    class Proizvod
    {
        public string naziv;
        public double cena;

        public Proizvod(string n, double c)
        {
            naziv = n;
            cena = c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod p1 = new Proizvod("Hleb", 80);
            Proizvod p2 = new Proizvod("Mleko", 110);

            Console.WriteLine(p1.naziv + " - " + p1.cena + " din.");
            Console.WriteLine(p2.naziv + " - " + p2.cena + " din.");
            double ukupno = p1.cena + p2.cena;
            Console.WriteLine("Ukupna vrednost: " + ukupno + " din.");
            Console.ReadKey();
        }
    }
}
