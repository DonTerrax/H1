using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_if_statements_2
{
    class Program
    {
        
        private static int highScore = 300;
        private static string highScorePlayer = "Mike";

        static void Main(string[] args)
        {
           CheckHighScore(250,"Maria");
           CheckHighScore(320,"Morten");
           CheckHighScore(350,"Mike");
        
        }


        public static void CheckHighScore(int score,string playerName)
        {
            if (score > highScore)
            {
                highScore = score;
                Console.WriteLine("The new highscore is {0} ",highScore);
                Console.WriteLine("The new highscore holder is {0} ",playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of {0} could not be broken and is still held by {1}",highScore,highScorePlayer);
            }
        }
    }
}
