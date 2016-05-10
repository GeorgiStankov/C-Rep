using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Gryffindor = 0;
            int Slytherin = 0;
            int Ravenclaw = 0;
            int Hufflepuff = 0;


            for (int i=0;i< n; i++)
            {
                int sumASCII = 0;
               string[] student = Console.ReadLine().Split(' ').ToArray();
                string FirstName = student[0];
                string SecondName = student[1];
                for(int c = 0; c < FirstName.Length; c++)
                {
                    sumASCII += FirstName[c];
                }
                for (int c = 0; c < SecondName.Length; c++)
                {
                    sumASCII += SecondName[c];
                }
                string facultyNumber = string.Format("{0}{1}",sumASCII,FirstName[0]+""+SecondName[0]);
                int reminder = (sumASCII % 4);
                string house = "";
                if (reminder == 0)
                {
                    Gryffindor++;
                    house = "Gryffindor";
                }
                else if (reminder == 1)
                {
                    Slytherin++;
                    house = "Slytherin";
                }
                else if (reminder == 2)
                {
                    Ravenclaw++;
                    house = "Ravenclaw";
                }
                else if (reminder == 3)
                {
                    Hufflepuff++;
                    house = "Hufflepuff";
                }

                Console.WriteLine("{0} {1}",house,facultyNumber);

            }
            Console.WriteLine();
            Console.WriteLine("Gryffindor: {0}",Gryffindor);
            Console.WriteLine("Slytherin: {0}", Slytherin);
            Console.WriteLine("Ravenclaw: {0}", Ravenclaw);
            Console.WriteLine("Hufflepuff: {0}", Hufflepuff);


        }
    }
}
