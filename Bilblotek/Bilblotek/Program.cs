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

            Console.WriteLine("1: Books avalible \n2: Borrow book \n3: Return book");
            int choise = int.Parse(Console.ReadLine());

            Book logic = new Book();
            logic.Books();
            int i = 1;
            switch (choise)
            {
                case 1:
                    
                    foreach (Book item in Book.AddTobockStack())
                    {
                        Console.WriteLine("{0}. {1}.",i,item.Name);
                        i++;
                    }
                    break;

                case 2:
                    
                    foreach (Book item in Book.AddTobockStack())
                    {
                        
                        Console.WriteLine("{0}. {1}.", i, item.Name);
                        i++;
                    }

                    Console.WriteLine("what book do you want to borrow?");
                    int borrowBook = int.Parse(Console.ReadLine());
                    
                    break;

                case 3:
                    break;


                default:
                    break;
            }
            
            
        }
    }
}
