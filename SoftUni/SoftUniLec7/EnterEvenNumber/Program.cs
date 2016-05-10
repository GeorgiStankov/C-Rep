using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {           
            bool isEven = true;

            while (isEven)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    var n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: "+n);                        
                        break;
                    }
                }

                catch (FormatException)
                {                    
                    Console.WriteLine("Invalid number!");
                }
                catch (System.OverflowException)
                {

                }
                    
           }
            
                

        }
    }
}

