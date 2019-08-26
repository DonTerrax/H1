using System;

namespace Udemy_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("Central value is {0}",array2D[2,0]);
        }
    }
}
