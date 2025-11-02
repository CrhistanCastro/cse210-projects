using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int num = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(num!=0)
        {            
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if(num!=0)
            {
                numbers.Add(num);
            }
        }
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {numbers.Where(n => n > 0).Min()}");
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}