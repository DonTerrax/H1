using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alderifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            byte age = byte.Parse(Console.ReadLine());

            if (age < 3)
            {
                Console.WriteLine("{0}, du må gå med ble",name);
            }
            else if (age >= 3 && age <= 15)
            {
                Console.WriteLine("{0}, du må ingenting",name);
            }
            else if (age > 15 && age < 18)
            {
                Console.WriteLine("{0}, du må drikke",name);
            }
            else
            {
                Console.WriteLine("{0}, du må stemme og køre bil",name);
            }

            Console.ReadKey();
        }
    }
}
