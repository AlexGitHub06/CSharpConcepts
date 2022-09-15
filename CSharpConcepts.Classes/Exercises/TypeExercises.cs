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
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine((double)num1 / (double)num2);
            
        }

        // Q2: Calculator 2
        // Try to convert both the values to a double and write to the console the results of: +. - , *, /
        public static void Calculator(string value1, string value2)
        {

            double.TryParse(value1, out double doubleV1);
            double.TryParse(value2, out double doubleV2);

            Console.WriteLine(doubleV1 + doubleV2);
            Console.WriteLine(doubleV1 - doubleV2);
            Console.WriteLine(doubleV1 * doubleV2);
            Console.WriteLine(doubleV1 / doubleV2);
        }

        // Q3: Binary Strings
        // Write to the console the number printed in Binary, Decimal and Hex formats
        public static void BinaryStrings(int num)
        {
            string binaryV = Convert.ToString(num, 2);
            string decimalV = ((decimal)num).ToString();
            string hexV = Convert.ToString(num,16);

            Console.WriteLine($"{num}, {binaryV} in binary, {decimalV} in decimal, {hexV} in hex");
        }

        // Q4: BMI
        // Calculate and return the BMI - Body mass index
        public static double BMICalculator(double height, double weight)
        {
            double bmi = weight / (height * height);

            return bmi;
        }

        // Q5: FutureDate
        // Write to the console today's date. Return the date that it will be when the days passed in are added to the current date. 
        public static DateTime FutureDate(int days)
        {
            DateTime today = DateTime.Today;
            DateTime twoDays = today.AddDays(days);

            return today;
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
            if (Enum.TryParse(proposedLanguage, true, out Language language))
            {
                return language;
            }

            else
            {
                Console.WriteLine("Sorry your language was not valid. You will be randomly assigned a new language");

                Random random = new Random();
                int choice = random.Next(0,4);
                language = (Language)choice;

                return language;

            }
        }


    }
}
