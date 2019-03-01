using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometri
{
    public class Square
    {
        //public int _length;
        //public int _width;

        private int _width;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }


        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }


        // Constructor
        public Square(int length, int width)
        {
            _length = length;
            _width = width;
        }
    }
}
