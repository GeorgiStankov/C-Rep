using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondeseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = arr.Length;
            while (arr.Length> 1)
            {
                int[] condensed = new int[arr.Length-1];
                for(int i = 1; i < arr.Length-1; i++)
                {
                    condensed[i-1] = arr[i-1] + arr[i];
                    
                   
                }
                arr = condensed;
              
                
            }
            Console.WriteLine(arr[0]);
        }
    }
}
