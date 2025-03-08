using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqr = SquareNumber(number);
        DisplayResult(sqr,name);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string fullName = Console.ReadLine();
        return fullName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userImput = Console.ReadLine();
        int number = int.Parse(userImput);
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(int sqr,string name)
    {
        Console.WriteLine($"{name}, the square of your number is {sqr}");
    }
}