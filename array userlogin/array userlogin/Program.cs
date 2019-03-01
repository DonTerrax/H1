using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_userlogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]userArray = new string[5]{"User1","User2","User3","User4","User5"};
            int[]passArray = new int[5]{1,2,3,4,5};

            bool userpass = true;

            Console.WriteLine("Username");
            string userName = Console.ReadLine();

            foreach (var name in userArray)
            {
                if (userArray.Contains(userName))
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    Console.WriteLine("User does not exist");
                }
            }

            Console.WriteLine("Password");
            int passWord = int.Parse(Console.ReadLine());


            foreach (var pass in passArray)
            {
                if (userpass == pass) 
                {
                    
                }
            }
        }
    }
}
