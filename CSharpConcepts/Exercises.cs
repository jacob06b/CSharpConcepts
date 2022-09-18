﻿using System;
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
            CallTypeExercises();
            CallSelectionExercises();
        }

        private static void CallTypeExercises()
        {
            // Add your calling code here for the questions an example is below

            Console.WriteLine("#BMIcalculator");
            TypeExercises.BMICalculator(172.9, 63.4);
            Console.WriteLine();
        }

        private static void CallSelectionExercises()
        {
            // Add your calling code here for the selection questions
        }
    }
}
