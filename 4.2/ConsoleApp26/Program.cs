﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i,an;
            Console.WriteLine("podaj liczbę n = ");
            n = int.Parse(Console.ReadLine());
            i = 0;
            while (++i<=n)
            {
                an = 2 * i - 1;
                    Console.WriteLine("a ({0}) = {1}", i, an);

            }


        
    }
}
