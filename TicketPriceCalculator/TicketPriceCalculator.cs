using System;

#nullable enable

namespace DCIT318_Assignment1_11220227
{
    class TicketPriceCalculator
    {
        private const decimal REGULAR_PRICE = 10.00m;
        private const decimal DISCOUNTED_PRICE = 7.00m;
        private const int CHILD_AGE_LIMIT = 12;
        private const int SENIOR_AGE_LIMIT = 65;

        static void Main(string[] args)
        {
            Console.Title = "Ticket Price Calculator";
            Console.WriteLine("=== Movie Theater Ticket Price Calculator ===");
            Console.WriteLine("Regular ticket price: GHC10");
            Console.WriteLine("Discounted price: GHC7 (for seniors 65+ and children 12 and below)");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter your age (or 0 to exit): ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a valid age.\n");
                    continue;
                }

                if (int.TryParse(input, out int age))
                {
                    if (age == 0)
                    {
                        Console.WriteLine("Thank you for using the Ticket Price Calculator. Goodbye!");
                        break;
                    }
                    if (age < 0 || age > 150)
                    {
                        Console.WriteLine("Error: Please enter a valid age between 1 and 150.\n");
                        continue;
                    }

                    decimal ticketPrice = CalculateTicketPrice(age);
                    string customerType = GetCustomerType(age);

                    Console.WriteLine($"\nAge: {age}");
                    Console.WriteLine($"Customer Type: {customerType}");
                    Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}\n");
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid age (numbers only).\n");
                }
            }
        }

        static decimal CalculateTicketPrice(int age)
        {
            if (age <= CHILD_AGE_LIMIT || age >= SENIOR_AGE_LIMIT)
                return DISCOUNTED_PRICE;
            else
                return REGULAR_PRICE;
        }

        static string GetCustomerType(int age)
        {
            if (age <= CHILD_AGE_LIMIT)
                return "Child (12 and below)";
            else if (age >= SENIOR_AGE_LIMIT)
                return "Senior Citizen (65 and above)";
            else
                return "Regular Customer";
        }
    }
}
