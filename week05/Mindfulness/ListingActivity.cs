using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userE = GetListFromUser();
        _count = userE.Count;
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();

    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string userR = Console.ReadLine();
            if (userR != "")
            {
                userResponses.Add(userR);
            }
        }

        return userResponses;
    }
}