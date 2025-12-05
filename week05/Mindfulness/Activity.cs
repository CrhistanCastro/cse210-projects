using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "Unknown";
        _description = "Blank";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while(DateTime.Now < end)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if(i>=animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
