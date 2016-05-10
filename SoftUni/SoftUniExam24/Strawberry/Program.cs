using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = n;
            int boundary = 0;
            ;
            for(int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}/{3}",new string('-',boundary),new string('-',count), new string('-', count), new string('-', boundary));
                boundary+= 2;
                count -= 2;
            }
            count = n;
            boundary = 1;
            for(int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{2}",new string('-',count),new string('.',boundary), new string('-', count));
                count -= 2;
                boundary += 4;
            }
            count = 0;
            boundary = 2 * n + 1;
            for(int i = 0; i < n + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{2}", new string('-', count), new string('.', boundary), new string('-', count));
                count++;
                boundary -= 2;
            }
        }
    }
}
