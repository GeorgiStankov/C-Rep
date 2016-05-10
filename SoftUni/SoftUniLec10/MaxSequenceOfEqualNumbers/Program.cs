using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int tempSequence = 1, maxsequence = 1; ;
            int number1 = list[0];
            
            for (int i = 1; i < list.Count; i++)
            {
                
                if (list[i - 1] == list[i])
                {
                    tempSequence++;
                    if (tempSequence > maxsequence)
                    {
                        maxsequence = tempSequence;
                        number1 = list[i - 1];
                        
                    }

                }
                else tempSequence = 1;
            }
            
                for (int i = 0; i < maxsequence; i++)
                {
                    Console.WriteLine("{0} ", number1);
                }
            
        }
    }
}
