using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            string[,] matrix = new string[row, col];
            for(int i = 0; i < row; i++)
            {
                var cell = Console.ReadLine().Split(' ').ToArray();
                for(int s=0;s< col; s++)
                {
                    matrix[i, s] = cell[s];
                }
            }
            for (int i = 0; i <col; i++)
            {
                for (int s = row-1; s >=0; s--)
                {
                    Console.Write(matrix[s, i] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
