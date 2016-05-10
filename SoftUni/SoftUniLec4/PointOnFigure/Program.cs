using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = h;
            int x2 = 3 * h;
            int y2 = 0;
            int x3 = h;
            int y3 = 4 * h;
            int x4 = 2 * h;
            int y4 = h;



            var onLeftSide = (x == x1) && (y <= y1) && (y >= y2);
            var onRightSide = (x == x2) && (y <= y1) && (y >= y2);
            var onUpSide = (y == y1) && (x >= x1) && (x <= x3);
            var onDownSide = (y == y2) && (x >= x1) && (x <= x2);
            var onLeftSide1 = (x == x3) && (y <= y3) && (y >= y4);
            var onRightSide1 = (x == x4) && (y <= y3) && (y >= y4);
            var onUpSide1 = (y == y3) && (x >= x3) && (x <= x4);
            var onDownSide1 = (y == y4) && (x >= x4) && (x <= x2);
            bool isCorrect = true;
            if (onLeftSide || onRightSide || onUpSide || onDownSide || onLeftSide1 || onRightSide1 || onUpSide1 || onDownSide1)
            {
                Console.WriteLine("Border");
                isCorrect = false;
            }
            else if (x >= Math.Min(x1, x2) && x <= Math.Max(x1, x2) && y >= Math.Min(y1, y2) && y <= Math.Max(y1, y2))
            {
                Console.WriteLine("Inside");
                isCorrect = false;
            }
            else if (x >= Math.Min(x3, x4) && x <= Math.Max(x3, x4) && y >= Math.Min(y3, y4) && y <= Math.Max(y3, y4))
            {
                Console.WriteLine("Inside");
                isCorrect = false;
            }
            else if (isCorrect)
                Console.WriteLine("Outside");


        }
    }
}
