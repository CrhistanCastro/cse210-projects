using System;

public class Comment
{
    private string _name;
    private string _comments;

    public Comment(string name, string comment)
    {
        _name = name;
        _comments = comment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_name}\nComment: {_comments}");
    }
}