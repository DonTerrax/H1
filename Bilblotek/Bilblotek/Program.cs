using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblotek
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Book logic = new Book();
            logic.Books();
            int i = 1;

            while (true)
            {
                Console.WriteLine("1: Borrow book \n2: Return book \n3: Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        foreach (Book item in Book.AddTobockStack())
                        {
                            Console.WriteLine("{0}. {1}.", i, item.Name);
                            i++;
                        }

                        Console.WriteLine("what book do you want to borrow?");
                        sbyte borrowBook = sbyte.Parse(Console.ReadLine());
                        Book borrow = new Book(borrowBook);
                        borrow.BorrowBook();
                        i = 1;
                        Console.Clear();
                        break;

                    case 2:

                        Console.WriteLine("What book do you want to return?");
                        foreach (Book item in Book.RemoveFromlist())
                        {
                            Console.WriteLine("{0}. {1}.", i, item.Name);
                            i++;
                        }
                        sbyte returnBook = sbyte.Parse(Console.ReadLine());
                        Book bookReturn = new Book(returnBook);
                        bookReturn.ReturnBook();
                        i = 1;
                        Console.Clear();
                        break;

                    case 3:
                        Environment.Exit(3);
                        break;


                    default:
                        break;
                }
            }

        }
    }
}
