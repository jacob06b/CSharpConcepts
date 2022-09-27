using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class IterationExercises
    {
        // Q1: Centuries
        // Calculate the number of times a batter scored a century (100 runs) or more in a match
        public static int NumberOfCenturiesScored(List<int> scores)
        {
            int total = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] >= 100)
                {
                    total++;
                }
                

            }
            Console.WriteLine(total);
            return total;
        }

        // Q2: Batting Average
        // Calculate the batting average.
        // Exclude any values where the runs scored were negative as a negative value indicates that they did not bat in that match.
        public static double BattingAverage(List<int> runsScored)
        {
            int total = 0;
            for (int i = 0; i <runsScored.Count; i++)
            {
                total = total + runsScored[i];
              
            }
            double average = total / runsScored.Count;
            Console.WriteLine(average);
            return average;
        }

        // Q3: User Names
        // Determine the user names
        // It will be the first three characters of their name and a number, which will be the order of the name in the list.
        public static List<string> UserNames(List<string> names)
        {
            List<string> newusernames = new List<string>();
            for (int i = 0; i < names.Count; i++)
            {
                string abbrev = names[i].Substring(0, 3);
                string j = Convert.ToString(i);
                abbrev = abbrev + i;
                newusernames.Add(abbrev);
            }
            for (int k=0; k < newusernames.Count; k++)
            {
                Console.WriteLine(newusernames[k]);
            }
            return newusernames;
        }

        // Q4: Calculate Multiples
        // Write a function that will output the multiple of a number from 1 to the max number specified
        // So called with 6 and 10 it would output [6, 12, 18, 24, 30, 36, 42, 48, 54, 60]
        public static List<int> CalculateMultiples(int number, int maximumMultiple)
        {
            List<int> multiples = new List<int>();
            int uptonumber = number * maximumMultiple;
            for (int i = number; i < (uptonumber+1); i=i+number)
                
            {
                multiples.Add(i);
            }
            Console.WriteLine(String.Join(" ", multiples));
            return multiples;
        }

        // Q5: Is Prime
        // Write a function to determine whether a number is prime
        public static void IsPrime(int num)
        {
            string prime = $"{num} is prime";
            for (int i = 2;i<(num-1);i++)
            {
                if (num % i == 0)
                {
                    prime = $"{num} is not prime";
                }
            }
            Console.WriteLine(prime);
            
        }

        // Q6: Star Pattern
        // Write a procedure to output a star pattern based on the number of stars input
        // So for example if the user enters 6 then it will output:

        public static void StarPattern(int num)
        {
            string stars = "";
            for (int i = 0; i <= num;i++)
            {
                stars = "";
                for (int j = 0; j < i; j++)
                {
                    
                    stars = stars + "*";
                }
                Console.WriteLine(stars);
            }
            for (int i = num; i >= 0; i=i-1)
            {
                stars = "";
                for (int j = 1; j < i; j++)
                {
                    
                    stars = stars + "*";
                }
                Console.WriteLine(stars);
            }
        }


        // Q7: This function should take a noughts and crosses board represented as an character list,
        // A space represents an empty space as shown below.

        List<List<char>> board = new()
        {
            new() { 'X', '0', 'X' },
            new() { ' ', '0', ' ' },
            new() { 'X', '0', ' ' }
        };
        
        // The function should return a char: 'X' if player X has won, '0' if the player 0 has won,
        // and ' ' if there is currently no winner.
    }
}
