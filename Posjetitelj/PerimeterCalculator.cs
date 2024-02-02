using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    public class PerimeterCalculator : ShapeVisitor
    {
        public void visitCircle(Circle circle)
        {
            double perimeter = 2 * Math.PI * circle.getRadius();
            Console.WriteLine("Perimeter of circle: " + perimeter);
        }

        public void visitSquare(Square square)
        {
            double perimeter = 4 * square.getSide();
            Console.WriteLine("Perimeter of square: " + perimeter);
        }

        public void visitTriangle(Triangle triangle)
        {
            double perimeter = triangle.getSide1() + triangle.getSide2() + triangle.getSide3();
            Console.WriteLine("Perimeter of triangle: " + perimeter);
        }

        public void visitRectangle(Rectangle rectangle)
        {
            double perimeter = 2 * (rectangle.getLength() + rectangle.getWidth());
            Console.WriteLine($"Perimeter of rectangle: {perimeter}");
        }
    }
}
