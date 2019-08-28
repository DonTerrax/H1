using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_problem_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            
            for (int i = 3; i < 1000; i+=3)
            {
                sum1 = i + sum1;
            }
            for (int i = 5; i < 1000; i += 5)
            {
                sum2 = i + sum2;
            }

            Console.WriteLine(sum1+sum2);






        }
    }
}
