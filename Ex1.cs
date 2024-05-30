using System;

namespace CastingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an integer
            Console.Write("Enter an integer: ");
            int integerValue = int.Parse(Console.ReadLine());

            // Cast the integer to a double
            double doubleValue = (double)integerValue;

            // Output the results
            Console.WriteLine($"The number you entered is {integerValue} and as a double is {doubleValue}.");
        }
    }
}

