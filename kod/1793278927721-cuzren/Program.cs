using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_35
{
    class Ucenik
    {
        private int ocena;
        public int Ocena
        {
            get { return ocena; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    ocena = value;
                }
                else
                {
                    Console.WriteLine("Greska: ocena mora biti izmedju 1 i 5!");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucenik ucenik = new Ucenik();

            ucenik.Ocena = 4;
            Console.WriteLine("Ocena: " + ucenik.Ocena);

            ucenik.Ocena = 8;
            Console.WriteLine("Ocena: " + ucenik.Ocena);

            Console.ReadKey();
        }
    }
}
