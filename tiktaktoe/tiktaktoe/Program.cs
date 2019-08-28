using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace tiktaktoe
{
    class Program
    {
        private static char[,] playfield =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };



        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;


            do
            {


                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);

                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                setField();

                #region CheckForWinningCondition

                char[] playerChars = { 'X', 'O' };
                foreach (var playerChar in playerChars)
                {
                    if (((playfield[0, 0] == playerChar) && (playfield[0, 1] == playerChar) && (playfield[0, 2] == playerChar))
                        || ((playfield[1, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))
                        || ((playfield[2, 0] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 0] == playerChar) && (playfield[2, 0] == playerChar))
                        || ((playfield[0, 1] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 0] == playerChar))
                        )

                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won");
                        }

                        Console.WriteLine("Please any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;

                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("It was a draw");
                        Console.WriteLine("Press any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                    }
                }


                #endregion

                #region TestIfFieldIsTaken

                do
                {
                    Console.WriteLine("\nPlayer {0}: Choose your field! ", player);

                    try
                    {
                        input = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }



                    if ((input == 1) && (playfield[0, 0] == '1'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 2) && (playfield[0, 1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playfield[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playfield[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playfield[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playfield[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playfield[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playfield[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playfield[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\n Incorrect input. Please use another field.");
                    }


                } while (!inputCorrect);
                #endregion


            } while (true);
        }


        public static void ResetField()
        {

            char[,] playFieldInitial =
            {

            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }

            };

            playfield = playFieldInitial;
            setField();
            turns = 0;
        }

        public static void setField()
        {
            Console.Clear();
            Console.WriteLine("    |    |    ");
            Console.WriteLine(" {0}  |  {1} |  {2} ", playfield[0, 0], playfield[0, 1], playfield[0, 2]);
            Console.WriteLine("____|____|____");


            Console.WriteLine("    |    |    ");
            Console.WriteLine(" {0}  |  {1} |  {2} ", playfield[1, 0], playfield[1, 1], playfield[1, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |     ");

            Console.WriteLine(" {0}  |  {1} |  {2} ", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
            Console.WriteLine("    |    |    ");
            turns++;


        }

        public static void EnterXorO(int player, int input)
        {
            char playSign = ' ';
            if (player == 1)
            {
                playSign = 'X';
            }
            else if (player == 2)
            {
                playSign = 'O';
            }

            switch (input)
            {
                case 1: playfield[0, 0] = playSign; break;
                case 2: playfield[0, 1] = playSign; break;
                case 3: playfield[0, 2] = playSign; break;
                case 4: playfield[1, 0] = playSign; break;
                case 5: playfield[1, 1] = playSign; break;
                case 6: playfield[1, 2] = playSign; break;
                case 7: playfield[2, 0] = playSign; break;
                case 8: playfield[2, 1] = playSign; break;
                case 9: playfield[2, 2] = playSign; break;

            }

        }


    }
}
