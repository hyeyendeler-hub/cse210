using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string filename = "goals.txt";
        bool running = true;

        Console.WriteLine("Welcome to the Eternal Quest program!");

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Create a New Goal");
            Console.WriteLine("4. Record an Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.DisplayPlayerInfo();
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    manager.CreateGoal();
                    break;
                case "4":
                    manager.RecordEvent();
                    break;
                case "5":
                    manager.SaveGoals(filename);
                    break;
                case "6":
                    if (File.Exists(filename))
                    {
                        manager.LoadGoals(filename);
                    }
                    else
                    {
                        Console.WriteLine("No saved goals file found.\n");
                    }
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("Thank you for using Eternal Quest!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}
