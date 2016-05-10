using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine()); 
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            var distanceF = Math.Abs(first - point);
            var distanceS = Math.Abs(second - point);

            if (point<=Math.Max(first,second) && point >= Math.Min(first,second))
            {
                Console.WriteLine("in");
            }
            else
                Console.WriteLine("out");

            if (distanceF > distanceS)
            {
                Console.WriteLine(distanceS);
            }
            else
                Console.WriteLine(distanceF);
        }
    }
}
