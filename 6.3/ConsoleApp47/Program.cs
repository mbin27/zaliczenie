using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i, j;
            int n, tmp;
            Console.Write("podaj liczbe elementow liczby n <=1000 ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<n;i++)
            {
                Console.Write("podaj tab = [{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for(i = 0; i<n; i++)
                for(j=i+1;j<n;j++)
                    if (tab[i] > tab[j])
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp; }
            Console.Write("elementy tablicy: ");
            for(i = 0; i<n; i++)
            {
                Console.Write("{0}, ", tab[i]);
            }
        }
    }
}
