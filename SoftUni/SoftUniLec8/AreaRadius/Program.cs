using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for(int i = 0; i < r; i++)
            {
                sum+= decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);

            
         }
    }
}
