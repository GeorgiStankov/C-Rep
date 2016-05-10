using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddNum = 0;
            int evenNum = 0;
            for(int i=0;i< n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddNum += num;
                }
                else
                    evenNum += num;
            }
            if (oddNum == evenNum)
            {
                Console.WriteLine("Yes, sum = " + oddNum);
            }
            else
                Console.WriteLine("No, diff = " + Math.Abs(oddNum-evenNum));

        }
    }
}
