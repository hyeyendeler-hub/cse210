using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store Video objects
        List<Video> videos = new List<Video>();

        // Create first video with comments
        Video video1 = new Video("Learn C# in 10 Minutes", "Code Academy", 600);
        video1.AddComment(new Comment("John Smith", "Great tutorial! Very helpful."));
        video1.AddComment(new Comment("Sarah Johnson", "I learned so much from this video."));
        video1.AddComment(new Comment("Mike Davis", "Can you make more videos like this?"));
        videos.Add(video1);

        // Create second video with comments
        Video video2 = new Video("Cooking Pasta Like a Pro", "Chef Mario", 900);
        video2.AddComment(new Comment("Emily Brown", "My pasta turned out perfect!"));
        video2.AddComment(new Comment("David Wilson", "Best cooking channel ever!"));
        video2.AddComment(new Comment("Lisa Anderson", "Thanks for the tips!"));
        videos.Add(video2);

        // Create third video with comments
        Video video3 = new Video("Guitar Basics for Beginners", "Music Master", 1200);
        video3.AddComment(new Comment("James Taylor", "Finally learned to play guitar!"));
        video3.AddComment(new Comment("Amanda White", "Your teaching style is amazing."));
        video3.AddComment(new Comment("Robert Garcia", "Subscribed! More lessons please."));
        videos.Add(video3);

        // Iterate through videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
            }
            
            Console.WriteLine();
        }
    }
}
