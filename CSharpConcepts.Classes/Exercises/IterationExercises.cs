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
        public static int NumberOfCenturiesScored(List<int> runsScored)
        {
            int centuries = 0;

            foreach (int runs in runsScored)
            {
                if (runs >= 100) { centuries++; }
            }

            return centuries;
        }

        // Q2: Batting Average
        // Calculate the batting average.
        // Exclude any values where the runs scored were negative as a negative value indicates that they did not bat in that match.
        public static double BattingAverage(List<int> runsScored)
        {
            double positiveTotal = 0;
            int exceptions = 0;

           for(int i = 0; i < runsScored.Count; i++)
            {
                positiveTotal += (runsScored[i] < 0) ? 0 : runsScored[i];
                exceptions += (runsScored[i] < 0) ? 1 : 0;

            }

            return positiveTotal / (runsScored.Count - exceptions);
        }

        // Q3: User Names
        // Determine the user names
        // It will be the first three characters of their name and a number, which will be the order of the name in the list.
        public static List<string> UserNames(List<string> names)
        {
            List<string> userNames = new();

            for (int i = 0; i < names.Count(); i++)
            {
                userNames.Add(names[i].Substring(0,3) + (i+1).ToString());
            }

            return userNames;
        }

        // Q4: Calculate Multiples
        // Write a function that will output the multiple of a number from 1 to the max number specified
        // So called with 6 and 10 it would output [6, 12, 18, 24, 30, 36, 42, 48, 54, 60]
        public static List<int> CalculateMultiples(int number, int maximumMultiple)
        {
            List<int> mults = new();

            for (int i = 1; i < maximumMultiple+1; i++)
            {
                mults.Add(number * i);
            }

            return mults;
        }

        // Q5: Is Prime
        // Write a function to determine whether a number is prime

        public static bool IsPrime(int number)
        {
            double sqr = Math.Sqrt(number); //only have to go up to >= sqrt
            if(sqr % 1 <= (Double.Epsilon * 100)) { return false; }

            bool isPrime = true;

            for (int i = 2; i < Math.Floor(sqr); i++)
            {
                if (number % i ==0) { isPrime = false; break; }
            }

            return isPrime;

        }


        // Q6: Star Pattern
        // Write a procedure to output a star pattern based on the number of stars input
        // So for example if the user enters 6 then it will output:

        //*
        //**
        //***
        //****
        //*****
        //******
        //*****
        //****
        //***
        //**
        //*

        public static void StarPattern(int num)
        {
            int numStars;

            for (int i = 1; i < num*2; i++)
            {
                numStars = num - Math.Abs(num - i);
                Console.WriteLine(new String('*',numStars));
            }
        }


        // Q7: This function should take a noughts and crosses board represented as a character list,
        // A space represents an empty space as shown below.

        /* List<List<char>> board = new()
         {
             new() { 'X', '0', 'X' },
             new() { ' ', '0', ' ' },
             new() { 'X', '0', ' ' }
         };*/

        // The function should return a char: 'X' if player X has won, '0' if the player 0 has won,
        // and ' ' if there is currently no winner.

        
        public static char NoughtsCrosses(List<List<char>> board)
        {
            List<char> options = new() {'X', '0' };

            //check columns
            foreach (char symbol in options){

                for(int i = 0; i<3; i++) //rows
                {
                    for(int j=0; j<3; j++)
                    {
                        if (board[i][j] != symbol) { break; }
                        if (j == 2) { return symbol; }
                    }
                }

                for (int i = 0; i < 3; i++) //columns
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[j][i] != symbol) { break; }
                        if (j == 2) { return symbol; }
                    }
                }

                for (int i = 0; i < 3; i++) //diagonal topleft
                {
                    if (board[i][i] != symbol) { break; }
                    if (i == 2) { return symbol; }       
                }

                for (int i = 0; i < 3; i++) //diagonal topright
                {
                    if (board[i][2-i] != symbol) { break; }
                    if (i == 2) { return symbol; }  
                }
                
            }

            return ' '; //draw
        }

    }
}
