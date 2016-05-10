using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var metric = double.Parse(Console.ReadLine());
            var unitFrom = Console.ReadLine();
            var unitTo = Console.ReadLine();

            if (unitFrom == "mm")
            {
                metric = metric / 1000;
                convert(metric, unitTo);

            }
            if (unitFrom == "cm")
            {
                metric = metric / 100;
                    convert(metric, unitTo);

            }

            if (unitFrom == "m")
            {

                convert(metric, unitTo);
            }


            if (unitFrom == "mi")
            {
                metric = metric / 0.000621371192;
                convert(metric, unitTo);

            }
            if (unitFrom == "in")
            {
                metric = metric / 39.3700787;
                convert(metric, unitTo);

            }
            if (unitFrom == "km")
            {
                metric = metric / 0.001;
                convert(metric, unitTo);

            }
            if (unitFrom == "ft")
            {
                metric = metric / 3.2808399;
                convert(metric, unitTo);

            }
            if (unitFrom == "yd")
            {
                metric = metric / 1.0936133;
                convert(metric, unitTo);

            }
        }

        public static void convert(double metric,string unitTo)
        {
            if (unitTo == "mm")
            {
                metric = metric* 1000;

            }
            if (unitTo == "cm")
            {
                metric = metric * 100;

            }

            if (unitTo == "m")
            {
                metric = metric;


            }


            if (unitTo == "mi")
            {
                metric = metric *0.000621371192;

            }
            if (unitTo == "in")
            {
                metric = metric * 39.3700787;

            }
            if (unitTo == "km")
            {
                metric = metric * 0.001;

            }
            if (unitTo == "ft")
            {
                metric = metric * 3.2808399;

            }
            if (unitTo == "yd")
            {
                metric = metric * 1.0936133;

            }
            Console.WriteLine(metric +" "+ unitTo);
            

        }
    }
}
