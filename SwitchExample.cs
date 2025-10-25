using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class SwitchExample
    {
        public void userOutput()
        {
            Console.WriteLine("Enter a Number");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 10:
                    Console.WriteLine("User Entered Value is 10");
                    break;
                case 20:
                    Console.WriteLine("User Entered Value is 20");
                    break;
                case 30:
                    Console.WriteLine("User Entered Value is 30");
                    break;
                case 40:
                    Console.WriteLine("User Entered Value is 40");
                    break;
                case 50:
                    Console.WriteLine("User Entered Value is 50");
                    break;
                default:
                    Console.WriteLine("User Entered Number is not 10, 20, 30, 40 or 50");
                    break;
            }
        }
    }
}
