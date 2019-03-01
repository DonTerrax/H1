using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_for_loops_1
{
    class Program
    {
        private static int studentGradeAsInt = 0;
        static void Main(string[] args)
        {
            
            int timesRun = 0;
            double sum = 0;
            
            do
            {
                sum = sum+studentGradeAsInt;
                Console.WriteLine("Enter the grade of the student");
                string studentGrade = (Console.ReadLine());
                try
                {
                    studentGradeAsInt = int.Parse(studentGrade);
                }
                catch (Exception)
                {

                }

                if (studentGradeAsInt == -1)
                {
                    break;
                }

                if (studentGradeAsInt <1 || studentGradeAsInt >20)
                {
                    Console.WriteLine("Please write a number between 1 and 20");
                }
                
                
                timesRun++;
            } while (true);


            Console.WriteLine("The average grades of students is "+ sum/timesRun );
        }
    }
}
