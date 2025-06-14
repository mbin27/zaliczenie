using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("podaj bok a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj bok b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj bok c = ");
            c = int.Parse(Console.ReadLine());

            if ((a + b > c) && (a +c  > b)&&(b+c>a))
                Console.WriteLine("Z tych odcinków da się zbudować trojkąt");
            
            else
                Console.WriteLine("z tych odcinków nie da się zbudować trójkąta");




        }
    }
}
