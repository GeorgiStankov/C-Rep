using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLec6
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());

          
                Console.Write(new string('*',(4 * a)/2));
                Console.Write(new string(' ', a));
                Console.WriteLine(new string('*', (4 * a) / 2));
                
            for (int i = 0; i < a - 2; i++)
            {
                Console.Write("*");
                if (i==(a-1)/2-1)
                {
                    Console.Write(new string('/', 2 * a - 2));
                    Console.Write("*");
                    Console.Write(new string('|', a));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * a - 2));
                    Console.Write("*");
                    Console.WriteLine();

                }
                else
                {
                    Console.Write(new string('/', 2 * a-2));
                    Console.Write("*");
                    Console.Write(new string(' ',  a));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * a - 2));
                    Console.Write("*");
                    Console.WriteLine();
                }

            }
            Console.Write(new string('*', (4 * a) / 2));
            Console.Write(new string(' ', a));
            Console.WriteLine(new string('*', (4 * a) / 2));


        }
    }
}