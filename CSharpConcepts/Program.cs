namespace CSharpConcepts
{
    internal class Program
    {
        static void Main()
        {
            // Calls the example code
            //Examples.Run();

            // Calls the exercises code

            string userRSP = "";
            //Console.WriteLine("What is your choice for rock paper scissors?"); //how to call this correctly when other exercises running too?
            //string userRSP = Console.ReadLine();

            Console.WriteLine("Enter 3 lengths of the triangle:");
            double.TryParse(Console.ReadLine(), out double side1);
            double.TryParse(Console.ReadLine(), out double side2);
            double.TryParse(Console.ReadLine(), out double side3);

            Exercises.Run(userRSP, side1, side2, side3);
        }

       

       
    }
}
