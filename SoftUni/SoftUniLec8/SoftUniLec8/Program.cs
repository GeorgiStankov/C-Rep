using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLec8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Centuries = ");
            ulong century = ulong.Parse(Console.ReadLine());
            ulong year = century * 100;
            ulong day = (ulong)(year * 365.2422);
            ulong hours = day * 24;
            ulong minute = hours * 60;
            ulong sec = minute * 60;
            ulong milisec = sec * 1000;
            ulong microsec =  milisec * 1000;
            decimal nanosec = (decimal) microsec * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", century, year, day, hours, minute,sec,milisec,microsec,nanosec);
        }
    }
}
 