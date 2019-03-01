using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_if_statements
{
    class Program
    {
        private static string username;
        private static string password;

        static void Main(string[] args)
        {
         Registration();
         Login();
        }

        public static void Registration()
        {
            Console.WriteLine("Write your username");
            username = Console.ReadLine();
            Console.WriteLine("Write your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration complete");
            Console.WriteLine("------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Wrong username");
            }
         
        }
        
            
          
    }
}
