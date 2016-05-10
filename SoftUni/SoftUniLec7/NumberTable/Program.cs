using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            int num = 1;
            for(int row=0;row< a; row++)
            {
                for(int col=0;col<a; col++)
                {
                    num = row + col + 1;
                    if (num > a)
                    {
                        num = 2 * a - num;
                        
                    }
                   
                        Console.Write(num + " ");
                    
                    
                }
                Console.WriteLine();
            }
       
        }
    }
}
