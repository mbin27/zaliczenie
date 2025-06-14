using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ciag;
            Console.WriteLine("podaj n");
            n = Convert.ToInt32(Console.ReadLine());
            ciag = 3 * n - 1;
            Console.WriteLine("suma wynosi {0} ", ciag);



        }
    }
}
