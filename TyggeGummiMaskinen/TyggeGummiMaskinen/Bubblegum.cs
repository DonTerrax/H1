using System;

namespace TyggeGummiMaskinen
{
    public class Bubblegum
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private double _count;

        public double Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public Bubblegum(string type, double count)
        {
            _type = type;
        }

        //private double green = Math.Round(55 * .10);



    }
}