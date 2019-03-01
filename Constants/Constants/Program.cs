using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class Program
    //Constants are immutable values which are know at compile time and not change for the life of the program.
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        private const string birthDay = "11-05-1982";


        static void Main(string[] args)
        {
            Console.WriteLine(birthDay);
        }
    }
}
