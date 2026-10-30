using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] niz = new int[5, 5];
            int zbir = 0;
            int max = 0;
            Random x = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    niz[i, j] = x.Next() % 100;
                    zbir += niz[i, j];
                    if (niz[i, j] > max) max = niz[i, j];
                    Console.Write("   " + niz[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
