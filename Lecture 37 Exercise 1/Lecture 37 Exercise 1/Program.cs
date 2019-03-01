using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_37_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipArray = { 4800, 4930, 1020, 3040, 3031, 3021, 3400, 2800, 2900, 2044 };
            Console.WriteLine("Enter the zip code to check if we deliver in that area");

            int zip = int.Parse(Console.ReadLine());
            bool contains = false;
            for (int i = 0; i < zipArray.Length; i++)
            {
                if(zip == zipArray[i])
                {
                    contains = true;
                    break;
                }
            }
            if(contains == true)
            {
                Console.WriteLine("We deliver to this area");
            }
            else
            {
                Console.WriteLine("we do not deliver in this area");
            }
        }
    }
}
