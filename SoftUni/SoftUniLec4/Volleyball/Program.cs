using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            double weekend = 48-h;
            weekend = weekend * 3/4+p*2/3 +h;
           
            if (year == "normal")
            {
                Console.WriteLine(weekend);
            }
            else if (year == "leap")
            {
                weekend = weekend + (weekend * 0.15);
                Console.WriteLine("{0:f0}",weekend);

            }
        }
    }
}
