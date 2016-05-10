using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitbyWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators= new char[]{ ',', ';', ':', '.', '!', ' ','\"','(',')','[',']','/','\\','\'' };
            var str = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries).ToList();
            var lowercase = new List<string>();
            var mixcase = new List<string>();
            var uppercase = new List<string>();
            foreach (var element in str)
            {
                var lowerCaseChars = 0;
                var upperCaseChars = 0;
                foreach (char letter in element)
                    if (char.IsLower(letter)) lowerCaseChars++;
                    else if (char.IsUpper(letter)) upperCaseChars++;
                if (lowerCaseChars == element.Length)
                    lowercase.Add(element);
                else if (upperCaseChars == element.Length)
                    uppercase.Add(element);
                else mixcase.Add(element);

            }
            Console.WriteLine("Lower-case: {0}",string.Join(", ",lowercase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixcase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercase));
        }
    }
}
