using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningkastet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Kast med terningen");
            Console.ReadKey();
            Random random = new Random();
            int terningskast = random.Next(1, 7);

            if (terningskast == 1)
            {
                Console.WriteLine("Du slog en etter");
            }
            else if (terningskast == 2)
            {
                Console.WriteLine("Du slog en to'er");
            }
            else if (terningskast == 3)
            {
                Console.WriteLine("Du slog en tre'er");
            }
            else if (terningskast == 4)
            {
                Console.WriteLine("Du slog en fire");
            }
            else if (terningskast == 5)
            {
                Console.WriteLine("Du slog en femmer");
            }
            else if (terningskast == 6)
            {
                Console.WriteLine("Du slog en sekser");
            }
            
        }
    }
}
