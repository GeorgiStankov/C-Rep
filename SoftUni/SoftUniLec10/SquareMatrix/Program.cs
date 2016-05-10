using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            char[,] matrix = new char[row, col];
            int count = 0;

            for (int i = 0; i < row; i++)
            {
                var cell = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int s = 0; s < col; s++)
                {
                    matrix[i, s] = cell[s]; 
                }
            }
            for (int i = 1; i < row; i++)
            {
                
                for (int s = 1; s < col; s++)
                {
                    if (matrix[i-1, s-1] == matrix[i-1, s] && matrix[i,s-1]==matrix[i,s] && matrix[i-1,s-1]==matrix[i,s-1])
                    {
                        count++;
                    }
                }
            }
             Console.WriteLine(count);

        }
    }
}
