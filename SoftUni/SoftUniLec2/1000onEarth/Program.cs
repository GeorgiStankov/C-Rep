using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000onEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            var c =Console.ReadLine();
            string format="dd-MM-yyyy" ;
            DateTime d=DateTime.ParseExact(c,format,null);           
           
            Console.WriteLine((d.AddDays(999)).ToString(format));
            
            
        }
    }
}
