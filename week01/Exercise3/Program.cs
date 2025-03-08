using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("What is the magic number?");
        while (true)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            
            if (number > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (number < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (number == magicNumber)
            {
                Console.WriteLine($"You guessed it! this is the number: {magicNumber}");
                break;
            }
        }
    }
}