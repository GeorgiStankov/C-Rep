using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] arr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            bool command = true;
            do
            {
                int index1 = 0;
                int index2 = 0;
                string[] comm = Console.ReadLine().Split(' ').ToArray();
                if (comm[0] == "end")
                {
                    command = false;
                    break;
                }
                else if (comm[0] == "swap")
                {
                    index1 = int.Parse(comm[1]);
                    index2 = int.Parse(comm[2]);
                    swap(index1, index2, arr);
                       
                }
                else if (comm[0] == "multiply")
                {
                    index1 = int.Parse(comm[1]);
                    index2 = int.Parse(comm[2]);
                    arr[index1] = arr[index1] * arr[index2];

                }
                else if (comm[0] == "decrease")
                {
                    for(int i = 0; i < arr.Length; i++)
                    {
                        arr[i] -= 1;
                    }

                }


            } while (command);

            Console.WriteLine(string.Join(", ",arr));
        }
        public static decimal[] swap(int index1,int index2,decimal[] arr)
        {
            decimal temp = 0;
            temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
            return arr;
        }
        
        
    }
}
