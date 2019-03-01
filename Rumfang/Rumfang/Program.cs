using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast højde");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast bredde");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast længde");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Rumfang = " + h * b * l);

        }
    }
}
