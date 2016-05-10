using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int pos = 0;
            while (pos < list.Count-1)
            {
                if (list[pos] == list[pos + 1])
                {
                    list[pos] = list[pos] * 2;
                    list.RemoveAt(pos + 1);
                    if(pos!=0)
                    pos--;

                }
                else pos++;
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
