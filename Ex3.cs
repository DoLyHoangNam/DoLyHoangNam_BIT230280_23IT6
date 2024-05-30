using System;

namespace CharToIntConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a character
            Console.Write("Enter a character: ");
            char userChar = Console.ReadLine()[0];

            // Convert the character to its ASCII code (int)
            int asciiCode = (int)userChar;

            // Output the results
            Console.WriteLine($"The character you entered is '{userChar}', its ASCII code is {asciiCode}.");
        }
    }
}