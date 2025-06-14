using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,i;
            Console.Write("podaj liczbę a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("podaj liczbę b = ");
            b = int.Parse(Console.ReadLine());
            i = a;
            while (i<=b)
            {
                if (i % 2 == 0) Console.Write("{0},  ", i);
                i++;
            }
        }
    }
}
