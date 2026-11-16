using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_25
{
    class Automobil
    {
        public string marka;
        public int GodisteProizvodnje;

        public void Prikazi()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Godiste proizvodnje: " + GodisteProizvodnje);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobil auto = new Automobil();
            auto.marka = "Golf";
            auto.GodisteProizvodnje = 2015;
            auto.Prikazi();
            Console.ReadKey();
        }
    }
}
