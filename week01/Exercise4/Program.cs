using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Collect numbers from the user until they enter 0, then display the list,
        // sum, average, and largest number using a List.

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when you are done.");
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Compute the sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        // Compute the average
        double average = (double)sum / numbers.Count;

        // Find the largest number
        int largest = numbers[0];
        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}
