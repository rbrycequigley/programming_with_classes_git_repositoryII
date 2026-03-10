using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Circle circle = new Circle(5);
        circle.SetColor("Red");
        shapes.Add(circle);
        Square square = new Square(3);
        square.SetColor("Blue");
        shapes.Add(square);
        Rectangle rectangle = new Rectangle(2, 4);
        rectangle.SetColor("Green");
        shapes.Add(rectangle);

        foreach (Shape lone_shape in shapes)
        {
            Console.WriteLine($"{lone_shape} color: {lone_shape.GetColor()}");
            Console.WriteLine($"{lone_shape} area: {lone_shape.GetArea()}");
        }
        
    }
}