using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class BurgerShopWhile
    {
        public void burgerShop()
        {
            double totalBill = 0;
            string userChoice = "";
            string continueOrder = "Yes";
            Console.WriteLine("Welcome to Coder’s Burger Shop!");
            Console.WriteLine("-------------------------------");

            while (continueOrder.ToLower() == "yes")
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Classic Burger - 120");
                Console.WriteLine("2. Cheese Burger  - 150");
                Console.WriteLine("3. Veggie Burger  - 100");
                Console.WriteLine("4. Fries Combo    - 180");
                Console.WriteLine("\nEnter your choice:");
                userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Added Classic Burger!");
                        totalBill += 120;
                        break;
                    case "2":
                        Console.WriteLine("Added Cheese Burger!");
                        totalBill += 150;
                        break;
                    case "3":
                        Console.WriteLine("Added Veggie Burger!");
                        totalBill += 100;
                        break;
                    case "4":
                        Console.WriteLine("Added Fries Combo!");
                        totalBill += 180;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again!");
                        break;
                }

                Console.WriteLine("\nDo you want to continue ordering? (yes/no):");
                continueOrder = Console.ReadLine();
            }
            Console.WriteLine("\nFinalizing your order...");
            Console.WriteLine($"Your total bill amount is: {totalBill}");
            Console.WriteLine("Thank you for visiting Coder’s Burger Shop! Have a tasty day ");
        }
    }
}
