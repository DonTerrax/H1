using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pass by Reference vs Pass by Value
            //Pass by Value
            int student1grade = 75;
            Console.WriteLine("Students grade before extra credits {0}",student1grade);
            GiveExtraCredits(student1grade);
            Console.WriteLine("Students grade AFTER extra credits {0}",student1grade);

            //Console.WriteLine("Number 1");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Number 2");
            //int number2 = int.Parse(Console.ReadLine());
            //int answer = Numbers(number1,number2);
            //Console.WriteLine(answer);
        }
        private static void GiveExtraCredits(int studentsGrade)
        {
            studentsGrade += 3;
            Console.WriteLine("Students grade after extra credits inside function {0}",studentsGrade);
        }
        //public static int Numbers(int number1, int number2)
        //{
        //    int answer = number1 + number2;
        //    return answer;
        //}
    }
}
