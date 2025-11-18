using System;

class Program
{
    static void Main(string[] args)
    {
        string text = @"Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart.
        Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.";

        Reference reference1 = new Reference("Doctine and Covenants", 8, 2, 3);
        Scripture scripture1 = new Scripture(reference1, text);

        Console.WriteLine("Welcome to the ScriptureMemorizer Program.");

        while (!scripture1.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());
            Console.Write("Press enter to continue or type 'quit' to finish:");
            string choice = Console.ReadLine();

            if (choice == "quit")
            {
                return;
            }

            if (choice == "")
            {
                scripture1.HiddenRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture1.GetDisplayText());
    }
}