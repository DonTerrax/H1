using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Mike", "Jakub", "Morten", "Joanna" };
            int[] grades = { 100, 70, 60, 50 };

            Console.WriteLine("Enter students name to search for");
            string studentsName = Console.ReadLine();

            bool contains = false;
            int studentGrade = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if(studentsName == students[i])
                {
                    contains = true;
                    studentGrade = grades[i];
                    break;
                }
            }
            if(contains == true)
            {
                Console.WriteLine("The student is in the class");
                Console.WriteLine("The students grade is {0}", studentGrade);
            }
            else
            {
                Console.WriteLine("The student is NOT in the class");
            }
        }
    }
}
