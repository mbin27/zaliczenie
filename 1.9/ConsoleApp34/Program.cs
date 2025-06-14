using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("podaj liczbę a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("suma kwadratów a = {0}  b = {1} wynosi {2}", a, b, a * a + b * b);

        }
    }
}
