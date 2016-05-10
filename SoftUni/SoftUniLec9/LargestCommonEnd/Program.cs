using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Split(' ').ToArray();
            string[] words2 = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine(LargestCommonEnd(words1, words2));

        }   
        static int LargestCommonEnd(
   string[] words1, string[] words2)
        {
            var rightCount = 0;
            while (rightCount < words1.Length &&
                   rightCount < words2.Length)               
               if ((words1[words1.Length - rightCount - 1] == words2[words2.Length - rightCount - 1]) ||
                    (words1[rightCount] == words2[rightCount]))
                rightCount++;

            else break;
            return rightCount;
        }

    }
}
