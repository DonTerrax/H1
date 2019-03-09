using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Square test = new Square(5);

            Console.WriteLine(test.calculator());


            Square test2 = new Square(20);
            Console.WriteLine(test2.calculator());

            Square test3 = new Square(10);
            Console.WriteLine(test3.area());
        }
    }
}
