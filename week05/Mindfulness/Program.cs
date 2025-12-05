using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program.\n");

        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        int choice;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                breathingActivity.Run();
            }
            else if (choice == 2)
            {
                reflectionActivity.Run();
            }
            else if(choice==3)
            {
                listingActivity.Run();
            }

        } while (choice != 4);
    }
}