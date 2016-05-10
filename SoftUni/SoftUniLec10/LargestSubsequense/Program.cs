using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSubsequense
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> subseq = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> DP = new List<int>();
            List<int> prev = new List<int>();
            int maxLength = 1, bestEnd = 0;
            DP[0] = 1;
            prev[0] = -1;

            for (int i = 1; i < subseq.Count; i++)
            {
                DP[i] = 1;
                prev[i] = -1;

                for (int j = i - 1; j >= 0; j--)
                    if (DP[j] + 1 > DP[i] && subseq[j] < subseq[i])
                    {
                        DP[i] = DP[j] + 1;
                        prev[i] = j;
                    }

                if (DP[i] > maxLength)
                {
                    bestEnd = i;
                    maxLength = DP[i];
                }
            }
            Console.Write(maxLength);
        }
    }
}
