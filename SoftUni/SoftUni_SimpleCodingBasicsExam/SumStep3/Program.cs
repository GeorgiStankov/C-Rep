    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SumStep3
    {
        class Program
        {
            static void Main(string[] args)
            {
                var n = int.Parse(Console.ReadLine());
                int sum1 = 0, sum2 = 0, sum3 = 0;
                for(int i=0;i< n; i++)
                {
                    var c = int.Parse(Console.ReadLine());
                    if (i % 3 == 0)
                    {
                        sum1 = sum1 + c;
                    }
                    if (i % 3 == 1)
                    {
                        sum2 = sum2 + c;
                    }
                    if (i % 3    == 2)
                    {
                        sum3 = sum3 + c;
                    }
                }
                Console.WriteLine("sum1= {0}", sum1);
                Console.WriteLine("sum2= {0}", sum2);
                Console.WriteLine("sum3= {0}", sum3);
            }
        }
    }
