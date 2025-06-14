using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
          int r, p, obw;
          Console.WriteLine("podaj promien kola");
          r = Convert.ToInt32(Console.ReadLine());
            p = Math.PI * r * r;
            obw = 2 * Math.PI * r;

            Console.WriteLine("Pole koła wynosi {0} ", p);



        }
    }
}
