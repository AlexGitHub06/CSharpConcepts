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
        public static string FizzBuzz(int num)
        {
            string result;

            if (num % 3 == 0 && num % 5 == 0) { result = "FizzBuzz"; }
            else if (num % 3 == 0) { result = "Fizz"; }
            else if (num % 5 == 0) { result = "Buzz"; }
            else { result = num.ToString(); }

            return result;
        }

        // Q2: Vowel or Consonant
        // Using a switch statement write a function which returns true if the input is a vowel and
        // false if it is a consonant
        public static bool VowelOrConsonant(char letter)
        {
            bool isVowel;

            switch (letter)
            {
                case 'a':
                    isVowel = true;
                    break;
                case 'e':
                    isVowel = true;
                    break;
                case 'i':
                    isVowel= true;
                    break;
                case 'o':
                    isVowel = true;
                    break;
                case 'u':
                    isVowel = true;
                    break;
                default:
                    isVowel = false;
                    break;  
            }

            return isVowel;
        }

        // Q3: DiceRoller
        // Write a procedure which rolls three dice and write the following messages to the console
        // If all three dice have the same value write, "Three of a kind"
        // If two of the dice have the same value write, "You have a pair!
        // Otherwise write, "Sorry you lose"

        public static string DiceRoller()
        {
            string output;

            Random random = new Random();

            int dice1 = random.Next(0, 7);
            int dice2 = random.Next(0, 7);
            int dice3 = random.Next(0, 7);

            Console.WriteLine($"{dice1},{dice2},{dice3}");

            if (dice1 == dice2 && dice2 == dice3) { output = "Three of a kind"; }
            else if (dice1 == dice2 | dice1 == dice3 | dice2 == dice3) { output = "You have a pair!"; }
            else { output = "Sorry you lose"; }

            return output;

        }

        // Q4: Angles
        // Write a function to return whether the angle input is acute, right angle, obtuse, straight or reflex
        // Use an enum for the different angle types

        public enum Angle
        {
            Acute,
            RightAngle,
            Obtuse,
            Straight,
            Reflex
        }

        public static string Angles(double angle)
        {
            string angleType = "";

            switch (angle)
            {
                case > 180:
                    angleType = Angle.Reflex.ToString();
                    break;
                case 180:
                    angleType = Angle.Straight.ToString();
                    break;
                case > 90:
                    angleType = Angle.Obtuse.ToString();
                    break;
                case 90:
                    angleType = Angle.RightAngle.ToString();
                    break;
                case < 90:
                    angleType = Angle.Acute.ToString();
                    break;
                default:
                    angleType = "invalid input";
                    break;
            }

            return angleType;
        }

        // Q5: Rock, Paper Scissors
        // Write a procedure which takes the user's choice as input and randomly generate the computer's choice
        // It should write the computer's choice to the console and write whether the user lost, won, or drew.
        // Handle the user input in the calling code in Program.cs

        public enum RPSChoices
        {
            rock,
            paper,
            scissors
        }

        public static void RockPaperScissors(string userChoice) //need to uncomment input from program.cs to work
        {

            Random random = new Random();
            int num = random.Next(0, 3);
            string computerChoice = ((RPSChoices)num).ToString();

            Console.WriteLine($"User choice: {userChoice}");
            Console.WriteLine($"Computer choice: {computerChoice}");

            int userNum = (int)Enum.Parse(typeof(RPSChoices), userChoice.ToLower());

            if (userNum - num == 1 || userNum - num == -2) { Console.WriteLine("User won"); }
            else if (num - userNum == 1 || num - userNum == -2) { Console.WriteLine("User lost"); } 
            else if (num - userNum == 0) { Console.WriteLine("Draw"); }

        }

        // Q6: Triangle
        // Write a function that takes in three side lengths.
        // Determine whether a triangle with those sides is equilateral, isosceles, scalene or impossible

        public static string Triangle(double side1, double side2, double side3) //need to uncomment input from program.cs to work
        {
            string shape;

            if (side1 + side2 < side3 || side2 + side3 < side1 || side1 + side3 < side2) { shape = "impossible"; }
            else if(side1 == side2 && side2 == side3) { shape = "equilateral"; }
            else if (side1 == side2 | side2 == side3 | side1 == side3) { shape = "isosceles"; }
            else { shape = "scalene"; }

            return shape;
        }

    }
}
