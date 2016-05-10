using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var arrHour = int.Parse(Console.ReadLine());
            var arrMinute = int.Parse(Console.ReadLine());

            if (examHour < arrHour || (examHour == arrHour && examMinute < arrMinute))
            {
                Console.WriteLine("Late");
                if (examHour == arrHour)
                {
                    Console.WriteLine(Math.Abs(examMinute - arrMinute) + " minutes after the start");
                }
                if (examHour < arrHour)
                {
                    if ((Math.Abs(examHour - arrHour)==1)&& (Math.Abs(examMinute - arrMinute) == 1))
                    {

                    }
                    Console.WriteLine(Math.Abs(examHour - arrHour) + ":{0} hours after the start", Math.Abs(examMinute - arrMinute));
                }

            }
            if ((examHour == arrHour && examMinute == arrMinute) || (examHour >= arrHour && (Math.Abs(examMinute - arrMinute) <= 30)))
            {
               
                if (examHour > arrHour && (Math.Abs(examMinute - arrMinute)) >= 30)
                {

                    Console.WriteLine("Early");
                    Console.WriteLine(Math.Abs(examHour - arrHour) + ":{0} hours before the start", Math.Abs(examMinute - arrMinute));
                }

            }
            else if ((examHour == arrHour && examMinute == arrMinute) || (examHour >= arrHour && (Math.Abs(examMinute - arrMinute) <= 30)))
            {
                Console.WriteLine("On time");
                if ((Math.Abs(examMinute - arrMinute) < 60) && (Math.Abs(examHour - arrHour) < 1))
                {
                    
                    Console.WriteLine("{0} minutes before the start", Math.Abs(examMinute - arrMinute));
                }
                if (examHour > arrHour)
                {
                    Console.WriteLine(Math.Abs(examHour - arrHour) + ":{0} hours before the start", Math.Abs(examMinute - arrMinute));
                }


            }
            
        }
    }
}
