using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayssss
{
    class Program
    {
        static string[] user = new[] { "user1", "user2", "user3", "user4", "user5" };
        static string[] passWordArray = new[] { "1", "2", "3", "4", "5" };

        static void Main(string[] args)
        {
            Console.WriteLine("Username?");
            string userName = Console.ReadLine().ToLower();
            int count = -1;
            bool checkUserName = true;

            foreach (string userCheck in user)
            {
                count++;
                if (userName == userCheck)
                {


                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Password: ");
                        string password = Console.ReadLine();

                        if (password == passWordArray[count])
                        {
                            Console.WriteLine("Welcome!");
                            i = 4;
                            checkUserName = false;
                        }
                        else if (i == 2)
                        {
                            Console.WriteLine("You wrote the wrong password too many times");
                            i = 4;
                            checkUserName = false;
                        }
                    }
                }
            }

            if (checkUserName == true)
            {
                Console.WriteLine("You are not registered in the database!");
            }

        }
    }
}
