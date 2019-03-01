using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_øvelse_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            float sum1 = 0;
            float sum2 = 0;
            
            float[,] grades = new float[10,10];
            

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter students grade {0} group {1}",j+1,i+1);
                    grades[i, j] = Convert.ToSingle(Console.ReadLine());

                    if (i == 0)
                    {
                        sum1 += grades[i, j];
                    }
                    else if (i == 1)
                    {
                        sum2 += grades[i, j];
                    }
                }
            }

            Console.WriteLine("Average grades for group 1: {0}",sum1/10);
            Console.WriteLine("Average grades for group 2: {0}",sum2/10);
           
        }
    }
}
