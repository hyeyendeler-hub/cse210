using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing in and out.")
    {
    }

    public (string name, int duration) Run()
    {
        Start();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        int cycles = GetDuration() / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }

        End();
        return (GetName(), GetDuration());
    }
}
