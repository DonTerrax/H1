using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_produce_switch_to_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 15;

            switch (age)
            {
                case 15:
                    Console.WriteLine("You are too young");
                    break;
                case 25:
                    Console.WriteLine("You are good to go");
                    break;
                default:
                {
                    Console.WriteLine("How old are you then?");
                    break;
                }
            }

            if (age == 15)
            {
                Console.WriteLine("You are too young");
            }
            else if (age == 25)
            {
                Console.WriteLine("You are good to go");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string name = "Mike";

            switch (name)
            {
                case "Mike":
                    Console.WriteLine("Hello "+name);
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                {
                    Console.WriteLine("Username is unknown");
                    break;
                }
            }
        }
    }
}
