using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking for the name
        Console.Write("What is your first name? "); 
        string name = Console.ReadLine();
        // Asking for the last name
        Console.Write("What is your last name? "); 
        string lname = Console.ReadLine();
        // Concatenating
        Console.WriteLine($"Your name is {lname}, {name} {lname}");
    }
}