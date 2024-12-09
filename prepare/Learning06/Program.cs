using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Clear();
        Console.WriteLine("Hello Learning06 World!");

        Console.WriteLine("");
        Console.WriteLine("Square");
        Square square = new Square("yellow", 5);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Console.WriteLine("");
        Console.WriteLine("Rectangle");
        Rectangle rectangle = new Rectangle("blue", 10, 15);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());


        Console.WriteLine("");
        Console.WriteLine("Circle");
        Circle circle = new Circle("red", 20);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        Console.WriteLine("");
        Console.WriteLine("List of shapes");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach( Shape s in shapes)
        {
           Console.WriteLine("----------------");
           Console.WriteLine(s.GetColor());
           Console.WriteLine(s.GetArea());
        }
    }
}