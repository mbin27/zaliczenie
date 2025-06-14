using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("podaj liczbe nr 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbe nr 2");
            b =int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbe nr 3");
            c = int.Parse(Console.ReadLine());

            if ((a<=b)&&(a<=c))
                Console.WriteLine("Najmniejsza liczba {0}", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("najmniejsza liczba {0}", b);
            else
                Console.WriteLine("liczba {0} jest najmniejsza", c);

            if ((a>=b)&& (a>=c))
                    Console.WriteLine("liczba {0} jest największa", a);
            else if ((b >= a) && (b >= c))
                    Console.WriteLine("liczba {0} jest największa", b);
           else
                Console.WriteLine("liczba {0} jest największa", c);

        }
    }
}
