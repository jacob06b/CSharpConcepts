using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class SelectionExercises
    {
 

        // Q1: FizzBuzz
        // Return Fizz if divisible by 3. Buzz if divisible by 5. FizzBuzz if divisible by both.
        // If divisible by neither return the number itself (as a string)
//            public static string FizzBuzz(int num)
//        {
//            bool fizzcheck = false;
//            bool buzzcheck = false;
//            int div3 = num % 3;
//            int div5 = num % 5;
//            if (div3 == 0)
//            {
//                bool fizzcheck = true;
//            }
//            else
//            {
//                bool fizzcheck = false;
//            }
//            if (div5 == 0)
//            {
//                bool buzzcheck = true;
//            }
//            else
//            {
//                bool buzzcheck = false;
//            }
//            if (fizzcheck == true)
//            {
//                if (buzzcheck == true)
//                {
//                    Console.WriteLine("FizzBuzz");
//                }
//                else
//                {
//                    Console.WriteLine("Fizz");
//                }
//            }
//            else if (buzzcheck == true)
//            {
//                Console.WriteLine("Buzz");
//            }
//            else
//            {
//                Console.WriteLine(num);
//            }
//        }
//
        // Q2: Vowel or Consonant
        // Using a switch statement write a function which returns true if the input is a vowel and
        // false if it is a consonant
        public static bool VowelOrConsonant(char letter)
        {
            string stringletter = letter.ToString();
            if (stringletter == "a"
                || stringletter == "e"
                || stringletter == "i"
                || stringletter == "o"
                || stringletter == "u")
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
            
        }

        // Q3: DiceRoller
        // Write a procedure which rolls three dice and write the following messages to the console
        // If all three dice have the same value write, "Three of a kind"
        // If two of the dice have the same value write, "You have a pair!
        // Otherwise write, "Sorry you lose
        public static int DiceRoller()
        {
            Random rnd = new Random();
            int die1 = rnd.Next(1, 7);
            int die2 = rnd.Next(1, 7);
            int die3 = rnd.Next(1, 7);
            Console.WriteLine(die1);
            Console.WriteLine(die2);
            Console.WriteLine(die3);
            if (die1 == die2)
            {
                if (die1 == die3)
                {
                    Console.WriteLine("Three of a kind");
                }
                else
                {
                    Console.WriteLine("You have a pair!");
                }
            }
            else if (die2 == die3)
            {
                Console.WriteLine("You have a pair!");
            }
            else
            {
                Console.WriteLine("Sorry, you lose!");
            }
            return die1;
        }  
        // Q4: Angles
        // Write a function to return whether the angle input is acute, right angle, obtuse, straight or reflex
        // Use an enum for the different angle types

        // Q5: Rock, Paper Scissors
        // Write a procedure which takes the user's choice as input and randomly generate the computer's choice
        // It should write the computer's choice to the console and write whether the user lost, won, or drew.
        // Handle the user input in the calling code in Program.cs

        // Q6: Triangle
        // Write a function that takes in three side lengths.
        // Determine whether a triangle with those sides is equilateral, isosceles, scalene or impossible



    }
}
