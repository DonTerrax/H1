using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1,11);
            Console.WriteLine("Guess a number between 1 and 10");
            int inputGuess;
            do
            {
                inputGuess = int.Parse(Console.ReadLine());
                if (inputGuess < randomNumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (inputGuess > randomNumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("You guessed correct!");
                }
            } while (inputGuess != randomNumber);
            
        }
    }
}
