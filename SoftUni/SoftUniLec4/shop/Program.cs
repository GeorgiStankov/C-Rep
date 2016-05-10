using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town =Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            double price = 0;
            

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.5;
                }
                if (product == "water")
                {
                    price = quantity * 0.8;
                }
                if (product == "beer")
                {
                    price = quantity * 1.2;
                }
                if (product == "sweets")
                {
                    price = quantity * 1.45;
                }
                if (product == "peanuts")
                {
                    price = quantity * 1.6;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.4;
                }
                if (product == "water")
                {
                    price = quantity * 0.7;
                }
                if (product == "beer")
                {
                    price = quantity * 1.15;
                }
                if (product == "sweets")
                {
                    price = quantity * 1.30;
                }
                if (product == "peanuts")
                {
                    price = quantity * 1.50;
                }
            }
           else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.45;
                }
                if (product == "water")
                {
                    price = quantity * 0.70;
                }
                if (product == "beer")
                {
                    price = quantity * 1.1;
                }
                if (product == "sweets")
                {
                    price = quantity * 1.35;
                }
                if (product == "peanuts")
                {
                    price = quantity * 1.55;
                }
            }
            Console.WriteLine(price);
        }
    }
}
