using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Madplan
{
    class Program
    {
        private static List<string> opskrifter = new List<string>();
        private static List<string> temp = new List<string>();

        private static Random ranGen = new Random();



        static void Main(string[] args)
        {
            Opskrifter();
            Menu();

        }
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Tast 1 for at få en opskrift til idag");
            Console.WriteLine("Tast 2 for at få opskrifter til en uge");
            int input1 = int.Parse(Console.ReadLine());

            int Menu;
            switch (input1)
            {
                case 1:
                    RandomOpskrift();
                    break;
                case 2:
                    RandomOpskrifter();
                    break;
            }

        }

        public static void Opskrifter()
        {
            opskrifter.Add("Lasagne");
            opskrifter.Add("Hakkedreng");
            opskrifter.Add("Pizza(Hungry)");
            opskrifter.Add("Mørbradgryde");
            opskrifter.Add("Krebinetter");
            opskrifter.Add("Boller i karry");
            opskrifter.Add("Pitabrød");
            opskrifter.Add("Culottesteg");
            opskrifter.Add("Frikadeller");
            opskrifter.Add("Wienersnitchel");
            opskrifter.Add("Svensk pølseret");
            opskrifter.Add("Pizza(Hjemmelavet)");
            opskrifter.Add("Stegt flæsk med persillesovs");
            opskrifter.Add("Tarteletter");
            opskrifter.Add("Brændende kærlighed");
            opskrifter.Add("Bøf stroganoff");
            opskrifter.Add("Wok med kylling og kokosmælk");
            opskrifter.Add("Hjemmelavet burger");
            opskrifter.Add("Kylling og pommes");
        }

        public static void RandomOpskrifter()
        {

            for (int i = 0; i < 7; i++)
            {
                int random = ranGen.Next(opskrifter.Count);
                Console.ForegroundColor = ConsoleColor.Yellow;

                if(temp.Contains(opskrifter[random]) == false)
                { 
                temp.Add(opskrifter[random]);
                }

                else
                {
                    i--;
                }
            }

            foreach (var VARIABLE in temp)
            {
                Console.WriteLine(VARIABLE);
            }
        }
        public static void RandomOpskrift()
        {
                   
           Console.WriteLine(opskrifter[ranGen.Next(opskrifter.Count)]);
            
        }
    }
}
