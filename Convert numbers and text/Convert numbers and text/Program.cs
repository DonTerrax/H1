using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_numbers_and_text
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversions
            int num = 1234567780;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            //Explicit conversion
            //Cast double to int
            myInt = (int) myDouble;

            //Type conversion
            string myString = myFloat.ToString();
            Console.WriteLine(myString);
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
        }
    }
}
