using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Examples
{
    public class TypeExamples
    {
        public static void DeclaringNumericTypes()
        {
            float floatNum = 10.1f;
            Console.WriteLine($"{floatNum} is of type {floatNum.GetType()}."); 

            double doubleNum = 10.1d;
            Console.WriteLine($"{doubleNum} is of type {doubleNum.GetType()}.");

            decimal decimalNum = 10.1m;
            Console.WriteLine($"{decimalNum} is of type {decimalNum.GetType()}. ");

            int intNum = 10;
            Console.WriteLine($"{intNum} is of type {intNum.GetType()}. Min value is {int.MinValue}. Max value is {int.MinValue}.");
        }     


        public static void DeclaringNonNumericTypes()
        {
            bool found = false;
            Console.WriteLine($"{found} is of type {found.GetType()}.");

            string greeting = "Hello";
            Console.WriteLine($"{greeting} is of type {greeting.GetType()}.");

            char letter = 'H';
            Console.WriteLine($"{letter} is of type {letter.GetType()}.");

            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"{dateTime} is of type {dateTime.GetType()}.");
        }

        public static void DividingIntegers()
        {
            int numA = 10;
            int numB = 3;

            // Dividing integers A
            double numC = numA / numB;
            Console.WriteLine($"When both numbers are integers: {numA} / {numB} is {numC}.");

            // Dividing integers B
            numC = numA / (double)numB;
            Console.WriteLine($"When one number is converted to a float: {numA} / {(double)numB} is {numC}.");
        }


        public static void ConvertingToADouble(string value)
        {
            // We can''t just cast a string to a double (double)value won't work

            if (Double.TryParse(value, out double num))
            {
                Console.WriteLine($"Converted {value} to {num}");
            }
            else
            {
                Console.WriteLine($"Could not convert {value} to a double");
            }

            double num2 = Double.Parse(value);
            Console.WriteLine($"Converted {value} to {num2}");

            double num3 = Convert.ToDouble(value);
            Console.WriteLine($"Converted {value} to {num3}");
        }          


        // An enum is a set of named constants
        public enum House
        {
            Griffindor,
            Hufflepuff,
            Ravenclaw,
            Slytherin
        }

        public static House SortingHat()
        {
            Random random = new Random();
            int choice = random.Next(0, 4);
            // Converts the number to the houses enum
            House hogwartsHouse = (House)choice;
            return hogwartsHouse;
        }

        public static House SortingHat(string possibleHouse)
        {
            if (Enum.TryParse(possibleHouse, true, out House house))
            {
                return house;
            }
            else
            {
                Console.WriteLine("Sorry your house was not valid. You will be randomly assigned a house");
                house = SortingHat();
                return house;
            }
        }

    }
}
