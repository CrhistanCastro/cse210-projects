using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile=new StreamWriter(file, append: true))
        {
            outputFile.WriteLine("Date,Prompt,Entry");
            
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
    
}