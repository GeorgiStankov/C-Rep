/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15min_
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());

            minute += 15;
                if (minute < 60)
            {
                
                if (hour >= 0 && hour < 9)
                {
                   Console.WriteLine(hour + ":" + minute);

                }
                else if(hour>9)
                {
                    Console.WriteLine(hour + ":" + minute);

                }

            }
            else if (minute >= 60)
            {
                minute = minute - 60;
                hour++;
                if (hour == 24 )
                {
                    if (minute < 10)
                        Console.WriteLine("0:0" + minute);
                    else
                        Console.WriteLine("0:" + minute);
                }
                else if(hour==25)
                {
                    hour = 1;
                    if (minute < 10)
                        Console.WriteLine(hour + ":0" + minute);
                    else
                        Console.WriteLine(hour + ":" + minute);
                }
                else if(hour>=1 && hour < 9)
                {
                    if (minute < 10)
                        Console.WriteLine(hour + ":0" + minute);
                    else
                        Console.WriteLine(hour + ":" + minute);

                }
                else if (hour > 9)
                {
                    if (minute < 10)
                        Console.WriteLine(hour + ":0" + minute);
                    else
                        Console.WriteLine(hour + ":" + minute);

                }
            }
            
            
        }
    }
}*/
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
            Console.WriteLine(NumberToWords(number));
        }
        public static string NumberToWords(int number)
        {
            string words = "";
            if (number == 0 )
                return "zero";

            else if (number < 0 || number > 100)
                return "invalid number";
            else if (number == 100)
            {
                return "one hundred";
            }


            else if (number > 0)
            {

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
