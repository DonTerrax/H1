using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Inventory
    {
        private string marsbar;
        private string snickers;

        #region Properties
        
        public string Marsbar
        {
            get
            {
                return marsbar;

            }
            set
            {
                marsbar = value;

            }
        }

        public string Snickers
        {
            get
            {
                return snickers;

            }
            set
            {
                snickers = value;

            }
        }
        #endregion


        public Inventory()
        {
            snickers = "Snickers";
            marsbar = "Marsbar";
        }

        
    }
}
