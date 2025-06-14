using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            Console.WriteLine("podaj ilość liczb");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
         
            {
                    Console.WriteLine(i*7);

            }
        }
    }
}
