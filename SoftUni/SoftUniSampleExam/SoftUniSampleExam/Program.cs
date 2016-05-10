using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniSampleExam
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal priceUS =decimal.Parse(Console.ReadLine());
            long weightUS = long.Parse(Console.ReadLine());
            decimal priceUK = decimal.Parse(Console.ReadLine());
            long weightUK = long.Parse(Console.ReadLine());
            decimal priceCH = decimal.Parse(Console.ReadLine());
            long weightCH = long.Parse(Console.ReadLine());

            priceUS = priceUS / 0.58M;
            priceUK = priceUK / 0.41M;
            priceCH =priceCH * 0.27M;
            decimal USperKilo = priceUS / weightUS;
            decimal UKperKilo = priceUK / weightUK;
            decimal CHperKilo = priceCH / weightCH;
            string store="";
            decimal price = Math.Min(USperKilo, Math.Min(UKperKilo, CHperKilo));
            decimal maxPrice= Math.Abs((Math.Max(USperKilo,Math.Max(UKperKilo, CHperKilo))-price));
            if (price == USperKilo)
            {
                store = "US";
            }
            else if (price == UKperKilo)
            {
                store = "UK";
            }
            else if (price == CHperKilo)
            {
                store = "Chinese";
            }
            
            Console.WriteLine("{0} store. {1:f2} lv/kg",store,price);
            Console.WriteLine("Difference {0:f2} lv/kg",maxPrice);

        }
    }
}
