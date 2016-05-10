using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (number > 10 && number <= 50)
            {
                Console.Write("average");
            }
            else if (number > 50 && number <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (number > 150 && number <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
                Console.WriteLine("extremely fast");
        }
    }
}

