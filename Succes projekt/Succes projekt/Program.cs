using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Succes_projekt
{
    class Program
    {
        static void Main(string[] args)
        {


            //Test p1 = new Test(50,"Mike");
            //Console.WriteLine(p1.Navn,p1.Age);











            DateTime currentTime = DateTime.Now;
            DateTime fri = new DateTime(currentTime.Year,currentTime.Month,currentTime.Day,15,30,currentTime.Second);
            //TimeSpan diff = currentTime - fri;
            TimeSpan diff = currentTime.Subtract(fri);
            
            
            if (currentTime >= fri)
            {
                Console.WriteLine("Du har fri nu!");
            }
            else
            {
                Console.WriteLine("Du har ikke fri endnu! Men du har fri om {0} timer og {1} minutter",fri.Hour - currentTime.Hour, fri.Minute - currentTime.Minute);

            }
        }


    }
}
