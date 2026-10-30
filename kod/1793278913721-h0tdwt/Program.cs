using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_18
{
    internal class Program
    {
        static int Mnozi(int x, int y)
        {
            return x * y;
        }
        static void Parnost(int z)
        {
            if (z % 2 == 0) Console.WriteLine("Broj je paran!");
            if (z % 2 == 1) Console.WriteLine("Broj je neparan!");
        }
        static void Main(string[] args)
        {
            int a = 7, b = 3;
            int rezultat;
            rezultat = Mnozi(a, b);
            Console.WriteLine("Mnozenjem dobijam : " + rezultat);
            Parnost(rezultat);
            Console.ReadKey();
        }
    }
}
