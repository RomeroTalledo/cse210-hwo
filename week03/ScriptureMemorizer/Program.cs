using System;

class Program
{
    static void Main(string[] args)
    {
        //Contains the Scriptures and References
        List<ScriptureTemplate> listScriptures = new List<ScriptureTemplate>
        {
            new ScriptureTemplate("2-Nephi 25:26", "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins."),

            new ScriptureTemplate("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),

        };
        int index = new Random().Next(0, listScriptures.Count);
        Scripture scripture = new Scripture(listScriptures[index].GetReference(), listScriptures[index].GetText());


   
        string userInput = "";

        while(userInput.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if(scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            if(userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
            
        }
    }
}