using System;
using System.Collections.Generic;

class Program
{
    private static List<(string name, int duration, DateTime timestamp)> _sessionHistory = new List<(string, int, DateTime)>();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. View Session History");
            Console.WriteLine("  5. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    var (bName, bDuration) = breathing.Run();
                    _sessionHistory.Add((bName, bDuration, DateTime.Now));
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    var (rName, rDuration) = reflecting.Run();
                    _sessionHistory.Add((rName, rDuration, DateTime.Now));
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    var (lName, lDuration) = listing.Run();
                    _sessionHistory.Add((lName, lDuration, DateTime.Now));
                    break;
                case "4":
                    ShowHistory();
                    break;
                case "5":
                    exit = true;
                    break;
            }
        }
    }

    static void ShowHistory()
    {
        Console.Clear();
        Console.WriteLine("=== Session History ===");
        Console.WriteLine();
        if (_sessionHistory.Count == 0)
        {
            Console.WriteLine("No sessions completed yet.");
        }
        else
        {
            int totalSeconds = 0;
            foreach (var session in _sessionHistory)
            {
                Console.WriteLine($"- {session.name}: {session.duration} seconds ({session.timestamp:g})");
                totalSeconds += session.duration;
            }
            Console.WriteLine();
            Console.WriteLine($"Total sessions: {_sessionHistory.Count}");
            Console.WriteLine($"Total time: {totalSeconds / 60} min {totalSeconds % 60} sec");
        }
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
