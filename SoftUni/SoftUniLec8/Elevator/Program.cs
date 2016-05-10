using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int courses = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling((double)people/courses));
        }
    }
}
