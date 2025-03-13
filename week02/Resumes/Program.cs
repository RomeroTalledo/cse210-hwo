using System;

class Program
{
    static void Main(string[] args)
    {
        // Object #1
        Job job1 = new Job("Microsoft", "Software Engineer", 2018, 2023);

        //Object #2 
        Job job2 = new Job("Apple","Manager",2022,2023);

        Resume myResume = new Resume();
        myResume._name = "Dallin Romero";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}