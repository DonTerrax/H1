using System;

namespace OOP_1_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Human mike = new Human("Madsen", "Mike", "Green", 36);
            mike.introduceMySelf();

            Human mischa = new Human("Enoksen", "Mischa", "brown", 27);
            mischa.introduceMySelf();
            
        }
    }
}
