using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_11
{
    internal class Program
    {
        struct tacka
        {
            public int x, y;
        }
        static void Main(string[] args)
        {
            tacka koordinata;
            Random broj = new Random();
            koordinata.x = broj.Next() % 100;
            koordinata.y = broj.Next() % 100;
            Console.WriteLine("x koordinata tacke je: " + koordinata.x);
            Console.WriteLine("y koordinata tacke je: " + koordinata.y);
            Console.ReadKey();
        }
    }
}
