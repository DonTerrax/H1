using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Planet logic = new Planet(); //Create a new object
            logic.AddPlanets();

            foreach (Planet item in Planet.getList())   //
            {
                Console.WriteLine("1" + item.Name);
            }

            Console.WriteLine();


            logic.InsertVenus();  //Here we call the method InsertVenus

            foreach (Planet item in Planet.getList())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            logic.RemovePluto();

            foreach (Planet item in Planet.getList())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            logic.Insertpluto();

            foreach (Planet item in Planet.getList())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            Console.WriteLine("amount of elements "+ logic.AmountOfElements());

            Console.WriteLine();

            logic.MeanTempereture();

            Console.WriteLine("Planets with a meantemp under 0: ");
            foreach (Planet item in Planet.Meanlist())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            logic.Dia();

            Console.WriteLine("Planets with a diameter over 10000 and under 50000");

            foreach (Planet item in Planet.Diameterlist())
            {
                Console.WriteLine(item.Name);
            }
        }

        
    }
}
