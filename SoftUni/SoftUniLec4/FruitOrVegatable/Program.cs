using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegatable
{
    class Program
    {
        static void Main(string[] args)
        {
            var food = Console.ReadLine();
            var fruit = new[] { "banana","kiwi","apple","cherry","lemon","grapes" };
            var vegetable = new[] { "tomato", "cucumber", "pepper", "carrot" };
            bool isUnknownType = true;

            for(int i = 0; i < fruit.Length; i++)
            {
                if (food == fruit[i]) 
                {
                    Console.WriteLine("fruit");
                    isUnknownType = false;
                    break;
                }
            }
            for(int i = 0; i < vegetable.Length; i++)
            {
                if (food == vegetable[i])
                {
                    Console.WriteLine("vegetable");
                    isUnknownType = false;
                    break;
                }
                
            }
            if(isUnknownType)
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
