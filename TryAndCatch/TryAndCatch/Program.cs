using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            int number2 = int.Parse(Console.ReadLine());
            int num1 = 10;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (Exception)
            {
                Console.WriteLine("You cant divide with 0");
                
            }
            finally
            {
                Console.WriteLine("Try again!");
            }

            try
            {
                int userInput = int.Parse(Console.ReadLine());
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverFlow exception, the number was too long or too short for an int32.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }
        }
    }
}
