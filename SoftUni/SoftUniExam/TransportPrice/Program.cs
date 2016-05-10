using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var travel = Console.ReadLine();
            double tax = 0;
            double price = 0;
            if (n >=100)
            {               
                    tax = 0.06;
                    price = tax * n; 
            }
            else if(n>=20 && n < 100)
            {
                tax = 0.09;
                price = tax * n;
                
            }
            else if (n < 20)
            {
                if (travel == "day")
                {
                    tax = 0.79;
                }
                else
                {
                    tax = 0.9 ;
                }
                price = tax * n+0.7;

            }
            Console.WriteLine(price);
        }
    }
}
