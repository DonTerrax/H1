using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {
            Console.WriteLine("Square or triangle?");
            string input1 = Console.ReadLine().ToLower();

            if (input1 == "square")
            {
                square();
            }
            else if(input1 == "triangle")
            {
                triangle();
            }
            
        }
        public static void square()
        {
            Console.WriteLine("Height of the square");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Width of the square");
            int width = int.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();
            Square test = new Square(height, width);

            Console.WriteLine("Perimeter of the square is: "+calculator.SquareArea(test.Length, test.Width));

        }
        public static void triangle()
        {
            Console.WriteLine("Height of the triangle?");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Width of the triangle?");
            int width = int.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();
            Triangle test = new Triangle(height, width);

            Console.WriteLine("Area of the triangle is: "+calculator.TriangleArea(test._length,test._width));
        }

    }
}
