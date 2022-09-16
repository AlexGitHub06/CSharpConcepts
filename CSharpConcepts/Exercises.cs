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
            CallTypeExercises();
            CallSelectionExercises();

        }

        private static void CallTypeExercises()
        {
            // Add your calling code here for the questions an example is below

            Console.WriteLine("# Calculator");
            TypeExercises.Calculator("12", "5");

            Console.WriteLine("\n# Binary Strings");
            TypeExercises.BinaryStrings(10);

            Console.WriteLine("\n# BMI");
            Console.WriteLine(TypeExercises.BMICalculator(1.75,65));

            Console.WriteLine("\n# Future Date");
            Console.WriteLine(TypeExercises.FutureDate(2));

            Console.WriteLine("\n# Select Language");
            Console.WriteLine(TypeExercises.SelectLanguage("chinese"));

        }

        private static void CallSelectionExercises()
        {
            // Add your calling code here for the selection questions

            Console.WriteLine("# Fizz Buzz");
            Console.WriteLine(SelectionExercises.FizzBuzz(15));

            Console.WriteLine("\n# Vowel Or Consonant");
            Console.WriteLine(SelectionExercises.VowelOrConsonant('e'));

            Console.WriteLine("\n# Dice Roller");
            Console.WriteLine(SelectionExercises.DiceRoller());

            Console.WriteLine("\n# Angles");
            Console.WriteLine(SelectionExercises.Angles(270));

            Console.WriteLine("\n# Rock Paper Scissors");
            Console.WriteLine("What is your choice for rock paper scissors?");
            string rpsUserChoice = Console.ReadLine();
            SelectionExercises.RockPaperScissors(rpsUserChoice); //need to uncomment user input in program.cs to work



            Console.WriteLine("\n# Triangle");

            Console.WriteLine("Enter 3 lengths of the triangle:");
            double.TryParse(Console.ReadLine(), out double lg1);
            double.TryParse(Console.ReadLine(), out double lg2);
            double.TryParse(Console.ReadLine(), out double lg3);

            
            Console.WriteLine(SelectionExercises.Triangle(lg1,lg2,lg3)); //need to uncomment user input in program.cs to work


        }
    }
}
