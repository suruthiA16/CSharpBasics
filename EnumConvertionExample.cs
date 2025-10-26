using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class EnumConvertionExample
    {
        //Enum & its convertions
        enum ProjectStatus
        {
            NotStarted = 0,
            InProgress = 1,
            Completed = 2,
            OnHold = 3,
            Cancelled = 4
        }

        public void EnumExample()
        {
            //Get All Names
            Console.WriteLine("Example to get all Enum Names");
            var Names = Enum.GetNames(typeof(ProjectStatus));
            foreach(var v in Names)
            {
                Console.WriteLine($"{v}");
            }

            //Get All Values
            Console.WriteLine("Example to get all Enum values");
            var intValues = Enum.GetValues(typeof(ProjectStatus));
            foreach (var i in intValues)
            {
                Console.WriteLine($"{i} = {(int)i}");
            }

            //Enum to String Conversion - Using ToString()
            Console.WriteLine("Enum to String Conversion");
            ProjectStatus statusE1 = ProjectStatus.Completed;
            string statusStringE1 = statusE1.ToString();
            Console.WriteLine($"Enum string value (Using ToString()) {statusStringE1}");

            //Enum to String Conversion - Using Enum.GetName()
            string statusStringE2 = Enum.GetName(typeof(ProjectStatus), 2);
            Console.WriteLine($"Enum string value (Using Enum.GetName()) {statusStringE1}");

            //String to Enum Conversion - Using Enum.Parse() - Not safe it will throw error if string doesnt match
            string userEnteredStatusE1 = "InProgress";
            ProjectStatus convertedEnumStatus = (ProjectStatus)Enum.Parse(typeof(ProjectStatus), userEnteredStatusE1);
            Console.WriteLine($"Enum type value (Using Enum.Parse()) {convertedEnumStatus}");

            //String to Enum Conversion - Using Enum.TryParse() - safe conversion
            string userEnteredStatusE2 = "Completed";
            if (Enum.TryParse(userEnteredStatusE2, out ProjectStatus res))
            {
                Console.WriteLine($"Parsed successfully: {res}");
            }
            else
            {
                Console.WriteLine("Invalid enum string");
            }

            //Enum to Int conversion
            Console.WriteLine("Enum to Integer Conversion");
            ProjectStatus enumStatusE1 = ProjectStatus.NotStarted;
            int statusValueE1 = (int)enumStatusE1;
            Console.WriteLine($"Enum to Int conversion {statusValueE1}");

            //Int to Enum conversion - not safe as it will throw error if int is invalid
            Console.WriteLine("Integer to Enum Conversion");
            int IntStatusE1 = 2;
            ProjectStatus enumStatusValueE1 = (ProjectStatus)IntStatusE1;
            Console.WriteLine($"Int to Enum conversion {enumStatusValueE1}");

            //Int to Enum conversion - safe as it will handle invalid int
            int invalidInt = 99;
            if (Enum.IsDefined(typeof(ProjectStatus), invalidInt))
            {
                ProjectStatus converedIntToEnum = (ProjectStatus)invalidInt;
                Console.WriteLine($"Converted Enum value {converedIntToEnum}");
            }
            else
            {
                Console.WriteLine("Invalid ProjectStatus value");
            }
        }
    }
}
