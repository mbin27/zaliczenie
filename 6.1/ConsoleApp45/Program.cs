using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; //tablica 1000 liczb int
                int i, n;
            Console.Write("podaj liczbę elementów tablicy n <- 1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<n; i++)
            {
                Console.Write("podaj tab [{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("elementy tablicy: ");
            for (i = 0; i < n; i++) {
                Console.Write("{0}, ", tab[i]);
            }

        }
    }
}
