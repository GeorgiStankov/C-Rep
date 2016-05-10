using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int c = 0; c < i; c++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
