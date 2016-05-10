using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            int s = 1;
            for(int i=1;i<= a; i++)
            {
                s = a * i;
                
            }
            Console.WriteLine(s);
        }
    }
}
