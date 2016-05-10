using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int space = n/2;
            int space1 = 1;
            int space2= 0; 
            if (n == 2)
            {
                Console.WriteLine("**");
                Console.WriteLine("||");
            }
            else if (n == 3)
            {
                Console.WriteLine("-*-");
                Console.WriteLine("***");
                Console.WriteLine("|*|");
            }
            else if (n != 2 && n != 3)
            {


                if (n % 2 == 1)
                {
                    for (int i = 0; i <= n / 2; i++)
                    {

                        for (int c = 1; c <= space; c++)
                        {
                            Console.Write('-');
                        }
                        for (int c = 1; c <= space1; c++)
                        {
                            Console.Write('*');
                        }
                        for (int c = 1; c <= space; c++)
                        {
                            Console.Write('-');
                        }
                        space--;
                        space1 += 2;
                        Console.WriteLine();
                    }
                }
                    if (n % 2 == 0)
                    {
                    for (int i = 0; i < n / 2; i++)
                    {
                        for (int c = 1; c < space; c++)
                        {
                            Console.Write('-');
                        }
                        for (int c = 0; c <= space2; c++)
                        {
                            Console.Write("**");
                        }
                        for (int c = 1; c < space; c++)
                        {
                            Console.Write('-');
                        }
                        space--;
                        space2++;
                        Console.WriteLine();
                    }
             }
                for (int s = 0; s < n / 2; s++)
                {
                    Console.Write('|');
                    for (int c = 1; c <= n - 2; c++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine('|');
                }

            }
                
            }
        }
    }


