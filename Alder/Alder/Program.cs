using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast dit navn");
            string Navn = Console.ReadLine();
            Console.WriteLine("Indtast din alder");
            int age = int.Parse(Console.ReadLine());

            if (age < 3)
            {
                Console.WriteLine("Du må gå med ble");
            }
            else if (age >= 3 && age <= 15)
            {
                Console.WriteLine(Navn + ", du må ingenting");
            }
            else if (age > 15 && age < 18)
            {
                Console.WriteLine(Navn + " , du må drikke");
            }
            else
                Console.WriteLine(Navn + ", du må gerne stemme og køre bil");

            




            
        }

    }
}
