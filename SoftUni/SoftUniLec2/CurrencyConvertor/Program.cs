using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var a=double.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            var c = Console.ReadLine();

            if (s == "BGN")
            {
                Console.WriteLine(BGN(a, c));
            }
            if (s == "EUR")
            {
                a = a * 1.95583;
                Console.WriteLine(BGN(a, c));                
            }
            if (s == "USD")
            {
                a = a * 1.79549;
                Console.WriteLine(BGN(a, c));
            }
            if (s == "GBP")
            {
                a = a * 2.53405;
                Console.WriteLine(BGN(a, c));
            }

        }
        public static  string BGN(double a, string c)
        {
            string b = "wrong currency";
            if (c == "USD")
            {
                 b=Math.Round(a / (1.79549), 2) +" USD";
               
            }
            if (c == "BGN")
            {
                 b= Math.Round(a,2) + " BGN";
                
            }
            if (c == "GBP")
            {
                 b=Math.Round(a / (2.53405), 2) + " GBP";
                
            }
            if (c == "EUR")
            {
                b=Math.Round(a / (1.95583), 2)+" EUR";
            }
            return b;   
        }
    }
}
