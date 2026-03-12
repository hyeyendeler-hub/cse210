// W02 Journal Program
// 
// Exceeds core requirements:
// 1. A dedicated PromptGenerator class manages the list of prompts and random selection,
//    keeping that responsibility separate from the Journal and Entry classes.
// 2. The program supports loading and saving with a pipe-delimited format that handles
//    multi-word entries correctly.
// 3. The user can specify any filename when saving or loading, not just a hardcoded name.

Journal journal = new Journal();
PromptGenerator promptGenerator = new PromptGenerator();

bool running = true;

while (running)
{
    Console.WriteLine("=== Journal Menu ===");
    Console.WriteLine("1. Write a new entry");
    Console.WriteLine("2. Display all entries");
    Console.WriteLine("3. Save journal to file");
    Console.WriteLine("4. Load journal from file");
    Console.WriteLine("5. Quit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine($"\nPrompt: {prompt}");
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            Entry entry = new Entry(date, prompt, response);
            journal.AddEntry(entry);
            Console.WriteLine("Entry added!\n");
            break;

        case "2":
            Console.WriteLine();
            journal.DisplayAll();
            break;

        case "3":
            Console.Write("Enter filename to save to: ");
            string saveFile = Console.ReadLine();
            journal.SaveToFile(saveFile);
            Console.WriteLine();
            break;

        case "4":
            Console.Write("Enter filename to load from: ");
            string loadFile = Console.ReadLine();
            journal.LoadFromFile(loadFile);
            Console.WriteLine();
            break;

        case "5":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.\n");
            break;
    }
}
