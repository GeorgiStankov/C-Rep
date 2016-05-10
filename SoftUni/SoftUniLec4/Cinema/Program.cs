using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var project = Console.ReadLine();
            var line = int.Parse(Console.ReadLine());
            var colum = int.Parse(Console.ReadLine());

            double result=0;
            var hall = line * colum;
            if (project == "Premiere")
            {
                result = hall * 12;
            }
            else if (project == "Normal")
            {
                result = hall * 7.5;
            }
            else if (project == "Discount")
            {
                result = hall * 5;
            }
            Console.WriteLine("{0:f2} leva", result);


        }
    }
}
