﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,wynik =1,n;
            Console.WriteLine("podaj liczbę naturalną n");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
                wynik = wynik * 2;
            Console.WriteLine("2^{0}={1}", n, wynik);

            {

            }
        }
    }
}
