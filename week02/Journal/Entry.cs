using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void DisplayEntry()
    {
        DateTime date = DateTime.Now;
        _date = date.ToShortDateString();
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}\n");
    }
}