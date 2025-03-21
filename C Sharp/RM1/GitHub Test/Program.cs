using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Ask the user for their age
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // Calculate the year when the user will turn 100
            int yearToTurn100 = DateTime.Now.Year + (100 - age);

            // Display a personalized greeting
            Console.WriteLine($"Hello, {name}! You will turn 100 in the year {yearToTurn100}.");

            // Wait for user to press a key before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
