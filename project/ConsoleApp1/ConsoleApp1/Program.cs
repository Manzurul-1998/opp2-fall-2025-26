using System;

class Program
{
    static void Main()
    {
        bool continueCalculation;

        do
        {
            Console.WriteLine("Select a calculation method:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validChoice = true;

            switch (choice)
            {
                case "1":
                    result = number1 + number2;
                    break;
                case "2":
                    result = number1 - number2;
                    break;
                case "3":
                    result = number1 * number2;
                    break;
                case "4":
                    if (number2 != 0)
                        result = number1 / number2;
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validChoice = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    validChoice = false;
                    break;
            }

            if (validChoice)
                Console.WriteLine($"Result: {result}");

            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string continueInput = Console.ReadLine().ToLower();
            continueCalculation = continueInput == "yes";

        } while (continueCalculation);

        Console.WriteLine("Thank you for using the calculator!");
    }
}
