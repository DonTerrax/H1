using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mozart
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            string[,]minutten = new string[16,12];
            string[,]trioen = new string[16,6];
            int dice1;
            int dice2;
            int dice1Random;
            int dice2Random;
            int indexMin = 0;
            int indexTri = 0;

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();

            for (int i = 0; i < 16; i++)
            {
                dice2 = random.Next(2, 12);
                dice2Random = random.Next(1, 176);
                for (int j = 0; j < 12; j++)
                {
                    if (j == dice2)
                    {
                        minutten[i,dice2] = @"C:\Users\mike5171\Desktop\Wave\M"
                                                + dice2Random + ".wav";
                        indexMin++;
                        sp.SoundLocation = minutten[i,dice2];
                        sp.Load();
                        sp.PlaySync();
                        Console.WriteLine("{0},{1}",minutten[i,dice2],indexMin);
                    }
                }
            }

            Console.WriteLine("");

            for (int i = 0; i < 16; i++)
            {
                dice1 = random.Next(1, 6);
                dice1Random = random.Next(1, 96);
                for (int j = 0; j < 6; j++)
                {
                    if (j == dice1)
                    {
                        trioen[i,dice1] = @"C:\Users\mike5171\Desktop\Wave\T"
                                                     + dice1Random + ".wav";
                        indexMin++;
                        sp.SoundLocation = trioen[i, dice1];
                        sp.Load();
                        sp.PlaySync();
                        Console.WriteLine("{0},{1}", trioen[i, dice1], indexMin);

                    }
                }
            }




























            //Random r = new Random();
            //int index = 0;

            //int[,] minuttenArray = new int[11,16];
            //int row = 10;
            //int columns = 15;
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        minuttenArray[row, columns] = r.Next(1, 150);
            //    }
            //}

            ////for (int i = 0; i < minuttenArray.Length; i++)
            ////{
            ////    Console.WriteLine(i);
            ////}

            ////Console.ReadLine();

            //Random random = new Random();
            //int dice1 = random.Next(0, 11);
            //int dice2 = random.Next(0, 16);
            //string diceresult = Convert.ToString(dice1);
            //string dicereulst2 = Convert.ToString(dice2);
            //string[] mFiles = Directory.GetFiles(@"C:\Users\mike5171\Desktop\Wave", "M*.wav");
            //System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            //Console.WriteLine(dice1);
            //Console.WriteLine(dice2);
            //var castresult = Convert.ToString(minuttenArray[dice1, dice2]);
            //Console.WriteLine(castresult);
            //foreach (string c in mFiles)
            //{
            //    sp.SoundLocation = c;
            //    sp.Load();
            //    sp.PlaySync();
            //    Console.WriteLine(c);

            //}




            ////for (int i = 0; i < 16; i++)
            ////{
            ////    for (int j = 0; j < 2; j++)
            ////    {
            ////        if (j <= 1)
            ////        {

            ////            minuttenArray[i, j] = @"C:\Users\mike5171\Desktop\Wave\M"
            ////                                  + index + ".wav";
            ////        }
            ////        else
            ////        {
            ////            minuttenArray[i, j] = @"C:\Users\mike5171\Desktop\Wave\T"
            ////                                  + index + ".wav";
            ////        }

            ////        index++;
            ////    }


            ////}

            //for (int i = 0; i < 16; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        dice1 = random.Next(2, 12);
            //        minuttenArray[i, j] = dice1;
            //    }
            //}

            ////System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            ////foreach (string musicFile in minuttenArray)
            ////{
            ////    sp.SoundLocation = musicFile;
            ////    sp.Load();
            ////    sp.PlaySync();
            ////    Console.WriteLine(musicFile);
            ////}









        }
    }
}
