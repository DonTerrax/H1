using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder_h1_pytagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1: ");
            double input1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            double input2 = double.Parse(Console.ReadLine());

            if (input1 > input2)
            {
                Console.WriteLine("Input 1 is largest");
            }
            else if(input1 < input2)
            {
                Console.WriteLine("input 2 is largest");
            }
            else
            {
                Console.WriteLine("Number 1 and number 2 is the same size");
            }

            Console.WriteLine("");

            Console.WriteLine("C = {0}",pythagoras(input1,input2));
        }

        public static double pythagoras(double number1, double number2)
        {
            double result = Math.Sqrt(number1 * number1 + number2 * number2);

            return (result);
        }
    }
}
