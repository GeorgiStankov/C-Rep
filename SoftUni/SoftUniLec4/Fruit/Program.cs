using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            bool isError = true;
            
            
            var day1 = new[] {"Monday","Tuesday","Wednesday","Thursday","Friday"};
            
           
                for (int i = 0; i < day1.Length; i++)
                {
                    if (day == day1[i])
                    {
                    workDays(fruit, quantity);
                        isError = false;
                    }
                }
                if (day == "Sunday" || day == "Saturday")
                {
                weekend(fruit, quantity);
                    isError = false;
                }
                if (isError)
                {
                    Console.WriteLine("error");
                }

            
        }

        public static void workDays(string fruit,double quantity)
        {
            double price = 0;
            string p="";

            if (fruit == "banana")
            {
                price =2.50* quantity;
            }
            else if (fruit == "apple")
            {
                price =1.20* quantity;
            }
            else if (fruit == "orange")
            {
                price =0.85* quantity;
            }
           else if (fruit == "grapefruit")
            {
                price =1.45* quantity;
            }
           else if (fruit == "kiwi")
            {
                price =2.70* quantity;
            }
           else if (fruit == "pineapple")
            {
                price =5.50* quantity;
            }
           else if (fruit == "grapes")
            {
                price =3.85* quantity;
            }
            else
            {
                Console.WriteLine("error");
                
            }
            Console.WriteLine("{0:f2}", price);
        }
        public static void weekend(string fruit,double quantity)
        {
            double price=0;

            if (fruit == "banana")
            {
                price = 2.70 * quantity;
            }
           else if (fruit == "apple")
            {
                price = 1.25 * quantity;
            }
            else if (fruit == "orange")
            {
                price = 0.90 * quantity;
            }
           else if (fruit == "grapefruit")
            {
                price = 1.60 * quantity;
            }
           else if (fruit == "kiwi")
            {
                price = 3.00 * quantity;
            }
         else   if (fruit == "pineapple")
            {
                price = 5.60 * quantity;
            }
           else if (fruit == "grapes")
            {
                price = 4.20 * quantity;
            }
            else
            {
                Console.WriteLine("error");
                               
            
            }
          

            Console.WriteLine( "{0:f2}",price);
        }
    }
}
