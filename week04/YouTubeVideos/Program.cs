using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Learn C#", "Code Academy", 600);
        video1.AddComment(new Comment("Carlos", "Great tutorial!"));
        video1.AddComment(new Comment("Maria", "This helped me a lot."));
        video1.AddComment(new Comment("John", "Very clear explanation."));

        Video video2 = new Video("Top 10 Programming Tips", "Tech World", 850);
        video2.AddComment(new Comment("Laura", "Tip number 3 was very useful."));
        video2.AddComment(new Comment("David", "I learned something new today."));
        video2.AddComment(new Comment("Sofia", "Amazing video!"));

        Video video3 = new Video("Python for Beginners", "Programming School", 1200);
        video3.AddComment(new Comment("Andres", "Python looks easy to learn."));
        video3.AddComment(new Comment("Camila", "Thank you for this tutorial."));
        video3.AddComment(new Comment("Daniel", "Please make more videos like this."));

        Video video4 = new Video("Web Development Basics", "Web Tutorials", 950);
        video4.AddComment(new Comment("Ana", "Great introduction to HTML."));
        video4.AddComment(new Comment("Pedro", "I enjoyed learning CSS."));
        video4.AddComment(new Comment("Valentina", "Very helpful content."));
        video4.AddComment(new Comment("Luis", "Looking forward to the next video."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
