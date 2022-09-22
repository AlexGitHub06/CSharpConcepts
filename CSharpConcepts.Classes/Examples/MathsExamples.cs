using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Examples
{
    public static class MathsExamples
    {
        #region Rounding
        // At a midpoint Math.Round rounds to the nearest even number
        public static void Rounding()
        {
            double num1 = 12.5;
            Console.WriteLine($"{num1} rounded is {Math.Round(num1)}");

            double num2 = 13.5;
            Console.WriteLine($"{num2} rounded is {Math.Round(num2)}");
        }

        // There are different options to round in c#
        public static void DifferentRoundingOptions(double number)
        {
            double roundedNumber = Math.Round(number);
            Console.WriteLine($"{number} rounded is {roundedNumber}");

            // Floor gives the nearest integral number that is lower
            double flooredNumber = Math.Floor(number);
            Console.WriteLine($"{number} floored is {flooredNumber}");

            // Ceiling gives the nearest integral number that is higher
            double ceilingNumber = Math.Ceiling(number);
            Console.WriteLine($"{number} ceiling is {ceilingNumber}");

            // Truncate gives the nearest integral number that is closer to zero
            double truncatedNumber = Math.Truncate(number);
            Console.WriteLine($"{number} truncated is {truncatedNumber}");
        }
        #endregion
    }
}
