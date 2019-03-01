using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseKode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something you want translated to morsekode");
            string type = Console.ReadLine().ToUpper(); //user input to upper case

            char[] Letters = type.ToCharArray(); //Dynamic array

            int count = type.Length; //Variable that counts the amount of letters typed
            Console.WriteLine(Letters);

            for (int i = 0; i < Letters.Length; i++) //for-loop that loops the same amount as letters typed
            {

                //List<string> list = new List<string>();
                //list.Add("a");
                //Console.WriteLine(list[0]);

                switch (Letters[i]) // If 
                {
                    case 'A':
                        Console.Write(".- ");
                        break;
                    case 'B':
                        Console.Write("-... ");
                        break;
                    case 'C':
                        Console.Write("-.-. ");
                        break;
                    case 'D':
                        Console.Write("-.. ");
                        break;
                    case 'E':
                        Console.Write(". ");
                        break;
                    case 'F':
                        Console.Write("..- ");
                        break;
                    case 'G':
                        Console.Write("--. ");
                        break;
                    case 'H':
                        Console.Write(".... ");
                        break;
                    case 'I':
                        Console.Write(".. ");
                        break;
                    case 'J':
                        Console.Write(".--- ");
                        break;
                    case 'K':
                        Console.Write("-.- ");
                        break;
                    case 'L':
                        Console.Write(".-.. ");
                        break;
                    case 'M':
                        Console.Write("-- ");
                        break;
                    case 'N':
                        Console.Write("-. ");
                        break;
                    case 'O':
                        Console.Write("--- ");
                        break;
                    case 'P':
                        Console.Write(".--. ");
                        break;
                    case 'Q':
                        Console.Write("--.- ");
                        break;
                    case 'R':
                        Console.Write(".-. ");
                        break;
                    case 'S':
                        Console.Write("... ");
                        break;
                    case 'T':
                        Console.Write("- ");
                        break;
                    case 'U':
                        Console.Write("..- ");
                        break;
                    case 'V':
                        Console.Write("...- ");
                        break;
                    case 'W':
                        Console.Write(".-- ");
                        break;
                    case 'X':
                        Console.Write("-..- ");
                        break;
                    case 'Y':
                        Console.Write("-.-- ");
                        break;
                    case 'Z':
                        Console.Write("--.. ");
                        break;
                    case 'Æ':
                        Console.Write(".-.- ");
                        break;
                    case 'Ø':
                        Console.Write("---. ");
                        break;
                    case 'Å':
                        Console.Write(".--.- ");
                        break;


                }
            }
        }
    }
}
