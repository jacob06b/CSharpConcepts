using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Examples
{
    public static class IterationExamples
    {
        #region Count controlled 
        // In Count controlled or definite iteration
        // The statement is repeated a specific number of times

        // For loop examples
        public static int Sum(int n)
        {
            int total = 0;
            for (int i=0; i <= n; i++)
            {
                total += n;
            }
            return total;
        }
        public static int Sum(int n, int step)
        {
            int total = 0;
            for (int i = 0; i <= n; i+=step)
            {
                total += n;
            }
            return total;
        }

        // For each examples
        public static int Sum()
        {
            int[] numbers = { 5, 2, 3, 6, 7, 8 };
            int total = 0;
            foreach (int num in numbers)
            {
               total += num;
            }
            return total;
        }

        // For each examples
        public static string BirthdayGreeting()
        {
            string[] names = { "Bob", "Jane", "Kevin", "Fred"};
            string greeting = "Happy birthday to ";
            foreach (string name in names)
            {
                greeting = greeting + $"{name} ";
            }
            return greeting;
        }

        // For loop versus a foreach loop
        // In a foreach loop the loop variable is read only and cannot be changed
        public static double[] SquaredNumbers()
        {
            double[] numbers = { 9, 12, 3, 7, 17 };
            for (int i=0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Pow(numbers[i], 2);
            }
            return numbers;
        }
        /* public static double[] SquaredNumbersWithForeach()
         {
             double[] numbers = { 9, 12, 3, 7, 17 };
             foreach (double num in numbers)
             {
                 num = Math.Pow(num, 2);
             }
             return numbers;
         }*/
        #endregion

    }
}
