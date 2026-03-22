// Scripture Memorizer Program
// 
// Exceeds core requirements:
// 1. The program randomly selects a scripture from a library of multiple scriptures
//    each time it runs, giving the user variety in what they memorize.
// 2. The Reference class supports verse ranges (e.g., John 3:16-17), not just single verses.
// 3. Words are hidden in batches of 3 at a time for a better user experience.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Library of scriptures to randomly choose from
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"),
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight"),
            new Scripture(new Reference("Philippians", 4, 13),
                "I can do all this through him who gives me strength"),
            new Scripture(new Reference("Joshua", 1, 9),
                "Have I not commanded you Be strong and courageous Do not be afraid do not be discouraged for the Lord your God will be with you wherever you go"),
            new Scripture(new Reference("Romans", 8, 28),
                "And we know that in all things God works for the good of those who love him who have been called according to his purpose")
        };

        Random rng = new Random();
        Scripture scripture = library[rng.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
