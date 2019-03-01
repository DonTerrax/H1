using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_camilla_med_ble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Your age?");
            int age = int.Parse(Console.ReadLine());
            CheckAge(age);
            Console.WriteLine("{0}, {1}",name,CheckAge(age));


        }

        public static string CheckAge(int age)
        {
            if (age < 3)
            {
                return "you shall wear a diper";
            }
            else if (age >= 3 && age <= 15)
            {
                return "you are allowed to do nothing";
            }
            else if (age > 15 && age < 18)
            {
                return "you are allowed to drink";
            }
            else
            {
                return "you are allowed to drive and vote";
            }

            return (CheckAge(age));
        }
    }
}
