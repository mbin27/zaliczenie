using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] tab = new int[1000];
            Console.WriteLine("podaj liczbę n ciągu <1000: ");
            n = int.Parse(Console.ReadLine());
            for (i=0;i<n;i++)
            {
                Console.WriteLine("podaj tab[{0}]", i);
                tab[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("elementy tablicy: ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0}, ", tab[i]);
            }

        }
    }
}
