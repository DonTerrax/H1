using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_tutorial
{
    class Person
    {
        public string name;
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }


        public Person()
        {

        }

        public void Eat()
        {
            Console.WriteLine("Eat...Mums!");
        }

        public string Sleep(int time)
        {
            return "zZzzzZZz";
        }

    }
}
