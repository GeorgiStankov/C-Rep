using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int space = n;
           // for (int k = 0; k <= space; k++)
            {
              //  Console.Write(" ");
            }

            for (int i=0;i<= n; i++)
            {                          

                    for (int c = 0; c < space; c++)
                    {
                        Console.Write(" ");
                    }
                    space--;
                    for (int c = 0; c <i; c++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" | ");
                    for (int c = 0; c < i; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                
            }
        }
    }
}
