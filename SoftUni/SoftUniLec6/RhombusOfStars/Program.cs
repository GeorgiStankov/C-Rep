using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int space = n;
            for( int i=1;i<= n; i++)
            {
                for(int c=1;c<= space; c++)
                {
                    Console.Write(" ");
                }
                space--;
                for(int c=1;c<=i; c++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            space = 1;
            for(int i = 1; i <= n - 1; i++)
            {
                for(int c=0;c<= space; c++)
                {
                    Console.Write(" ");
                }
                space++;
                for (int c = 1; c <= n-i; c++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }


          
        }
    }
    }

