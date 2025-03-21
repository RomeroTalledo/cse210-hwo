using System;

public class Scripture
{
    private Reference _reference = new Reference("",0,0);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach(string i in text.Split(' '))
        {
            Word word = new Word(i);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (IsCompletelyHidden())
        {
             return; 
        }
        numberToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < numberToHide; i++)
        {
            int index = new Random().Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.Display();
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        
        return $"{referenceText}\n..........................................\n{scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
