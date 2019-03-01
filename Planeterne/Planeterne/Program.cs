using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Program
    {
        public static void Main(string[] args)
        {

            //List<string> list = new List<string>();
            //list.Add("Earth");
            //list.Add("venus");
            
            //foreach (string prime in list)
            //{
            //    System.Console.WriteLine(prime);
            //}
        }
        public void planet()
        {
            List<string> planets = new List<string>();
            planets.Add("Merkur");
            planets.Add("Earth");
            planets.Add("Mars");
            planets.Add("Jupiter");
            planets.Add("Saturn");
            planets.Add("Uranus");
            planets.Add("Neptun");
            planets.Add("Pluto");

            foreach(string planet in planets)
            {
                Console.WriteLine(planets);
            }
        }
    }
}
