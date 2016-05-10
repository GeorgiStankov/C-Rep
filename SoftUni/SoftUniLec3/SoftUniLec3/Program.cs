using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLec3
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade =double.Parse(Console.ReadLine());
            if (grade >= 5.5 && grade <= 6)
            {
                Console.WriteLine("Excellent!");
            }
            else
                Console.WriteLine("Not excellent.");
                
        }

    }
}
