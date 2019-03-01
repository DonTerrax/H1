using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_60_Exercise_1
{
    class Square
    {
        private int _area;
        private int _sideLength;

        public Square(int sideLength)//constructor
        {
            _sideLength = sideLength;
            
            calcArea();//Calls the method calcArea
        }


        public int Area
        {
            get { return _area; }
        }


        public int SideLength
        {
            get { return _sideLength; }
        }


        private void calcArea()
        {
            _area = _sideLength * _sideLength;
        }
     

    }
}
