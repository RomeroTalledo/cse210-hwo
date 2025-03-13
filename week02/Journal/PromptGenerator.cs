using System;
public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count > 0)
        {
            int index = new Random().Next(0, _prompts.Count);
            return _prompts[index];
        }
        return "No prompts available.";
    }
}