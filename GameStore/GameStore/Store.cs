using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Store
    {
        private static List<Game>gameList = new List<Game>();
        private static List<Game>shoppeingCart = new List<Game>();
        private int id;

        #region Properties
        
        public static List<Game> GameList
        {
            get
            {
                return gameList;

            }
            set
            {
                gameList = value;

            }
        }

        public static List<Game> ShoppingCart
        {
            get
            {
                return shoppeingCart;

            }
            set
            {
                shoppeingCart = value;

            }
        }

        public int Id
        {
            get
            {
                return id;

            }
            set
            {
                id = value;

            }
        }
        #endregion

        public Store()
        {

        }

        public Store(int id)
        {
            this.id = id;
        }

        #region Methods

        public void Games()
        {
            Game game1 = new Game("The Walking Dead","PC",400);
            Game game2 = new Game("World Of Warcraft","PC",200);
            Game game3 = new Game("RedDeadRedemption","PS4",500);
            Game game4 = new Game("Anarchy Online","PC",120);
            Game game5 = new Game("Apex Legends","PC",0);

            gameList.Add(game1);
            gameList.Add(game2);
            gameList.Add(game3);
            gameList.Add(game4);
            gameList.Add(game5);
        }

        public static List<string> OutPut()
        {
            List<string>outPut = new List<string>();
            int i = 1;
            foreach (Game item in ReturnList())
            {
                outPut.Add("Id: " + i+" Title: "+item.Title+" Price: "+item.Price+" Platform: "+item.Platform);
                i++;
            }

            return outPut;
        }

        public static List<Game> ReturnList()
        {
            return gameList;
        }

        public int CheckOut()
        {
            int sum = 0;
            foreach (Game item in shoppeingCart)
            {
                sum += item.Price;
            }

            return sum;
        }

        public void AddToShoppingCart()
        {
            shoppeingCart.Add(gameList[id - 1]);
        }

        public List<Game> ReturnShoppingCart()
        {
            return shoppeingCart;
        }

        
        #endregion





    }
}
