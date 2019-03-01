using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pytagoras
{
    class Program
    {
        static void Main(string[] args)
        {

            double sqh, h;
            Console.WriteLine("First number");
            double input1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            double input2 = double.Parse(Console.ReadLine());
            sqh = input1 * input1 + input2 * input2;
            h = Math.Sqrt(sqh);
            Console.WriteLine("C = {0}",h);
            if (input1 > input2)
            {
                Console.WriteLine("First input is largest");
            }
            else
            {
                Console.WriteLine("Second input is largest");
            }

            Console.ReadKey();
        }
    }
}
