using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Game
    {
        private string title;
        private string platform;
        private int price;

        #region Properties

        public string Title
        {
            get
            {
                return title;

            }
            set
            {
                title = value;

            }
        }

        public string Platform
        {
            get
            {
                return platform;

            }
            set
            {
                platform = value;

            }
        }

        public int Price
        {
            get
            {
                return price;

            }
            set
            {
                price = value;

            }
        }

        #endregion

        public Game()
        {

        }

        #region Constructor


        public Game(string title,string platform,int price)
        {
            this.title = title;
            this.platform = platform;
            this.price = price;
        }


        #endregion

    }
 

}
