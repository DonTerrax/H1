using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace array_og_bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            int[] array = new int[100];
            Random random = new Random();

            
            for (int i = 0; i < array.Length; i++)
            {
                randomNumber = random.Next(0, 1000);
                array[i] = randomNumber;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < (array.Length -1) - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "   ");
                
            }




        }
    }
}
