using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            double area=0;
            
            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            if(figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                 area = a * b;
            }
            if (figure == "circle")
            {
                var a = double.Parse(Console.ReadLine());
                area = Math.PI * a *a;

            }
            if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                area = (a * b) / 2;
            }
            Console.WriteLine(Math.Round(area, 3));
        }        
    }
}
