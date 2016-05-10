using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());           
            int num=0;
            do
            {
                
                num = num + n % 10;
                if (n != 0)
                {
                    n = n / 10;
                }
                

            } while (n!=0);

            Console.WriteLine("tre result is: "+num);
        }
    }
}
