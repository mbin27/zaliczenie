using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("podaj liczbę n ");
            n = int.Parse(Console.ReadLine());
            i = 0;
            while (i<=n)
            {
                if (n % 2 == 0)
                    i++;
            }
            Console.Write("liczba {0} jest pierwsza", n);
            
        }
    }
}
