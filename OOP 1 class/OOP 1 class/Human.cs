using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1_class
{
    class Human
    {
        private string lastName;
        private string firstName;
        private string eyeColor;
        private int age;

        public Human(string lastName, string firstName, string eyeColor, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        public void introduceMySelf()
        {
            Console.WriteLine("Hi, im {0} {1} and my eyecolor is {2} and im {3} years old",firstName,lastName,eyeColor,age);
        }
    }
}
