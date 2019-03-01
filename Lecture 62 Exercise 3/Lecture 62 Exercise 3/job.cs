using System;
using System.Collections.Generic;
namespace Lecture_62_Exercise_3
{
    class Job
    {
        private string _jobDescription;
        private double _timeInHours;
        private double _perHourRate;

        public Job(string jobDescription, double timeInHours, double perHourRate)
        {
            _jobDescription = jobDescription;
            _timeInHours = timeInHours;
            _perHourRate = perHourRate;
        }

        public string JobDescription
        {
            get { return _jobDescription; }
            set { _jobDescription = value; }
        }

        public double TimeinHours
        {
            get { return _timeInHours; }
            set { _timeInHours = value; }
        }

        public double PerHourRate
        {
            get { return _perHourRate; }
            set { _perHourRate = value; }
        }

        public double TotalFee
        {
            get
            {
                return _perHourRate * _timeInHours;
            }
        }



        //public double TotalFee
        //{
        //    get
        //    {
        //        return calc();
        //    }
        //}

        public static Job operator +(Job j1, Job j2)
        {
            string newDescription = j1._jobDescription + " and " + j2._jobDescription;
            double newTotalHours = j1._timeInHours + j2._timeInHours;
            double newPerHourRate = (j1._perHourRate + j2._perHourRate) / 2;
            Job addedJob = new Job(newDescription, newTotalHours, newPerHourRate);
            return addedJob;
        }

    

        //public double TotalFee()
        //{
        //   return _perHourRate * _timeInHours;
        //}
    }
}
