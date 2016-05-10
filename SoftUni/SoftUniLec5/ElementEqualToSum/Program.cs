using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementEqualToSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNum = 0;
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
               var a= int.Parse(Console.ReadLine());
                if (biggestNum < a)
                {
                    biggestNum = a;
                }
                sum =sum + a;
            }
            if (biggestNum == (sum-biggestNum))
            {
                Console.WriteLine("Yes, sum = " + biggestNum);
            }
            else
                Console.WriteLine("No, diff = " + Math.Abs(biggestNum-(sum-biggestNum)));
        }
    }
}
