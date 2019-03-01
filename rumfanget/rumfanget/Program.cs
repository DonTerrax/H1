using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rumfanget
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume;
            Console.WriteLine("Length of the box?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Hight of the box?");
            double hight = double.Parse(Console.ReadLine());
            Console.WriteLine("Width of the box?");
            double width = double.Parse(Console.ReadLine());

            volume = length * hight * width;

            Console.WriteLine("The volume of the box is: {0}",volume);
        }
    }
}
