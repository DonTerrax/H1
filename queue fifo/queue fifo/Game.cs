using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace queue_fifo
{
    class Game
    {
        private static Queue<Game> userGames = new Queue<Game>();
        private static List<object> listOfGames = new List<object>();
        private string title;
        private int price;
        private string platform;
        private static int id;

        #region properties

        public Queue<Game> UserGames
        {
            get
            {
                return userGames;

            }
            set
            {
                userGames = value;

            }
        }

        public List<object> ListOfGames
        {
            get
            {
                return listOfGames;

            }
            set
            {
                listOfGames = value; 

            }
        }

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

        public string PlatForm
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

        //Constructor
        public Game(string title)
        {
            this.title = title;
        }

        public Game()
        {

        }

        public static List<object>ReturnList()
        {
            return listOfGames;
        }

        //Constructor
        public Game(string title,int price,string platform)
        {
            this.title = title;
            this.price = price;
            this.platform = platform;
        }

        //Add game
        public void AddGame()
        {
            Game game = new Game(title,price,platform);
            listOfGames.Add(game);
        }
        //Delete game
        public void DeleteGame(int iid)
        {
            
            listOfGames.RemoveAt(iid);
        }

        public int ShowNumberOfGames()
        {
            return listOfGames.Count;
        }
        //Find min value
        public int Min()
        {
            List<int>min = new List<int>();
            foreach (Game item in listOfGames)
            {
                min.Add(item.Price);
            }

            return min.Min();
        }
        //Find max value
        public int Max()
        {
            List<int>max = new List<int>();
            foreach (Game item in listOfGames)
            {
                max.Add(item.price);
            }

            return max.Max();
        }

        public string GamesAvalible(int menu)
        {
            foreach (Game item in Game.listOfGames)
            {
                if (listOfGames[menu] == item)
                {
                    return "ID:" + menu + " Title: " + item.Title + " Price: " + item.Price + " Platform: " + item.platform;
                }
                
            }

            return "empty";
        }
        //Find game
        public string FindGame()
        {
            foreach (Game item in Game.listOfGames)
            {
                if (item.title.Contains(title))
                {
                    id++;
                    return "title: " + item.title + "\nprice: "+ item.price+ "\nPlatform: "+item.PlatForm;
                    
                }
            }

            return "Game not found";
        }

        public Queue<Game> QueueGames()
        {
            foreach (Game item in listOfGames)
            {
                Game test = new Game(item.title,item.Price,item.platform);
                userGames.Enqueue(test);
                return userGames;
            }

            return userGames;
        }
       
        
    }
}
