﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("|");
                for (int c = 0; c < n - 2; c++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
