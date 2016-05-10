using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiasToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var bg = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((bg * 1.79549),2));


        }
    }
}
