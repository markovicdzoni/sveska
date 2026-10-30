using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_14
{
    internal class Program
    {
        static void Duplirajbroj(int x)
        {
            x = x * 2;
            Console.WriteLine("U metodi broj je : " + x);
        }
        static void Main(string[] args)
        {
            int broj = 8;
            Console.WriteLine("Broj pre metode je : " + broj);
            Duplirajbroj(broj);
            Console.WriteLine("Broj posle metode je : " + broj);
            Console.ReadKey();
        }
    }
}
