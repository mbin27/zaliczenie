using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, i,j;
            Console.WriteLine("podaj liczbę n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę k = ");
            k = int.Parse(Console.ReadLine());
            i = 1;
            while (i<=n)
            {
                j = 1;
                while (j<=k) 
                {
                    Console.Write("*");
                    j++;
                    
                }
                
                    Console.WriteLine("");
                    i++;
                }
                
            }
        }
    }

