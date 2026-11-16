using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_27
{
    class Pravougaonik
    {
        public double sirina;
        public double visina;

        public Pravougaonik(double s, double v)
        {
            sirina = s;
            visina = v;
        }

        public double IzracunajPovrsinu()
        {
            return sirina * visina;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravougaonik p1 = new Pravougaonik(4, 5);
            Pravougaonik p2 = new Pravougaonik(3, 7);

            Console.WriteLine("Povrsina prvog pravougaonika: " + p1.IzracunajPovrsinu());
            Console.WriteLine("Povrsina drugog pravougaonika: " + p2.IzracunajPovrsinu());
            Console.ReadKey();
        }
    }
}
