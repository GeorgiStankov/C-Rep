using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea1
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            double area= ((a * b) / 2);
            Console.WriteLine(Math.Round(area,2));
        }
    }
}
