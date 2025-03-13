using System;
using System.IO;
using System.Collections.Generic;

public class Entry
{
    public string _date { get; set; } = DateTime.Now.ToString("MM/dd/yyyy");
    public string _promptText { get; set; } = string.Empty;
    public string _entryText { get; set; } = string.Empty;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void DisplayEntryDetails()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_promptText}\nEntry: {_entryText}\n");
    }
}