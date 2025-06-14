using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, silnia =1;
            Console.WriteLine("podaj liczbę n: ");
            n = int.Parse(Console.ReadLine());
            
            i = 1;
            while (i <= n)
            {
                silnia = silnia * i;
                i++;
            }
                Console.WriteLine("silnia z {0} wynosi {1} ", n,silnia);
            }


        }
    }

