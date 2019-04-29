using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuOption;
            const int snickers = 5;
            const int marsbar = 10;
            string confirm;
            Dispenser item = new Dispenser();
            item.FillSnickers();
            item.FillMarsbar();
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Choose your option:\n1: Buy candy\n2: Admin menu\n3: Exit");
                    menuOption = int.Parse(Console.ReadLine());

                    switch (menuOption)
                    {
                        case 1:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine(item.Empty());
                                Console.WriteLine("1: Snickers: {0}kr\n2: Marsbar {1}kr\n3: Exit", snickers, marsbar);
                                menuOption = int.Parse(Console.ReadLine());

                                switch (menuOption)
                                {

                                    case 1:
                                        Console.Clear();
                                        confirm = "n";

                                        Console.WriteLine("Insert money to the dispenser");
                                        int coinSnickers = int.Parse(Console.ReadLine());
                                        if (coinSnickers >= snickers)
                                        {
                                            Console.WriteLine("Confirm y/n");
                                            confirm = Console.ReadLine().ToLower();
                                            if (confirm == "y")
                                            {
                                                coinSnickers -= snickers;
                                                Console.WriteLine("You get {0}kr back", coinSnickers);
                                                item.TotalDispenserSum(coinSnickers);
                                                Console.WriteLine(item.RemoveFromSnickers());
                                                Console.ReadKey();


                                            }
                                            else
                                            {
                                                Console.WriteLine("You get {0} back in change", coinSnickers);
                                                Console.ReadKey();
                                            }
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("Not enough money inserted");
                                            Console.ReadKey();
                                        }
                                        
                                        break;


                                    case 2:
                                        Console.Clear();

                                        Console.WriteLine("Insert money to the dispenser");
                                        int coinMars = int.Parse(Console.ReadLine());

                                        if (coinMars >= marsbar)
                                        {
                                            Console.WriteLine("Confirm y/n");
                                            confirm = Console.ReadLine().ToLower();

                                            if (confirm == "y")
                                            {
                                                coinMars -= marsbar;
                                                Console.WriteLine("You get {0}kr back", coinMars);
                                                Console.WriteLine(item.RemoveFromMars());
                                                item.TotalDispenserSum(marsbar);
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                Console.WriteLine("You get {0} back in change", coinMars);
                                                Console.ReadKey();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Not enough money inserted");
                                            Console.ReadKey();
                                        }
                                        break;
                                   
                                    default:
                                        Console.Clear();
                                        break;

                                }

                            } while (menuOption != 3);

                            break;
                        case 2:
                            Console.WriteLine("1: Get the cash\n2: Fill Snickers\n3: Fill Marsbars\n4: Exit");
                            menuOption = int.Parse(Console.ReadLine());

                            switch (menuOption)
                            {
                                case 1:
                                    item.MoneyToFile();
                                    Console.WriteLine("You empty the box and get {0}kr", item.TotalDispenserSum(0));
                                    item.TotalSum = 0;
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    item.FillSnickers();
                                    break;
                                case 3:
                                    item.FillMarsbar();
                                    break;
                                default:
                                    break;
                                
                            }
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;

                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Wrong input" + fe.Message);
                    Console.ReadKey();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input" + e.Message);
                    Console.ReadKey();

                }

            }

        }


    }
}
