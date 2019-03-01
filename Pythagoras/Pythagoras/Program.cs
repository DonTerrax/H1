using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqh, h;
            Console.WriteLine("First number");
            double inputA = double.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            double inputB = double.Parse(Console.ReadLine());
            sqh = inputA * inputA + inputB * inputB;

            h = Math.Sqrt(sqh);
            Console.WriteLine("Hypotenius is "+ h);

            if (inputA > inputB)
            {
                Console.WriteLine("First number is largest");
            }
            else if (inputB > inputA)
            {
                Console.WriteLine("Second number is largest");
            }
        }
    }
}
