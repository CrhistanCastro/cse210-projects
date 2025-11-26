using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the YouTubeVideos Project.");

        Video video1 = new Video("Cats in action", "Meow047", 90);
        Comment comment1 = new Comment("Johnny", "Hahaha it's funny.");
        Comment comment2 = new Comment("Alice", "It's so cute.");
        Comment comment3 = new Comment("Sara", "They look like ninjas.");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Three-Milk Cake", "Cakeart", 120);
        Comment commentA = new Comment("James", "Mmmm delicious.");
        Comment commentB = new Comment("Mara", "Look at that cake.");
        Comment commentC = new Comment("Steven", "That made me hungry.");
        video2.AddComment(commentA);
        video2.AddComment(commentB);
        video2.AddComment(commentC);

        Video video3 = new Video("Mayan Pyramids", "Ecofr78", 150);
        Comment comment = new Comment("Zack", "Its heiht is impressive.");
        Comment comment0 = new Comment("Loise", "What a beautiful landscape!");
        Comment commentZ = new Comment("Brent", "How they built it without today's technology.");
        video3.AddComment(comment);
        video3.AddComment(comment0);
        video3.AddComment(commentZ);

        List<Video> videos = new List<Video>() { video1, video2, video3 };
        
        foreach(Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}