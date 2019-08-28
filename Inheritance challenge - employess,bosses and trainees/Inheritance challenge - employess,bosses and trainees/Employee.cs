using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_challenge___employess_bosses_and_trainees
{
    class Employee
    {


        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }


        // constructor
        public Employee(string firstName,string lastName,int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public Employee()
        {
            FirstName = "Mike";
            LastName = "Madsen";
            Salary = 50000;
        }
        
        public void Work()
        {
            Console.WriteLine("Im working");
        }

        public void Pause()
        {
            Console.WriteLine("Im having a break");
        }

    }
}
