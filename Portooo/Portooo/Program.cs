using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Portooo
{
    class Program
    {
        static double length;
        static double height;
        static double width;
        static double weight;
        static int i;
        static bool dk = false;

        static int[] weightGrams = new[] { 50, 100, 250, 500, 1000, 2000, 5000, 10000, 15000, 20000, 25000, 30000, 35000 };
        static int[] dkletterPrice = new[] { 10, 20, 40, 60, 60, 60, 70, 90, 160, 160, 200, 225, 250 };
        static int[] udletterPrice = new[] { 30, 30, 60, 90, 90, 90, 315, 493, 638, 790 }; // udlandet = 10kr

        static void Main(string[] args)
        {





            Console.WriteLine("Where do you want to send your package? \n1: Danmark\n2: Udlandet");
            double userInput = UserInput();
            switch (userInput)
            {
                case 1:
                    dk = true;
                    PacketSize();
                    break;
                case 2:
                    
                    PacketSize();
                    break;
            }
        }
        //User input gets converted to a double
        static double UserInput()
        {
            double userInput = double.Parse(Console.ReadLine());
            return userInput;
        }

        static void PacketSize()
        {
            Console.WriteLine("Length of the package?");
            length = UserInput();
            Console.WriteLine("Height of the package?");
            height = UserInput();
            Console.WriteLine("Widht of the package?");
            width = UserInput();
            Console.WriteLine("Weight of the package?");
            weight = UserInput();
            Checkprice();

        }

        static void Checkprice()
        {
            double volume = length + width + height;
            if (weight <= weightGrams[0] && volume < 90)
            {
                i = 0;
                DkPrice();
            }
            else if (weight <= weightGrams[1] && volume < 90)
            {
                i = 1;
                DkPrice();
            }
            else if (weight <= weightGrams[2] && volume < 90)
            {
                i = 2;
                DkPrice();
            }
            else if (weight <= weightGrams[3] && volume < 90)
            {
                i = 3;
                DkPrice();
            }
            else if (weight <= weightGrams[4] && volume < 90)
            {
                i = 4;
                DkPrice();
            }
            else if (weight <= weightGrams[5] && volume < 90)
            {
                i = 5;
                DkPrice();
            }
            else if (weight <= weightGrams[6] && volume < 300)
            {
                i = 6;
                DkPrice();
            }
            else if (weight <= weightGrams[7] && volume < 300)
            {
                i = 7;
                DkPrice();
            }
            else if (weight <= weightGrams[8] && volume < 300)
            {
                i = 8;
                DkPrice();
            }
            else if (weight <= weightGrams[9] && volume < 300)
            {
                i = 9;
                DkPrice();
            }
            else if (weight <= weightGrams[10] && volume < 300)
            {
                i = 10;
                DkPrice();
            }
            else if (weight <= weightGrams[11] && volume < 300)
            {
                i = 11;
                DkPrice();
            }
            else if (weight <= weightGrams[12] && volume < 300)
            {
                i = 12;
                DkPrice();
            }
            
        }

        static void DkPrice()
        {
            if (dk == true)
            {
                Console.WriteLine("Price: {0}", dkletterPrice[i]);
            }
            else
            {
                Console.WriteLine("Price: {0}",udletterPrice[i]);
            }

        }
    }
}
