using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pakke til udlandet eller DK?");
            string input2 = Console.ReadLine().ToLower();
            Console.WriteLine("Vil du sende et brev eller en pakke?");
            string input1 = Console.ReadLine().ToLower();
            int længde = 0;
            int bredde = 0;
            int højde = 0;
            int vægt = 0;
            int udlandet = 0;
            int pris = 0;

            if(input2 == "udlandet")
            {
                udlandet = 1;
                
            }

            if (input1 == "brev")
            {
                pris = Mål(bredde,længde,højde, vægt, udlandet);              
            }
            else if(input1 == "pakke")
            {
                pris = Mål(længde, bredde, højde, vægt, udlandet);
            }
            Console.WriteLine("Porto er = " + pris+ " kr");
            
        } 
        public static int Mål(int bredde,int længde, int højde, int vægt, int udlandet)
        {
            int pris = 0;
            Console.WriteLine("Længde: ");
            længde = int.Parse(Console.ReadLine());
            Console.WriteLine("Bredde: ");
            bredde = int.Parse(Console.ReadLine());
            Console.WriteLine("Højde: ");
            højde = int.Parse(Console.ReadLine());
            Console.WriteLine("Vægt i gram: ");
            vægt = int.Parse(Console.ReadLine());
     
            if (vægt <= 50 && længde <=90)
            {
                pris = 9;
                if(udlandet == 1)
                {
                    pris = 27;
                }
            }
            else if(vægt <= 100 && længde <= 90)
            {
                pris = 18;
                if (udlandet == 1)
                {
                    pris = 27;
                }
            }
            else if (vægt <= 250 && længde <= 90)
            {
                pris = 36;
                if (udlandet == 1)
                {
                    pris = 54;
                }
            }
            else if (vægt <= 500 && længde <= 90)
            {
                pris = 45;
                if (udlandet == 1)
                {
                    pris = 54;
                }
            }
            else if (vægt <= 1000||vægt < 2000 && længde <= 90)
            {
                pris = 54;
                if (udlandet == 1)
                {
                    pris = 108;
                }
            }
            else if (vægt <= 5000 && længde <= 300)
            {
                pris = 60;
                if (udlandet == 1)
                {
                    pris = 517;
                }
            }
            else if (vægt <= 10000 && længde <= 300)
            {
                pris = 90;
                if (udlandet == 1)
                {
                    pris = 840;
                }
            }
            else if (vægt <= 15000 && længde <= 300)
            {
                pris = 150;
                if (udlandet == 1)
                {
                    pris = 1244;
                }
            }
            else if (vægt <= 20000 && længde <= 300)
            {
                pris = 90;
                if (udlandet == 1)
                {
                    pris = 1648;
                    
                }
            }
            else if (vægt <= 25000 && længde <= 300)
            {
                if (udlandet == 1)
                {
                    Console.WriteLine("Du kan max sende pakker til udlandet på 20kg");

                }
                else
                    pris = 250;
            }
            else if (vægt <= 30000 && længde <= 300)
            {
                pris = 312;
            }
            else if (vægt <= 35000 && længde <= 300)
            {
                pris = 350;
            }                     
            return pris;
        }



        
        

        
    }
}
