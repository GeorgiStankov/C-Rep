using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalidromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            char cRow = 'a';
            char cCol = cRow;

            for(int i = 0; i < row; i++)
            {

                for(int s = 0; s < col; s++)
                {
                    
                    Console.Write(cRow +""+ cCol+""+cRow+" ");
                    cCol++;
                }
                Console.WriteLine();
                cRow++;
                cCol = cRow;

            }
        }
    }
}
