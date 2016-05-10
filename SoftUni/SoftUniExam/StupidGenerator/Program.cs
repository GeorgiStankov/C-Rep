using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            char[] alphabet = { 'a', 'b', 'c', 'd' };

            for (int i = 1; i < n; i++)
            {
                for (int s = 1; s < n; s++)
                {
                    for (int c = 0; c < alphabet.Length; c++)
                    {
                        for (int e = 0; e < alphabet.Length; e++)
                        {
                            for (int w = 1; w < n; w++)
                            {


                                var first = i;
                                var second = s;
                                var third = alphabet[c];
                                var fourth = alphabet[e];
                                var fifth = w;  
                                
                                String number = first + "" + second + "" + third + "" + fourth +fifth+"";
                                Console.WriteLine(number);
                                
                            }

                        }
                    }
                }

            }
        }
    }
}
