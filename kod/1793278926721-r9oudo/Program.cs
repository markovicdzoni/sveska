using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_34
{
    internal class Program
    {
        class iPhone
        {
            public double SetCena;
            public double GetCena
            {
                get { return SetCena; }
                set
                {
                    if (value >= 800)
                    {
                        SetCena = value;
                    }
                    else
                    {
                        Console.WriteLine("Greska: cena ne moze biti manja od 800!");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            iPhone iPhone = new iPhone();
            iPhone.GetCena = 1000;
            Console.WriteLine("Cena telefona: " + iPhone.GetCena);
            iPhone.GetCena = -200;
            Console.WriteLine("Cena telefona: " + iPhone.GetCena);
            Console.ReadKey();
        }
    }
}
