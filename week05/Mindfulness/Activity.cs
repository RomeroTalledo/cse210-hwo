using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_name}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter the duration in seconds for this session: ");
        _duration = int.Parse(Console.ReadLine() ?? "60");
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed {_duration} seconds of {_name}.");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        string[] chars = { "/", "-", "\\", "|" };
        int counter = 0;

        while (counter < seconds)
        {
            foreach (var ch in chars)
            {
                Console.Write(ch);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            counter += 2;
        }
    }

    public void ShowCountSpinner(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }
}
