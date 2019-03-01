using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_øvelse2
{
    class Program
    {
        private static List<string> nameArray = new List<string>
        {
            "mike", "elias", "clara", "william", "oliver", "noah", "emil", "lars", "sander", "august", "frederik",
            "alexander", "malthe", "villads", "tobias", "adam", "oscar", "martin", "simon", "mads"
        };

        private static List<string> listarray = new List<string>
        {
            "mia", "emma"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("1. Search for a name\n2. Sort name list in alphabetic order");
            int input = int.Parse(Console.ReadLine());
            nameArray.AddRange(listarray);

            switch (input)
            {
                case 1:
                    Console.WriteLine("Search for a name:");
                    string search = Console.ReadLine().ToLower();
                    for (int i = 0; i < nameArray.Count; i++)
                    {
                        if (nameArray[i].IndexOf(search) > -1)
                        {
                            Console.WriteLine("{0} is on the list", nameArray[i]);
                            i = 21;
                        }
                        else if(i == nameArray.Count)
                        {
                            Console.WriteLine("{0} is not on the list", search);
                        }

                    }
                    break;
                case 2:
                    nameArray.Sort();
                    foreach (string name in nameArray)
                    {
                        Console.WriteLine(name);
                    }
                    break;

            }
        }
    }
}
