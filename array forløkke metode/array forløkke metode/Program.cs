using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace array_forløkke_metode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Write a number");
            //int x = int.Parse(Console.ReadLine());
            

            for (int i = 1; i < arrayRising(tal) ; i++)
            {
                Console.WriteLine(i);
            }

           int tal =  arrayRising();
            
            Console.WriteLine("");

            for (int i = 10; i > arrayDecending(); i--)
            {
                
                Console.WriteLine(i);
            }

            arrayDecending();
        }

        public static int arrayRising (int loop)
        { 
            int tal = 11;
            int[] array = new int[tal];
            return (loop);
        }

        public static int arrayDecending(int loop)
        {
            int tal = loop;
            int[] array = new int[loop];
            return (loop);
        }
    }
}
