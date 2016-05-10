using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePark
{
    class Program
    {
        static void Main(string[] args)
        {
            var carPark = Console.ReadLine().Split(' ').ToList();
            int sold = 0;
            
            bool end = true;
            do
            {
                int price = 0;
                string request1 = Console.ReadLine();               
               
                if (request1== "End of customers!")
                {
                    end = false;
                    break;
                }
                string[] request = request1.Split(' ').ToArray();
                string type = request[0].ToLower();
                string seat = request[2];
                string car =type[0]+""+seat;
                
                if (carPark.Contains(car))
                {
                    price = type[0] * int.Parse(seat);
                    Console.WriteLine("Yes, sold for {0}$", price);
                    carPark.Remove(car);
                    sold++;
                    
                }
                else Console.WriteLine("No");

                

            } while (end);
            
                Console.WriteLine("Vehicles left: " + string.Join(", ",carPark));
                Console.WriteLine("Vehicles sold: {0}",sold);
        }
    }
}
