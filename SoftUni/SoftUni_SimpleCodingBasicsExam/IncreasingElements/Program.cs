using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int len = 0;
            int maxlen = 0;
            int prev = 0;

            for(int i=0;i< n; i++)
            {
                var m = int.Parse(Console.ReadLine());
                if ((i==0) || (m > prev))
                {
                    len++;
                }

              else 
                {
                    len = 1;
                }
               if(len>maxlen)                
                    maxlen = len;                 
                                 
               prev=m;
                
            }
            Console.WriteLine(maxlen);
            
        }
    }
}
