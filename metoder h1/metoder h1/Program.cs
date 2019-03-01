using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder_h1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Multiply: {0}\nDivide: {1}\nModulus: {2}\nPow: {3}",Math(input1,input2),Divide(input1,input2),modulus(input1,input2),Pow(input1,input2));
        }


        public static int Math(int number1,int number2)
        {
            int resultAddere;
            resultAddere = number1 * number2;

            return(resultAddere);
            
        }
        public static double Divide(double number1, double number2)
        {
            double resultDivide;
            resultDivide = number1 / number2;
            return (resultDivide);
        }

        public static double modulus(double number1, double number2)
        {
            double modulus;
            modulus = number1 % number2;
            return (modulus);
        }

        public static double Pow(double number1, double number2)
        {
            double pow;
            pow = System.Math.Pow(number1, number2);
            return (pow);
        }
    }
}
