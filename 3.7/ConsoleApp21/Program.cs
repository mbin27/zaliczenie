using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            Console.WriteLine("podaj liczbę n");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= 100; i++)
                if (n % 13 == 0) Console.Write("{0}, ", i);
            {

            }
        }
    }
}
