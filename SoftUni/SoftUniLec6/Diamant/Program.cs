using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamant
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int space =n/2;
            int loop = n / 2;
            int mid = n - (2 * space) - 2;
            if (n == 1)
            {
                Console.WriteLine('*');
                return;
            }
           else if(n==2) {
                Console.WriteLine("**");
                return;
            }

            for (int i=0;i<= loop; i++)
            {
                if (i == 0)
                {

                    if (n % 2 == 1)
                    {
                        for (int c = 0; c < space; c++)
                        {
                            Console.Write('-');
                        }
                        Console.Write('*');
                        for (int c = 0; c < space; c++)
                        {
                            Console.Write('-');
                        }
                        Console.WriteLine();
                        space--;
                    }
                    if (n % 2 == 0)
                    {
                        for (int c = 0; c < space-1; c++)
                        {
                            Console.Write('-');
                        }
                        Console.Write("**");
                        for (int c = 0; c < space-1; c++)
                        {
                            Console.Write('-');
                        }
                        Console.WriteLine();
                        space = space - 2;
                        loop--;

                    }
                }
                else {

                    if (i == 0)
                    {
                        continue;
                    }

                    for (int c = 0; c < space; c++)
                    {

                        Console.Write('-');
                    }

                    Console.Write('*');
                    for (int c = 0; c < n - (2 * space) - 2; c++)
                    {
                        Console.Write('-');
                    }
                    Console.Write('*');

                    for (int c = 0; c < space; c++)
                    {
                        Console.Write('-');
                    }
                    space--;
                    Console.WriteLine();
                }
                
               
            }
            space = 1;
            for (int i = 0; i < loop; i++)
            {

                
               
                    if (i !=n/2-1){

                for (int c = 0; c < space; c++)
                {

                    Console.Write('-');
                }

                Console.Write('*');
                for (int c = 0; c < n - (2 * space) - 2; c++)
                {
                    Console.Write('-');
                }
                Console.Write('*');

                for (int c = 0; c < space; c++)
                {
                    Console.Write('-');
                }
                space++;
                Console.WriteLine();
            }
                


                else {

                        if (n % 2 == 1)
                        {
                            for (int c = 0; c < space; c++)
                            {
                                Console.Write('-');
                            }
                            Console.Write('*');
                            for (int c = 0; c < space; c++)
                            {
                                Console.Write('-');
                            }
                            Console.WriteLine();
                            space++;
                        }
                        if (n % 2 == 0)
                        {
                            for (int c = 0; c < space - 1; c++)
                            {
                                Console.Write('-');
                            }
                            Console.Write("**");
                            for (int c = 0; c < space - 1; c++)
                            { 
                                Console.Write('-');
                            }
                            Console.WriteLine();
                            space++;

                        }                        
                }
                

            }
        }
    }
}
