using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class TypeExercises
    {
        // Q1: Calculator 1
        // Write to the console correctly the results of: +. - , *, /
        public static void Calculator(int num1, int num2)
        {
            int addition = num1 + num2;
            int multiplication = num1 * num2;
            int subtraction = num1 - num2;
            double division = num1 / num2;
            Console.WriteLine($"The two numbers added together ={addition}");
            Console.WriteLine($"The two numbers multiplied together together ={multiplication}");
            Console.WriteLine($"The first number minus the second number ={subtraction}");
            Console.WriteLine($"The first number divided by the second number ={division}");
        }

        // Q2: Calculator 2
        // Try to convert both the values to a double and write to the console the results of: +. - , *, /
        public static void Calculator(string value1, string value2)
        {
            double newvalue1 = double.Parse(value1);
            double newvalue2 = double.Parse(value2);
            double addition = newvalue1 + newvalue2;
            double multiplication = newvalue1 * newvalue2;
            double subtraction = newvalue1 - newvalue2;
            double division = newvalue1 / newvalue2;
            Console.WriteLine($"The two numbers added together ={addition}");
            Console.WriteLine($"The two numbers multiplied together together ={multiplication}");
            Console.WriteLine($"The first number minus the second number ={subtraction}");
            Console.WriteLine($"The first number divided by the second number ={division}");
        }

        // Q3: Binary Strings
        // Write to the console the number printed in Binary, Decimal and Hex formats
        public static void BinaryStrings(int num)
        {
            String BinNum = Convert.ToString(num, 2);
            Decimal DecNum = Convert.ToDecimal(num);
            String HexNum = Convert.ToString(num, 16);
            Console.WriteLine(BinNum);
            Console.WriteLine(DecNum);
            Console.WriteLine(HexNum);

        }

        // Q4: BMI
        // Calculate and return the BMI - Body mass index
        public static double BMICalculator(double height, double weight)
        {
            double bmi = height / (weight * weight);
            Console.WriteLine($"The BMI is {bmi}");
            return bmi
        }

        // Q5: FutureDate
        // Write to the console today's date. Return the date that it will be when the days passed in are added to the current date. 
        public static DateTime FutureDate(int days)
        {
            throw new NotImplementedException();
        }
        
        // Q6: Languages
        // Using the enum below write a program that will convert the proposed language to the enum if availabe
        // Otherwise it should randomly assign a language
        public enum Language
        {
            French,
            Italian,
            Spanish,
            Finnish
        }
        public static Language SelectLanguage(string proposedLanguage)
        {
            throw new NotImplementedException();
        }


    }
}
