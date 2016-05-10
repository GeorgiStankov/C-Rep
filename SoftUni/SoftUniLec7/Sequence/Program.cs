using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int k = 1;
            for (int i = 0; i < n;i++)
            {
                if (k <= n)
                {
                    Console.WriteLine(k);
                    k = (2 * k) + 1;
                 }

               
            }
        }
    }
}
