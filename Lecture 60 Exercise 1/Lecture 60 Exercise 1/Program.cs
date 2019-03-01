using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_60_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squares = new Square[10];//array

            for (int i = 0; i < 10; i++)//for loop
            {
                squares[i] = new Square(i+1);//Calls array "squares" and loops it 10 times
                Console.WriteLine("{0}, {1}",squares[i].SideLength,squares[i].Area);
            }
        }
    }
}
