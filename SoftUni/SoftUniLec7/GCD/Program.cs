﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            while (a % b != 0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
                
            }
            Console.WriteLine(b);


        }
    }
}
