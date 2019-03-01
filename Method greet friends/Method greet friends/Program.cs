using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_greet_friends
{
    class Program
    {
        static void Main(string[] args)
        {
           string name1 = "Frank";
           string name2 = "Jakub";
           string name3 = "Mike";

           GreetFriends(name1);
           GreetFriends(name2);
           GreetFriends(name3);
        }
        public static void GreetFriends(string friendName)
        {
            Console.WriteLine("Hi " +friendName+ ", my friend!");
        }
    }
}
