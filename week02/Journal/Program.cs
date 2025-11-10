using System;
//The program saves the journal in a .csv file
//I added more questions
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        PromptGenerator randomPrompt = new PromptGenerator();

        int choice;

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = randomPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                string anEntry = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._promptText = prompt;
                newEntry._entryText = anEntry;
                journal.AddEntry(newEntry);



            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else
            {
                Console.WriteLine("Invalid option, try again.");
            }
        } while (choice != 5);
    }
}