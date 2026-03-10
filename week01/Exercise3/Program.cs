using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a number and count up to that number using a loop
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int limit = int.Parse(input);

        // Count from 1 to the number
        for (int i = 1; i <= limit; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
