using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, k, j;
            Console.WriteLine("podaj liczbę n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę k");
            k = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                for (j = 1; j <= k; j++)
                    Console.Write("*");
                Console.WriteLine("");


            }
                





        }
    }
}
