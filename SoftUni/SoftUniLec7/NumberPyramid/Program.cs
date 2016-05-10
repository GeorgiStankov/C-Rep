using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int s = 1;
            for (int c = 1; c <= n; c++)
            {
           
                for (int i = 1; i <= c; i++)
                {
                    Console.Write("{0} ",s);
                    s++;                    
                    if(s>n)
                    {
                        break;
                    }                    
                   
                }
                if (s > n)
                {
                    break;
                }
                Console.WriteLine();
               
                

            }
        }
    }
}
