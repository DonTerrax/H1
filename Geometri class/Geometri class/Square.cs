using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_class
{
   public class Square
    {

        private int a;
        private int b;
        private int c;
        private int d;

        #region Get/set

        
        public int A
        {
            get
            {
                return a;

            }
            set
            {
                a = value;

            }
        }

        public int B
        {
            get
            {
                return b;

            }
            set
            {
                b = value;

            }
        }

        public int C
        {
            get
            {
                return c;

            }
            set
            {
                c = value;

            }
        }

        public int D
        {
            get
            {
                return d;

            }
            set
            {
                d = value;

            }
        }
        #endregion


        public Square(int a)
        {
            this.a = a;
        }

        public int calculator()
        {
            return A * 4;
        }

        public int area()
        {
            return A * a;
        }

       

       
    }
}
