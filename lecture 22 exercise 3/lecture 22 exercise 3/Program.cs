using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_22_exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1,11);
            int userGuess;
            int userGuesses = 0;
            Console.WriteLine("Guess a number between 1 and 10");
            do
            {
                
                userGuess = int.Parse(Console.ReadLine());
                if(userGuess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else if(userGuess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else
                {
                    Console.WriteLine("You guessed the right number!");
                    Console.WriteLine("You guessed wrong {0}",userGuess," times");
                }
                userGuesses++;
            } while (userGuess != randomNumber);
        }


    }
}
