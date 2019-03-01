using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[9];
            int j = 1;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = j;

                if (i == 4)
                {
                    arrayNumbers[i] = j * 2;
                }
                j++;
            }
            foreach (var number in arrayNumbers)
            {
                Console.WriteLine(number);
            }








        }
    }
}
