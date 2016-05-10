using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 100000000000000;
            for (int i=0;i<n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < sum)
                {
                    sum=num;
                }
                 
                
            }
            Console.WriteLine(sum);
        }
    }
}
