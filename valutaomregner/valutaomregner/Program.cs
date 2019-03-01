using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valutaomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency DKK: ");
            double input = double.Parse(Console.ReadLine());
            double usd = input * 0.15;
            double bp = input * 0.12;
            double euro = input * 0.13;
            double sve = input * 1.37;
            Console.WriteLine("Currency in USD:{1}  Currency in BP:{1}  Currency in EURO:{2}  Currency in SVE:{3}",usd,bp,euro,sve);
            
            Console.ReadKey();
        }
    }
}
