using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, suma =0, n;
            Console.WriteLine("podaj n");
            n = int.Parse(Console.ReadLine());
            for (i = 2; i <= n; i++)
                suma = suma + i;
                    Console.WriteLine("1+...{0}={1}",n, suma);

        }
    }
}
