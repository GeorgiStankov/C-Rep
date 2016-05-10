using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)

        {
            var leftSum = 0;
            int rightSum = 0;
            int biggest = -10000000;
            int smallest = 1000000000;
            bool isEqual = true;
            var n = int.Parse(Console.ReadLine());

            
            for (var i = 0; i < 1; i++)
            {
               var a = int.Parse(Console.ReadLine());
               var b= int.Parse(Console.ReadLine());
                leftSum = a + b;
                n = n - 1;
            }
            for (var i = 0; i < n; i++)
            {
                for (int c = 0; c < 2; c++)
                {
                    rightSum = int.Parse(Console.ReadLine());
                    rightSum += int.Parse(Console.ReadLine()); ;
                    if (rightSum > biggest)
                    {
                        biggest = rightSum;
                    }
                    if (rightSum < smallest)
                    {
                        smallest = rightSum;
                    }
                }
                if (leftSum - rightSum == 0)
                    {
                        Console.WriteLine("Yes, value=" + leftSum);
                        isEqual = false;
                    break;
                    }
                    else break;
                             

            }
            if (isEqual)
            {
                Console.WriteLine("No, maxdiff=" + (biggest - smallest));
            }
            

        }
    }
}
