using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());

            var dayAfter5 = day + 5;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (month == 12 && dayAfter5>31)
                {
                    month = month - 12;
                }
                if (dayAfter5 > 31)
                {
                    month++;
                    dayAfter5 = dayAfter5 - 31;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (dayAfter5 > 30)
                {
                    month++;
                    dayAfter5 = dayAfter5 - 30;
                }
            }
            else if (month == 2)
            {
                if (dayAfter5 > 28)
                {
                    month++;
                    dayAfter5 = dayAfter5 - 28;
                }

            }
            if (month < 10)
            {
                Console.WriteLine(dayAfter5 + ".0" + month);
            }
            else
            {
                Console.WriteLine(dayAfter5 + "." + month);
            }


        }
    }
}
