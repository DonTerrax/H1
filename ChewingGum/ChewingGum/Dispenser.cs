using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewingGum
{
    class Dispenser
    {
        private int capacity;
        private bool empty;
        private double amount;

        private static List<Gum> gumlist = new List<Gum>();
        

        public Dispenser()
        {

        }

        #region Constructor

        public Dispenser(int capacity,bool empty,int amount)
        {
            this.capacity = capacity;
            this.empty = empty;
            this.amount = amount;
        }
        #endregion


        #region Properties

        public int Capacity
        {
            get
            {
                return capacity;

            }
            set
            {
                capacity = value;

            }
        }

        public bool Empty
        {
            get
            {
                return empty;

            }
            set
            {
                empty = value;

            }
        }

        public List<Gum> Gumlist
        {
            get
            {
                return gumlist;
                
            }
            set
            {
                gumlist = value;

            }
        }

        public double Amount
        {
            get
            {
                return amount;

            }
            set
            {
                amount = value;

            }
        }


        #endregion


        #region Methods

        
        public void TurnLever()
        {

        }

        public void InsertCoin()
        {

        }

        public void CreateGum()
        {
            Gum blue = new Gum("blue","Blueberry");
            Gum purple = new Gum("Purple","Blackberry");
            Gum yellow = new Gum("Yellow","Tutti Frutti");
            Gum orange = new Gum("Orange", "Orange");
            Gum red = new Gum("Red", "Strawberry");
            Gum green = new Gum("Green", "Apple");

            bool again = true;
            double countBlue = 55 * 0.2;
            double countPurple = 55 * 0.12;
            double countYellow = 55 * 0.20;
            double countOrange = 55 * 0.19;
            double countRed = 55 * 0.14;
            double countGreen = 55 * 0.10;

            for (int i = 0; i < countBlue; i++)
            {
                Gum gum = new Gum();
                gumlist.Add(blue);
            }
            for (int i = 0; i < countPurple; i++)
            {
                Gum gum = new Gum();
                gumlist.Add(purple);
            }
            for (int i = 0; i < countYellow; i++)
            {
                Gum gum = new Gum();
                gumlist.Add(yellow);
            }
            for (int i = 0; i < countOrange; i++)
            {
                Gum gum = new Gum();
                gumlist.Add(orange);
            }
            for (int i = 0; i < countRed; i++)
            {
                Gum gum = new Gum();
                gumlist.Add(red);
            }
            for (int i = 0; i < countGreen; i++)
            {
                Gum gum = new Gum();
                gumlist.Add(green);
            }
        }

        //public List<Gum>AddGum()
        //{

        //}

        public static Gum[] RandomGum()
        {
            Random random = new Random();
            Gum[]randomGum = new Gum[1];
            
            for (int i = 0; i < 1; i++)
            {
                int j = random.Next(gumlist.Count);
                
                randomGum[i] = gumlist[j];

                gumlist.RemoveAt(j);
                return randomGum;
            }

            return null;

        }

        public static List<Gum> ReturnGumList()
        {
            return gumlist;
        }
        
        #endregion
    }
}
