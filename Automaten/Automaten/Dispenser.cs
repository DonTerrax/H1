using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Dispenser
    {
        private static Stack<Inventory> snickers = new Stack<Inventory>();
        private static Stack<Inventory> marsbars = new Stack<Inventory>();
        private byte price;
        private int totalSum;

        private const int max = 10;


        public Dispenser()
        {

        }

        //constructor
        public Dispenser(byte price,int totalSum)
        {
            this.price = price;
            this.totalSum = totalSum;
        }

        #region Properties

        public static Stack<Inventory> Snickers
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

        public static Stack<Inventory> Marsbars
        {
            get
            {
                return marsbars;

            }
            set
            {
                marsbars = value;

            }
        }

        public byte Price
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

        public int TotalSum
        {
            get
            {
                return totalSum;

            }
            set
            {
                totalSum = value;

            }
        }


        #endregion

        #region Methods

        public string RemoveFromSnickers()
        {
            try
            {
                snickers.Pop();
            }
            catch (Exception e)
            {
                throw e;
               // return "Empty";
            }

            return null;

        }

        public string RemoveFromMars()
        {
            try
            {
                marsbars.Pop();
            }
            catch (Exception e)
            {
                return "Empty";

            }

            return null;
        }

        public string Empty()
        {
            if (snickers.Count == 0)
            {
                return "There are no snickers left" + " but there are "+ marsbars.Count+ " left";
            }
            else if (marsbars.Count == 0)
            {
                return "There are no marsbars left" + " but there are " + snickers.Count + " left";
            }
            else if(snickers.Count == 0 && marsbars.Count == 0)
            {
                return "There is nothing left";
            }

            return "There is: " + snickers.Count + " snickers left\n" + "There is: " + marsbars.Count + " marsbars left";
        }

        public void FillMarsbar()
        {
            Inventory mars = new Inventory();
            for (int i = 0; i < max; i++)
            {
                if (marsbars.Count < max)
                {
                    marsbars.Push(mars);
                }
                
            }
        }
        
        public void FillSnickers()
        {
            Inventory snickersbar = new Inventory();
            for (int i = 0; i < 10; i++)
            {
                if (snickers.Count < 10)
                {
                    snickers.Push(snickersbar);
                }
                
            }
        }

        

        public void MoneyToFile()
        {
            File.AppendAllText(@".\money.txt",totalSum.ToString() + "\r\n");
        }

        public Stack<Inventory> ReturnSnickers()
        {
            return snickers;
        }

        public int TotalDispenserSum(int price)
        {
            totalSum = totalSum + price;
            return totalSum;
        }




        #endregion

    }
}
