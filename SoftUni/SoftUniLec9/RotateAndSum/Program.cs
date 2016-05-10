using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] narr = new int[n.Length];


            RotateRight(n, k);
            for(int i = 0; i < n.Length - 1; i++)
            {
                Console.Write(n[i]+" ");
            }
            
            
        }
        public static void RotateRight(int[] input, int right)
        {
            for (var i = 0; i < right; i += 1)
            {
                RotateRightOne(input);
            }
        }

        public static void RotateRightOne(int[] input)
        {
            var last = input.Length - 1;
            for (var i = 0; i < last; i += 1)
            {
                input[i] ^= input[last];
                input[last] ^= input[i];
                input[i] ^= input[last];
            }
        }
    }
}   
