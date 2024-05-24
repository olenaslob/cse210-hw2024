using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create videos
        Video video1 = new Video
        {
            Title = "Introduction to C#",
            Author = "John Doe",
            Length = 300
        };

        Video video2 = new Video
        {
            Title = "Advanced C# Techniques",
            Author = "Jane Smith",
            Length = 600
        };

        Video video3 = new Video
        {
            Title = "C# Design Patterns",
            Author = "Emily Davis",
            Length = 900
        };

        // Add comments to videos
        video1.Comments.Add(new Comment { Name = "Alice", Text = "Great introduction!" });
        video1.Comments.Add(new Comment { Name = "Bob", Text = "Very helpful, thanks!" });
        video1.Comments.Add(new Comment { Name = "Charlie", Text = "Well explained." });

        video2.Comments.Add(new Comment { Name = "Dave", Text = "Excellent techniques." });
        video2.Comments.Add(new Comment { Name = "Eve", Text = "Learned a lot!" });
        video2.Comments.Add(new Comment { Name = "Frank", Text = "Clear and concise." });

        video3.Comments.Add(new Comment { Name = "Grace", Text = "Fantastic patterns overview." });
        video3.Comments.Add(new Comment { Name = "Hank", Text = "Very informative." });
        video3.Comments.Add(new Comment { Name = "Ivy", Text = "Great examples." });

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
