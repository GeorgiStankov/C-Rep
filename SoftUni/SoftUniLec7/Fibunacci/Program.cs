using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibunacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1;
            int f0 = 1;
            int f1 = 1;
            for(int i=1;i< n; i++)
            {                
                num = f0 + f1;
                f0 = f1;
                f1 = num;
            }
            Console.WriteLine(num);
        }
    }
}
