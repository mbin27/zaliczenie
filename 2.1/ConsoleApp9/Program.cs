using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) 
                Console.WriteLine("liczba {0} jest parzysta", a);
            else 
                Console.WriteLine("liczba {0} jest nieparzysta", a);

        }
    }
}
