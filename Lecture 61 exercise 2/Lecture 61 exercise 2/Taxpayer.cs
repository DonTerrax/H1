using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_61_exercise_2
{
    class Taxpayer
    {
        private string _socialSecurityNumber;
        private double _income;
        private double _taxowed;

        public double TaxOwed
        {
            get { return _taxowed; }
        }

        public double Income
        {
            get { return _income; }
            set
            {
                _income = value;
                Taxcalc();
            }
        }     

        public string SocialSecurityNumber
        {
            get { return _socialSecurityNumber; }
            set { _socialSecurityNumber = value; }
        }
        private void Taxcalc()
        {
            if (_income < 30000)
            {
                _taxowed = _income * 0.15;
            }
            else
            {
                _taxowed = _income * 0.28;
            }
        }

    }
}
