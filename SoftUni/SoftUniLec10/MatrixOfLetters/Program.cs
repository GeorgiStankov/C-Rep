using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());
            var matrix = new char[row, col];
            char letter = 'A';

            for(int i=0;i< row; i++)
            {
                for(int s=0;s< col; s++)
                {
                    matrix[i,s] = letter;
                    letter++;

                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int s = 0; s < col; s++)
                {
                    Console.Write(matrix[i,s]+" ");

                }
                Console.WriteLine();
            }


        }
    }
}
