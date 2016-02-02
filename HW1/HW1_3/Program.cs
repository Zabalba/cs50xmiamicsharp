using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_3
{
    class Divide
    {
        static void Main(string[] args)
        {
            /*
            Write a function that accepts a variable number of integers, 
            finds the largest number that’s divisible by 5, 
            and prints that number to the screen; 
            If none of the integers are divisible the print “None Found”
            */

            IsDivisableByFive(51,26,84,43,4,5);

            IsDivisableByFive(1, 5, 10, 13, 20,24);

        }
        static void IsDivisableByFive(params int[] list)
        {

            bool success = false;

            int[] sortedlist = list.OrderByDescending(c => c).ToArray();

            foreach (var item in sortedlist)
            {
                if((item % 5) == 0)
                {
                    Console.WriteLine("Largest number divisible by 5: " + item.ToString() + Environment.NewLine);
                    success = true;
                    break;
                }

            }

            if(!success)
            {
                Console.WriteLine("None Found :(" + Environment.NewLine);
            }


        }
    }
}
