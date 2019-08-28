using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewingGum
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispenser chew = new Dispenser();
            chew.CreateGum();
            Console.WriteLine("Insert 5 kr");
            Console.ReadKey();

            foreach (Gum item in Dispenser.RandomGum())
            {
                Console.WriteLine(item.color);
            }

            Console.ReadKey();



        }
    }
}
