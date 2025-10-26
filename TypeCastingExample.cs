using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class TypeCastingExample
    {
        public void typeCasting()
        {
            Console.WriteLine("=== TYPE CONVERSION DEMO ===\n");

            //Implicit type convertion - automatic (small type value to big type value)
            Console.WriteLine("IMPLICIT CONVERSION (Automatic)\n");
            int intValueE1 = 33;
            double convertedDoubleValueE1 = intValueE1;
            Console.WriteLine($"Implicit Conversion (int to double): {convertedDoubleValueE1}\n");

            //Explicit type convertion - manual (big type value to small type value)
            Console.WriteLine("EXPLICIT CONVERSION (Casting)\n");
            double doubleValueE2 = 3.14159;
            int convertedIntValueE2 = (int)doubleValueE2;
            Console.WriteLine($"Explicit Conversion (double to int): {convertedIntValueE2}\n");

            //Convertion using convert class (preferred for string to any type conversion)
            Console.WriteLine("CONVERSION USING Convert CLASS\n");
            string stringValueE3 = "123";
            int convertedIntValueE3 = Convert.ToInt32(stringValueE3);
            Console.WriteLine($"Using Convert Class (string to int): {convertedIntValueE3} \n");

            Console.WriteLine("Convert handles null safely\n");
            string nullStringValueE4 = null;
            int convertedIntValueE4 = Convert.ToInt32(nullStringValueE4);
            Console.WriteLine($"Convert with null string: {convertedIntValueE4} \n");

            //Convertion using Parse() - it wont handle null or errored formats ex: from "abc" to int (FormatException)
            Console.WriteLine("CONVERSION USING Parse()\n");
            string stringValueE5 = "1677";
            int convertedIntValueE5 = int.Parse(stringValueE5);
            Console.WriteLine($"Using Parse() (string to int): {convertedIntValueE5} \n");

            //Convertion using TryParse() - it will safely handle null & format exception
            Console.WriteLine("CONVERSION USING TryParse()\n");

            //Convertion with alphabet
            string stringAlphabetValueE6 = "abc";
            bool alphabetConvertionResult = int.TryParse(stringAlphabetValueE6, out int res);
            if (alphabetConvertionResult)
            {
                Console.WriteLine($"Using TryParse() (string to int): {res}\n");
            }
            else
            {
                Console.WriteLine("TryParse failed.\n");
            }

            //Convertion with number type string
            string stringNumberValueE6 = "1222";
            bool numberConvertionResult = int.TryParse(stringNumberValueE6, out int val);
            if (numberConvertionResult)
            {
                Console.WriteLine($"Using TryParse() (string to int): {val} \n");
            }
            else
            {
                Console.WriteLine("TryParse failed.\n");
            }

            //Reference Type Implicit Convertion - Upcasting
            Console.WriteLine("IMPLICIT CONVERSION BETWEEN REFERENCE TYPES\n");
            Dog newDog = new Dog();
            Animal dogAnimal = new Animal();
            Console.WriteLine("Implicit Reference Conversion: Dog to Animal\n");

            //Reference Type Explicit Convertion - downcasting
            Console.WriteLine("EXPLICIT CONVERSION BETWEEN REFERENCE TYPES\n");
            Animal animal = new Dog();
            Dog dog = (Dog) animal;
            Console.WriteLine("Explicit Reference Conversion: Animal to Dog (safe)\n");

            Console.WriteLine("Safe downcasting check\n");
            Animal animalSoftConvertion = new Animal();
            Dog convertedAnimalDog = animalSoftConvertion as Dog;

            if (convertedAnimalDog != null) Console.WriteLine("Safe Downcasting with 'as' failed (animal is not a Dog)\n");

            Console.WriteLine("\n=== END OF DEMO ===");
        }

        public class Animal() { };

        public class Dog() : Animal { };
    }
}
