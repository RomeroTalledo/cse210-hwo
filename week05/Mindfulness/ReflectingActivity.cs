using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base(
        "Reflecting Activity",
        "This activity will help you reflect on times when you showed strength and resilience. This helps you recognize your power and apply it in other areas of life.",
        0)
    {
        #region  lists of prompts and questions
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than others?",
            "What is your favorite thing about this experience?",
            "What could you learn that applies to other situations?",
            "What did you learn about yourself?",
            "How can you keep this in mind in the future?"
        };
        #endregion
    }

    public void Run()
    {
        Console.Clear();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each question related to that experience.");
        Console.Write("You may begin in: ");
        ShowCountSpinner(5);
        Console.Clear();

        var tempQuestions = new List<string>(_questions);
        int elapsed = 0;

        while (elapsed < _duration && tempQuestions.Count > 0)
        {
            DisplayQuestion(tempQuestions);
            elapsed += 15;
        }
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
    }

    private void DisplayQuestion(List<string> questions)
    {
        int index = new Random().Next(questions.Count);
        Console.WriteLine($"> {questions[index]}");
        questions.RemoveAt(index);
        ShowSpinner(15);
    }

    private string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
}
