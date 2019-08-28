using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {

            Store addGame = new Store();
            addGame.Games();
            int menu = 0;
            int choice = 0;
            string checkOut;
            while (true)
            {
                Console.WriteLine("1: View Games in the store\n2: Add games to shoppingcart\n3: Checkout\n4: Exit");
                menu = int.Parse(Console.ReadLine());
                int i = 1;

                try
                {
                    switch (menu)
                    {

                        case 1:
                            foreach (string item in Store.OutPut())
                            {
                                Console.WriteLine(item);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            menu = 0;

                            foreach (string item in Store.OutPut())
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("What games do you want to buy? (ID)");
                            try
                            {
                                
                                choice = int.Parse(Console.ReadLine());
                                Store addToCart = new Store(choice);
                                addToCart.AddToShoppingCart();
                                Console.Clear();
                            }

                            catch (Exception e)
                            {
                                Console.WriteLine("Wrong input. Write the ID number on the game you want to buy");
                                Console.ReadKey();
                            }
                            
                            break;
                        case 3:
                            Store showCart = new Store();
                            foreach (Game item in Store.ShoppingCart)
                            {
                                Console.WriteLine(item.Title);
                            }

                            try
                            {
                                Console.WriteLine("Proceed to checkout? y/n");
                                checkOut = Console.ReadLine();
                                Console.Clear();
                                if (checkOut == "y")
                                {
                                    Store total = new Store();
                                    Console.WriteLine("Total sum of the games that you have bought: " + total.CheckOut());
                                    Console.ReadKey();
                                }
                                
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Wrong input. Press y or n");
                                
                            }
                            
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input. Use numbers press any key to continue");
                    Console.ReadKey();
                }

            }




        }
    }
}
