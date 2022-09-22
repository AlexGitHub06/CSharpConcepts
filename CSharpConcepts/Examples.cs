using CSharpConcepts.Classes.Examples;
using System.Diagnostics;

namespace CSharpConcepts
{
    internal class Examples
    {
        internal static void Run()
        {
            // CallTypeExamples();
            // CallSelectionExamples();
            CallIterationExamples();
            // CallMathsExamples();
        }

        private static void CallMathsExamples()
        {
            MathsExamples.Rounding();
            Console.WriteLine();

            MathsExamples.DifferentRoundingOptions(12.5);
            Console.WriteLine();
            MathsExamples.DifferentRoundingOptions(-12.5);
            Console.WriteLine();
        }

        private static void CallIterationExamples()
        {
            //string greeting = IterationExamples.BirthdayGreeting();
            //Console.WriteLine(greeting);

            //int sum = IterationExamples.SumNumbers();
            //Console.WriteLine(sum);

            // To save commenting and uncommenting our code and to help test different cases we can use Debug.Assert            
            // Testing Sum            
            Debug.Assert(IterationExamples.Sum(-1) == 2, "$Output unexpected");
            Debug.Assert(IterationExamples.Sum(10) == 55);
            Debug.Assert(IterationExamples.Sum(100) == 5050);

            List<double> numbers = new() { 9, 12, 3, 7, 17 };
            List<double> squareNumbers = IterationExamples.SquaredNumbers(numbers);
            string squareNumbersOutput = string.Join(", ", squareNumbers);
            Console.WriteLine(squareNumbersOutput);

            //IterationExamples.CakesEaten(10);

            //IterationExamples.ValidateNumberEntry();

            List<List<int>> testScores = new()
            {
                new() { 1, 3, 5, 7, 9 },
                new() { 0, 2, 4, 6 },
                new() { 11, 22 }
            };
            List<int> totalTestScores = IterationExamples.FindTotalTestScore(testScores);
            string totalTestScoreOutput = string.Join(", ", totalTestScores);
            Console.WriteLine($"Total test scores are {totalTestScoreOutput}");           

        }

        private static void CallTypeExamples()
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

        private static void CallSelectionExamples()
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
    }

   
}
