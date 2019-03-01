using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gætettal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);           
            byte numberOfTries = 1;
            bool check = false;

            while (check == false)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                int guess = int.Parse(Console.ReadLine());

                if (guess < randomNumber)
                {
                    Console.WriteLine("Tallet er større prøv igen");
                    numberOfTries++;

                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Tallet er mindre prøv igen");
                    numberOfTries++;
                }
                else
                {
                    check = true;
                    Console.WriteLine("Du ramte rigtigt! og brugte {0} forsøg",numberOfTries);
                    if (numberOfTries < 5)
                    {
                        Console.WriteLine("Du er dygtig!");
                    }
                    else
                    {
                        Console.WriteLine("Du er knapt så dygtig");
                    }
                }
            }
          

        }
    }
}
