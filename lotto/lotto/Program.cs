using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]lottoArray = new int[7];
            int[]userArray = new int[7];
            Random random = new Random();
            int randomNumber;
            int randomUser;
            int correct = 0;

            for (int i = 0; i < lottoArray.Length; i++)
            {

                randomNumber = random.Next(1, 20);
                lottoArray[i] = randomNumber;
                randomUser = random.Next(1, 20);
                userArray[i] = randomUser;
                if (lottoArray.Contains(userArray[i]))
                {
                    correct++;
                }
            }
            if (correct <= 2)
            {
                Console.WriteLine("you won nothing");
            }
            else if (correct >= 3 && correct <5)
            {
                Console.WriteLine("you won 100kr");
            }
            else if (correct >= 5 && correct <= 6)
            {
                Console.WriteLine("You won 500kr");
            }
            else
            {
                Console.WriteLine("You won 1000kr");
            }


        }
    }
}
