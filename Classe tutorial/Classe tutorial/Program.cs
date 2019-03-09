using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mike = new Person();

            string res = mike.Sleep(10);
            mike.Age = 12;

            Console.WriteLine(res);
        }
    }
}
