using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you made a difference.",
        "Think of a time when you felt the Spirit."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite part of this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What would you do differently if you had to do this again?",
        "How did you need to become a better person?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and discovered that you can use that strength to handle other difficulties.")
    {
    }

    public void Run()
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
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int questionIndex = 0;
        while (DateTime.Now < endTime)
        {
            string question = _questions[questionIndex % _questions.Count];
            Console.WriteLine();
            Console.WriteLine(question);
            ShowCountdown(10);
            questionIndex++;
        }

        End();
    }

}
