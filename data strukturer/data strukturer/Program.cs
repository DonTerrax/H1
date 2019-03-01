using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace data_strukturer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateArray();

            array = fillArray(array);

            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static int[] CreateArray()
        {
            int[]arrayMetode = new int[10];
            return arrayMetode;
        }

        public static int[] fillArray(int[] array)
        {
            for (int i = 0; i < array.Length ; i++)
            {
                array[i] = i;
                if (array[i] == array[5])
                {
                    array[5] = array[5] *= 2;
                }
            }
            return array;
        }

        

        

       
    }
}
