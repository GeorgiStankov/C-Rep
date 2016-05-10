using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMaxMinAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] seq = new int[n];
            for (int i = 0; i < n; i++)
            {
                seq[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = "+ seq.Sum());
            Console.WriteLine("Min = " + seq.Min());
            Console.WriteLine("Max = " + seq.Max());
            Console.WriteLine("First = " + seq.First());
            Console.WriteLine("Last= " + seq.Last());
            Console.WriteLine("Average = " + seq.Average());
        }
    }
}
