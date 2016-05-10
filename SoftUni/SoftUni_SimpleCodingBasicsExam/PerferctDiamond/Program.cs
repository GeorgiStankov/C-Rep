using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerferctDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());            
            int space = n - 1;

            for (int i = 0; i < n; i++)
            {
                for (int c = 1; c <= space; c++)
                {
                    Console.Write(" ");
                }                      

                    space--;

                    Console.Write('*');
                for (int k=0;k< i; k++)
                {
                    Console.Write("-*");
                    
                }
                Console.WriteLine();
            }
            space = 1;
           for (int i = 1; i < n; i++)
            {
                for (int c = 1; c <= space; c++)
                {
                    Console.Write(" ");
                }

                space++;

                Console.Write('*');
                for (int k = 0; k <n-i-1; k++)
                {
                    Console.Write("-*");

                }
                Console.WriteLine();
            }
        }
    }
}
