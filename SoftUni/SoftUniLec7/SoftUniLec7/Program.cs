using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLec7
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = int.Parse(Console.ReadLine());

            for(int i=1;i<= b; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
