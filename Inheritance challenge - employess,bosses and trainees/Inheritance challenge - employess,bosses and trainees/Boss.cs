using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_challenge___employess_bosses_and_trainees
{
    class Boss:Employee
    {

        public string CompanyCar { get; set; }

        public Boss(string companyCar,string firstName,string lastName, int salary):base(firstName,lastName,salary)
        {
            this.CompanyCar = companyCar;
        }
      
        
        public void Lead()
        {
            Console.WriteLine("Im boss!");
        }

    }
}
