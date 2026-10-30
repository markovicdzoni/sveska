using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = new int[5];
            int zbir = 0;
            int max = 0;
            Random x = new Random();
            for (int i = 0; i < 5; i++)
            {
                brojevi[i] = x.Next() % 100;
                zbir += brojevi[i];
                if (brojevi[i] > max) max = brojevi[i];
            }
            Console.WriteLine("zbir je:" + zbir);
            Console.WriteLine("max je:" + max);
            Console.ReadKey();
        }
    }
}
