using System;

public class Video
{
    public string _title;
    public string _author; 
    public int _duration; 
    public List<Comment> _comments; 

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }
  
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Video: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        
        foreach (var comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine(new string('-', 50)); 
    }
}