using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("podaj liczbe a");
            a = int.Parse(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba {0} jest dodatnia", a);
            else if (a < 0)
                Console.WriteLine("Liczba {0} jest ujemna", a);
            else
                Console.WriteLine("Liczba {0} jest równa 0", a);


        }
    }
}
