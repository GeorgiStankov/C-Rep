using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
           var a=int.Parse(Console.ReadLine()); 
           var b=int.Parse(Console.ReadLine());
           var c = int.Parse(Console.ReadLine());

            int second = a + b + c;
            int minutes = second / 60;
            second = second - minutes * 60;

            if (second < 60)
            {
                if (second < 10)
                {
                    Console.WriteLine(minutes + ":0" + second);
                }
                else
                Console.WriteLine(minutes+":"+second);

            }
        }
    }
}
