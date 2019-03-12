using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_fifo
{
    class Program
    {
        static void Main(string[] args)
        {

            int menu;
            string title;
            int price;
            string platform;
            int id;
            while (true)
            {
                Console.WriteLine("1: Add game\n2: Delete game\n3: Show number of games\n4: Show min/max\n5: Find a game\n6: Show all games\n7: Buy game\n8: Exit");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1://add game
                        Console.WriteLine("Title:");
                        title = Console.ReadLine();
                        Console.WriteLine("Price:");
                        price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Platform:");
                        platform = Console.ReadLine();
                        Game gameAdd = new Game(title, price, platform);
                        gameAdd.AddGame();
                        Console.Clear();
                        break;
                    case 2://Delete game
                        Console.WriteLine("Title:");
                        title = Console.ReadLine();
                        Game delete = new Game(title);

                        Console.WriteLine("delete id:");
                        int iid = int.Parse(Console.ReadLine());
                        delete.DeleteGame(iid);
                        break;
                    case 3://show number of games
                        Game showNumber = new Game();
                        Console.WriteLine("Number of games {0}", showNumber.ShowNumberOfGames());
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4://Show min max
                        Game minMax = new Game();
                        Console.WriteLine("Min: {0} Max: {1}",minMax.Min(),minMax.Max());
                        break;
                    case 5://Find game
                        Console.WriteLine("Title: ");
                        title = Console.ReadLine();

                        Game search = new Game(title);
                        Console.WriteLine(search.FindGame());
                        Console.ReadKey();
                        break;
                    case 6://show all games
                        menu = 0;
                        foreach (Game items in Game.ReturnList())
                        {
                            Console.WriteLine("ID: {0} Title: {1}. Price: {2}. Platform: {3}", menu, items.Title, items.Price, items.PlatForm);
                            menu++;
                        }

                        Console.ReadKey();
                        break;
                    case 7://Buy game
                        Console.Clear();
                        menu = 0;
                        Game games = new Game();
                        for (int i = 0; i < games.ListOfGames.Count; i++)
                        {
                            Console.WriteLine(games.GamesAvalible(menu));
                            menu++;
                        }

                        Console.WriteLine("Choose a game: (title)");
                        title = Console.ReadLine();

                        Game buy = new Game();
                        buy.QueueGames();
                        Console.WriteLine("Games bought:");

                        while (buy.UserGames.Count > 0)
                        {
                            Game name = buy.UserGames.Dequeue();
                            Console.WriteLine("Title: {0}. Price: {1} Platform {2}", name.Title, name.Price,name.PlatForm);
                        }
                        Console.ReadKey();
                        
                        break;
                    case 8:
                        Environment.Exit(0);
                        break; 
                    default:
                        break;

                }
            }
        }
    }
}
