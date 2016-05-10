using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExam24
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal guest = decimal.Parse(Console.ReadLine());
            decimal priceBanana = decimal.Parse(Console.ReadLine());
            decimal priceEgg = decimal.Parse(Console.ReadLine());
            decimal priceBerry = decimal.Parse(Console.ReadLine());

            decimal set = Math.Ceiling(guest / 6);
           
           
            decimal price= set*((2*priceBanana)+(4*priceEgg)+(priceBerry*0.2m));
           
            decimal neededMoney = Math.Abs(amount-price);
          
            if (amount >=price)
            {
                 Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", price);
                
            }
            else Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", neededMoney);

        }
    }
}
