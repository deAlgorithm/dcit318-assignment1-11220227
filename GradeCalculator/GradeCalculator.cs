using System;

#nullable enable

namespace DCIT318_Assignment1_11220227
{
    class GradeCalculator
    {
        static void Main(string[] args)
        {
            Console.Title = "Grade Calculator";
            
            // Welcome message
            Console.WriteLine("=== Grade Calculator ===");
            Console.WriteLine("Welcome to the Grade Calculator!");
            Console.WriteLine("This application converts numerical grades (0-100) to letter grades.");


            bool keepRunning = true;

            while (keepRunning)
            {
                double grade;
                while (true)
                {
                    Console.Write("Enter your numerical grade (0-100): ");
                    string? input = Console.ReadLine();

                    if (double.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 100.\n");
                    }
                }

                string letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"\nNumerical Grade: {grade}");
                Console.WriteLine($"Letter Grade: {letterGrade}\n");

                while (true)
                {
                    Console.Write("Type 1 to enter another grade, or 0 to exit: ");
                    string? choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine();
                        break;
                    }
                    else if (choice == "0")
                    {
                        keepRunning = false;
                        Console.WriteLine("\nThank you for using the Grade Calculator. Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please type 1 to continue or 0 to exit.\n");
                    }
                }
            }
        }

        static string GetLetterGrade(double grade)
        {
            if (grade >= 90) return "A";
            if (grade >= 80) return "B";
            if (grade >= 70) return "C";
            if (grade >= 60) return "D";
            return "F";
        }
    }
}