using System;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice = "";
        
        GoalManager goalManager = new GoalManager();

        while (menuChoice != "6")
        {
            goalManager.DisplayPlayerInfo();
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1": goalManager.CreateGoal(); break;
                case "2": goalManager.ListGoalDetails(); break;
                case "3": goalManager.SaveGoals(); break;
                case "4": goalManager.LoadGoals(); break;
                case "5": goalManager.RecordEvent(); break;
                default: break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
    }
}
