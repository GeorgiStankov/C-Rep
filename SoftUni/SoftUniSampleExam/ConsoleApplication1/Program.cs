using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "3456";
            string p = "34";
            if((s[0] + "" + s[1])==p)
            Console.WriteLine(s[0]+""+s[1]);
        }
    }
}
