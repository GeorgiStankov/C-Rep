using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[30];
            double OddSum = 0;
            double OddMin = 10000000;
            double OddMax = -1000000;
            double EvenSum = 0;
            double EvenMin = 10000000;
            double EvenMax = -1000000;
            var n = int.Parse(Console.ReadLine());


            
            for (int i=1;i<= n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());

            }
            for(int i=1;i<=n; i++)
            {
                if (i % 2 == 1 ||i==1)
                {
                    OddSum +=numbers[i];

                    if (OddMin > numbers[i] )
                    {
                        OddMin = numbers[i];
                    }
                    if (numbers[i] > OddMax)
                    {
                        OddMax = numbers[i];
                    }
                }
                else
                {
                    EvenSum += numbers[i];                   
                    if (EvenMin > numbers[i])
                    {
                        EvenMin = numbers[i];
                    }
                    if (numbers[i] > EvenMax)
                    {
                        EvenMax = numbers[i];
                    }

                }

            }
            if (n == 0)
            {
                Console.WriteLine("OddSum=0" + ",OddMin=No" + ",OddMax=No" + ",EvenSum=0" + ",EvenMin=No"  + ",EvenMax=No" );
            }
            else if (OddMax== -1000000 || OddMin== 10000000)
            {
                Console.WriteLine("OddSum=0"+ ",OddMin=No"  + ",OddMax=No" + ",EvenSum=" + EvenSum + ",EvenMin=" + EvenMin + ",EvenMax=" + EvenMax);
            }
          else   if(EvenMax == -1000000 || EvenMin == 10000000)
            {
                Console.WriteLine("OddSum=" + OddSum + ",OddMin=" + OddMin + ",OddMax=" + OddMax + ",EvenSum=0" + ",EvenMin=No" + ",EvenMax=No");
            }
           else  if(EvenMax != -1000000 || OddMax != -1000000)
            Console.WriteLine("OddSum=" + OddSum + ",OddMin=" + OddMin + ",OddMax=" + OddMax + ",EvenSum="+EvenSum + ",EvenMin="+EvenMin+",EvenMax="+EvenMax);

           
        }
    }
}
