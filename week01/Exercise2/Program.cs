using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage and display the letter grade
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        double grade = double.Parse(input);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Keep trying!");
        }
    }
}
