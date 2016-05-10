using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumElements
{
    class Program
    {
        static void Main(string[] args)
        {
             
            
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = Math.Max(first.Length, second.Length);
            int[] sum = new int[length];

            for(int i = 0; i < length; i++)
            {
                sum[i] = first[i % first.Length] + second[i % second.Length];
                Console.WriteLine();
                
            }
            Console.WriteLine(string.Join(" ",sum));

        }
    }
}
