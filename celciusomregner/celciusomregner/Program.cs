using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            double Reamur;
            double Celcius;
            double Fahrenheit;

            Console.WriteLine("Hvor mange celcius er det?");
            Celcius = double.Parse(Console.ReadLine());

            Reamur = Celcius * 0.8;
            Fahrenheit = Celcius * 1.8 + 32;

            Console.WriteLine("Fahrenheit = {0} Reamur = {1}",Fahrenheit,Reamur);
            Console.ReadKey();


        }
    }
}
