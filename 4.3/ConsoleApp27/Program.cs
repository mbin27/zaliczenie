using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, suma =0;
            Console.WriteLine("podaj liczbę a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę b = ");
            b = int.Parse(Console.ReadLine());

            i = a;
            while (i <= b)
            {
                suma = suma + i;
                i++;
            }

                Console.WriteLine("{0}+...+{1}={2}", a, b, suma);
            }
        }
    }
}

