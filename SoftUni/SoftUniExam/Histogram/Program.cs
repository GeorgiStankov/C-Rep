    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Histogram
    {
        class Program
        {
            static void Main(string[] args)
            {
                var n = int.Parse(Console.ReadLine());
                double p1 = 0;
                double p2 = 0;
                double p3 = 0;
                double p4 = 0;
                double p5 = 0;


                for (int i=0;i< n; i++)
                {
                    var x = int.Parse(Console.ReadLine());
                    if (x < 200)
                    {
                        p1++;
                    }
                   if(x>=200 && x < 400)
                    {
                        p2++;
                    }
                    if (x >=400 && x < 600)
                    {
                        p3++;
                    }
                    if (x >= 600 && x < 800)
                    {
                        p4++;
                    }
                    if (x >= 800 )
                    {
                        p5++;
                    }
                }
                Console.WriteLine("{0}%",Math.Round(p1/n*100.00,2));
                Console.WriteLine("{0}%", Math.Round(p2 / n * 100.00,2));
                Console.WriteLine("{0}%", Math.Round(p3 / n * 100.00,2));
                Console.WriteLine("{0}%", Math.Round(p4 / n * 100.00,2));
                Console.WriteLine("{0}%", Math.Round(p5 / n * 100.00,2));
            }
        }
    }
