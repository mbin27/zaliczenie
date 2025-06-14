using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp53
{
    class Program
    {
        static double max(double a, double b)
        {
            if (a > b)  return a;
            else return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("max z 3 i 8 to {0}", max(3, 8));
            Console.WriteLine("max ze 100 i 99 to {0}", max(100, 99));
        }
    }
}
