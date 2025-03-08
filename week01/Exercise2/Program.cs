//  and = &&
//  or = ||
//  not = (!(variable = "example" || variable2 = "example2")); 
// correct varible name -- firstName, lastName -- this is a camle case
// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce tu calificacion:");
        string userInput = Console.ReadLine();
        int nota = int.Parse(userInput);
        if (nota>=90)
            {
                Console.WriteLine("Aprovaste el curso");
                Console.WriteLine($"Nota: {nota} = A");
            }
        else if (nota>=80)
            {
                Console.WriteLine("Aprovaste el curso");
                Console.WriteLine($"Nota: {nota} = B");
            }
        else if (nota>=70)
            {
                Console.WriteLine("Aprovaste el curso");
                Console.WriteLine($"Nota: {nota} = C");
            }  
        else if (nota>=60)
            {
                Console.WriteLine("Desaprovaste el curso");
                Console.WriteLine($"Nota: {nota} = D");
            }
        else if (nota<60)
            {
                Console.WriteLine("Desaprovaste el curso");
                Console.WriteLine($"Nota: {nota} = F");
            }
        else
            {
                Console.WriteLine("Datos incorrectos");
            }        
    }
}