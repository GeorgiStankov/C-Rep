using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var first=Console.ReadLine();
            var second = Console.ReadLine();
            first = first.ToLower();
            second = second.ToLower();

            if (first == second)
            {
                Console.WriteLine("yes");

            }
            else
                Console.WriteLine("no");
        }
    }
}
