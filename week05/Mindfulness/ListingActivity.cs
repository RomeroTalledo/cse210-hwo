using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by listing as many items as you can within a category.",
        60)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who have you helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        Console.Clear();
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountSpinner(5);

        var responses = GetResponses();
        Console.WriteLine($"\nYou listed {responses.Count} items!");
    }

    private void DisplayPrompt()
    {
        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---\n");
    }

    private List<string> GetResponses()
    {
        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
                items.Add(response);
        }

        return items;
    }
}
