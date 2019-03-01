using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            welcomeScreen();
            evenFibonacci();
            int wait = Convert.ToInt32(Console.ReadLine());
        }

        private static void welcomeScreen()
        {
            Console.Write("\a"
                          + "\t*******************************************************" + "\n"
                          + "\t**                                                   **" + "\n"
                          + "\t**                   Welcome To                      **" + "\n"
                          + "\t**                                                   **" + "\n"
                          + "\t**               Find Even Fibonacci                 **" + "\n"
                          + "\t**                                                   **" + "\n"
                          + "\t**                 and there sum                     **" + "\n"
                          + "\t**                                                   **" + "\n"
                          + "\t*******************************************************" + "\n");
        }

        private static void evenFibonacci()
        {
            int num, count = 0;
            long previous = 1, next = 0, sum;
            Console.Write("\t Enter Your Number to Find Fibonacci ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\t First " + num + " Even Fibonacci Numbers Are \n");

            do
            {
                if (previous % 2 == 0)
                {
                    Console.Write("\n\t " + previous + " ");
                    count++;
                }
                sum = previous + next;
                next = previous;
                previous = sum;

            } while (count != num);

        }
    }
}

