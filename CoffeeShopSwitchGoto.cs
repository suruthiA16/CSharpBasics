using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class CoffeeShopSwitchGoto
    {
        public void coffeeShop()
        {
            int totalOrderPrice = 0;
        Start:
            Console.WriteLine("Please select your Cofee Size: 1 - Small, 2 - Medium, 3 - Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    totalOrderPrice += 1;
                    break;
                case 2:
                    totalOrderPrice += 2;
                    break;
                case 3:
                    totalOrderPrice += 3;
                    break;
                default:
                    Console.WriteLine("Your Choice {0} is invalid", userChoice);
                    goto Start;
            }

        Decision:
            Console.WriteLine("Do you want to buy another coffee - Yes or No ?");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choce {0} is invalid. Please try again...", userDecision);
                    goto Decision;
            }

            Console.WriteLine("Thank You for shopping with us");
            Console.WriteLine("Total Bill Amount {0}", totalOrderPrice);
        }
    }
}
