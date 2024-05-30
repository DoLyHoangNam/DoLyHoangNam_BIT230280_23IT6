using System;

namespace FindMaxInArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter array size: ");
            int[] arr = new int[int.Parse(Console.ReadLine())];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int max = arr[0];
            foreach (int num in arr)
                if (num > max)
                    max = num;

            Console.WriteLine($"The maximum value is: {max}");
        }
    }
}