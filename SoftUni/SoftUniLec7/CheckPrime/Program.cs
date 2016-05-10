using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
                bool isPrime = true;
                int temp;
            if (num == 0 || num == 1 || num == -11)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {


                for (int i = 2; i <= num / 2; i++)
                {

                    temp = num % i;

                    if (temp == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
        
    }
    }
}
