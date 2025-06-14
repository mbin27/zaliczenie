using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] tab = new int[1000];

            Console.WriteLine("Podaj liczbę liczb w ciągu (n <= 1000): ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]: ", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            // Wyświetlenie elementów tablicy
            Console.WriteLine("Elementy tablicy:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("tab[{0}] = {1}", i, tab[i]);
            }

            // Szukanie najmniejszej i największej liczby
            int min = tab[0];
            int max = tab[0];

            for (i = 1; i < n; i++)
            {
                if (tab[i] < min)
                    min = tab[i];
                if (tab[i] > max)
                    max = tab[i];
            }

            Console.WriteLine("Najmniejsza liczba: " + min);
            Console.WriteLine("Największa liczba: " + max);
        }
    }


}
    

