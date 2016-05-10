using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            double s = x1-x2;
            double p = y1 - y2;
           
            if ((x1 - x2) < 1)
            {
                s = (x1 - x2) * (-1);
            }
            if ((y1 - y2) < 1)
            {
                p = (y1 - y2) * (-1);
            }

            double q = s * p;
            Console.WriteLine(q);
            Console.WriteLine(2*(s+p));
           
        }
    }
}
