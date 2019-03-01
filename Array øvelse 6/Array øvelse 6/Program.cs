using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_øvelse_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2d = new int[2, 2]
            {
                {1, 2},
                {1, 3}
            };

            int result = array2d[1, 1] * array2d[1, 1];

            Console.WriteLine(result);
            //for (int i = 0; i < array2d.Length; i++)
            //{
            //    Console.WriteLine(array2d.Length);
            //}
        }
    }
}
