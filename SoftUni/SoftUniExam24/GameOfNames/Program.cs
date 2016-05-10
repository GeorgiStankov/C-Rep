using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           int finalScore = -100000000;
            string winner = "";
            for (int i = 0; i < n; i++)
            {
                string name =Console.ReadLine();            
                int score = int.Parse(Console.ReadLine());              
             
                for(int c = 0; c < name.Length; c++)
                {
                    if (name[c] % 2 == 0)
                    {
                        score += name[c];
                    }
                    else score = score- name[c];
                }
                if (finalScore < score && (name.Length>=3 && name.Length<=30))
                {
                    finalScore = score;
                    winner = name;                    
                }
                
            }
            
            Console.WriteLine("The winner is {0} - {1} points", winner, finalScore);

        }
    }
}
