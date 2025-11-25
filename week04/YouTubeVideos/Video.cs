using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nDuration: {_length} seconds");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
    public void NumberOfComments()
    {
        Console.WriteLine($"The number of comments is {_comments.Count}");
    }
}