using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");
        Square square1 = new Square ("orange", 3.6);
        //Console.WriteLine($"Area of {square1.GetColor()} square is {square1.GetArea()} units squared");
        Rectangle rectangle1 = new Rectangle ("yellow", 3.1, 2.4);
        //Console.WriteLine($"Area of {rectangle1.GetColor()} rectanlge is {rectangle1.GetArea()} units squared");
        Circle circle1 = new Circle ("green", 4.7);
        //Console.WriteLine($"Area of {circle1.GetColor()} circle is {circle1.GetArea()} units squared");

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(square1);
        shapeList.Add(rectangle1);
        shapeList.Add(circle1);

        foreach (Shape shape in shapeList){
            Console.WriteLine($"Area of {shape.GetColor()} shape is {shape.GetArea()} units squared.");
        }


    }
}