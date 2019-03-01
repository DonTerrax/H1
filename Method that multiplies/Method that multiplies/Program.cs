using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_that_multiplies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(10,10));
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
