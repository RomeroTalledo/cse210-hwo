using System;

class Program
{
    static void Main(string[] args)
    {
        // Object # 1
        Fraction f1 = new Fraction();
        Console.WriteLine($"Top: {f1.GetTop()}");
        Console.WriteLine($"Bottom: {f1.GetBottom()}");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine("-------------------------------------------------------------------");
        // Object # 2
        Fraction f2 = new Fraction();
        f2.SetTop(5);
        Console.WriteLine($"Top: {f2.GetTop()}");
        Console.WriteLine($"Bottom: {f2.GetBottom()}");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine("-------------------------------------------------------------------");
        // Object # 3
        Fraction f3 = new Fraction();
        f3.SetTop(3);
        Console.WriteLine($"Top: {f3.GetTop()}");
        f3.SetBottom(4);
        Console.WriteLine($"Bottom: {f3.GetBottom()}");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine("-------------------------------------------------------------------");

        // Object # 4
        Fraction f4 = new Fraction(1,3);
        f4.SetTop(1);
        Console.WriteLine($"Top: {f4.GetTop()}");
        f4.SetBottom(3);
        Console.WriteLine($"Bottom: {f4.GetBottom()}");
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        
    }
}