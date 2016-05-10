using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] arr1 = new int[arr.Length/2];
            int[] arr2 = new int[arr.Length / 2];

            for (int i = 0; i < k; i++)
            {
                arr1[i] = arr[k-1-i];
                arr1[k + i] = arr[(4*k-1) - i];
                arr2[i] = arr[k + i];
                arr2[k + i] = arr[2 * k + i];
            }
            
            
            for(int i = 0; i < arr.Length / 2; i++)
            {
                
                Console.Write(arr1[i] + arr2[i]+" ");
                
            }
        

        }
    }
}
