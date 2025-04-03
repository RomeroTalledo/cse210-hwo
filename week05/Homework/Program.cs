using System;
using System.Threading.Tasks.Dataflow;
using assignmentProgram;
class Program
{
    static void Main(string[] args)
    {
        Assignment tarea1 = new Assignment("Dallin Romero","Fracciones");
        MathAssignment tarea2 = new MathAssignment("Dallin Romero","Fracciones","Section 7.3","Problems 8- 19");
        WritingAssignment tarea3 = new WritingAssignment("Dallin Romero","European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(tarea1.GetSummary());
        Console.WriteLine(tarea2.GetHomeworkList());
        Console.WriteLine(tarea3.GetWritingInformation());
    }
}