using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CSharpConcepts.Classes.Exercises;

namespace CSharpConcepts
{
    internal class Exercises
    {
        internal static void Run()
        {
            CallIterationExercises();
            CallSelectionExercises();
        }

        private static void CallIterationExercises()
        {
            Console.WriteLine("# Number of centuries");
            List<int> input = new() { 12, 5, 2, 100, 11, 22, 55, 17, 23, 17, 66, 100, 6, 100, 0 };
            IterationExercises.NumberOfCenturiesScored(input);
            Console.WriteLine();

            Console.WriteLine("# Batting average");
            IterationExercises.BattingAverage(input);
            Console.WriteLine();

            Console.WriteLine("# UserNames");
            List<string> names = new() { "George", "Jacob", "Mahin", "Ian", "Alex", "Rakan", "Chongyang", "Kevin", "Xichao", "Aseem" };
            IterationExercises.UserNames(names);
            Console.WriteLine();

            Console.WriteLine("# Multiples");
            IterationExercises.CalculateMultiples(6, 10);
            Console.WriteLine();

            Console.WriteLine("# IsPrime?");
            IterationExercises.IsPrime(7);
            Console.WriteLine();

            Console.WriteLine("# Stars");
            IterationExercises.StarPattern(7);
            Console.WriteLine();
        }

        private static void CallSelectionExercises()
        {
            // Add your calling code here for the selection questions
        }
    }
}
