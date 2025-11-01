using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,100);       

        Console.Write("What is your guess? ");
        string input = Console.ReadLine();
        int guess = int.Parse(input);

        while (guess != magic)
        {
            if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            guess = int.Parse(input);
        }
        Console.WriteLine("You guessed it!");
        
    }
}