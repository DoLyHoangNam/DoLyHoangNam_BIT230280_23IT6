using System;

namespace NumericConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a real number
            Console.Write("Enter a real number: ");
            string input = Console.ReadLine();

            // Try to parse the input as a double
            if (double.TryParse(input, out double realNumber))
            {
                // Convert the double to an int and a long
                int intNumber = (int)realNumber;
                long longNumber = (long)realNumber;

                // Output the results
                Console.WriteLine($"The number you entered is {realNumber}, as an int is {intNumber} and as a long is {longNumber}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a real number.");
            }
        }
    }
}