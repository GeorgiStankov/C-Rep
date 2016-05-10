using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = (double.Parse(Console.ReadLine()))*100;
            var w = double.Parse(Console.ReadLine());
            
            double width = w * 100 - 100;
            int place = (int) width / 70;
            int rows = (int) h / 120; ;       
            
           
            Console.WriteLine(place * rows - 3);
        }
    }
}
