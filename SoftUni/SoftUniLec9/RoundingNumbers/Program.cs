using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for(int index = 0; index < nums.Length; index++)
            {
                Console.WriteLine("{0} => {1}",nums[index],((int) Math.Round(nums[index],MidpointRounding.AwayFromZero)));
            }
        }
    }
}
