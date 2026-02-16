using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square sq1 = new Square(5);
        sq1.SetColor("blue square");
        Rectangle rc1 = new Rectangle(4, 5);
        rc1.SetColor("green rectangle");
        Circle cr1 = new Circle(6);
        cr1.SetColor("yellow circle");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq1);
        shapes.Add(rc1);
        shapes.Add(cr1);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"The area of the {shape.GetColor()} is {area}");

        }




    }
}