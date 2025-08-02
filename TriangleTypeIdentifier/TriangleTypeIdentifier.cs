using System;

#nullable enable

namespace DCIT318_Assignment1_11220227
{
    class TriangleTypeIdentifier
    {
        static void Main(string[] args)
        {
            Console.Title = "Triangle Type Identifier";
            Console.WriteLine("=== Triangle Type Identifier ===");
            Console.WriteLine("Enter the lengths of three sides to determine the triangle type.");

            while (true)
            {
                double side1 = GetSideLength("first");
                if (side1 == 0) break;

                double side2 = GetSideLength("second");
                if (side2 == 0) break;

                double side3 = GetSideLength("third");
                if (side3 == 0) break;

                if (IsValidTriangle(side1, side2, side3))
                {
                    string triangleType = DetermineTriangleType(side1, side2, side3);
                    Console.WriteLine($"\nSide 1: {side1}");
                    Console.WriteLine($"Side 2: {side2}");
                    Console.WriteLine($"Side 3: {side3}");
                    Console.WriteLine($"Triangle Type: {triangleType}\n");
                }
                else
                {
                    Console.WriteLine("\nError: The given sides cannot form a valid triangle.");
                    Console.WriteLine("Note: The sum of any two sides must be greater than the third side.\n");
                }
            }

            Console.WriteLine("\nThank you for using the Triangle Type Identifier. Goodbye!");
        }

        static double GetSideLength(string sideNumber)
        {
            while (true)
            {
                Console.Write($"Enter the length of the {sideNumber} side (or 0 to exit): ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && double.TryParse(input, out double sideLength))
                {
                    if (sideLength >= 0)
                    {
                        return sideLength;
                    }
                    else
                    {
                        Console.WriteLine("Error: Side length must not be negative. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid number. Please try again.");
                }
            }
        }

        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) &&
                   (side1 + side3 > side2) &&
                   (side2 + side3 > side1);
        }

        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (Math.Abs(side1 - side2) < 0.0001 &&
                Math.Abs(side2 - side3) < 0.0001)
            {
                return "Equilateral (all three sides are equal)";
            }
            else if (Math.Abs(side1 - side2) < 0.0001 ||
                     Math.Abs(side2 - side3) < 0.0001 ||
                     Math.Abs(side1 - side3) < 0.0001)
            {
                return "Isosceles (two sides are equal)";
            }
            else
            {
                return "Scalene (no sides are equal)";
            }
        }
    }
}