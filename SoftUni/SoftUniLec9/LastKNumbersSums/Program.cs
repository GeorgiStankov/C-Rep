using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;            
            for(int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int prev = i - k; prev <= i - 1; prev++)
                    if (prev >= 0)                  
                         sum += sequence[prev];
                
                sequence[i] = sum;
            }
            for(int c = 0; c < n; c++)
            {
                Console.WriteLine(sequence[c]);
            }
        
        }
    }
}
