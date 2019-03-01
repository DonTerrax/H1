using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhanced_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;
            if (temperature < 0)
            {
                stateOfMatter = "Solid";
            }
            else
            {
                stateOfMatter = "Liquid";
            }
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 30;

            // In short
            stateOfMatter = temperature < 0 ? "solid" : "Liquid";

            //Challenge
            temperature += 101;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "Liquid";



            Console.WriteLine("State of matter is {0}", stateOfMatter);

            
        }
    }
}
