using System;

class Program
{
    static void Main(string[] args)
    {
        // elementos
        Square cuadrado = new Square(3,"RED");
        Rectangle rectangulo = new Rectangle(5,4,"Blue");
        Circle circulo = new Circle(5,"Yellow");
        
        // Lista
        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(cuadrado);
        shapes.Add(rectangulo);
        shapes.Add(circulo);

        foreach (Shapes i in shapes)
        {
            double area = i.GetArea();
            string c = i.GetColor();
            Console.WriteLine($"Color: {c}, Area: {area}");
        }
        
        // public static void DisplayImformation(Shapes shape, Shapes color)
        // {
        //     double area = shape.GetArea();
        //     string c = color.GetColor();
        //     Console.WriteLine($"Color: {c}, Area: {area}");
        // }
        
    }
}