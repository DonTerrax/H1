using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemycourse
{
    class Members
    {
        private string memberName;
        private string jobTitle;
        private int salary;

        public int age;

        

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }


        public void introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. Im {2} years old",memberName,jobTitle,salary);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        public Members()
        {
            age = 37;
            memberName = "Mike";
            salary = 100000;
            jobTitle = "Deleloper";

            Console.WriteLine("Object created");
        }



        ~Members()
        {
            //Clean up statements

            Console.WriteLine("Deconstruction of members object");
            Debug.Write("Deconstruction of members object");
        }

    }
}
