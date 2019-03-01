using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_62_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Job j1 = new Job("Wash windows",5,15);
            Console.WriteLine("{0}, {1}, {2}, {3}",j1.JobDescription,j1.TimeinHours,j1.PerHourRate,j1.TotalFee);
            Job j2 = new Job("Take out trash",2,12.50);
            Console.WriteLine("{0}, {1}, {2}, {3}",j2.JobDescription,j2.TimeinHours,j2.PerHourRate,j2.TotalFee);

            Job j3 = j1 + j2;
            Console.WriteLine("{0}, {1}, {2}, {3}",j3.JobDescription,j3.TimeinHours,j3.PerHourRate,j3.TotalFee);

        }
    }
}
