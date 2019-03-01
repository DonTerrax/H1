using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gæt_et_tal_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int wrong = 1;
            int randomNumber = random.Next(0, 10);
            bool win = false;

            do
            {

                Console.WriteLine("Guess a number between 0 and 10!");
                int number = int.Parse(Console.ReadLine());

                if (number < randomNumber)
                {
                    Console.WriteLine("Wrong answer. It is higher");
                    wrong++;
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("Wrong answer. It is lower");
                    wrong++;
                }
                else if (number == randomNumber)
                {
                    Console.WriteLine("You are correct! And you used " + wrong + " tries");
                    win = true;
                    if (wrong < 10)
                    {
                        Console.WriteLine("You pass!");
                    }
                    else if (wrong > 10)
                    {
                        Console.WriteLine("You fail!");
                    }
                }

            } while (win == false);

        }
    }
}
