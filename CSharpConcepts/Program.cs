using System.Diagnostics;
using CSharpConcepts.Classes.Examples;
using CSharpConcepts.Classes.Exercises;

namespace CSharpConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallTypeExamples();
            //CallTypeExercises();

            //CallSelectionExamples();
            //CallSelectionExercises();
        }

        static void CallTypeExamples()
        {
            Console.WriteLine("# Declaring numeric types");
            TypeExamples.DeclaringNumericTypes();
            Console.WriteLine();

            Console.WriteLine("# Converting numeric types");
            Console.WriteLine("Please enter a number to convert");
            string value = Console.ReadLine() ?? "";
            TypeExamples.ConvertingToADouble(value);
            Console.WriteLine();

            Console.WriteLine("# Dividing integers");
            TypeExamples.DividingIntegers();
            Console.WriteLine();

            Console.WriteLine("# Declaring non numeric types");
            TypeExamples.DeclaringNonNumericTypes();
            Console.WriteLine();

            Console.WriteLine("# Sorting Hat");
            TypeExamples.House house = TypeExamples.SortingHat();
            Console.WriteLine($"Your house is {house}");
            Console.WriteLine();

            Console.WriteLine("# Sorting Hat 2");
            Console.WriteLine("Please enter your house");
            string possibleHouse = Console.ReadLine() ?? "";
            TypeExamples.House actualHouse = TypeExamples.SortingHat(possibleHouse);
            Console.WriteLine($"Your house is {actualHouse}");
            Console.WriteLine();
        }

        static void CallTypeExercises()
        {
            Console.WriteLine("# Calculator");
            TypeExercises.Calculator(12, 5);
            Console.WriteLine();

            // Add your own calling code here for the other questions
        }

        static void CallSelectionExamples()
        {
            Console.WriteLine("# Assign Letter Grade");
            string grade = SelectionExamples.AssignLetterGrade(90);
            Console.WriteLine($"Your grade was a {grade}");
            // Can use Debug.Assert to check return values
            Debug.Assert(SelectionExamples.AssignLetterGrade(70) == "Merit", "Merit expected");
            Console.WriteLine();

            Console.WriteLine("# Conditional Operations");
            SelectionExamples.ConditionalOperations(false, true);
            Console.WriteLine();

            Console.WriteLine("# Lift Takeoff");
            string message = SelectionExamples.LiftTakeoff(5, 142d);
            Console.WriteLine(message);
            Console.WriteLine();

            Console.WriteLine("# Determine tip");
            decimal tip = SelectionExamples.DetermineTip("Good");
            Console.WriteLine($"The tip will be {tip}");
            Console.WriteLine();

            Console.WriteLine("# Determine tip with enum");
            decimal tip2 = SelectionExamples.DetermineTip(SelectionExamples.ServiceLevel.Ok);
            Console.WriteLine($"The tip will be {tip2}");
            Console.WriteLine();


        }

        static void CallSelectionExercises()
        {
          // Add your own calling code here for the selection questions
        }
    }
}
