using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_61_exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxpayer[] payers = new Taxpayer[10];

            for (int i = 0; i < payers.Length; i++)
            {
                payers[i] = new Taxpayer();
                Console.WriteLine("Enter payer #{0} SSN", i + 1);
                payers[i].SocialSecurityNumber = Console.ReadLine();
                Console.WriteLine("Enter payer {0} yearly income", i +1);
                payers[i].Income = double.Parse(Console.ReadLine());

               
            }
            for (int i = 0; i < payers.Length; i++)
            {
                Console.WriteLine("Tax payer {0} has SSN {1} and a yearly income of {2}$ and he ows {3} tax",i +1,payers[i].SocialSecurityNumber,payers[i].Income,payers[i].TaxOwed);
            }
        }
    }
}
