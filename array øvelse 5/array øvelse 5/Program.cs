using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_øvelse_5
{
    class Program
    {
        static int[,] array2D = new int[5, 5]
        {
            {1, 2, 3, 4, 5},
            {6, 7, 8, 9, 10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
        };

        static void Main(string[] args)
        {
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 5; j++)
                {
                    if (array2D[i,j] < 10)
                    {
                        Console.Write("  {0}  ",array2D[i, j]);
                    }
                    else
                    {
                        Console.Write("  {0} ",array2D[i, j]);

                    }
                }
                Console.WriteLine("");

            }
        }
    }
}
