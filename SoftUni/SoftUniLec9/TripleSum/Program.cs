﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isNo = true;
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int a = nums[i];
                    int b = nums[j];
                    int sum = a + b;
                    if (nums.Contains(sum))
                    {
                       Console.WriteLine($"{a} + {b} == {sum}");
                        isNo = false;
                    }
                                        
                }
            if (isNo)
            {
                Console.WriteLine("No");
            }

                                      
        }
    }
}