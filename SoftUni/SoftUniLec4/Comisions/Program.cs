using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            double commission = 0;

            if (town == "Sofia")
            {
                if (0 <= sales && sales <= 500) commission = 0.05;
                else if (500 <= sales && sales <= 1000) commission = 0.07;
                else if (1000 <= sales && sales <= 10000) commission = 0.08;
                else if (sales > 1000) commission = 0.12;

            }
            else if (town == "Varna")
            {
                if (0 <= sales && sales <= 500) commission = 0.045;
                else if (500 <= sales && sales <= 1000) commission = 0.075;
                else if (1000 <= sales && sales <= 10000) commission = 0.1;
                else if (sales > 1000) commission = 0.13;

            }
            else if (town == "Plovdiv")
            {
                if (0 <= sales && sales <= 500) commission = 0.055;
                else if (500 <= sales && sales <= 1000) commission = 0.08;
                else if (1000 <= sales && sales <= 10000) commission = 0.12;
                else if (sales > 1000) commission = 0.145;

            }
            else if (town != "Sofia" || town != "Varna" || town != "Plovdiv") Console.WriteLine("error");
            if (commission != 0) Console.WriteLine("{0:f2}", commission * sales);
            else Console.WriteLine("error");
            
             


        }
    }
}
