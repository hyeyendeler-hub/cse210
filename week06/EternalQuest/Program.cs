using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

        bool quit = false;
        string filename = "goals.txt";

        while (!quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    Console.WriteLine("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    manager.SaveGoals(filename);
                    break;
                case "5":
                    Console.WriteLine("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    if (File.Exists(filename))
                    {
                        manager.LoadGoals(filename);
                    }
                    else
                    {
                        Console.WriteLine("File not found.\n");
                    }
                    break;
                case "6":
                    quit = true;
                    Console.WriteLine("Thank you for using EternalQuest!");
                    break;
            }
        }