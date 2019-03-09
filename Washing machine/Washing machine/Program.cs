using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washing_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer machine = new Washer();

            //Console.WriteLine("Turn on the machine? yes/no");
            //string running = Console.ReadLine().ToLower();
            //machine.Power(running);



            bool b = machine.Power();
            Console.WriteLine(b);
            machine.Running = true;



            b = machine.Power();
            Console.WriteLine(b);



        }
    }
}
