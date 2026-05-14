using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Rihab";
        string continueChoice = "yes";

        Console.WriteLine("Helloo, " + name);
        Console.WriteLine("=== Welcome to my app! ===");

        while (continueChoice == "yes")
        {
            Console.Write("\nPlease enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose the operation you want to perform:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5- Modulus");
            Console.WriteLine("6- Exponentiation");
            Console.WriteLine("7- Square Root");
            Console.WriteLine("8 - Exit");

            Console.Write("Enter the number corresponding to the operation: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;

           switch (operation)
{
    case 1:
        result = num1 + num2;
        Console.WriteLine("The result of addition is: " + result);
        break;

    case 2:
        result = num1 - num2;
        Console.WriteLine("The result of subtraction is: " + result);
        break;

    case 3:
        result = num1 * num2;
        Console.WriteLine("The result of multiplication is: " + result);
        break;

    case 4:
        if (num2 != 0)
        {
            result = num1 / num2;
            Console.WriteLine("The result of division is: " + result);
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        break;

    case 5:
        result = num1 % num2;
        Console.WriteLine("The result of modulus is: " + result);
        break;

    case 6:
        result = Math.Pow(num1, num2);
        Console.WriteLine("The result of exponentiation is: " + result);
        break;

    case 7:
        if (num1 >= 0)
        {
            result = Math.Sqrt(num1);
            Console.WriteLine("The square root of " + num1 + " is: " + result);
        }
        else
        {
            Console.WriteLine("Error: Square root of a negative number is not allowed.");
        }
        break;

    case 8:
        Console.WriteLine("Exiting...");
        return;

    default:
        Console.WriteLine("Invalid operation selected.");
        break;
}

            Console.Write("\nDo you want to perform another operation? (yes/no): ");
            continueChoice = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thank you for using the app. Goodbye!");
    }
}
