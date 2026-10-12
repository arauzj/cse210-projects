using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 8);
        
        Rectangle rectangle1 = new Rectangle("blue", 8, 5);

        Circle circle1 = new Circle("green", 3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Shape Color: {color}, Shape Area: {area}");
        }
    }
}