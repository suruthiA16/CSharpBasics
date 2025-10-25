using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class WhileDoWhileExample
    {
        public void DoWhileBasic()
        {
            int userTarget = 0;
            string userDecision = string.Empty;
            do
            {
                int start = 0;
                Console.WriteLine("Please Enter Your Target Number");
                userTarget = int.Parse(Console.ReadLine());

                while (start <= userTarget)
                {
                    Console.Write(start + " ");
                    start += 2;
                }

                do
                {
                    Console.WriteLine("\nDo you want to continue – Yes or No?");
                    userDecision = Console.ReadLine().ToUpper();

                    if (userDecision != "YES" && userDecision != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No");
                    }

                } while (userDecision != "YES" && userDecision != "NO");

            } while (userDecision == "YES");
        }

    }
}
