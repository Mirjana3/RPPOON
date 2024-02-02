using System;
using System.Collections.Generic;

namespace Posjetitelj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle(5),
                new Square(3),
                new Triangle(3,4,5),
                new Rectangle(7,8)
            };

            ShapeVisitor areaCalculator = new AreaCalculator();
            ShapeVisitor perimeterCalculator = new PerimeterCalculator();
            ColorVisitor color = new ColorShape();

            foreach(Shape shape in shapes)
            {
                shape.accept(color);
                shape.accept(perimeterCalculator);
                shape.accept(areaCalculator);
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
