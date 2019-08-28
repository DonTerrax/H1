using System;

namespace Inheritance_challenge___employess_bosses_and_trainees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee mike = new Employee();
            mike.Work();

            Boss chuck = new Boss("Ferrari","Chuck","Norris",100000);
            chuck.Lead();

            Trainee jakub = new Trainee(10,20,"Jakub","Grubarsky",999999);
            jakub.Learn();
            jakub.Work();
            Console.ReadKey();

        }
    }
}
