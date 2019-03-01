using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();
            List<int> listOfNumbers2 = listOfNumbers;
            for (int i = 1; i <= 19; i++)
            {
                i++;
                listOfNumbers.Add(i);
                for (int j = 0; j < 20;)
                {
                    j += 3;
                    listOfNumbers.Remove(j);

                }
            }

            listOfNumbers[2] = 17;
            

            foreach (int numbers in listOfNumbers)
            {
                Console.WriteLine(numbers);
            }
            listOfNumbers2.Reverse();
            Console.WriteLine("");
            foreach (int reverseNumbers in listOfNumbers2)
            {
                Console.WriteLine(reverseNumbers);
            }
        }
    }
}
