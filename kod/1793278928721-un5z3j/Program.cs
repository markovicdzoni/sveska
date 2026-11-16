using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_36
{
    class Student
    {
        public string ime;
        public static int brojStudenata = 0;

        public Student(string ime)
        {
            this.ime = ime;
            brojStudenata++;
        }
        public int Koliko()
        {
            return brojStudenata;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Marko");
            Student s2 = new Student("Ana");
            Student s3 = new Student("Jovan");

            Console.WriteLine("Ukupno napravljeno studenata: " + Student.brojStudenata);

            Console.WriteLine(s1.Koliko());
            Console.WriteLine(s2.Koliko());
            Console.WriteLine(s3.Koliko());

            Console.ReadKey();
        }
    }
}
