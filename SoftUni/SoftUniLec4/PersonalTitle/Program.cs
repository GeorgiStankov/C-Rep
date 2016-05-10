using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender =Console.ReadLine();
            string title = "";
            if (gender == "m")
            {
                if (age >= 16)
                {
                    title = "Mr.";
                }
                else
                    title = "Master";
            }
            if (gender == "f")
            {
                if (age >= 16)
                {
                    title = "Ms.";
                }
                else
                    title = "Miss";
            }
            Console.WriteLine(title);
        }
    }
}
