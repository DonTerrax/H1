using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_opgave_4_løsning_2
{
    class Program
    {
        static string[] arrayElements;
        

        static void Main(string[] args)
        {
            bool exit = true;
            do
            {
                Console.WriteLine("1. Add data \n2. See all data \n3. Search \n4. Statistics \n5. Terminate program");
                int menu = int.Parse(Console.ReadLine());
                int inputAmount = 0;

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("How many data do you want to add?");
                        inputAmount = int.Parse(Console.ReadLine());
                        arrayElements = new string[inputAmount];
                        for (int i = 0; i < inputAmount; i++)
                        {
                            
                            Console.WriteLine("Add data: ");
                            arrayElements[i] = Console.ReadLine();
                            
                        }

                        break;
                    case 2:
                        foreach (string name in arrayElements)
                        {
                            Console.WriteLine("{0} ",name);
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("What do you want to search for?");
                        string input = Console.ReadLine();
                        for (int i = 0; i < arrayElements.Length; i++)
                        {
                            if (arrayElements[i].IndexOf(input)> -1)
                            {
                                Console.WriteLine("{0} is on the list",arrayElements[i]);
                                i = arrayElements.Length + 1;
                            }
                            else if(i == arrayElements.Length -1)
                            {
                                Console.WriteLine("{0} is not on the list",input);
                            }

                            Console.ReadLine();
                        }

                        break;

                    case 4:
                        Console.WriteLine("{0} amount of data", arrayElements.Length);
                        Console.ReadKey();
                        break;

                    case 5:
                        exit = false;
                        break;
                    default:
                        break;
                        
                }
                
                Console.Clear();
            } while (exit == true);
        }
    }
}
