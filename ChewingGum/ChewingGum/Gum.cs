using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewingGum
{
    class Gum
    {
        public string color;
        public string flavor;

        #region Properties

        public string Color
        {
            get
            {
                return color;

            }
            set
            {
                color = value;

            }
        }

        public string Flavor
        {
            get
            {
                return flavor;

            }
            set
            {
                flavor = value;

            }
        }
        

        #endregion

        public Gum()
        {

        }

        public Gum(string color,string flavor)
        {
            this.color = color;
            this.flavor = flavor;
            
        }
    }
}
