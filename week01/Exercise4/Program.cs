using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.Write("Enter number: ");
            string userImput = Console.ReadLine();
            int number = int.Parse(userImput); 
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"The sum is {numbers.Sum()}");
                Console.WriteLine($"The average is: {numbers.Average()}");
                Console.WriteLine($"The largest number is: {numbers.Max()}");
                break;
            }
        }
    }
}