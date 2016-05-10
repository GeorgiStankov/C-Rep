using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = arr.Length / 2 - 1;
            int end = start + 2;
            if (arr.Length == 1) start = end = 0;
            else if (arr.Length % 2 == 0) end--;
            int[] mid = new int[end - start + 1];
            for(int i = 0; i < mid.Length; i++)
            {
                mid[i] = arr[start+i];
            }

            Console.WriteLine("{ "+string.Join(", ",mid)+" }");
        }
    }
}
