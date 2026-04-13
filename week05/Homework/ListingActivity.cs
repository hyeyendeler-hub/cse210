using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _userEntries = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public (string name, int duration) Run()
    {
        Start();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
            {
                _userEntries.Add(entry);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_userEntries.Count} items!");
        ShowSpinner(3);

        End();
        return (GetName(), GetDuration());
    }
}
