using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class ForAndForeachExample
    {
        public void forForEach()
        {
            int[] arrayValues = [101, 102, 103, 104, 105, 106];

            //For example
            Console.WriteLine("Example of for loop");
            for (int i = 0; i < arrayValues.Length; i++)
            {
                Console.WriteLine(arrayValues[i]);
            }

            //Foreach example
            Console.WriteLine("Example of foreach loop");
            foreach (int i in arrayValues)
            {
                Console.WriteLine(i);
            }

            //continue example with for loop - Print even numbers
            Console.WriteLine("Enter the target number to get its even numbers");
            int userTargetInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Example of continue");
            for (int i = 0; i < userTargetInput; i++)
            {
                if (i % 2 == 1)
                    continue; //this will skip odd numbers and continue the loop till the condition met
                Console.WriteLine(i);

            }

            //break example with for loop - Print till 10 only
            Console.WriteLine("Example of break");
            for (int i = 1; i < userTargetInput; i++)
            {
                Console.WriteLine(i);
                if (i == 10)
                    break; //this will skip the remaining process and will came out of loop               
            }

        }
    }
}
