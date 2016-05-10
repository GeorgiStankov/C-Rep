using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            double s= w * m;
            double a = Math.Ceiling(x / s);
            
            Console.WriteLine(a);
            
        }
    }
}
