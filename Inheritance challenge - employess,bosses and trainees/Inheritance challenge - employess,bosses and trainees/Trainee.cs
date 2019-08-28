using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_challenge___employess_bosses_and_trainees
{
    class Trainee:Employee
    {
        
        public int WorkingHours { get; set; }

        public int SchoolHours { get; set; }

        public Trainee() { }

        public Trainee(int workingHours,int schoolHours,string firstName,string lastName,int salery):base(firstName,lastName,salery)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("Im learning. My name is {0} {1}, and my salery is {2}",FirstName,LastName,Salary);
        }

        public new void Work()
        {
            Console.WriteLine("Im working for {0} hours",WorkingHours);
        }

       

    }
}
