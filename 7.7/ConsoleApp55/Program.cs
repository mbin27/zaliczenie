using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static int pole_deltoidu(int p, int q)
        {
            return (p * q)/2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("pole deltoidu dla p = 5 i q = 8 to {0} ", pole_deltoidu(5, 8));
        }
    }
}
