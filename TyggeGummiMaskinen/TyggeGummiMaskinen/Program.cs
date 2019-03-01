using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TyggeGummiMaskinen
{
    class Program
    {
        static void Main(string[] args)
        {


            Bubblegum Blåbær = new Bubblegum("Blåbær", 0.25);
            Dispenser dispenser = new Dispenser();
            dispenser.Maskine.Add(new Bubblegum("apple", 0.10));
            dispenser.Maskine = new List<Bubblegum>(){ new Bubblegum("apple", 0.10) , new Bubblegum("apple", 0.10) };


            //double[]dispenser = new double[6];
            //dispenser[0] = Math.Round(55 * 0.10);//Æble
            //dispenser[1] = Math.Round(55 * 0.25) ;//Blåbær
            //dispenser[2] = Math.Round(55 * 0.14) ;//Jordbær
            //dispenser[3] = Math.Round(55 * 0.20);//Tutti-Frutti
            //dispenser[4] = Math.Round(55 * 0.12);//Brombær
            //dispenser[5] = Math.Round(55 * 0.19);//Appelsin



            //Random randomGenerator = new Random();

            //while (true)
            //{
            //    int randomNumber = randomGenerator.Next(6);

            //    if (randomNumber == 1 && dispenser[0] > 0)
            //    {
            //        Console.WriteLine("You got a green with apple taste!");
            //        dispenser[0] -= 1;
            //    }
            //    else if (randomNumber == 2 && dispenser[1] > 0)
            //    {
            //        Console.WriteLine($"You got a purple with blombær taste");
            //        dispenser[1] -= 1;

            //    }
            //    else if (randomNumber == 3 && dispenser[2] > 0)
            //    {
            //        Console.WriteLine("You got a red with tutti-frutti taste");
            //        dispenser[2] -= 1;

            //    }
            //    else if (randomNumber == 4 && dispenser[3] > 0)
            //    {
            //        Console.WriteLine("You got a red with strawbarry taste");
            //        dispenser[3] -= 1;

            //    }
            //    else if (randomNumber == 5 && dispenser[4] > 0)
            //    {
            //        Console.WriteLine("You got a red with strawbarry taste");
            //        dispenser[4] -= 1;

            //    }
            //    else if (randomNumber == 6 && dispenser[5] > 0)
            //    {
            //        Console.WriteLine("You got a orange with orange taste");
            //        dispenser[5] -= 1;

            //    }
            //  else if (dispenser[0] ==0 && dispenser[1] == 0 )
            //    {

            //    }

            //}

        }

    }
}
