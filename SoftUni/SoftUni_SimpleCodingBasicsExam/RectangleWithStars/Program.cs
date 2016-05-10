using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int space = (n - 1) / 2;



            for (int k = 0; k < n * 2; k++)
            {
                Console.Write('%');
            }
            Console.WriteLine();

            if (n % 2 == 1)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write('%');

                    if (c != space)
                    {
                        for (int i = 0; i < 2 * n - 2; i++)
                            Console.Write(" ");

                    }


                    else
                    {
                        for (int s = 0; s < (2 * n - 4) / 2; s++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write("**");
                        for (int s = 0; s < (2 * n - 4) / 2; s++)
                        {
                            Console.Write(" ");
                        }

                    }

                    Console.Write('%');
                    Console.WriteLine();
                }


            }

            else
            {
                for(int c = 0; c < n-1; c++)
                {
                    Console.Write('%');

                    if (c != space)
                    {
                        for (int i = 0; i < 2 * n - 2; i++)
                            Console.Write(" ");
                    }
                    else
                    {
                        for (int s = 0; s < (2 * n - 4) / 2; s++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write("**");
                        for (int s = 0; s < (2 * n - 4) / 2; s++)
                        {
                            Console.Write(" ");
                        }

                    }

                    Console.Write('%');
                    Console.WriteLine();
                }

            }
            for (int k = 0; k < n * 2; k++)
            {
                Console.Write('%');
            }
            Console.WriteLine();

        }
    }
}

