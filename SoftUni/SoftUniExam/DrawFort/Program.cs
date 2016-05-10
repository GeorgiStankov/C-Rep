using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int space = 1;
            int space1 = 1;
                   

            Console.Write("/");
            space++;
            
            for(int i = 0; i < n / 2; i++)
            {
                Console.Write("^");
                space++;
                space1++;
            }
            Console.Write("\\");
            space++;
            space1++;
            if (n > 4)
            {
                for(int i = 0; i < n / 2; i++)
                {
                    Console.Write("_");
                    space++;
                }
            }
            Console.Write("/");
            space++;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("^");
                space++;
            }
            Console.Write("\\");
            space++;
            Console.WriteLine();
            for(int i = 1; i <= n-2; i++)
            {
                if (i==n-2 && n>4)
                {
                    Console.Write("|");
                    for (int s = 0; s <space1-1; s++)
                    {
                        Console.Write(" ");
                    }
                    for (int s = 0; s < (n / 2); s++)
                    {
                        Console.Write("_");
                    }
                    for (int s = 0; s < space1-1 ; s++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
                
                else
                    {
                    Console.Write("|");
                    for (int c = 0; c < space - 3; c++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                   }
            }
            Console.Write("\\");
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("_");
            }
            Console.Write("/");
            if (n > 4)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(" ");
                }
            }
            Console.Write("\\");

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("_");
            }
            Console.Write("/");
            Console.WriteLine();


        }
    }
}
