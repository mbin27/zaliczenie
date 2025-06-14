using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, j;
            Console.WriteLine("podaj n");
            n = int.Parse(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }

        }
    }
}
