using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learn C#", "John Smith", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing."));

        Video video2 = new Video("OOP in C#", "Jane Doe", 900);
        video2.AddComment(new Comment("David", "Excellent explanation."));
        video2.AddComment(new Comment("Emma", "I finally understand abstraction."));
        video2.AddComment(new Comment("Frank", "Well done!"));

        Video video3 = new Video("LINQ Basics", "Mike Johnson", 750);
        video3.AddComment(new Comment("Grace", "Awesome video."));
        video3.AddComment(new Comment("Henry", "Clear examples."));
        video3.AddComment(new Comment("Isabella", "Very informative."));

        DisplayVideo(video1);
        DisplayVideo(video2);
        DisplayVideo(video3);
    }

    static void DisplayVideo(Video video)
    {
        Console.WriteLine($"Title: {video._title}");
        Console.WriteLine($"Author: {video._author}");
        Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
        Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

        foreach (Comment comment in video.GetComments())
        {
            Console.WriteLine($"- {comment._name}: {comment._text}");
        }

        Console.WriteLine();

    }
}