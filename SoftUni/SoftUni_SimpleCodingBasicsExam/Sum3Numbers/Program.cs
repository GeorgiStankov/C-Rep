using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var min = Math.Min(Math.Min(a, b), c);
            var max = Math.Max(Math.Max(a, b), c);
            var sum = a + b + c;
            var mid = sum-  max - min;

            if (min + mid == max)
            {
                Console.WriteLine(min+"+"+mid+"="+max);
            }
            else
                Console.WriteLine("No");
        }
    }
}

            