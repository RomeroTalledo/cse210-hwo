using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int[] activityCounter = { 0, 0, 0 };
        string userInput = string.Empty;

        while (userInput != "4")
        {
            ShowMenu();
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    var breathing = new BreathingActivity();
                    breathing.DisplayStartingMessage();
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                    activityCounter[0]++;
                    break;
                case "2":
                    var reflecting = new ReflectingActivity();
                    reflecting.DisplayStartingMessage();
                    reflecting.Run();
                    reflecting.DisplayEndingMessage();
                    activityCounter[1]++;
                    break;
                case "3":
                    var listing = new ListingActivity();
                    listing.DisplayStartingMessage();
                    listing.Run();
                    listing.DisplayEndingMessage();
                    activityCounter[2]++;
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You completed {activityCounter[0]} Breathing, {activityCounter[1]} Reflecting, and {activityCounter[2]} Listing activities.");
        Thread.Sleep(3000);
    }

    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}
